using RebtelTest.Data;
using RebtelTest.Data.Models;
using RebtelTest.Data.Statics;
using RebtelTest.Service.Converters;
using RebtelTest.Service.CustomExceptions;
using RebtelTest.Service.Protos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RebtelTest.Service.Helpers
{
    /// <summary>
    /// A helper class to deal with database.
    /// </summary>
    public sealed class LibraryHelper
    {
        #region Declarations

        private readonly LibraryContext dbContext;
        private readonly ProtoConverter protoConverter = new();

        #endregion Declarations

        #region Constructors

        public LibraryHelper(LibraryContext context)
        {
            this.dbContext = context;
        }

        #endregion Constructors

        #region Methods

        public Books GetMostBorrowedBooks()
        {
            List<int> bookIds = this.dbContext.UserBorrowedBooks
                .GroupBy(ubb => ubb.BookId)
                .Select(ubb => new KeyValuePair<int, int>(ubb.Key, ubb.Count()))
                .ToList()
                .Where(kv => kv.Value > Constants.MostBorrowedBooksThreshold)
                .OrderByDescending(kv => kv.Value)
                .Select(kv => kv.Key)
                .ToList();

            var books = dbContext.Books.Where(b => bookIds.Contains(b.Id)).ToList();
            return protoConverter.Convert(books);
        }

        public GetBorrowedAvailableStatusResponse GetBorrowedAvailableStatus(int bookId)
        {
            Data.Models.Book book = this.dbContext.Books.Find(bookId);

            if (book == null)
            {
                throw new BookNotFoundException(string.Format(Constants.GrpcServer.Message.BookNotFoundErrorMessage, bookId));
            }

            // if we have a large date set to query, using explicit loading is always safe and fast.
            this.dbContext.Entry(book).Collection(s => s.UserBorrowedBooks).Load();

            return new GetBorrowedAvailableStatusResponse
            {
                Status = string.Format(
                    Constants.GrpcServer.Message.BorrowedAvailableStatus,
                    book.UserBorrowedBooks.Count,
                    book.NoOfCopyBooks - book.UserBorrowedBooks.Count)
            };
        }

        public GetUsersBorrowedMostBooksResponse GetUsersWithMostBorrowings(GetUsersBorrowedMostBooksRequest request)
        {
            DateTime fromDate = request.FromDate.ToDateTime();
            DateTime toDate = request.ToDate.ToDateTime();

            List<int> bookIds = this.dbContext.UserBorrowedBooks
                .Where(ubb => ubb.BorrowedDate >= fromDate && ubb.BorrowedDate <= toDate)
                .GroupBy(ubb => ubb.BookId)
                .Select(ubb => new KeyValuePair<int, int>(ubb.Key, ubb.Count()))
                .ToList()
                .Where(kv => kv.Value > Constants.MostBorrowedBooksThreshold)
                .OrderByDescending(kv => kv.Value)
                .Select(kv => kv.Key)
                .ToList();

            List<int> userIds = this.dbContext.UserBorrowedBooks
                .Where(ubb => bookIds.Contains(ubb.BookId))
                .Select(ubb => ubb.UserId)
                .Distinct()
                .ToList();

            List<string> users = this.dbContext.Users.Where(u => userIds.Contains(u.Id)).Select(u => u.Name).ToList();

            GetUsersBorrowedMostBooksResponse response = new GetUsersBorrowedMostBooksResponse();

            users.ForEach(u =>
            {
                response.Names.Add(u);
            });

            return response;
        }

        public Books GetUserBorrowedBooks(GetUserBorrowedBooksRequest request)
        {
            User user = this.dbContext.Users
                .Find(request.UserId);

            if (user == null)
            {
                throw new UserNotFoundException(string.Format(Constants.GrpcServer.Message.UserNotFoundErrorMessage, request.UserId));
            }

            DateTime fromDate = request.FromDate.ToDateTime();
            DateTime toDate = request.ToDate.ToDateTime();

            this.dbContext.Entry(user).Collection(s => s.UserBorrowedBooks).Load();

            List<int> bookIds = user.UserBorrowedBooks
                .Where(ubb => ubb.BorrowedDate >= fromDate && ubb.BorrowedDate <= toDate).Select(ubb => ubb.BookId).Distinct().ToList();
            List<Data.Models.Book> books = this.dbContext.Books.Where(b => bookIds.Contains(b.Id)).ToList();

            return protoConverter.Convert(books);
        }

        public Books GetPossibleRelatedBooks(int bookId)
        {
            Data.Models.Book book = this.dbContext.Books.Find(bookId);

            if (book == null)
            {
                throw new BookNotFoundException(string.Format(Constants.GrpcServer.Message.BookNotFoundErrorMessage, bookId));
            }

            this.dbContext.Entry(book).Collection(s => s.UserBorrowedBooks).Load();

            List<int> userIds = book.UserBorrowedBooks
                .Select(b => b.UserId).Distinct().ToList();

            List<int> bookIds = this.dbContext.UserBorrowedBooks
                .Where(ubb => userIds.Contains(ubb.UserId) && ubb.BookId != bookId)
                .Select(ubb => ubb.BookId).Distinct().ToList();

            List<Data.Models.Book> books = this.dbContext.Books.Where(b => bookIds.Contains(b.Id)).ToList();
            return protoConverter.Convert(books);
        }

        public GetReadRateResponse GetReadRate(int bookId)
        {
            var book = this.dbContext.Books.Find(bookId);

            if (book == null)
            {
                throw new BookNotFoundException(string.Format(Constants.GrpcServer.Message.BookNotFoundErrorMessage, bookId));
            }

            this.dbContext.Entry(book).Collection(s => s.UserBorrowedBooks).Load();

            double avarage = book.UserBorrowedBooks
                .Where(ubb => ubb.ReturnDate.HasValue)
                .Select(ubb => book.NoPages / ubb.ReturnDate.Value.Subtract(ubb.BorrowedDate).Days)
                .Average();

            return new GetReadRateResponse() { Rate = avarage };
        }

        #endregion Methods
    }
}
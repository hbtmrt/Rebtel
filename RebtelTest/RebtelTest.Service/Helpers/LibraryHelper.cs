using RebtelTest.Data;
using RebtelTest.Data.Models;
using RebtelTest.Data.Statics;
using RebtelTest.Service.Converters;
using RebtelTest.Service.Protos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RebtelTest.Service.Helpers
{
    public sealed class LibraryHelper
    {
        private readonly LibraryContext dbContext;
        private readonly ProtoConverter protoConverter = new();
        private readonly DateHelper dateHelper = new();

        public LibraryHelper(LibraryContext context)
        {
            this.dbContext = context;
        }

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
            GetBorrowedAvailableStatusResponse response = new();

            Data.Models.Book book = this.dbContext.Books.Find(bookId);

            response.Status = book == null ?
                Constants.GrpcServer.Message.BookNotFound
                : string.Format(Constants.GrpcServer.Message.BorrowedAvailableStatus, book.NoOfCopyBooks, book.NoOfAvailableBooks);

            return response;
        }

        public GetUsersBorrowedMostBooksResponse GetUsersWithMostBorrowings(GetUsersBorrowedMostBooksRequest request)
        {
            if (request.FromDate == null || request.ToDate == null)
            {
                return null;
            }

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
            if (request.FromDate == null || request.ToDate == null)
            {
                return null;
            }

            User user = this.dbContext.Users
                .Find(request.UserId);

            if (user == null)
            {
                return null;
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
            List<int> userIds = this.dbContext.UserBorrowedBooks
                .Where(ubb => ubb.BookId == bookId)
                .Select(ubb => ubb.UserId).Distinct().ToList();

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
                throw new ArgumentException($"The book cannot be found for the book id: {bookId}");
            }

            this.dbContext.Entry(book).Collection(s => s.UserBorrowedBooks).Load();

            double avarage = book.UserBorrowedBooks
                .Select(ubb => book.NoPages / ubb.ReturnDate.Value.Subtract(ubb.BorrowedDate).Days)
                .Average();

            return new GetReadRateResponse() { Rate = avarage };
        }
    }
}
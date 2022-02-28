using RebtelTest.Data;
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
    }
}
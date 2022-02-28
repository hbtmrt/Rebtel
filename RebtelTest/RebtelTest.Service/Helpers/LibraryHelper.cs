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
            return null;
        }
    }
}
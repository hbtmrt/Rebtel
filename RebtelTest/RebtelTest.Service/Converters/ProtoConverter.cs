using RebtelTest.Service.Protos;
using System.Collections.Generic;

namespace RebtelTest.Service.Converters
{
    /// <summary>
    /// Convert model to proto.
    /// </summary>
    public sealed class ProtoConverter
    {
        public Book Convert(Data.Models.Book book)
        {
            return new Book
            {
                Name = book.Name
            };
        }

        public Books Convert(List<Data.Models.Book> books)
        {
            Books bookList = new();

            List<Book> converted = new();

            books.ForEach(book =>
            {
                bookList.BookList.Add(Convert(book));
            });

            return bookList;
        }
    }
}
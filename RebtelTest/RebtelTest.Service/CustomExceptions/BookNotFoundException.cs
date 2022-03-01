using System;

namespace RebtelTest.Service.CustomExceptions
{
    /// <summary>
    /// A custom exception to handle unknown books.
    /// </summary>
    public class BookNotFoundException : Exception
    {
        public BookNotFoundException(string message) : base(message)
        {
        }
    }
}
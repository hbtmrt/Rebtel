using System;

namespace RebtelTest.Service.CustomExceptions
{
    /// <summary>
    /// A custom exception class to handle unknown users.
    /// </summary>
    public class UserNotFoundException : Exception
    {
        public UserNotFoundException(string message) : base(message)
        {
        }
    }
}
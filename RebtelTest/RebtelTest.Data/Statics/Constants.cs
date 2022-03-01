namespace RebtelTest.Data.Statics
{
    public static class Constants
    {
        public const int MostBorrowedBooksThreshold = 25;

        public static class GrpcServer
        {
            public const string EndPoint = "https://localhost:5001";

            public static class Message
            {
                public const string BookNotFound = "The book cannot be found for the specified book id.";
                public const string BorrowedAvailableStatus = "Borrowed: {0}, Available {1}";
                public const string BookNotFoundErrorMessage = "The book cannot be found for the book id: {0}";
                public const string UserNotFoundErrorMessage = "The user cannot be found for the user id: {0}";
            }
        }

        public static class GrpcClient
        {
            public static class Message
            {
                public const string MostBorrowedBooksThreshold = "The following shows the books borrowed at least {0} times.";
                public const string FromDateGreaterThanToError = "The from date is greater than to date.";
            }
        }
    }
}
namespace RebtelTest.Data.Statics
{
    public static class Constants
    {
        public const int MostBorrowedBooksThreshold = 25;

        public static class GrpcServer
        {
            public const string EndPoint = "https://localhost:5001";
        }

        public static class GrpcClient
        {
            public static class Message
            {
                public const string MostBorrowedBooksThreshold = "The following shows the books borrowed at least {0} times.";
            }
        }
    }
}
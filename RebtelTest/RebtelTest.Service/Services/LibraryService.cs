using Grpc.Core;
using RebtelTest.Data;
using RebtelTest.Service.Helpers;
using RebtelTest.Service.Protos;
using System.Threading.Tasks;

namespace RebtelTest.Service.Services
{
    public class LibraryService : LibraryManager.LibraryManagerBase
    {
        private readonly LibraryHelper libraryHelper;

        public LibraryService(LibraryContext context)
        {
            libraryHelper = new LibraryHelper(context);
        }

        public override Task<Books> GetMostBorrowedBooks(GetMostBorrowedBooksRequest request, ServerCallContext context)
        {
            return Task.FromResult(libraryHelper.GetMostBorrowedBooks());
        }

        public override Task<GetBorrowedAvailableStatusResponse> GetBorrowedAvailableStatus(GetBorrowedAvailableStatusRequest request, ServerCallContext context)
        {
            return Task.FromResult(libraryHelper.GetBorrowedAvailableStatus(request.BookId));
        }

        public override Task<GetUsersBorrowedMostBooksResponse> GetUsersBorrowedMostBooks(GetUsersBorrowedMostBooksRequest request, ServerCallContext context)
        {
            return Task.FromResult(libraryHelper.GetUsersWithMostBorrowings(request));
        }

        public override Task<Books> GetUserBorrowedBooks(GetUserBorrowedBooksRequest request, ServerCallContext context)
        {
            return Task.FromResult(libraryHelper.GetUserBorrowedBooks(request));
        }

        public override Task<Books> GetPossibleRelatedBooks(GetPossibleRelatedBooksRequest request, ServerCallContext context)
        {
            return Task.FromResult(libraryHelper.GetPossibleRelatedBooks(request.BookId));
        }

        public override Task<GetReadRateResponse> GetReadRate(GetReadRateRequest request, ServerCallContext context)
        {
            return Task.FromResult(libraryHelper.GetReadRate(request.BookId));
        }
    }
}
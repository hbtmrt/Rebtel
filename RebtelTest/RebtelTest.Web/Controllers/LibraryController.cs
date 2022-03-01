using Google.Protobuf.WellKnownTypes;
using Grpc.Net.Client;
using Microsoft.AspNetCore.Mvc;
using RebtelTest.Data.Statics;
using RebtelTest.Web.Helpers;
using RebtelTest.Web.Protos;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace RebtelTest.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        #region Declarations

        private LibraryManager.LibraryManagerClient client;
        private readonly ConverterHelper converterHelper = new();

        #endregion Declarations

        #region Constructor

        public LibraryController()
        {
            GrpcChannel channel = GrpcChannel.ForAddress(Constants.GrpcServer.EndPoint);
            client = new LibraryManager.LibraryManagerClient(channel);
        }

        #endregion Constructor

        #region Methods

        [HttpGet("books/most-borrowed")]
        public async Task<IActionResult> GetMostBorrowedBooks()
        {
            try
            {
                Books books = await client.GetMostBorrowedBooksAsync(new GetMostBorrowedBooksRequest { });
                return Ok(converterHelper.GetMostBorrowedBooksString(books));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("books/{id}/borrowed-available-status")]
        public async Task<IActionResult> GetBorrowedAvailableStatus(int id)
        {
            try
            {
                GetBorrowedAvailableStatusResponse response = await client.GetBorrowedAvailableStatusAsync(new GetBorrowedAvailableStatusRequest { BookId = id });
                return Ok(response.Status);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("users/with-most-borrowed-books")]
        public async Task<IActionResult> GetUsersWithMostBorrowedBooks(DateTime from, DateTime to)
        {
            if (from > to)
            {
                return BadRequest(Constants.GrpcClient.Message.FromDateGreaterThanToError);
            }

            if (to == DateTime.MinValue)
            {
                // if to date is not provided, it is set to Today by default.
                to = DateTime.Now;
            }

            try
            {
                GetUsersBorrowedMostBooksResponse response = await client.GetUsersBorrowedMostBooksAsync(new GetUsersBorrowedMostBooksRequest
                {
                    FromDate = DateTime.SpecifyKind(from, DateTimeKind.Utc).ToTimestamp(),
                    ToDate = DateTime.SpecifyKind(to, DateTimeKind.Utc).ToTimestamp()
                });

                return Ok(response.Names.ToString());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("users/{id}/borrowed-books")]
        public async Task<IActionResult> GetUserBorrowedBooks(int id, DateTime from, DateTime to)
        {
            if (from > to)
            {
                return BadRequest(Constants.GrpcClient.Message.FromDateGreaterThanToError);
            }

            if (to == DateTime.MinValue)
            {
                // if to date is not provided, it is set to Today by default.
                to = DateTime.Now;
            }

            try
            {
                var books = await client.GetUserBorrowedBooksAsync(new GetUserBorrowedBooksRequest
                {
                    UserId = id,
                    FromDate = DateTime.SpecifyKind(from, DateTimeKind.Utc).ToTimestamp(),
                    ToDate = DateTime.SpecifyKind(to, DateTimeKind.Utc).ToTimestamp()
                });

                return Ok(string.Join(",", books.BookList.Select(bl => bl.Name)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("books/{id}/possible-related-books")]
        public async Task<IActionResult> GetPossibleRelatedBooks(int id)
        {
            // What other books were borrowed by individuals that borrowed a particular book?

            try
            {
                var books = await client.GetPossibleRelatedBooksAsync(new GetPossibleRelatedBooksRequest
                {
                    BookId = id
                });

                return Ok(string.Join(",", books.BookList.Select(bl => bl.Name)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("books/{id}/read-rate")]
        public async Task<IActionResult> GetReadRate(int id)
        {
            try
            {
                GetReadRateResponse readRate = await client.GetReadRateAsync(new GetReadRateRequest
                {
                    BookId = id
                });

                return Ok(readRate.Rate);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        #endregion Methods
    }
}
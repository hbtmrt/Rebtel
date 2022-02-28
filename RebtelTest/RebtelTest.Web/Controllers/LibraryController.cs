﻿using Google.Protobuf.WellKnownTypes;
using Grpc.Net.Client;
using Microsoft.AspNetCore.Mvc;
using RebtelTest.Data.Statics;
using RebtelTest.Web.Protos;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebtelTest.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private LibraryManager.LibraryManagerClient client;

        public LibraryController()
        {
            GrpcChannel channel = GrpcChannel.ForAddress(Constants.GrpcServer.EndPoint);
            client = new LibraryManager.LibraryManagerClient(channel);
        }

        [HttpGet("books/most-borrowed")]
        public async Task<string> GetMostBorrowedBooks()
        {
            Books books = await client.GetMostBorrowedBooksAsync(new GetMostBorrowedBooksRequest { });

            StringBuilder sb = new();
            sb.AppendLine(string.Format(Constants.GrpcClient.Message.MostBorrowedBooksThreshold, Constants.MostBorrowedBooksThreshold));
            sb.AppendLine(string.Join(",", books.BookList.Select(bl => bl.Name)));

            return sb.ToString();
        }

        [HttpGet("books/{id}/borrowed-available-status")]
        public async Task<string> GetBorrowedAvailableStatus(int id)
        {
            GetBorrowedAvailableStatusResponse response = await client.GetBorrowedAvailableStatusAsync(new GetBorrowedAvailableStatusRequest { BookId = id });
            return response.Status;
        }

        [HttpGet("users/with-most-borrowed-books")]
        public async Task<string> GetUsersWithMostBorrowedBooks(DateTime from, DateTime to)
        {
            GetUsersBorrowedMostBooksResponse response = await client.GetUsersBorrowedMostBooksAsync(new GetUsersBorrowedMostBooksRequest {
                FromDate = DateTime.SpecifyKind(from, DateTimeKind.Utc).ToTimestamp(),
                ToDate = DateTime.SpecifyKind(to, DateTimeKind.Utc).ToTimestamp()
            });

            return response.Names.ToString();
        }
    }
}
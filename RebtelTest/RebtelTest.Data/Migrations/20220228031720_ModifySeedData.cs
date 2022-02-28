using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RebtelTest.Data.Migrations
{
    public partial class ModifySeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "NoOfBorrowedBooks", "NoOfCopyBooks" },
                values: new object[] { 41, 60 });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "NoOfBorrowedBooks", "NoOfCopyBooks" },
                values: new object[] { 23, 94 });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "NoOfBorrowedBooks", "NoOfCopyBooks" },
                values: new object[] { 6, 87 });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "NoOfBorrowedBooks", "NoOfCopyBooks" },
                values: new object[] { 20, 82 });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "NoOfBorrowedBooks", "NoOfCopyBooks" },
                values: new object[] { 23, 94 });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "NoOfBorrowedBooks", "NoOfCopyBooks" },
                values: new object[] { 13, 69 });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "NoOfBorrowedBooks", "NoOfCopyBooks" },
                values: new object[] { 47, 96 });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "NoOfBorrowedBooks", "NoOfCopyBooks" },
                values: new object[] { 17, 68 });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "NoOfBorrowedBooks", "NoOfCopyBooks" },
                values: new object[] { 17, 64 });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "NoOfBorrowedBooks", "NoOfCopyBooks" },
                values: new object[] { 10, 76 });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "NoOfBorrowedBooks", "NoOfCopyBooks" },
                values: new object[] { 24, 95 });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "NoOfBorrowedBooks", "NoOfCopyBooks" },
                values: new object[] { 45, 76 });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "NoOfBorrowedBooks", "NoOfCopyBooks" },
                values: new object[] { 29, 58 });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "NoOfBorrowedBooks", "NoOfCopyBooks" },
                values: new object[] { 7, 90 });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "NoOfBorrowedBooks", "NoOfCopyBooks" },
                values: new object[] { 28, 53 });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "NoOfBorrowedBooks", "NoOfCopyBooks" },
                values: new object[] { 39, 98 });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "NoOfBorrowedBooks", "NoOfCopyBooks" },
                values: new object[] { 12, 93 });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "NoOfBorrowedBooks", "NoOfCopyBooks" },
                values: new object[] { 43, 81 });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "NoOfBorrowedBooks", "NoOfCopyBooks" },
                values: new object[] { 39, 88 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 12, new DateTime(2021, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 13, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 8, new DateTime(2021, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "BorrowedDate" },
                values: new object[] { 14, new DateTime(2021, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 11, new DateTime(2021, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 15, new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 17, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 14 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 5, new DateTime(2021, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { new DateTime(2021, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 13 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 19, new DateTime(2021, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 12, new DateTime(2021, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 9, new DateTime(2021, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 13, new DateTime(2021, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 18 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 10, new DateTime(2021, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 14 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 7, new DateTime(2021, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 2, new DateTime(2021, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 12, new DateTime(2021, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 6, new DateTime(2021, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 4, new DateTime(2021, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 12, new DateTime(2021, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 12, new DateTime(2021, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { new DateTime(2021, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 8 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 1, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 1, new DateTime(2021, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 13, new DateTime(2021, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 19, new DateTime(2021, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 8, new DateTime(2021, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 7, new DateTime(2021, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 4, new DateTime(2021, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 14 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 2, new DateTime(2021, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 19, new DateTime(2021, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 4, new DateTime(2021, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 9, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 2, new DateTime(2021, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 1, new DateTime(2021, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 16 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 7, new DateTime(2021, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 11 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 12, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 12, new DateTime(2021, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 5, new DateTime(2021, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 4 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 14, new DateTime(2021, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 17, new DateTime(2021, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BookId", "BorrowedDate" },
                values: new object[] { 9, new DateTime(2021, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 10, new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 6 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 15, new DateTime(2021, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 6 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 9, new DateTime(2021, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 13 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 2, new DateTime(2021, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 9 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 11, new DateTime(2021, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 16, new DateTime(2021, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 1, new DateTime(2021, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 8 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 11, new DateTime(2021, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "BookId", "BorrowedDate" },
                values: new object[] { 1, new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 15, new DateTime(2021, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 9, new DateTime(2021, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 4, new DateTime(2021, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 9 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 11, new DateTime(2021, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 4, new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 14 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 14, new DateTime(2021, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 8 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 2, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 12, new DateTime(2021, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BookId", "BorrowedDate" },
                values: new object[] { 3, new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 8, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 4, new DateTime(2021, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 8, new DateTime(2021, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 14, new DateTime(2021, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 2, new DateTime(2021, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 5, new DateTime(2021, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 10, new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 8, new DateTime(2021, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 7, new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 4, new DateTime(2021, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 17, new DateTime(2021, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { new DateTime(2021, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 6 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 15, new DateTime(2021, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 17, new DateTime(2021, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 16, new DateTime(2021, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 1, new DateTime(2021, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 14 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 16, new DateTime(2021, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 11 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 16, new DateTime(2021, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 18, new DateTime(2021, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 12, new DateTime(2021, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 2, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 12 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 11, new DateTime(2021, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 18 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 17, new DateTime(2021, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 19, new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 8 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 16, new DateTime(2021, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 9 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 17, new DateTime(2021, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 4 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 10, new DateTime(2021, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 11, new DateTime(2021, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 9 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 12, new DateTime(2021, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 8, new DateTime(2021, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 18 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 13, new DateTime(2021, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 7, new DateTime(2021, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 14, new DateTime(2021, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 6, new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 8, new DateTime(2021, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 8 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 10, new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 16, new DateTime(2021, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 18 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 1, new DateTime(2021, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 18, new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 17, new DateTime(2021, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 15, new DateTime(2021, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 6 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { new DateTime(2021, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 12, new DateTime(2021, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 4, new DateTime(2021, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 3, new DateTime(2021, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 7, new DateTime(2021, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 11, new DateTime(2021, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 18 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 9, new DateTime(2021, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 16, new DateTime(2021, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 8 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 6, new DateTime(2021, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { new DateTime(2021, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 1, new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 18 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 4, new DateTime(2021, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "BookId", "BorrowedDate" },
                values: new object[] { 10, new DateTime(2021, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 19, new DateTime(2021, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 13 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 18, new DateTime(2021, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 4 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "BorrowedDate", "UserId" },
                values: new object[] { new DateTime(2021, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 13, new DateTime(2021, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 14 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 10, new DateTime(2021, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 1, new DateTime(2021, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "BookId", "BorrowedDate" },
                values: new object[] { 16, new DateTime(2021, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 15, new DateTime(2021, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 9 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 17, new DateTime(2021, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 4 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 14, new DateTime(2021, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 10, new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 3, new DateTime(2021, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 19, new DateTime(2021, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 11, new DateTime(2021, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 4 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 15, new DateTime(2021, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 7, new DateTime(2021, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "BookId", "BorrowedDate" },
                values: new object[] { 16, new DateTime(2021, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 6, new DateTime(2021, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 17, new DateTime(2021, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 14 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 6, new DateTime(2021, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 10, new DateTime(2021, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 8 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 11, new DateTime(2021, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 6, new DateTime(2021, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 3, new DateTime(2021, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 13 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 14, new DateTime(2021, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 13 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 14, new DateTime(2021, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 16, new DateTime(2021, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 18 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 12, new DateTime(2021, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 12 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "BookId", "BorrowedDate" },
                values: new object[] { 10, new DateTime(2021, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 13, new DateTime(2021, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 13 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 17, new DateTime(2021, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 1, new DateTime(2021, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 12 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 1, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 18, new DateTime(2021, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 16, new DateTime(2021, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 13, new DateTime(2021, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 19, new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 10, new DateTime(2021, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 18, new DateTime(2021, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 18, new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 11, new DateTime(2021, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 18 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 5, new DateTime(2021, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 17, new DateTime(2021, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 2, new DateTime(2021, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 11, new DateTime(2021, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 12, new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 13, new DateTime(2021, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 18 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 5, new DateTime(2021, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 10, new DateTime(2021, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 15, new DateTime(2021, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 13 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 4, new DateTime(2021, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 18, new DateTime(2021, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 9, new DateTime(2021, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 6, new DateTime(2021, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "BookId", "BorrowedDate" },
                values: new object[] { 7, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 19, new DateTime(2021, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 6, new DateTime(2021, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 13 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { new DateTime(2021, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 18 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 4, new DateTime(2021, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 18, new DateTime(2021, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 18, new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 8, new DateTime(2021, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 17, new DateTime(2021, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 10, new DateTime(2021, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 13, new DateTime(2021, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 15, new DateTime(2021, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 6, new DateTime(2021, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 1, new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 19, new DateTime(2021, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 5, new DateTime(2021, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 6 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 1, new DateTime(2021, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 11 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 12, new DateTime(2021, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 13, new DateTime(2021, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 4, new DateTime(2021, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 12 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 13, new DateTime(2021, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate" },
                values: new object[] { 4, new DateTime(2021, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 14, new DateTime(2021, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 16 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "BookId", "BorrowedDate" },
                values: new object[] { 12, new DateTime(2021, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { new DateTime(2021, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "BookId", "BorrowedDate" },
                values: new object[] { 7, new DateTime(2021, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 1, new DateTime(2021, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 4 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "BorrowedDate", "UserId" },
                values: new object[] { new DateTime(2021, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 12, new DateTime(2021, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 7, new DateTime(2021, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 9 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 9, new DateTime(2021, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 6 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 10, new DateTime(2021, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 5, new DateTime(2021, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 16, new DateTime(2021, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 17, new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 1, new DateTime(2021, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 15, new DateTime(2021, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 18, new DateTime(2021, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 6, new DateTime(2021, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 16, new DateTime(2021, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 14 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 19, new DateTime(2021, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 3, new DateTime(2021, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 6 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 4, new DateTime(2021, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 16 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 6, new DateTime(2021, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 11 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 10, new DateTime(2021, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 13 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 3, new DateTime(2021, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 9, new DateTime(2021, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 13 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 15, new DateTime(2021, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 9, new DateTime(2021, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 1, new DateTime(2021, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 17, new DateTime(2021, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 16, new DateTime(2021, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "BookId", "BorrowedDate" },
                values: new object[] { 5, new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "BorrowedDate", "ReturnDate" },
                values: new object[] { new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 4, new DateTime(2021, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 1, new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 4 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 9, new DateTime(2021, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 8, new DateTime(2021, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 17, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 8, new DateTime(2021, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 18, new DateTime(2021, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 14, new DateTime(2021, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 14 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 11, new DateTime(2021, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { new DateTime(2021, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 16 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 5, new DateTime(2021, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 3, new DateTime(2021, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 16 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 17, new DateTime(2021, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 11, new DateTime(2021, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 7, new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 12, new DateTime(2021, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 4 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 16, new DateTime(2021, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 16 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 10, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 6 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 2, new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 11, new DateTime(2021, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 9, new DateTime(2021, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 13, new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 14 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 5, new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 14 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 16, new DateTime(2021, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 18, new DateTime(2021, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 6 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 13, new DateTime(2021, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 18, new DateTime(2021, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 1, new DateTime(2021, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 14, new DateTime(2021, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 4, new DateTime(2021, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 2, new DateTime(2021, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 14, new DateTime(2021, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 13, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 2, new DateTime(2021, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 19, new DateTime(2021, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 8 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 18, new DateTime(2021, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 8, new DateTime(2021, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 3, new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 9 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 10, new DateTime(2021, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 18 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 7, new DateTime(2021, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 8, new DateTime(2021, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 9 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 7, new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 17, new DateTime(2021, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 8, new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "BorrowedDate", "UserId" },
                values: new object[] { new DateTime(2021, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 3, new DateTime(2021, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { new DateTime(2021, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 4 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 5, new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 18, new DateTime(2021, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 4 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 16, new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 11, new DateTime(2021, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 4, new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 12, new DateTime(2021, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 8, new DateTime(2021, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 8, new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "BorrowedDate", "UserId" },
                values: new object[] { new DateTime(2021, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 16, new DateTime(2021, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 6, new DateTime(2021, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 13, new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "BookId", "BorrowedDate" },
                values: new object[] { 2, new DateTime(2021, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "BorrowedDate", "UserId" },
                values: new object[] { new DateTime(2021, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "BookId", "BorrowedDate" },
                values: new object[] { 4, new DateTime(2021, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 3, new DateTime(2021, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 16, new DateTime(2021, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 9 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 15, new DateTime(2021, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 18, new DateTime(2021, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 19, new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 18 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "BookId", "BorrowedDate" },
                values: new object[] { 8, new DateTime(2021, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 15, new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 15, new DateTime(2021, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 2, new DateTime(2021, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 13, new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 4, new DateTime(2021, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 16 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "BorrowedDate", "UserId" },
                values: new object[] { new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 4, new DateTime(2021, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 6, new DateTime(2021, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 8, new DateTime(2021, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 4, new DateTime(2021, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 8, new DateTime(2021, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 6 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 5, new DateTime(2021, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 4 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 16, new DateTime(2021, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 15, new DateTime(2021, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 2, new DateTime(2021, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 2, new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 15, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 9, new DateTime(2021, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 12 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 16, new DateTime(2021, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 19, new DateTime(2021, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 11, new DateTime(2021, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 13 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 2, new DateTime(2021, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 9 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 5, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 11 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { new DateTime(2021, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 8, new DateTime(2021, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate" },
                values: new object[] { 18, new DateTime(2021, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 5, new DateTime(2021, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 13, new DateTime(2021, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 14 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 10, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "BookId", "BorrowedDate" },
                values: new object[] { 16, new DateTime(2021, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { new DateTime(2021, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 14, new DateTime(2021, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 13, new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 11 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 17, new DateTime(2021, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 4, new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 6 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 17, new DateTime(2021, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "BookId", "BorrowedDate" },
                values: new object[] { 17, new DateTime(2021, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 12, new DateTime(2021, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 18, new DateTime(2021, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 11, new DateTime(2021, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 1, new DateTime(2021, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 17, new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 13, new DateTime(2021, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 11, new DateTime(2021, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 18 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 17, new DateTime(2021, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 15, new DateTime(2021, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 16, new DateTime(2021, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "BookId", "BorrowedDate" },
                values: new object[] { 8, new DateTime(2021, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 14, new DateTime(2021, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 8 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 11, new DateTime(2021, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 10, new DateTime(2021, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 15, new DateTime(2021, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 12 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 3, new DateTime(2021, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 7, new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 4, new DateTime(2021, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 4, new DateTime(2021, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "BorrowedDate", "UserId" },
                values: new object[] { new DateTime(2021, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 14, new DateTime(2021, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 19, new DateTime(2021, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { new DateTime(2021, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 18, new DateTime(2021, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 19, new DateTime(2021, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 14 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 13, new DateTime(2021, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 9, new DateTime(2021, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 17, new DateTime(2021, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 8, new DateTime(2021, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 12, new DateTime(2021, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 17, new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 4 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 19, new DateTime(2021, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 12 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 16, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 18 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 10, new DateTime(2021, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 18, new DateTime(2021, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 8, new DateTime(2021, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 9 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 12, new DateTime(2021, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 13 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 11, new DateTime(2021, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 6, new DateTime(2021, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 12 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 17, new DateTime(2021, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 13, new DateTime(2021, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 17, new DateTime(2021, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 8, new DateTime(2021, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 18 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 13, new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 9 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 9, new DateTime(2021, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 6 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 4, new DateTime(2021, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 7, new DateTime(2021, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 18 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 2, new DateTime(2021, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 13, new DateTime(2021, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 4, new DateTime(2021, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 3, new DateTime(2021, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 19, new DateTime(2021, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 4, new DateTime(2021, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 6 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "BorrowedDate", "UserId" },
                values: new object[] { new DateTime(2021, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "BookId", "BorrowedDate" },
                values: new object[] { 14, new DateTime(2021, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "BookId", "ReturnDate", "UserId" },
                values: new object[] { 15, new DateTime(2022, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 16, new DateTime(2021, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 9, new DateTime(2021, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 16 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 19, new DateTime(2021, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 12, new DateTime(2021, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 9, new DateTime(2021, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 17, new DateTime(2021, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "BookId", "BorrowedDate" },
                values: new object[] { 6, new DateTime(2021, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 6, new DateTime(2021, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 19, new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 12, new DateTime(2021, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 7, new DateTime(2021, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 7, new DateTime(2021, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 11 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 4, new DateTime(2021, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 2, new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 11, new DateTime(2021, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 8 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 17, new DateTime(2021, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 7, new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 12 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 19, new DateTime(2021, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 4 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 1, new DateTime(2021, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 6, new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 11, new DateTime(2021, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 4 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 10, new DateTime(2021, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 11, new DateTime(2021, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 13, new DateTime(2021, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 10, new DateTime(2021, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 9, new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 4, new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 9 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 8, new DateTime(2021, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 3, new DateTime(2021, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "BookId", "BorrowedDate" },
                values: new object[] { 16, new DateTime(2021, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 16, new DateTime(2021, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 2, new DateTime(2021, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 3, new DateTime(2021, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 2, new DateTime(2021, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 7, new DateTime(2021, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 9, new DateTime(2021, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { new DateTime(2021, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 9 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 10, new DateTime(2021, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 14, new DateTime(2021, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 11 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 3, new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 8, new DateTime(2021, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 11, new DateTime(2021, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 19, new DateTime(2021, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 4 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 17, new DateTime(2021, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 14, new DateTime(2021, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 16, new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 12 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 4, new DateTime(2021, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 11, new DateTime(2021, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 18 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "BookId", "BorrowedDate" },
                values: new object[] { 17, new DateTime(2021, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { new DateTime(2021, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 4, new DateTime(2021, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 19, new DateTime(2021, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "BorrowedDate", "UserId" },
                values: new object[] { new DateTime(2021, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 5, new DateTime(2021, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 18 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 12, new DateTime(2021, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 12, new DateTime(2021, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 17, new DateTime(2021, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 11 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 14, new DateTime(2021, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 12 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 6, new DateTime(2021, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 7, new DateTime(2021, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 14 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 13, new DateTime(2021, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 4, new DateTime(2021, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 11, new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 4 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 14, new DateTime(2021, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 15, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 8, new DateTime(2021, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { new DateTime(2021, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 12 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 13, new DateTime(2021, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { new DateTime(2021, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 11 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 8, new DateTime(2021, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 2, new DateTime(2021, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 7, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 18, new DateTime(2021, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 13, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 18, new DateTime(2021, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 16, new DateTime(2021, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 8, new DateTime(2021, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 6, new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 4 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 14, new DateTime(2021, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 17, new DateTime(2021, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 8 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 3, new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 3, new DateTime(2021, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 10, new DateTime(2021, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 8, new DateTime(2021, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { new DateTime(2021, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "BookId", "BorrowedDate" },
                values: new object[] { 5, new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 16, new DateTime(2021, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 9 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 17, new DateTime(2021, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 5, new DateTime(2021, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 9, new DateTime(2021, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 2, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 17, new DateTime(2021, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 6, new DateTime(2021, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 4, new DateTime(2021, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 6, new DateTime(2021, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 18, new DateTime(2021, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 19, new DateTime(2021, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 12 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 17, new DateTime(2021, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 19, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 12, new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 11, new DateTime(2021, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 8, new DateTime(2021, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 11, new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 6, new DateTime(2021, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 8, new DateTime(2021, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 9 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 15, new DateTime(2021, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 3, new DateTime(2021, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { new DateTime(2021, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 5, new DateTime(2021, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 11 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 19, new DateTime(2021, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 13, new DateTime(2021, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 15, new DateTime(2021, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 16 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 10, new DateTime(2021, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 14 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 499,
                column: "BorrowedDate",
                value: new DateTime(2021, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "NoOfBorrowedBooks", "NoOfCopyBooks" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "NoOfBorrowedBooks", "NoOfCopyBooks" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "NoOfBorrowedBooks", "NoOfCopyBooks" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "NoOfBorrowedBooks", "NoOfCopyBooks" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "NoOfBorrowedBooks", "NoOfCopyBooks" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "NoOfBorrowedBooks", "NoOfCopyBooks" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "NoOfBorrowedBooks", "NoOfCopyBooks" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "NoOfBorrowedBooks", "NoOfCopyBooks" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "NoOfBorrowedBooks", "NoOfCopyBooks" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "NoOfBorrowedBooks", "NoOfCopyBooks" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "NoOfBorrowedBooks", "NoOfCopyBooks" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "NoOfBorrowedBooks", "NoOfCopyBooks" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "NoOfBorrowedBooks", "NoOfCopyBooks" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "NoOfBorrowedBooks", "NoOfCopyBooks" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "NoOfBorrowedBooks", "NoOfCopyBooks" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "NoOfBorrowedBooks", "NoOfCopyBooks" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "NoOfBorrowedBooks", "NoOfCopyBooks" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "NoOfBorrowedBooks", "NoOfCopyBooks" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "NoOfBorrowedBooks", "NoOfCopyBooks" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 4, new DateTime(2021, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 19, new DateTime(2021, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 4 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 1, new DateTime(2021, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "BorrowedDate" },
                values: new object[] { 3, new DateTime(2021, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 18, new DateTime(2021, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 12, new DateTime(2021, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 14, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 9 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 7, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 18 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 5, new DateTime(2021, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 8, new DateTime(2021, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 19, new DateTime(2021, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 7, new DateTime(2021, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 11, new DateTime(2021, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 10, new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 17, new DateTime(2021, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 16, new DateTime(2021, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 18 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 3, new DateTime(2021, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 9 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 10, new DateTime(2021, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 6, new DateTime(2021, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 14 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 1, new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { new DateTime(2021, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 13, new DateTime(2021, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 14, new DateTime(2021, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 12, new DateTime(2021, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 15, new DateTime(2021, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 4, new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 18, new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 9, new DateTime(2021, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 8, new DateTime(2021, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 12, new DateTime(2021, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 3 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 6, new DateTime(2021, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 4, new DateTime(2021, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 14, new DateTime(2021, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 17, new DateTime(2021, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 15, new DateTime(2021, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 10, new DateTime(2021, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 6 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 10, new DateTime(2021, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 14 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 10, new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 6, new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 11, new DateTime(2021, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 10, new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BookId", "BorrowedDate" },
                values: new object[] { 5, new DateTime(2021, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 7, new DateTime(2021, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 14, new DateTime(2021, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 13 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 3, new DateTime(2021, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 19, new DateTime(2021, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 14 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 10, new DateTime(2021, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 6, new DateTime(2021, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 15, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 9 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 9, new DateTime(2021, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 16 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "BookId", "BorrowedDate" },
                values: new object[] { 15, new DateTime(2021, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 12, new DateTime(2021, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 16 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 13, new DateTime(2021, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 1, new DateTime(2021, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 18 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 7, new DateTime(2021, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 14 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 12, new DateTime(2021, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 6, new DateTime(2021, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 13 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 15, new DateTime(2021, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 15, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BookId", "BorrowedDate" },
                values: new object[] { 12, new DateTime(2021, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 9, new DateTime(2021, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 14 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 8, new DateTime(2021, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 10, new DateTime(2021, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 5, new DateTime(2021, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 5, new DateTime(2021, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 15, new DateTime(2021, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 6, new DateTime(2021, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 16, new DateTime(2021, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 16 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 10, new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 17, new DateTime(2021, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 14, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { new DateTime(2021, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 16, new DateTime(2021, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 14, new DateTime(2021, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 1, new DateTime(2021, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 16, new DateTime(2021, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 11 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 1, new DateTime(2021, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 6 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 7, new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 8, new DateTime(2021, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 10, new DateTime(2021, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 14, new DateTime(2021, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 11 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 17, new DateTime(2021, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 10, new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 3, new DateTime(2021, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 5, new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 4 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 4, new DateTime(2021, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 12, new DateTime(2021, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 14 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 10, new DateTime(2021, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 4 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 1, new DateTime(2021, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 16, new DateTime(2021, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 4, new DateTime(2021, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 15, new DateTime(2021, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 6 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 18, new DateTime(2021, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 3, new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 11, new DateTime(2021, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 17, new DateTime(2021, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 7, new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 5, new DateTime(2021, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 18 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 9, new DateTime(2021, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 9, new DateTime(2021, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 4 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 10, new DateTime(2021, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { new DateTime(2021, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 9 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 14, new DateTime(2021, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 13, new DateTime(2021, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 18, new DateTime(2021, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 12 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 1, new DateTime(2021, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 18, new DateTime(2021, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 6, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 10, new DateTime(2021, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 15, new DateTime(2021, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { new DateTime(2021, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 4, new DateTime(2021, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 5, new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 12 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "BookId", "BorrowedDate" },
                values: new object[] { 15, new DateTime(2021, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 10, new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 14 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 14, new DateTime(2021, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "BorrowedDate", "UserId" },
                values: new object[] { new DateTime(2021, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 2, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 7, new DateTime(2021, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 5, new DateTime(2021, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 12 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "BookId", "BorrowedDate" },
                values: new object[] { 2, new DateTime(2021, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 11, new DateTime(2021, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 12 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 12, new DateTime(2021, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 1, new DateTime(2021, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 1, new DateTime(2021, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 11, new DateTime(2021, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 5, new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 14, new DateTime(2021, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 11 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 8, new DateTime(2021, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 17, new DateTime(2021, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "BookId", "BorrowedDate" },
                values: new object[] { 7, new DateTime(2021, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 19, new DateTime(2021, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 8, new DateTime(2021, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 13, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 2, new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 5, new DateTime(2021, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 6 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 10, new DateTime(2021, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 16 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 16, new DateTime(2021, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 14 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 11, new DateTime(2021, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 4 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 10, new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 16 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 19, new DateTime(2021, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 9, new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 9 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "BookId", "BorrowedDate" },
                values: new object[] { 19, new DateTime(2021, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 10, new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 4 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 4, new DateTime(2021, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 5, new DateTime(2021, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 6, new DateTime(2021, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 10, new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 10, new DateTime(2021, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 6 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 10, new DateTime(2021, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 14, new DateTime(2021, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 1, new DateTime(2021, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 8 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 8, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 11 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 5, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 4, new DateTime(2021, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 12, new DateTime(2021, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 1, new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 18, new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 14 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 13, new DateTime(2021, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 1, new DateTime(2021, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 9, new DateTime(2021, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 7, new DateTime(2021, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 6, new DateTime(2021, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 19, new DateTime(2021, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 12 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 1, new DateTime(2021, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 5, new DateTime(2021, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 4, new DateTime(2021, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 6 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 11, new DateTime(2021, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "BookId", "BorrowedDate" },
                values: new object[] { 11, new DateTime(2021, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 10, new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 16 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 8, new DateTime(2021, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 8 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 19, new DateTime(2021, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 10, new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 9, new DateTime(2021, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 9, new DateTime(2021, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 13, new DateTime(2021, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 6 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 16, new DateTime(2021, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 6, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 16, new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 9, new DateTime(2021, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 7, new DateTime(2021, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 15, new DateTime(2021, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 19, new DateTime(2021, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 11 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 10, new DateTime(2021, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 12 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 2, new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 13 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 8, new DateTime(2021, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 11, new DateTime(2021, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 5, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate" },
                values: new object[] { 18, new DateTime(2021, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 2, new DateTime(2021, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "BookId", "BorrowedDate" },
                values: new object[] { 13, new DateTime(2021, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "BookId", "BorrowedDate" },
                values: new object[] { 5, new DateTime(2021, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 4, new DateTime(2021, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "BorrowedDate", "UserId" },
                values: new object[] { new DateTime(2021, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 6, new DateTime(2021, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 13, new DateTime(2021, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 8 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 12, new DateTime(2021, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 9, new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 19, new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 16 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 3, new DateTime(2021, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 2, new DateTime(2021, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 4, new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 18, new DateTime(2021, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 4, new DateTime(2021, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 17, new DateTime(2021, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 14, new DateTime(2021, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 11, new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 2, new DateTime(2021, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 13 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 19, new DateTime(2021, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 4, new DateTime(2021, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 16 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 11, new DateTime(2021, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 12 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 13, new DateTime(2021, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 19, new DateTime(2021, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 14 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 7, new DateTime(2021, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 16, new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 16, new DateTime(2021, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 1, new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 7, new DateTime(2021, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "BookId", "BorrowedDate" },
                values: new object[] { 2, new DateTime(2021, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "BorrowedDate", "ReturnDate" },
                values: new object[] { new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 17, new DateTime(2021, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 14, new DateTime(2021, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 7, new DateTime(2021, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 14, new DateTime(2021, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 7, new DateTime(2021, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 15, new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 4, new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 18 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 7, new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 9 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 6, new DateTime(2021, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 2, new DateTime(2021, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 16 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 10, new DateTime(2021, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 11 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 8, new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 17, new DateTime(2021, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 10, new DateTime(2021, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 8 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 7, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 13 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 19, new DateTime(2021, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 6, new DateTime(2021, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 13 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 9, new DateTime(2021, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 17, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 5, new DateTime(2021, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 11, new DateTime(2021, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 12, new DateTime(2021, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 17, new DateTime(2021, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 7, new DateTime(2021, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 6, new DateTime(2021, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 1, new DateTime(2021, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 6, new DateTime(2021, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 9, new DateTime(2021, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 3, new DateTime(2021, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 16 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 14, new DateTime(2021, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 12, new DateTime(2021, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 6, new DateTime(2021, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 18 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 19, new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 7, new DateTime(2021, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 13, new DateTime(2021, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 12 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 2, new DateTime(2021, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 8 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 14, new DateTime(2021, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 12 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 12, new DateTime(2021, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 6, new DateTime(2021, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 16 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 16, new DateTime(2021, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 6 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 14, new DateTime(2021, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 10, new DateTime(2021, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 14, new DateTime(2021, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 18 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "BorrowedDate", "UserId" },
                values: new object[] { new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 5, new DateTime(2021, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 16 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { new DateTime(2021, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 19, new DateTime(2021, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 13, new DateTime(2021, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 10, new DateTime(2021, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 7, new DateTime(2021, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 9, new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 1, new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 12 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 2, new DateTime(2021, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 6 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 16, new DateTime(2021, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "BorrowedDate", "UserId" },
                values: new object[] { new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 6, new DateTime(2021, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 8, new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 15, new DateTime(2021, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "BookId", "BorrowedDate" },
                values: new object[] { 6, new DateTime(2021, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "BorrowedDate", "UserId" },
                values: new object[] { new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "BookId", "BorrowedDate" },
                values: new object[] { 5, new DateTime(2021, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 8, new DateTime(2021, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 18, new DateTime(2021, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 8 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 6, new DateTime(2021, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 9 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 16, new DateTime(2021, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 6 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 12, new DateTime(2021, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 13 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "BookId", "BorrowedDate" },
                values: new object[] { 2, new DateTime(2021, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 3, new DateTime(2021, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 6 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 12, new DateTime(2021, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 5, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 12, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 12 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 3, new DateTime(2021, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "BorrowedDate", "UserId" },
                values: new object[] { new DateTime(2021, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 11, new DateTime(2021, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 8, new DateTime(2021, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 18, new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 18 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 15, new DateTime(2021, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 13, new DateTime(2021, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 2, new DateTime(2021, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 7, new DateTime(2021, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 3, new DateTime(2021, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 12, new DateTime(2021, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 17, new DateTime(2021, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 12, new DateTime(2021, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 5, new DateTime(2021, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 11, new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 9, new DateTime(2021, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 4 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 16, new DateTime(2021, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 16, new DateTime(2021, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 14 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 10, new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 4 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { new DateTime(2021, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 8 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 6, new DateTime(2021, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate" },
                values: new object[] { 12, new DateTime(2021, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 9, new DateTime(2021, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 12 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 19, new DateTime(2021, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 17, new DateTime(2021, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 4 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "BookId", "BorrowedDate" },
                values: new object[] { 8, new DateTime(2021, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { new DateTime(2021, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 1, new DateTime(2021, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 5, new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 8 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 10, new DateTime(2021, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 9, new DateTime(2021, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 19, new DateTime(2021, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "BookId", "BorrowedDate" },
                values: new object[] { 12, new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 19, new DateTime(2021, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 17, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 14, new DateTime(2021, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 10, new DateTime(2021, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 5, new DateTime(2021, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 3, new DateTime(2021, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 15, new DateTime(2021, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 12, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 14 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 13, new DateTime(2021, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 14, new DateTime(2021, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "BookId", "BorrowedDate" },
                values: new object[] { 9, new DateTime(2021, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 6, new DateTime(2021, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 13 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 7, new DateTime(2021, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 6 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 4, new DateTime(2021, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 8 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 19, new DateTime(2021, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 17, new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 6 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 18, new DateTime(2021, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 3, new DateTime(2021, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 11 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 19, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "BorrowedDate", "UserId" },
                values: new object[] { new DateTime(2021, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 7, new DateTime(2021, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 11, new DateTime(2021, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 6 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { new DateTime(2021, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 8 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 6, new DateTime(2021, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 17, new DateTime(2021, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 11 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 1, new DateTime(2021, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 14, new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 1, new DateTime(2021, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 11, new DateTime(2021, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 12 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 5, new DateTime(2021, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 16, new DateTime(2021, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 7, new DateTime(2021, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 11 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 19, new DateTime(2021, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 9, new DateTime(2021, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 8 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 11, new DateTime(2021, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 14, new DateTime(2021, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 8 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 6, new DateTime(2021, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 14 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 19, new DateTime(2021, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 4, new DateTime(2021, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 13 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 18, new DateTime(2021, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 9, new DateTime(2021, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 13, new DateTime(2021, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 4 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 18, new DateTime(2021, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 18, new DateTime(2021, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 8 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 17, new DateTime(2021, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 13 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 14, new DateTime(2021, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 4 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 6, new DateTime(2021, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 6, new DateTime(2021, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 7, new DateTime(2021, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 16 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 19, new DateTime(2021, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 6, new DateTime(2021, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 1, new DateTime(2021, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 14, new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "BorrowedDate", "UserId" },
                values: new object[] { new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "BookId", "BorrowedDate" },
                values: new object[] { 19, new DateTime(2021, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "BookId", "ReturnDate", "UserId" },
                values: new object[] { 19, null, 16 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 9, new DateTime(2021, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 18 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 12, new DateTime(2021, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 7, new DateTime(2021, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 11 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 4, new DateTime(2021, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 8 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 6, new DateTime(2021, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 13, new DateTime(2021, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "BookId", "BorrowedDate" },
                values: new object[] { 15, new DateTime(2021, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 8, new DateTime(2021, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 18 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 10, new DateTime(2021, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 16, new DateTime(2021, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 4, new DateTime(2021, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 3, new DateTime(2021, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 12 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 13, new DateTime(2021, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 9, new DateTime(2021, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 10, new DateTime(2021, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 8, new DateTime(2021, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 1, new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 9 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 5, new DateTime(2021, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 15, new DateTime(2021, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 11, new DateTime(2021, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 6, new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 12, new DateTime(2021, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 12 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 10, new DateTime(2021, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 5, new DateTime(2021, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 11, new DateTime(2021, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 16, new DateTime(2021, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 12, new DateTime(2021, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 4, new DateTime(2021, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 15, new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 9 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "BookId", "BorrowedDate" },
                values: new object[] { 18, new DateTime(2021, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 5, new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 3, new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 12 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 10, new DateTime(2021, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 6, new DateTime(2021, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 2, new DateTime(2021, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 13, new DateTime(2021, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { new DateTime(2021, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 4 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 19, new DateTime(2021, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 16 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 5, new DateTime(2021, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 8 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 18, new DateTime(2021, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 19, new DateTime(2021, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 19, new DateTime(2021, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 16, new DateTime(2021, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 11 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 14, new DateTime(2021, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 1, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 1, new DateTime(2021, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 16, new DateTime(2021, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 18, new DateTime(2021, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "BookId", "BorrowedDate" },
                values: new object[] { 4, new DateTime(2021, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 14, new DateTime(2021, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 12, new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 4 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "BorrowedDate", "UserId" },
                values: new object[] { new DateTime(2021, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 10, new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 13, new DateTime(2021, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 16, new DateTime(2021, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 11, new DateTime(2021, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 19, new DateTime(2021, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 11 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 1, new DateTime(2021, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 4, new DateTime(2021, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 10, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 5, new DateTime(2021, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 8, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 13, new DateTime(2021, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 1, new DateTime(2021, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 4, new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 13 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 1, new DateTime(2021, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { new DateTime(2021, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 8 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 19, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 12 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 6, new DateTime(2021, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 10, new DateTime(2021, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 18 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 16, new DateTime(2021, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 19, new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 7, new DateTime(2021, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 4, new DateTime(2021, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 16, new DateTime(2021, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 12 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 2, new DateTime(2021, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 15, new DateTime(2021, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 14, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 11 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 9, new DateTime(2021, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 12, new DateTime(2021, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 6, new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 8 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 12, new DateTime(2021, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 4 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { new DateTime(2021, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 4 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "BookId", "BorrowedDate" },
                values: new object[] { 1, new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 9, new DateTime(2021, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 5, new DateTime(2021, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 6 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 18, new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 4 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 19, new DateTime(2021, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 9, new DateTime(2021, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 6 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 4, new DateTime(2021, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 13, new DateTime(2021, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 9, new DateTime(2021, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 8 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 16, new DateTime(2021, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 3, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 5, new DateTime(2021, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 4, new DateTime(2021, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 13, new DateTime(2021, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 7, new DateTime(2021, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 12 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 8, new DateTime(2021, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 14 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 10, new DateTime(2021, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 2, new DateTime(2021, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 16, new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 4 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 4, new DateTime(2021, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 8 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[] { 10, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 17 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 9, new DateTime(2021, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { new DateTime(2021, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "BookId", "BorrowedDate", "ReturnDate", "UserId" },
                values: new object[] { 3, new DateTime(2021, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { new DateTime(2021, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 6 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 1, new DateTime(2021, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "BookId", "BorrowedDate", "UserId" },
                values: new object[] { 15, new DateTime(2021, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 14, new DateTime(2021, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 11 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "BookId", "BorrowedDate", "IsCopy", "UserId" },
                values: new object[] { 3, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 19 });

            migrationBuilder.UpdateData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 499,
                column: "BorrowedDate",
                value: new DateTime(2021, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}

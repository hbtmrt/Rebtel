using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RebtelTest.Data.Migrations
{
    public partial class seeduserbooksborrowings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "UserBorrowedBook",
                columns: new[] { "Id", "BookId", "BorrowedDate", "ExpectedReturnDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2021, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 4 },
                    { 341, 1, new DateTime(2021, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 18 },
                    { 340, 3, new DateTime(2021, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, new DateTime(2022, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 339, 11, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 8 },
                    { 338, 9, new DateTime(2021, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 16 },
                    { 337, 5, new DateTime(2021, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, new DateTime(2022, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 336, 8, new DateTime(2021, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, new DateTime(2022, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 335, 10, new DateTime(2021, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 2 },
                    { 334, 5, new DateTime(2021, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 333, 4, new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 9 },
                    { 332, 18, new DateTime(2021, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 13 },
                    { 331, 2, new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 1 },
                    { 330, 17, new DateTime(2021, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 9 },
                    { 329, 19, new DateTime(2021, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 8 },
                    { 328, 19, new DateTime(2021, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 14 },
                    { 327, 2, new DateTime(2021, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 9 },
                    { 326, 16, new DateTime(2021, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 6 },
                    { 325, 6, new DateTime(2021, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 3 },
                    { 324, 19, new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, new DateTime(2022, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 323, 8, new DateTime(2021, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 7 },
                    { 322, 8, new DateTime(2021, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 12 },
                    { 321, 15, new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 4 },
                    { 320, 19, new DateTime(2021, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 8 },
                    { 319, 3, new DateTime(2021, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 18 },
                    { 318, 8, new DateTime(2021, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 19 },
                    { 317, 11, new DateTime(2021, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 316, 2, new DateTime(2021, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 315, 8, new DateTime(2021, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 2 },
                    { 342, 18, new DateTime(2021, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 17 },
                    { 314, 5, new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 8 },
                    { 343, 13, new DateTime(2021, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 7 },
                    { 345, 16, new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 6 },
                    { 372, 16, new DateTime(2021, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 2 },
                    { 371, 18, new DateTime(2021, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 8 },
                    { 370, 10, new DateTime(2021, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 8 },
                    { 369, 12, new DateTime(2021, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 16 },
                    { 368, 6, new DateTime(2021, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, new DateTime(2022, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 367, 9, new DateTime(2021, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 13 },
                    { 366, 18, new DateTime(2021, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 12 },
                    { 365, 14, new DateTime(2021, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 19 },
                    { 364, 9, new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 8 },
                    { 363, 4, new DateTime(2021, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 1 }
                });

            migrationBuilder.InsertData(
                table: "UserBorrowedBook",
                columns: new[] { "Id", "BookId", "BorrowedDate", "ExpectedReturnDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[,]
                {
                    { 362, 16, new DateTime(2021, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 8 },
                    { 361, 4, new DateTime(2021, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 12 },
                    { 360, 16, new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 1 },
                    { 359, 9, new DateTime(2021, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 2 },
                    { 358, 9, new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 4 },
                    { 357, 16, new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 2 },
                    { 356, 19, new DateTime(2021, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 355, 11, new DateTime(2021, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 16 },
                    { 354, 19, new DateTime(2021, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 9 },
                    { 353, 14, new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 6 },
                    { 352, 6, new DateTime(2021, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 4 },
                    { 351, 3, new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 3 },
                    { 350, 17, new DateTime(2021, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 6 },
                    { 349, 12, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 348, 19, new DateTime(2021, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 17 },
                    { 347, 8, new DateTime(2021, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 3 },
                    { 346, 15, new DateTime(2021, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 12 },
                    { 344, 3, new DateTime(2021, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 14 },
                    { 313, 11, new DateTime(2021, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 11 },
                    { 312, 6, new DateTime(2021, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 4 },
                    { 311, 6, new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 278, 10, new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 6 },
                    { 277, 5, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 276, 7, new DateTime(2021, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 1 },
                    { 275, 3, new DateTime(2021, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 7 },
                    { 274, 15, new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 273, 18, new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 19 },
                    { 272, 8, new DateTime(2021, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 271, 12, new DateTime(2021, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 2 },
                    { 270, 12, new DateTime(2021, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 9 },
                    { 269, 15, new DateTime(2021, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 4 },
                    { 268, 14, new DateTime(2021, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 16 },
                    { 267, 14, new DateTime(2021, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 19 },
                    { 266, 8, new DateTime(2021, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 17 },
                    { 265, 8, new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 264, 18, new DateTime(2021, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 2 },
                    { 263, 4, new DateTime(2021, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 14 },
                    { 262, 2, new DateTime(2021, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 261, 1, new DateTime(2021, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 14 },
                    { 260, 4, new DateTime(2021, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 19 },
                    { 259, 10, new DateTime(2021, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 7 },
                    { 258, 6, new DateTime(2021, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 16 }
                });

            migrationBuilder.InsertData(
                table: "UserBorrowedBook",
                columns: new[] { "Id", "BookId", "BorrowedDate", "ExpectedReturnDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[,]
                {
                    { 257, 16, new DateTime(2021, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 18 },
                    { 256, 12, new DateTime(2021, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 7 },
                    { 255, 16, new DateTime(2021, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 17 },
                    { 254, 15, new DateTime(2021, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 1 },
                    { 253, 19, new DateTime(2021, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 3 },
                    { 252, 7, new DateTime(2021, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 279, 2, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 9 },
                    { 280, 6, new DateTime(2021, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 7 },
                    { 281, 7, new DateTime(2021, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 6 },
                    { 282, 5, new DateTime(2021, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 14 },
                    { 310, 16, new DateTime(2021, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 18 },
                    { 309, 8, new DateTime(2021, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 4 },
                    { 308, 14, new DateTime(2021, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 8 },
                    { 307, 17, new DateTime(2021, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 14 },
                    { 306, 5, new DateTime(2021, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 17 },
                    { 305, 8, new DateTime(2021, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 7 },
                    { 304, 13, new DateTime(2021, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 6 },
                    { 303, 3, new DateTime(2021, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 19 },
                    { 302, 15, new DateTime(2021, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 3 },
                    { 301, 5, new DateTime(2021, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 11 },
                    { 300, 18, new DateTime(2021, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 2 },
                    { 299, 10, new DateTime(2021, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 14 },
                    { 298, 1, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 373, 7, new DateTime(2021, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 16 },
                    { 297, 4, new DateTime(2021, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 8 },
                    { 295, 6, new DateTime(2021, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 11 },
                    { 294, 3, new DateTime(2021, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 293, 11, new DateTime(2021, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 6 },
                    { 292, 5, new DateTime(2021, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 11 },
                    { 291, 4, new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 6 },
                    { 290, 15, new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 9 },
                    { 289, 1, new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 9 },
                    { 288, 15, new DateTime(2021, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 7 },
                    { 287, 10, new DateTime(2021, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 14 },
                    { 286, 5, new DateTime(2021, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 16 },
                    { 285, 13, new DateTime(2021, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 16 },
                    { 284, 17, new DateTime(2021, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 7 },
                    { 283, 7, new DateTime(2021, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 6 },
                    { 296, 13, new DateTime(2021, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 1 },
                    { 251, 4, new DateTime(2021, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 11 },
                    { 374, 12, new DateTime(2021, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 11 },
                    { 376, 1, new DateTime(2021, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 13 }
                });

            migrationBuilder.InsertData(
                table: "UserBorrowedBook",
                columns: new[] { "Id", "BookId", "BorrowedDate", "ExpectedReturnDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[,]
                {
                    { 466, 4, new DateTime(2021, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 465, 12, new DateTime(2021, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 11 },
                    { 464, 4, new DateTime(2021, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 9 },
                    { 463, 13, new DateTime(2021, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 16 },
                    { 462, 19, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 11 },
                    { 461, 3, new DateTime(2021, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 2 },
                    { 460, 5, new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 11 },
                    { 459, 13, new DateTime(2021, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 13 },
                    { 458, 3, new DateTime(2021, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, new DateTime(2022, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 457, 19, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 16 },
                    { 456, 1, new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 7 },
                    { 455, 11, new DateTime(2021, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 1 },
                    { 454, 2, new DateTime(2021, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 2 },
                    { 453, 5, new DateTime(2021, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 16 },
                    { 452, 8, new DateTime(2021, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 11 },
                    { 451, 15, new DateTime(2021, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 8 },
                    { 450, 16, new DateTime(2021, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 14 },
                    { 449, 13, new DateTime(2021, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 14 },
                    { 448, 17, new DateTime(2021, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 11 },
                    { 447, 2, new DateTime(2021, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 11 },
                    { 446, 1, new DateTime(2021, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 2 },
                    { 445, 7, new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 2 },
                    { 444, 14, new DateTime(2021, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 3 },
                    { 443, 9, new DateTime(2021, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 16 },
                    { 442, 2, new DateTime(2021, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 7 },
                    { 441, 10, new DateTime(2021, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 440, 2, new DateTime(2021, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 7 },
                    { 467, 9, new DateTime(2021, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 2 },
                    { 439, 6, new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 3 },
                    { 468, 15, new DateTime(2021, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 19 },
                    { 470, 17, new DateTime(2021, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 11 },
                    { 497, 9, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 18 },
                    { 496, 16, new DateTime(2021, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 7 },
                    { 495, 8, new DateTime(2021, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 13 },
                    { 494, 7, new DateTime(2021, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 493, 10, new DateTime(2021, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, new DateTime(2022, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 492, 12, new DateTime(2021, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 14 },
                    { 491, 9, new DateTime(2021, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 13 },
                    { 490, 9, new DateTime(2021, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 8 },
                    { 489, 3, new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 8 },
                    { 488, 9, new DateTime(2021, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 19 },
                    { 487, 5, new DateTime(2021, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 }
                });

            migrationBuilder.InsertData(
                table: "UserBorrowedBook",
                columns: new[] { "Id", "BookId", "BorrowedDate", "ExpectedReturnDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[,]
                {
                    { 486, 6, new DateTime(2021, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 2 },
                    { 485, 19, new DateTime(2021, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 484, 12, new DateTime(2021, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 3 },
                    { 483, 9, new DateTime(2021, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 1 },
                    { 482, 14, new DateTime(2021, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 3 },
                    { 481, 18, new DateTime(2021, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 13 },
                    { 480, 7, new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 9 },
                    { 479, 17, new DateTime(2021, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 478, 13, new DateTime(2021, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 19 },
                    { 477, 1, new DateTime(2021, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 476, 3, new DateTime(2021, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 12 },
                    { 475, 11, new DateTime(2021, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 11 },
                    { 474, 17, new DateTime(2021, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 8 },
                    { 473, 17, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 14 },
                    { 472, 10, new DateTime(2021, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 4 },
                    { 471, 17, new DateTime(2021, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 12 },
                    { 469, 5, new DateTime(2021, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 8 },
                    { 438, 14, new DateTime(2021, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 17 },
                    { 437, 6, new DateTime(2021, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 1 },
                    { 436, 9, new DateTime(2021, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 8 },
                    { 403, 12, new DateTime(2021, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 18 },
                    { 402, 1, new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 14 },
                    { 401, 15, new DateTime(2021, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 14 },
                    { 400, 4, new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 8 },
                    { 399, 14, new DateTime(2021, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 2 },
                    { 398, 13, new DateTime(2021, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 397, 15, new DateTime(2021, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 12 },
                    { 396, 1, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 11 },
                    { 395, 3, new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 16 },
                    { 394, 16, new DateTime(2021, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 6 },
                    { 393, 14, new DateTime(2021, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 16 },
                    { 392, 2, new DateTime(2021, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 8 },
                    { 391, 19, new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 8 },
                    { 390, 4, new DateTime(2021, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 389, 10, new DateTime(2021, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 16 },
                    { 388, 15, new DateTime(2021, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 387, 9, new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 18 },
                    { 386, 6, new DateTime(2021, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, new DateTime(2022, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 385, 8, new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 12 },
                    { 384, 19, new DateTime(2021, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 13 },
                    { 383, 2, new DateTime(2021, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 18 },
                    { 382, 19, new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 14 }
                });

            migrationBuilder.InsertData(
                table: "UserBorrowedBook",
                columns: new[] { "Id", "BookId", "BorrowedDate", "ExpectedReturnDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[,]
                {
                    { 381, 6, new DateTime(2021, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 18 },
                    { 380, 19, new DateTime(2021, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 8 },
                    { 379, 2, new DateTime(2021, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 14 },
                    { 378, 9, new DateTime(2021, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 3 },
                    { 377, 16, new DateTime(2021, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 1 },
                    { 404, 1, new DateTime(2021, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 8 },
                    { 405, 13, new DateTime(2021, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 9 },
                    { 406, 7, new DateTime(2021, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 4 },
                    { 407, 18, new DateTime(2021, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, new DateTime(2022, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 435, 18, new DateTime(2021, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 2 },
                    { 434, 14, new DateTime(2021, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 16 },
                    { 433, 18, new DateTime(2021, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 432, 15, new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 13 },
                    { 431, 17, new DateTime(2021, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 4 },
                    { 430, 5, new DateTime(2021, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 8 },
                    { 429, 19, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 16 },
                    { 428, 11, new DateTime(2021, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 7 },
                    { 427, 1, new DateTime(2021, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 8 },
                    { 426, 7, new DateTime(2021, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 18 },
                    { 425, 5, new DateTime(2021, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 6 },
                    { 424, 2, new DateTime(2021, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 423, 9, new DateTime(2021, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, new DateTime(2022, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 375, 12, new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 3 },
                    { 422, 14, new DateTime(2021, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 12 },
                    { 420, 4, new DateTime(2021, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 9 },
                    { 419, 4, new DateTime(2021, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 418, 6, new DateTime(2021, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 7 },
                    { 417, 17, new DateTime(2021, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 17 },
                    { 416, 12, new DateTime(2021, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 17 },
                    { 415, 6, new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 12 },
                    { 414, 12, new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, new DateTime(2022, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 413, 19, new DateTime(2021, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 11 },
                    { 412, 15, new DateTime(2021, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 14 },
                    { 411, 2, new DateTime(2021, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, new DateTime(2022, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 410, 7, new DateTime(2021, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 8 },
                    { 409, 16, new DateTime(2021, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 4 },
                    { 408, 13, new DateTime(2021, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 421, 15, new DateTime(2021, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 3 },
                    { 498, 11, new DateTime(2021, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 17 },
                    { 250, 13, new DateTime(2021, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 1 },
                    { 248, 4, new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 11 },
                    { 91, 10, new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 6 }
                });

            migrationBuilder.InsertData(
                table: "UserBorrowedBook",
                columns: new[] { "Id", "BookId", "BorrowedDate", "ExpectedReturnDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[,]
                {
                    { 90, 10, new DateTime(2021, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 3 },
                    { 89, 14, new DateTime(2021, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 7 },
                    { 88, 3, new DateTime(2021, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 6 },
                    { 87, 10, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 9 },
                    { 86, 15, new DateTime(2021, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 85, 10, new DateTime(2021, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 16 },
                    { 84, 10, new DateTime(2021, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 83, 13, new DateTime(2021, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, new DateTime(2022, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 82, 18, new DateTime(2021, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 18 },
                    { 81, 16, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 18 },
                    { 80, 18, new DateTime(2021, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 18 },
                    { 79, 8, new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 17 },
                    { 78, 12, new DateTime(2021, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 7 },
                    { 77, 5, new DateTime(2021, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 8 },
                    { 76, 4, new DateTime(2021, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 11 },
                    { 75, 7, new DateTime(2021, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 4 },
                    { 74, 7, new DateTime(2021, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 73, 1, new DateTime(2021, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 8 },
                    { 72, 17, new DateTime(2021, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 16 },
                    { 71, 1, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 14 },
                    { 70, 18, new DateTime(2021, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 9 },
                    { 69, 3, new DateTime(2021, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 8 },
                    { 68, 6, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 11 },
                    { 67, 11, new DateTime(2021, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 66, 8, new DateTime(2021, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 9 },
                    { 65, 12, new DateTime(2021, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 11 },
                    { 92, 17, new DateTime(2021, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 64, 18, new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 7 },
                    { 93, 3, new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 11 },
                    { 95, 19, new DateTime(2021, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 12 },
                    { 122, 9, new DateTime(2021, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 11 },
                    { 121, 14, new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 7 },
                    { 120, 4, new DateTime(2021, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 119, 17, new DateTime(2021, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 16 },
                    { 118, 15, new DateTime(2021, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 17 },
                    { 117, 9, new DateTime(2021, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 9 },
                    { 116, 1, new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 1 },
                    { 115, 1, new DateTime(2021, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 12 },
                    { 114, 9, new DateTime(2021, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 12 },
                    { 113, 10, new DateTime(2021, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 3 },
                    { 112, 1, new DateTime(2021, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 111, 8, new DateTime(2021, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 17 }
                });

            migrationBuilder.InsertData(
                table: "UserBorrowedBook",
                columns: new[] { "Id", "BookId", "BorrowedDate", "ExpectedReturnDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[,]
                {
                    { 110, 14, new DateTime(2021, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 9 },
                    { 109, 15, new DateTime(2021, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 17 },
                    { 108, 8, new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 4 },
                    { 107, 19, new DateTime(2021, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 12 },
                    { 106, 14, new DateTime(2021, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 11 },
                    { 105, 6, new DateTime(2021, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 1 },
                    { 104, 6, new DateTime(2021, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 2 },
                    { 103, 4, new DateTime(2021, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 13 },
                    { 102, 5, new DateTime(2021, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 9 },
                    { 101, 3, new DateTime(2021, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 4 },
                    { 100, 4, new DateTime(2021, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 12 },
                    { 99, 7, new DateTime(2021, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 6 },
                    { 98, 1, new DateTime(2021, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 2 },
                    { 97, 14, new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 12 },
                    { 96, 19, new DateTime(2021, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 94, 2, new DateTime(2021, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 3 },
                    { 63, 15, new DateTime(2021, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 9 },
                    { 62, 5, new DateTime(2021, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 2 },
                    { 61, 13, new DateTime(2021, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 3 },
                    { 28, 17, new DateTime(2021, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 7 },
                    { 27, 1, new DateTime(2021, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 6 },
                    { 26, 6, new DateTime(2021, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 16 },
                    { 25, 12, new DateTime(2021, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, new DateTime(2022, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 24, 11, new DateTime(2021, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 8 },
                    { 23, 16, new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 16 },
                    { 22, 18, new DateTime(2021, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 8 },
                    { 21, 12, new DateTime(2021, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 19 },
                    { 20, 2, new DateTime(2021, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 13 },
                    { 19, 6, new DateTime(2021, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 6 },
                    { 18, 5, new DateTime(2021, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 3 },
                    { 17, 5, new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 18 },
                    { 16, 18, new DateTime(2021, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 16 },
                    { 15, 1, new DateTime(2021, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 4 },
                    { 14, 12, new DateTime(2021, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 12 },
                    { 13, 19, new DateTime(2021, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 12 },
                    { 12, 6, new DateTime(2021, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 1 },
                    { 11, 10, new DateTime(2021, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 10, 14, new DateTime(2021, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 8 },
                    { 9, 10, new DateTime(2021, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 8, 3, new DateTime(2021, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 4 },
                    { 7, 3, new DateTime(2021, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 3 },
                    { 6, 8, new DateTime(2021, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 16 }
                });

            migrationBuilder.InsertData(
                table: "UserBorrowedBook",
                columns: new[] { "Id", "BookId", "BorrowedDate", "ExpectedReturnDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[,]
                {
                    { 5, 17, new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 18 },
                    { 4, 17, new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 18 },
                    { 3, 6, new DateTime(2021, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 8 },
                    { 2, 1, new DateTime(2021, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 6 },
                    { 29, 10, new DateTime(2021, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 18 },
                    { 30, 14, new DateTime(2021, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 16 },
                    { 31, 18, new DateTime(2021, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 8 },
                    { 32, 4, new DateTime(2021, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 17 },
                    { 60, 18, new DateTime(2021, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 9 },
                    { 59, 4, new DateTime(2021, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 9 },
                    { 58, 17, new DateTime(2021, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 57, 14, new DateTime(2021, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 3 },
                    { 56, 19, new DateTime(2021, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 16 },
                    { 55, 9, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 4 },
                    { 54, 12, new DateTime(2021, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 18 },
                    { 53, 8, new DateTime(2021, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 52, 4, new DateTime(2021, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 7 },
                    { 51, 5, new DateTime(2021, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 18 },
                    { 50, 18, new DateTime(2021, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 4 },
                    { 49, 2, new DateTime(2021, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 16 },
                    { 48, 19, new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 18 },
                    { 123, 8, new DateTime(2021, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 9 },
                    { 47, 19, new DateTime(2021, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 12 },
                    { 45, 9, new DateTime(2021, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 44, 8, new DateTime(2021, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 16 },
                    { 43, 4, new DateTime(2021, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 19 },
                    { 42, 2, new DateTime(2021, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 9 },
                    { 41, 6, new DateTime(2021, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 7 },
                    { 40, 1, new DateTime(2021, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 4 },
                    { 39, 4, new DateTime(2021, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 13 },
                    { 38, 18, new DateTime(2021, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 16 },
                    { 37, 12, new DateTime(2021, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 9 },
                    { 36, 3, new DateTime(2021, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 7 },
                    { 35, 2, new DateTime(2021, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 6 },
                    { 34, 6, new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 14 },
                    { 33, 4, new DateTime(2021, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 11 },
                    { 46, 15, new DateTime(2021, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 7 },
                    { 249, 11, new DateTime(2021, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 2 },
                    { 124, 17, new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 8 },
                    { 126, 4, new DateTime(2021, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 1 },
                    { 216, 4, new DateTime(2021, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 12 },
                    { 215, 13, new DateTime(2021, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 17 }
                });

            migrationBuilder.InsertData(
                table: "UserBorrowedBook",
                columns: new[] { "Id", "BookId", "BorrowedDate", "ExpectedReturnDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[,]
                {
                    { 214, 15, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 16 },
                    { 213, 19, new DateTime(2021, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 212, 16, new DateTime(2021, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 2 },
                    { 211, 11, new DateTime(2021, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 1 },
                    { 210, 1, new DateTime(2021, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 12 },
                    { 209, 2, new DateTime(2021, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 6 },
                    { 208, 17, new DateTime(2021, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 14 },
                    { 207, 1, new DateTime(2021, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 3 },
                    { 206, 5, new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 1 },
                    { 205, 19, new DateTime(2021, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 19 },
                    { 204, 18, new DateTime(2021, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 11 },
                    { 203, 6, new DateTime(2021, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 13 },
                    { 202, 19, new DateTime(2021, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 7 },
                    { 201, 17, new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 17 },
                    { 200, 3, new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 199, 4, new DateTime(2021, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 13 },
                    { 198, 16, new DateTime(2021, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 197, 6, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, new DateTime(2022, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 196, 9, new DateTime(2021, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 4 },
                    { 195, 13, new DateTime(2021, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 194, 10, new DateTime(2021, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 6 },
                    { 193, 1, new DateTime(2021, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 192, 16, new DateTime(2021, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 6 },
                    { 191, 15, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 4 },
                    { 190, 6, new DateTime(2021, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 19 },
                    { 217, 2, new DateTime(2021, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 12 },
                    { 189, 3, new DateTime(2021, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 19 },
                    { 218, 6, new DateTime(2021, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 8 },
                    { 220, 10, new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 19 },
                    { 247, 16, new DateTime(2021, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 246, 10, new DateTime(2021, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 13 },
                    { 245, 3, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 19 },
                    { 244, 17, new DateTime(2021, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 8 },
                    { 243, 1, new DateTime(2021, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 16 },
                    { 242, 7, new DateTime(2021, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 1 },
                    { 241, 19, new DateTime(2021, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 13 },
                    { 240, 9, new DateTime(2021, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 16 },
                    { 239, 4, new DateTime(2021, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 238, 19, new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 4 },
                    { 237, 2, new DateTime(2021, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 1 },
                    { 236, 7, new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 235, 14, new DateTime(2021, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 }
                });

            migrationBuilder.InsertData(
                table: "UserBorrowedBook",
                columns: new[] { "Id", "BookId", "BorrowedDate", "ExpectedReturnDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[,]
                {
                    { 234, 17, new DateTime(2021, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 6 },
                    { 233, 18, new DateTime(2021, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 232, 7, new DateTime(2021, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 18 },
                    { 231, 16, new DateTime(2021, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 230, 19, new DateTime(2021, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 14 },
                    { 229, 14, new DateTime(2021, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 2 },
                    { 228, 3, new DateTime(2021, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, new DateTime(2022, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 227, 12, new DateTime(2021, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 16 },
                    { 226, 1, new DateTime(2021, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 17 },
                    { 225, 8, new DateTime(2021, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 14 },
                    { 224, 1, new DateTime(2021, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 1 },
                    { 223, 6, new DateTime(2021, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 1 },
                    { 222, 3, new DateTime(2021, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 8 },
                    { 221, 15, new DateTime(2021, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 2 },
                    { 219, 5, new DateTime(2021, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 4 },
                    { 188, 16, new DateTime(2021, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, new DateTime(2022, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 187, 9, new DateTime(2021, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 4 },
                    { 186, 9, new DateTime(2021, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 12 },
                    { 153, 13, new DateTime(2021, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 14 },
                    { 152, 3, new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 2 },
                    { 151, 5, new DateTime(2021, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 3 },
                    { 150, 6, new DateTime(2021, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, new DateTime(2022, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 149, 7, new DateTime(2021, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, new DateTime(2022, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 148, 9, new DateTime(2021, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 2 },
                    { 147, 9, new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 2 },
                    { 146, 14, new DateTime(2021, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 16 },
                    { 145, 7, new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 8 },
                    { 144, 2, new DateTime(2021, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 17 },
                    { 143, 7, new DateTime(2021, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, new DateTime(2022, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 142, 14, new DateTime(2021, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 7 },
                    { 141, 1, new DateTime(2021, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 16 },
                    { 140, 14, new DateTime(2021, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 139, 4, new DateTime(2021, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 12 },
                    { 138, 14, new DateTime(2021, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 17 },
                    { 137, 3, new DateTime(2021, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 7 },
                    { 136, 4, new DateTime(2021, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 7 },
                    { 135, 2, new DateTime(2021, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 3 },
                    { 134, 4, new DateTime(2021, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 16 },
                    { 133, 4, new DateTime(2021, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 8 },
                    { 132, 18, new DateTime(2021, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 4 },
                    { 131, 12, new DateTime(2021, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 7 },
                    { 130, 12, new DateTime(2021, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 9 }
                });

            migrationBuilder.InsertData(
                table: "UserBorrowedBook",
                columns: new[] { "Id", "BookId", "BorrowedDate", "ExpectedReturnDate", "IsCopy", "ReturnDate", "UserId" },
                values: new object[,]
                {
                    { 129, 4, new DateTime(2021, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 18 },
                    { 128, 5, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 127, 9, new DateTime(2021, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 11 },
                    { 154, 6, new DateTime(2021, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 3 },
                    { 155, 3, new DateTime(2021, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 1 },
                    { 156, 12, new DateTime(2021, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 157, 19, new DateTime(2021, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 17 },
                    { 185, 2, new DateTime(2021, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 6 },
                    { 184, 14, new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 17 },
                    { 183, 17, new DateTime(2021, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 8 },
                    { 182, 12, new DateTime(2021, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 6 },
                    { 181, 8, new DateTime(2021, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 9 },
                    { 180, 10, new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 1 },
                    { 179, 4, new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 2 },
                    { 178, 11, new DateTime(2021, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 16 },
                    { 177, 6, new DateTime(2021, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 1 },
                    { 176, 8, new DateTime(2021, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 14 },
                    { 175, 17, new DateTime(2021, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 11 },
                    { 174, 18, new DateTime(2021, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 11 },
                    { 173, 5, new DateTime(2021, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 125, 1, new DateTime(2021, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 172, 3, new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 12 },
                    { 170, 3, new DateTime(2021, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, new DateTime(2022, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 169, 16, new DateTime(2021, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 7 },
                    { 168, 17, new DateTime(2021, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 13 },
                    { 167, 17, new DateTime(2021, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 12 },
                    { 166, 17, new DateTime(2021, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 11 },
                    { 165, 3, new DateTime(2021, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 17 },
                    { 164, 4, new DateTime(2021, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 9 },
                    { 163, 8, new DateTime(2021, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, new DateTime(2022, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 162, 12, new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 9 },
                    { 161, 18, new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 12 },
                    { 160, 4, new DateTime(2021, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 8 },
                    { 159, 6, new DateTime(2021, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), true, null, 6 },
                    { 158, 16, new DateTime(2021, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 11 },
                    { 171, 8, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 17 },
                    { 499, 16, new DateTime(2021, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, null, 9 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "UserBorrowedBook",
                keyColumn: "Id",
                keyValue: 499);
        }
    }
}

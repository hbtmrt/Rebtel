using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RebtelTest.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserBorrowedBook",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    IsCopy = table.Column<bool>(type: "bit", nullable: false),
                    BorrowedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpectedReturnDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBorrowedBook", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserBorrowedBook_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserBorrowedBook_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "My Book 1" },
                    { 18, "My Book 18" },
                    { 17, "My Book 17" },
                    { 16, "My Book 16" },
                    { 15, "My Book 15" },
                    { 14, "My Book 14" },
                    { 13, "My Book 13" },
                    { 12, "My Book 12" },
                    { 11, "My Book 11" },
                    { 19, "My Book 19" },
                    { 9, "My Book 9" },
                    { 8, "My Book 8" },
                    { 7, "My Book 7" },
                    { 6, "My Book 6" },
                    { 5, "My Book 5" },
                    { 4, "My Book 4" },
                    { 3, "My Book 3" },
                    { 2, "My Book 2" },
                    { 10, "My Book 10" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 12, "My Book 12" },
                    { 13, "My Book 13" },
                    { 17, "My Book 17" },
                    { 15, "My Book 15" },
                    { 16, "My Book 16" },
                    { 11, "My Book 11" },
                    { 14, "My Book 14" },
                    { 10, "My Book 10" },
                    { 5, "My Book 5" },
                    { 8, "My Book 8" },
                    { 7, "My Book 7" },
                    { 6, "My Book 6" },
                    { 4, "My Book 4" },
                    { 3, "My Book 3" },
                    { 2, "My Book 2" },
                    { 1, "My Book 1" },
                    { 18, "My Book 18" },
                    { 9, "My Book 9" },
                    { 19, "My Book 19" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserBorrowedBook_BookId",
                table: "UserBorrowedBook",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_UserBorrowedBook_UserId",
                table: "UserBorrowedBook",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserBorrowedBook");

            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}

﻿using Microsoft.EntityFrameworkCore;
using RebtelTest.Data.Models;
using System;
using System.Collections.Generic;

namespace RebtelTest.Data
{
    public sealed class Seeder
    {
        internal void Seed(ModelBuilder modelBuilder)
        {
            SeedBooks(modelBuilder);
            SeedUsers(modelBuilder);
            SeeUserBorrowedBooks(modelBuilder);
        }

        private void SeeUserBorrowedBooks(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserBorrowedBook>()
                .HasData(GenerateUserBorrowedBooks());
        }

        private List<UserBorrowedBook> GenerateUserBorrowedBooks()
        {
            List<UserBorrowedBook> items = new();
            Random random = new();

            for (int i = 1; i < 500; i++)
            {
                int bookId = random.Next(1, 20);
                int userId = random.Next(1, 20);

                items.Add(new UserBorrowedBook {
                    Id = i,
                    BookId = bookId,
                    UserId = userId,
                    IsCopy = userId % 2 == 0,
                    BorrowedDate = new DateTime(2021, random.Next(1, 13), random.Next(1, 28)),
                    ExpectedReturnDate = DateTime.Today.AddMonths(2),
                    ReturnDate = userId % 5 == 0 ? new DateTime(2022, random.Next(1, 3), random.Next(1, 27)) :null
                });
            }

            return items;
        }

        private void SeedUsers(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasData(GenerateUsers());
        }

        private List<User> GenerateUsers()
        {
            List<User> users = new List<User>();
            for (int i = 1; i < 20; i++)
            {
                users.Add(new User
                {
                    Id = i,
                    Name = $"My Book {i}"
                });
            }

            return users;
        }

        private void SeedBooks(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasData(GenerateBooks());
        }

        private List<Book> GenerateBooks()
        {
            List<Book> books = new List<Book>();
            for (int i = 1; i < 20; i++)
            {
                books.Add(new Book
                {
                        Id = i,
                        Name = $"My Book {i}"
                });
            }

            return books;
        }
    }
}
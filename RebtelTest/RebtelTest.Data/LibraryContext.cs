using Microsoft.EntityFrameworkCore;
using RebtelTest.Data.Models;

namespace RebtelTest.Data
{
    public class LibraryContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserBorrowedBook> UserBorrowedBooks { get; set; }

        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>()
                .HasMany(b => b.UserBorrowedBooks);

            modelBuilder.Entity<User>()
                .HasMany(b => b.UserBorrowedBooks);

            modelBuilder.Entity<UserBorrowedBook>();

            new Seeder().Seed(modelBuilder);
        }
    }
}
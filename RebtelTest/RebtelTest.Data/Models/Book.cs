using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RebtelTest.Data.Models
{
    [Table("Book")]
    public class Book
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int NoOfCopyBooks { get; set; }
        public int NoOfBorrowedBooks { get; set; }

        [NotMapped]
        public int NoOfAvailableBooks => NoOfCopyBooks - NoOfBorrowedBooks;

        public virtual ICollection<UserBorrowedBook> UserBorrowedBooks { get; set; }

        public Book()
        {
            UserBorrowedBooks = new List<UserBorrowedBook>();
        }
    }
}
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RebtelTest.Data.Models
{
    [Table("UserBorrowedBook")]
    public class UserBorrowedBook
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }
        public int BookId { get; set; }
        public bool IsCopy { get; set; }
        public DateTime BorrowedDate { get; set; }
        public DateTime ExpectedReturnDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
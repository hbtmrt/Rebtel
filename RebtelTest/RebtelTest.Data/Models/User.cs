using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RebtelTest.Data.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<UserBorrowedBook> UserBorrowedBooks { get; set; }

        public User()
        {
            UserBorrowedBooks = new List<UserBorrowedBook>();
        }
    }
}
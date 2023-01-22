using System;
using System.ComponentModel.DataAnnotations;

namespace bookApp.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string BookId { get; set; }
        [Required]
        public string BookName { get; set; }
        public string Author { get; set; }
        public bool BookStatus { get; set; }
    }
}

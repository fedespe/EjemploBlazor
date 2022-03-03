using System.ComponentModel.DataAnnotations;

namespace CRUDCodeFirstEF.Models
{
    public class Book
    {
        [Required]
        public int BookId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
    }
}

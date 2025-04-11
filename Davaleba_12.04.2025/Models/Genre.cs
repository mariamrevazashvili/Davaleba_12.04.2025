using System.ComponentModel.DataAnnotations;

namespace Davaleba_12._04._2025.Models
{
    public class Genre : Base
    {
        [Required(ErrorMessage = "Genre is required")]
        [MaxLength(20)]
        public string Janri { get; set; }
        public ICollection<Book> Books = new List<Book>();
    }
}

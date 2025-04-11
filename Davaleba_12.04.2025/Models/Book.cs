using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Davaleba_12._04._2025.Models
{
    public class Book : Base
    {
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "PublishedYear is required")]
        public int PublishedYear { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(1, 50, ErrorMessage = "Age must be between 1 and 50")]
        public int Price { get; set; }

        public int AuthorId { get; set; }

        [ForeignKey("AuthorId")]
        public Author Author { get; set; }

        public int GenreId { get; set; }
        [ForeignKey("GenreId")]
        public Genre Genre { get; set; }
    }
}

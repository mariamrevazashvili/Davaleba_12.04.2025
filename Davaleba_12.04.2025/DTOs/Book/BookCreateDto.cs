using Davaleba_12._04._2025.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Davaleba_12._04._2025.DTOs.Book
{
    public class BookCreateDto
    {
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "PublishedYear is required")]
        public int PublishedYear { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(1, 50, ErrorMessage = "Price must be between 1 and 50")]
        public int Price { get; set; }

        public int AuthorId { get; set; }
        public int GenreId { get; set; }
    }
}


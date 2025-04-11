using System.ComponentModel.DataAnnotations;

namespace Davaleba_12._04._2025.Models
{
    public class Author : Base
    {
        [Required(ErrorMessage = "Name is required")]
        [MaxLength(20)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Surname is required")]
        [MaxLength(50)]
        public string Surname { get; set; }
        public ICollection<Book> Books = new List<Book>();
    }
}

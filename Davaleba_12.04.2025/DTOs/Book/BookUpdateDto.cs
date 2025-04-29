using Davaleba_12._04._2025.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Davaleba_12._04._2025.DTOs.Book
{
    public class BookUpdateDto
    {
        [Key]
        public int Id { get; set; }
        public int Price { get; set; }
    }
}


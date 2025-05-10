using Davaleba_12._04._2025.DTOs.Book;
using Davaleba_12._04._2025.Models;

namespace Davaleba_12._04._2025.Mapper
{
    public static class BookMappingExtensions
    {
        public static Book ToEntity(this BookCreateDto dto)
        {
            return new Book
            {
                Title = dto.Title,
                PublishedYear = dto.PublishedYear,
                Price = dto.Price,
                AuthorId = dto.AuthorId,
                GenreId = dto.GenreId
            };
        }

        public static void UpdateDto(BookUpdateDto dto, Book book)
        {
            book.Price = dto.Price;
        }
    }
}

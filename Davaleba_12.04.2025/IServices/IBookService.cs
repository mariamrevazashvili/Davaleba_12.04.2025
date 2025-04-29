using Davaleba_12._04._2025.Models;
using Davaleba_12._04._2025.DTOs.Book;

namespace Davaleba_12._04._2025.IServices
{
    public interface IBookService
    {
        Task<IEnumerable<Book>> GetAllBooksUnderPriceAsync(int price);
        Task<int> CreatebookAsync(BookCreateDto dto);
        void UpdateBook(BookUpdateDto dto);
    }
}

using Davaleba_12._04._2025.Models;

namespace Davaleba_12._04._2025.IServices
{
    public interface IBookService
    {
        Task<IEnumerable<Book>> GetAllBooksUnderPriceAsync(int price);
    }
}

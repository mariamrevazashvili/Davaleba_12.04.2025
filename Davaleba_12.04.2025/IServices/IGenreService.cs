using Davaleba_12._04._2025.Models;

namespace Davaleba_12._04._2025.IServices
{
    public interface IGenreService
    {
        Task<List<Book>> GetBookByGenreAsync(string genre);
    }
}

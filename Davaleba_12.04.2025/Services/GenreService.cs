using Davaleba_12._04._2025.Database;
using Davaleba_12._04._2025.IServices;
using Davaleba_12._04._2025.Models;
using Microsoft.EntityFrameworkCore;

namespace Davaleba_12._04._2025.Services
{
    public class GenreService : IGenreService
    {
        private readonly AppDbContext _context;

        public GenreService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Book>> GetBookByGenreAsync(string genre)
        {
            return await _context.Books
                .Include(b => b.Genre)
                .Where(b => b.Genre.Janri == genre)
                .ToListAsync();
        }
    }
}

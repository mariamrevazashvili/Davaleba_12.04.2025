using Davaleba_12._04._2025.Database;
using Davaleba_12._04._2025.IServices;
using Davaleba_12._04._2025.Models;
using Microsoft.EntityFrameworkCore;

namespace Davaleba_12._04._2025.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly AppDbContext _context;

        public AuthorService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Book>> GetBookByAuthorNameAsync(string authorName)
        {
            return await _context.Books
                .Include(b => b.Author)
                .Where(b => b.Author.Name == authorName)
                .ToListAsync();
        }
    }
}

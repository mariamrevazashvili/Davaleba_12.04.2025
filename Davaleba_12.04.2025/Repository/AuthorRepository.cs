using Davaleba_12._04._2025.Database;
using Davaleba_12._04._2025.IRepository;
using Davaleba_12._04._2025.Models;

namespace Davaleba_12._04._2025.Repository
{
    public class AuthorRepository : GenericRepository<Author>, IAuthorRepository
    {
        public AuthorRepository(AppDbContext context) : base(context) { }

    }
}

using Davaleba_12._04._2025.Database;
using Davaleba_12._04._2025.IRepository;
using Davaleba_12._04._2025.Models;

namespace Davaleba_12._04._2025.Repository
{
    public class GenreRepository : GenericRepository<Genre>, IGenreRepository
    {
        public GenreRepository(AppDbContext context) : base(context) { }
    }
}

using Davaleba_12._04._2025.Database;
using Davaleba_12._04._2025.IRepository;
using Davaleba_12._04._2025.Models;
using System;

namespace Davaleba_12._04._2025.Repository
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        public BookRepository(AppDbContext context) : base(context) { }

    }
}

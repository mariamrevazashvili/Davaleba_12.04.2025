using Davaleba_12._04._2025.Models;
using Microsoft.EntityFrameworkCore;

namespace Davaleba_12._04._2025.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}

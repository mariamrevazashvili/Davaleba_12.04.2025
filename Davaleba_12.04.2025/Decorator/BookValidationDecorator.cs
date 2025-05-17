using Davaleba_12._04._2025.IRepository;
using Davaleba_12._04._2025.Models;
using Davaleba_12._04._2025.Repository;

namespace Davaleba_12._04._2025.Decorator
{
    public class BookValidationDecorator : IBookRepository
    {
        private readonly IBookRepository _book;

        public BookValidationDecorator(IBookRepository book)
        {
            _book = book;
        }

        public async Task AddAsync(Book entity)
        {
            if (entity.Title.Length <= 3)
            {
                Console.WriteLine("Book title must be more than 3 characters.");
                return;
            }

            await _book.AddAsync(entity);
        }

        public void Update(Book entity)
        {
            _book.Update(entity);
        }

        public void Delete(int id)
        {
            _book.Delete(id);
        }

        public async Task<Book> GetByIdAsync(int id)
        {
            return await _book.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Book>> GetAllAsync()
        {
            return await _book.GetAllAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _book.SaveChangesAsync();
        }
    }
}

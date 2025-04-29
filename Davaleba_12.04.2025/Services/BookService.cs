using Davaleba_12._04._2025.DTOs.Book;
using Davaleba_12._04._2025.IRepository;
using Davaleba_12._04._2025.IServices;
using Davaleba_12._04._2025.Mapper;
using Davaleba_12._04._2025.Models;

namespace Davaleba_12._04._2025.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<IEnumerable<Book>> GetAllBooksUnderPriceAsync(int price)
        {
            var books = await _bookRepository.GetAllAsync();
            return books.Where(p => p.Price < price);
        }

        public void UpdateBook(BookUpdateDto dto)
        {
            var book = _bookRepository.GetByIdAsync(dto.Id).Result;
            if (book != null)
            {
                BookMappingExtensions.UpdateDto(dto, book);
                _bookRepository.Update(book);
                _bookRepository.SaveChangesAsync();
            }
        }

        public async Task<int> CreatebookAsync(BookCreateDto dto)
        {
            var book = BookMappingExtensions.ToEntity(dto);

            await _bookRepository.AddAsync(book);
            return book.Id;
        }
    }
}

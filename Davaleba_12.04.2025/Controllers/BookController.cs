﻿using Davaleba_12._04._2025.IRepository;
using Davaleba_12._04._2025.IServices;
using Davaleba_12._04._2025.Models;
using Microsoft.AspNetCore.Mvc;

namespace Davaleba_12._04._2025.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;
        private readonly IBookRepository _bookRepository;

        public BooksController(IBookService bookService, IBookRepository bookRepository)
        {
            _bookService = bookService;
            _bookRepository = bookRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
        {
            return Ok(await _bookRepository.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBook(int id)
        {
            var book = await _bookRepository.GetByIdAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }

        [HttpPost]
        public async Task<ActionResult<Book>> PostBook(Book book)
        {
            await _bookRepository.AddAsync(book);
            return CreatedAtAction("GetBook", new { id = book.Id }, book);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutBook(int id, Book book)
        {
            if (id != book.Id)
            {
                return BadRequest();
            }

            _bookRepository.Update(book);
            await _bookRepository.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            _bookRepository.Delete(id);
            return NoContent();
        }

        [HttpGet("underprice/{price}")]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooksUnderPrice(int price)
        {
            var books = await _bookService.GetAllBooksUnderPriceAsync(price);
            return Ok(books);
        }
    }
}

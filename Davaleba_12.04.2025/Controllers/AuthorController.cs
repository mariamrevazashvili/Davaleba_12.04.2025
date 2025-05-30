﻿using Davaleba_12._04._2025.IRepository;
using Davaleba_12._04._2025.IServices;
using Davaleba_12._04._2025.Models;
using Microsoft.AspNetCore.Mvc;

namespace Davaleba_12._04._2025.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IAuthorService _authorService;

        public AuthorsController(IAuthorRepository authorRepository, IAuthorService authorService)
        {
            _authorRepository = authorRepository;
            _authorService = authorService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Author>>> GetAuthors()
        {
            return Ok(await _authorRepository.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Author>> GetAuthor(int id)
        {
            var author = await _authorRepository.GetByIdAsync(id);
            if (author == null)
            {
                return NotFound();
            }
            return Ok(author);
        }

        [HttpPost]
        public async Task<ActionResult<Author>> PostAuthor(Author author)
        {
            await _authorRepository.AddAsync(author);
            return CreatedAtAction("GetAuthor", new { id = author.Id }, author);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAuthor(int id, Author author)
        {
            if (id != author.Id)
            {
                return BadRequest();
            }

            _authorRepository.Update(author);
            await _authorRepository.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAuthor(int id)
        {
            _authorRepository.Delete(id);
            return NoContent();
        }

        [HttpGet("BookByAuthor")]
        public async Task<ActionResult<List<Book>>> GetBookByAuthor(string authorName)
        {
            var books = await _authorService.GetBookByAuthorNameAsync(authorName);

            if (books == null || books.Count == 0)
            {
                return NotFound($"No books found for author: {authorName}");
            }

            return Ok(books);
        }
    }
}

using Davaleba_12._04._2025.IRepository;
using Davaleba_12._04._2025.Models;
using Microsoft.AspNetCore.Mvc;

namespace Davaleba_12._04._2025.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private readonly IGenreRepository _genreRepository;

        public GenresController(IGenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Genre>>> GetGenres()
        {
            return Ok(await _genreRepository.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Genre>> GetGenre(int id)
        {
            var genre = await _genreRepository.GetByIdAsync(id);
            if (genre == null)
            {
                return NotFound();
            }
            return Ok(genre);
        }

        [HttpPost]
        public async Task<ActionResult<Genre>> PostGenre(Genre genre)
        {
            await _genreRepository.AddAsync(genre);
            return CreatedAtAction("GetGenre", new { id = genre.Id }, genre);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutGenre(int id, Genre genre)
        {
            if (id != genre.Id)
            {
                return BadRequest();
            }

            _genreRepository.Update(genre);
            await _genreRepository.SaveChangesAsync();
            return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteGenre(int id)
        {
            _genreRepository.Delete(id);
            return NoContent();
        }
    }
}

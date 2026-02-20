using MiApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiApi.Data;
using Microsoft.EntityFrameworkCore;
using MiApi.Models;
namespace MiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibrosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public LibrosController(AppDbContext context)
        {
            _context = context;
        }
        //get api/libros
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Libro>>> GetLibros()
        {
            return await _context.Libros.ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult<Libro>> PostLibro(Libro libro)
        {
            libro.id = 0;
            _context.Libros.Add(libro);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetLibros), new { id = libro.id }, libro);
        }
        // get api/libros/{id}
        [HttpGet("{int:id}")]
        public async Task<ActionResult<Libro>> GetLibroById(int id)
            {
            var libro = await _context.Libros.FindAsync(id);
            if (libro == null)
                return NotFound();
            return Ok(libro);
        }
        // put api/libros/{id}
        [HttpPut("{int:id}")]
        public async Task<IActionResult> PutLibro( int id, Libro libro)
        {
            if (id != libro.id)
                return BadRequest();
            _context.Entry(libro).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Libros.Any(e => e.id == id))
                    return NotFound();
                else
                    throw;
            }
            return NoContent();
        }
        // delete api/libros/{id}
        [HttpDelete("{int:id}")]
        public async Task<IActionResult> DeleteLibro(int id)
        {
            var libro = await _context.Libros.FindAsync(id);
            if (libro == null)
                return NotFound();
            _context.Libros.Remove(libro);
            await _context.SaveChangesAsync();
            return NoContent();
        }






        }
}

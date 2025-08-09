using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using _3DPrintStoreBackendAPI.Models;

namespace _3DPrintStoreBackendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrintablesController : ControllerBase
    {
        private readonly PrintableContext _context;

        public PrintablesController(PrintableContext context)
        {
            _context = context;
        }

        // GET: api/Printables
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Printable>>> GetPrintables()
        {
            return await _context.Printables.ToListAsync();
        }

        // GET: api/Printables/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Printable>> GetPrintable(int id)
        {
            var printable = await _context.Printables.FindAsync(id);

            if (printable == null)
            {
                return NotFound();
            }

            return printable;
        }

        // PUT: api/Printables/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPrintable(int id, Printable printable)
        {
            if (id != printable.Id)
            {
                return BadRequest();
            }

            _context.Entry(printable).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PrintableExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Printables
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Printable>> PostPrintable(Printable printable)
        {
            _context.Printables.Add(printable);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPrintable), new { id = printable.Id }, printable);
        }

        // DELETE: api/Printables/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePrintable(int id)
        {
            var printable = await _context.Printables.FindAsync(id);
            if (printable == null)
            {
                return NotFound();
            }

            _context.Printables.Remove(printable);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PrintableExists(int id)
        {
            return _context.Printables.Any(e => e.Id == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pfe.Models;

namespace pfe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecCaissesController : ControllerBase
    {
        private readonly GestContext _context;

        public RecCaissesController(GestContext context)
        {
            _context = context;
        }

        // GET: api/RecCaisses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RecCaisse>>> GetRecCaisses()
        {
            return await _context.RecCaisses.ToListAsync();
        }

        // GET: api/RecCaisses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RecCaisse>> GetRecCaisse(int id)
        {
            var recCaisse = await _context.RecCaisses.FindAsync(id);

            if (recCaisse == null)
            {
                return NotFound();
            }

            return recCaisse;
        }

        // PUT: api/RecCaisses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRecCaisse(int id, RecCaisse recCaisse)
        {
            if (id != recCaisse.DepCaiId)
            {
                return BadRequest();
            }

            _context.Entry(recCaisse).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RecCaisseExists(id))
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

        // POST: api/RecCaisses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RecCaisse>> PostRecCaisse(RecCaisse recCaisse)
        {
            _context.RecCaisses.Add(recCaisse);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRecCaisse", new { id = recCaisse.DepCaiId }, recCaisse);
        }

        // DELETE: api/RecCaisses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRecCaisse(int id)
        {
            var recCaisse = await _context.RecCaisses.FindAsync(id);
            if (recCaisse == null)
            {
                return NotFound();
            }

            _context.RecCaisses.Remove(recCaisse);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RecCaisseExists(int id)
        {
            return _context.RecCaisses.Any(e => e.DepCaiId  == id);
        }
    }
}

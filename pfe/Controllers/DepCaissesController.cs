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
    public class DepCaissesController : ControllerBase
    {
        private readonly GestContext _context;

        public DepCaissesController(GestContext context)
        {
            _context = context;
        }

        // GET: api/DepCaisses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DepCaisse>>> GetDepCaisses()
        {
            return await _context.DepCaisses.ToListAsync();
        }

        // GET: api/DepCaisses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DepCaisse>> GetDepCaisse(int id)
        {
            var depCaisse = await _context.DepCaisses.FindAsync(id);

            if (depCaisse == null)
            {
                return NotFound();
            }

            return depCaisse;
        }

        // PUT: api/DepCaisses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDepCaisse(int id, DepCaisse depCaisse)
        {
            if (id != depCaisse.DepCaiId)
            {
                return BadRequest();
            }

            _context.Entry(depCaisse).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DepCaisseExists(id))
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

        // POST: api/DepCaisses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DepCaisse>> PostDepCaisse(DepCaisse depCaisse)
        {
            _context.DepCaisses.Add(depCaisse);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDepCaisse", new { id = depCaisse.DepCaiId }, depCaisse);
        }

        // DELETE: api/DepCaisses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDepCaisse(int id)
        {
            var depCaisse = await _context.DepCaisses.FindAsync(id);
            if (depCaisse == null)
            {
                return NotFound();
            }

            _context.DepCaisses.Remove(depCaisse);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DepCaisseExists(int id)
        {
            return _context.DepCaisses.Any(e => e.DepCaiId == id);
        }
    }
}

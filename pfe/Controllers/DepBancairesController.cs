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
    public class DepBancairesController : ControllerBase
    {
        private readonly GestContext _context;

        public DepBancairesController(GestContext context)
        {
            _context = context;
        }

        // GET: api/DepBancaires
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DepBancaire>>> GetDepBancaires()
        {
            return await _context.DepBancaires.ToListAsync();
        }

        // GET: api/DepBancaires/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DepBancaire>> GetDepBancaire(int id)
        {
            var depBancaire = await _context.DepBancaires.FindAsync(id);

            if (depBancaire == null)
            {
                return NotFound();
            }

            return depBancaire;
        }

        // PUT: api/DepBancaires/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDepBancaire(int id, DepBancaire depBancaire)
        {
            if (id != depBancaire.DepBanId)
            {
                return BadRequest();
            }

            _context.Entry(depBancaire).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DepBancaireExists(id))
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

        // POST: api/DepBancaires
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DepBancaire>> PostDepBancaire(DepBancaire depBancaire)
        {
            _context.DepBancaires.Add(depBancaire);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDepBancaire", new { id = depBancaire.DepBanId }, depBancaire);
        }

        // DELETE: api/DepBancaires/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDepBancaire(int id)
        {
            var depBancaire = await _context.DepBancaires.FindAsync(id);
            if (depBancaire == null)
            {
                return NotFound();
            }

            _context.DepBancaires.Remove(depBancaire);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DepBancaireExists(int id)
        {
            return _context.DepBancaires.Any(e => e.DepBanId == id);
        }
    }
}

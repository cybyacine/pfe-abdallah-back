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
    public class RecBancairesController : ControllerBase
    {
        private readonly GestContext _context;

        public RecBancairesController(GestContext context)
        {
            _context = context;
        }

        // GET: api/RecBancaires
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RecBancaire>>> GetRecBancaires()
        {
            return await _context.RecBancaires.ToListAsync();
        }

        // GET: api/RecBancaires/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RecBancaire>> GetRecBancaire(int id)
        {
            var recBancaire = await _context.RecBancaires.FindAsync(id);

            if (recBancaire == null)
            {
                return NotFound();
            }

            return recBancaire;
        }

        // PUT: api/RecBancaires/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRecBancaire(int id, RecBancaire recBancaire)
        {
            if (id != recBancaire.DepBanId)
            {
                return BadRequest();
            }

            _context.Entry(recBancaire).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RecBancaireExists(id))
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

        // POST: api/RecBancaires
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RecBancaire>> PostRecBancaire(RecBancaire recBancaire)
        {
            _context.RecBancaires.Add(recBancaire);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRecBancaire", new { id = recBancaire.DepBanId }, recBancaire);
        }

        // DELETE: api/RecBancaires/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRecBancaire(int id)
        {
            var recBancaire = await _context.RecBancaires.FindAsync(id);
            if (recBancaire == null)
            {
                return NotFound();
            }

            _context.RecBancaires.Remove(recBancaire);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RecBancaireExists(int id)
        {
            return _context.RecBancaires.Any(e => e.DepBanId == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Assignment3.DBContext;
using Assignment3.Models;

namespace Assignment3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseHistoriesController : ControllerBase
    {
        private readonly WebDBContextClass _context;

        public PurchaseHistoriesController(WebDBContextClass context)
        {
            _context = context;
        }

        // GET: api/PurchaseHistories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PurchaseHistory>>> GetPurchaseHistory()
        {
            return await _context.PurchaseHistory.ToListAsync();
        }

        // GET: api/PurchaseHistories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PurchaseHistory>> GetPurchaseHistory(int id)
        {
            var purchaseHistory = await _context.PurchaseHistory.FindAsync(id);

            if (purchaseHistory == null)
            {
                return NotFound();
            }

            return purchaseHistory;
        }

        // PUT: api/PurchaseHistories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPurchaseHistory(int id, PurchaseHistory purchaseHistory)
        {
            if (id != purchaseHistory.id)
            {
                return BadRequest();
            }

            _context.Entry(purchaseHistory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PurchaseHistoryExists(id))
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

        // POST: api/PurchaseHistories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PurchaseHistory>> PostPurchaseHistory(PurchaseHistory purchaseHistory)
        {
            _context.PurchaseHistory.Add(purchaseHistory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPurchaseHistory", new { id = purchaseHistory.id }, purchaseHistory);
        }

        // DELETE: api/PurchaseHistories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePurchaseHistory(int id)
        {
            var purchaseHistory = await _context.PurchaseHistory.FindAsync(id);
            if (purchaseHistory == null)
            {
                return NotFound();
            }

            _context.PurchaseHistory.Remove(purchaseHistory);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PurchaseHistoryExists(int id)
        {
            return _context.PurchaseHistory.Any(e => e.id == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealEstateManagementAPI.Models;

namespace RealEstateManagementAPI.Controllers
{
    [Route("api/Deposits")]
    [ApiController]
    public class DepositsController : ControllerBase
    {
        private readonly RealEstateManagementContext _context;

        public DepositsController(RealEstateManagementContext context)
        {
            _context = context;
        }

        // GET: api/Deposits
        [HttpGet]
        public async Task<IEnumerable<Deposits>> GetDeposits()
        {
            // TODO: Create a business and repo layer w/ interfaces and move this logic in
            var depositData = await _context.Deposits.Select(deposit => new Deposits
            {
                DepositId = deposit.DepositId,
                MoveInDate = deposit.MoveInDate,
                Rent = deposit.Rent,
                Deposit = deposit.Deposit,
                Active = deposit.Active,
                Agent = deposit.Agent,
                Property = deposit.Property,
                TransactionStatus = deposit.TransactionStatus,
            }).ToListAsync();

            return depositData;
        }

        // GET: api/Deposits/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Deposits>> GetDeposits(int id)
        {
            var deposits = await _context.Deposits.FindAsync(id);

            if (deposits == null)
            {
                return NotFound();
            }

            return deposits;
        }

        // PUT: api/Deposits/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDeposits(int id, Deposits deposits)
        {
            if (id != deposits.DepositId)
            {
                return BadRequest();
            }

            _context.Entry(deposits).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DepositsExists(id))
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

        // POST: api/Deposits
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<Deposits> PostDeposits(Deposits deposits)
        {
            _context.Deposits.Add(deposits);
            await _context.SaveChangesAsync();

            return deposits;
        }

        // DELETE: api/Deposits/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDeposits(int id)
        {
            var deposits = await _context.Deposits.FindAsync(id);
            if (deposits == null)
            {
                return NotFound();
            }

            _context.Deposits.Remove(deposits);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DepositsExists(int id)
        {
            return _context.Deposits.Any(e => e.DepositId == id);
        }
    }
}

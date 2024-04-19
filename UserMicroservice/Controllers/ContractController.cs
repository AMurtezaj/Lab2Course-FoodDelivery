using Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repositories;

namespace UserMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContractsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ContractsController(AppDbContext context)
        {
            _context = context;
        }

        // Endpoint për krijimin e kontratave
        [HttpPost]
        public async Task<ActionResult<Contract>> PostContract(Contract contract)
        {
            _context.Contracts.Add(contract);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetContract", new { id = contract.Id }, contract);
        }

        // Endpoint për marrjen e të gjitha kontratave
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Contract>>> GetContracts()
        {
            return await _context.Contracts.ToListAsync();
        }

        // Endpoint për marrjen e kontratave me datën e fillimit të sotme
        [HttpGet("today")]
        public async Task<ActionResult<IEnumerable<Contract>>> GetContractsToday()
        {
            DateTime today = DateTime.Today;
            return await _context.Contracts.Where(c => c.StartDate.Date == today).ToListAsync();
        }

        // Endpoint për marrjen e kontratave të një punonjësi të caktuar
        [HttpGet("employee/{employeeId}")]
        public async Task<ActionResult<IEnumerable<Contract>>> GetEmployeeContracts(int employeeId)
        {
            return await _context.Contracts.Where(c => c.EmployeeId == employeeId).ToListAsync();
        }

        // Endpoint për perditesimin e kontratave
        [HttpPut("{id}")]
        public async Task<IActionResult> PutContract(int id, Contract contract)
        {
            if (id != contract.Id)
            {
                return BadRequest();
            }

            _context.Entry(contract).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContractExists(id))
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

        private bool ContractExists(int id)
        {
            return _context.Contracts.Any(e => e.Id == id);
        }
    }

}

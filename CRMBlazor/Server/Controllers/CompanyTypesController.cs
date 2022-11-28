using CRMBlazor.Server.Data.CRMBlazorDb;
using CRMBlazor.Shared.Data.CRMBlazorDb.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRMBlazor.Server.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class CompanyTypesController : ControllerBase
    {
        private readonly CRMBlazorDbContext _context;

        public CompanyTypesController(CRMBlazorDbContext context)
        {
            _context = context;
        }

        // GET: api/CompanyTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CompanyType>>> GetCompanyTypes()
        {
            if (_context.CompanyTypes == null)
            {
                return NotFound();
            }
            return await _context.CompanyTypes.ToListAsync();
        }

        // GET: api/CompanyTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CompanyType>> GetCompanyType(int id)
        {
            if (_context.CompanyTypes == null)
            {
                return NotFound();
            }
            var companyType = await _context.CompanyTypes.FindAsync(id);

            if (companyType == null)
            {
                return NotFound();
            }

            return companyType;
        }

        // PUT: api/CompanyTypes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCompanyType(int id, CompanyType companyType)
        {
            if (id != companyType.Id)
            {
                return BadRequest();
            }

            _context.Entry(companyType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CompanyTypeExists(id))
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

        // POST: api/CompanyTypes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CompanyType>> PostCompanyType(CompanyType companyType)
        {
            if (_context.CompanyTypes == null)
            {
                return Problem("Entity set 'CRMBlazorDbContext.CompanyTypes'  is null.");
            }
            _context.CompanyTypes.Add(companyType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCompanyType", new { id = companyType.Id }, companyType);
        }

        // DELETE: api/CompanyTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompanyType(int id)
        {
            if (_context.CompanyTypes == null)
            {
                return NotFound();
            }
            var companyType = await _context.CompanyTypes.FindAsync(id);
            if (companyType == null)
            {
                return NotFound();
            }

            _context.CompanyTypes.Remove(companyType);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CompanyTypeExists(int id)
        {
            return (_context.CompanyTypes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

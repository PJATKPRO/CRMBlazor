using CRMBlazor.Server.Data.CRMBlazorDb;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRMBlazor.Server.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    internal sealed class ClientsController : ControllerBase
    {
        private readonly CRMBlazorDbContext _context;

        public ClientsController(CRMBlazorDbContext context)
        {
            _context = context;
        }

        // GET: api/Clients
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CRMBlazor.Shared.Data.CRMBlazorDb.Models.Client>>> GetClient()
        {
            if (_context.Client == null)
            {
                return NotFound();
            }
            return await _context.Client.ToListAsync();
        }

        // GET: api/Clients/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CRMBlazor.Shared.Data.CRMBlazorDb.Models.Client>> GetClient(int id)
        {
            if (_context.Client == null)
            {
                return NotFound();
            }
            var client = await _context.Client.FindAsync(id);

            if (client == null)
            {
                return NotFound();
            }

            return client;
        }

        // PUT: api/Clients/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClient(int id, CRMBlazor.Shared.Data.CRMBlazorDb.Models.Client client)
        {
            if (id != client.Id)
            {
                return BadRequest();
            }

            _context.Entry(client).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClientExists(id))
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

        // POST: api/Clients
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CRMBlazor.Shared.Data.CRMBlazorDb.Models.Client>> PostClient(CRMBlazor.Shared.Data.CRMBlazorDb.Models.Client client)
        {
            if (_context.Client == null)
            {
                return Problem("Entity set 'CRMBlazorDbContext.Client'  is null.");
            }
            _context.Client.Add(client);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetClient", new { id = client.Id }, client);
        }

        // DELETE: api/Clients/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClient(int id)
        {
            if (_context.Client == null)
            {
                return NotFound();
            }
            var client = await _context.Client.FindAsync(id);
            if (client == null)
            {
                return NotFound();
            }

            _context.Client.Remove(client);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ClientExists(int id)
        {
            return (_context.Client?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

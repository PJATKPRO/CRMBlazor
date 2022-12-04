﻿using CRMBlazor.Server.Data.CRMBlazorDb;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRMBlazor.Server.Controllers
{
    [Route("api/Client")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly CRMBlazorDbContext _context;

        public ClientsController(CRMBlazorDbContext context)
        {
            _context = context;
        }

        // GET: api/Clients
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Shared.Data.CRMBlazorDb.Models.Client>>> GetClients()
        {
            if (_context.Clients == null)
            {
                return NotFound();
            }
            //_context.Clients.RemoveRange(_context.Clients);
            //_context.Clients.Add(new Shared.Data.CRMBlazorDb.Models.Client() { Name = "mat1", Surname = "kal1", Email = "wp2@wp.pl", PeselOrNip = "11111111111" });
            //await _context.SaveChangesAsync();
            var c = await _context.Clients.ToListAsync();
            return c;
        }

        // GET: api/Clients/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Shared.Data.CRMBlazorDb.Models.Client>> GetClient(int id)
        {
            if (_context.Clients == null)
            {
                return NotFound();
            }
            var client = await _context.Clients.FindAsync(id);

            if (client == null)
            {
                return NotFound();
            }

            return client;
        }

        // PUT: api/Clients/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClient(int id, Shared.Data.CRMBlazorDb.Models.Client client)
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
        public async Task<ActionResult<Shared.Data.CRMBlazorDb.Models.Client>> PostClient(Shared.Data.CRMBlazorDb.Models.Client client)
        {
            if (_context.Clients == null)
            {
                return Problem("Entity set 'CRMBlazorDbContext.Clients'  is null.");
            }
            _context.Clients.Add(client);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetClient", new { id = client.Id }, client);
        }

        // DELETE: api/Clients/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClient(int id)
        {
            if (_context.Clients == null)
            {
                return NotFound();
            }
            var client = await _context.Clients.FindAsync(id);
            if (client == null)
            {
                return NotFound();
            }

            _context.Clients.Remove(client);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ClientExists(int id)
        {
            return (_context.Clients?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

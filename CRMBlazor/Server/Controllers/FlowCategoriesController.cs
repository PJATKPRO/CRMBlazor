using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CRMBlazor.Server.Data.CRMBlazorDb;
using CRMBlazor.Shared.Data.CRMBlazorDb.Models;

namespace CRMBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlowCategoriesController : ControllerBase
    {
        private readonly CRMBlazorDbContext _context;

        public FlowCategoriesController(CRMBlazorDbContext context)
        {
            _context = context;
        }

        // GET: api/FlowCategories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FlowCategory>>> GetFlowCategory()
        {
          if (_context.FlowCategory == null)
          {
              return NotFound();
          }
            return await _context.FlowCategory.ToListAsync();
        }

        // GET: api/FlowCategories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FlowCategory>> GetFlowCategory(int id)
        {
          if (_context.FlowCategory == null)
          {
              return NotFound();
          }
            var flowCategory = await _context.FlowCategory.FindAsync(id);

            if (flowCategory == null)
            {
                return NotFound();
            }

            return flowCategory;
        }

        // PUT: api/FlowCategories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFlowCategory(int id, FlowCategory flowCategory)
        {
            if (id != flowCategory.Id)
            {
                return BadRequest();
            }

            _context.Entry(flowCategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FlowCategoryExists(id))
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

        // POST: api/FlowCategories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FlowCategory>> PostFlowCategory(FlowCategory flowCategory)
        {
          if (_context.FlowCategory == null)
          {
              return Problem("Entity set 'CRMBlazorDbContext.FlowCategory'  is null.");
          }
            _context.FlowCategory.Add(flowCategory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFlowCategory", new { id = flowCategory.Id }, flowCategory);
        }

        // DELETE: api/FlowCategories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFlowCategory(int id)
        {
            if (_context.FlowCategory == null)
            {
                return NotFound();
            }
            var flowCategory = await _context.FlowCategory.FindAsync(id);
            if (flowCategory == null)
            {
                return NotFound();
            }

            _context.FlowCategory.Remove(flowCategory);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FlowCategoryExists(int id)
        {
            return (_context.FlowCategory?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

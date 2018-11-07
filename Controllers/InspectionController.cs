using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ASPNetCoreIdentityDemo.Data;
using ASPNetCoreIdentityDemo.Models;
using Microsoft.AspNetCore.Cors;

namespace ASPNetCoreIdentityDemo.Controllers
{
    [EnableCors("CORSPolicy")]
    [Produces("application/json")]
    [Route("api/Inspection")]
    public class InspectionController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InspectionController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Inspection
        [HttpGet]
        public IEnumerable<Inspection> GetInspections()
        {
            return _context.Inspections.OrderByDescending(c => c.InspectionId); ;
        }

        // GET: api/Inspection/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetInspection([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var inspection = await _context.Inspections.SingleOrDefaultAsync(m => m.InspectionId == id);

            if (inspection == null)
            {
                return NotFound();
            }

            return Ok(inspection);
        }

        // PUT: api/Inspection/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInspection([FromRoute] int id, [FromBody] Inspection inspection)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != inspection.InspectionId)
            {
                return BadRequest();
            }

            _context.Entry(inspection).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InspectionExists(id))
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

        // POST: api/Inspection
        [HttpPost]
        public async Task<IActionResult> PostInspection([FromBody] Inspection inspection)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Inspections.Add(inspection);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInspection", new { id = inspection.InspectionId }, inspection);
        }

        // DELETE: api/Inspection/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInspection([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var inspection = await _context.Inspections.SingleOrDefaultAsync(m => m.InspectionId == id);
            if (inspection == null)
            {
                return NotFound();
            }

            _context.Inspections.Remove(inspection);
            await _context.SaveChangesAsync();

            return Ok(inspection);
        }

        private bool InspectionExists(int id)
        {
            return _context.Inspections.Any(e => e.InspectionId == id);
        }
    }
}
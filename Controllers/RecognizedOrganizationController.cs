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
    [Route("api/RecognizedOrganization")]
    public class RecognizedOrganizationController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RecognizedOrganizationController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/RecognizedOrganization
        [HttpGet]
        public IEnumerable<RecognizedOrganization> GetRecognizedOrganizations()
        {
            return _context.RecognizedOrganizations;
        }

        // GET: api/RecognizedOrganization/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRecognizedOrganization([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var recognizedOrganization = await _context.RecognizedOrganizations.SingleOrDefaultAsync(m => m.RecognizedOrganizationId == id);

            if (recognizedOrganization == null)
            {
                return NotFound();
            }

            return Ok(recognizedOrganization);
        }

        // PUT: api/RecognizedOrganization/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRecognizedOrganization([FromRoute] int id, [FromBody] RecognizedOrganization recognizedOrganization)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != recognizedOrganization.RecognizedOrganizationId)
            {
                return BadRequest();
            }

            _context.Entry(recognizedOrganization).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RecognizedOrganizationExists(id))
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

        // POST: api/RecognizedOrganization
        [HttpPost]
        public async Task<IActionResult> PostRecognizedOrganization([FromBody] RecognizedOrganization recognizedOrganization)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.RecognizedOrganizations.Add(recognizedOrganization);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRecognizedOrganization", new { id = recognizedOrganization.RecognizedOrganizationId }, recognizedOrganization);
        }

        // DELETE: api/RecognizedOrganization/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRecognizedOrganization([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var recognizedOrganization = await _context.RecognizedOrganizations.SingleOrDefaultAsync(m => m.RecognizedOrganizationId == id);
            if (recognizedOrganization == null)
            {
                return NotFound();
            }

            _context.RecognizedOrganizations.Remove(recognizedOrganization);
            await _context.SaveChangesAsync();

            return Ok(recognizedOrganization);
        }

        private bool RecognizedOrganizationExists(int id)
        {
            return _context.RecognizedOrganizations.Any(e => e.RecognizedOrganizationId == id);
        }
    }
}
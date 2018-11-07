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
    [Route("api/Accident")]
    public class AccidentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccidentController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Accident
        [HttpGet]
        public IEnumerable<Accident> GetAccidents()
        {
            return _context.Accidents;
        }

        // GET: api/Accident/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAccident([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var accident = await _context.Accidents.SingleOrDefaultAsync(m => m.AccidentId == id);

            if (accident == null)
            {
                return NotFound();
            }

            return Ok(accident);
        }

        // PUT: api/Accident/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAccident([FromRoute] int id, [FromBody] Accident accident)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != accident.AccidentId)
            {
                return BadRequest();
            }

            _context.Entry(accident).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AccidentExists(id))
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

        // POST: api/Accident
        [HttpPost]
        public async Task<IActionResult> PostAccident([FromBody] Accident accident)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Accidents.Add(accident);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAccident", new { id = accident.AccidentId }, accident);
        }

        // DELETE: api/Accident/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAccident([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var accident = await _context.Accidents.SingleOrDefaultAsync(m => m.AccidentId == id);
            if (accident == null)
            {
                return NotFound();
            }

            _context.Accidents.Remove(accident);
            await _context.SaveChangesAsync();

            return Ok(accident);
        }

        private bool AccidentExists(int id)
        {
            return _context.Accidents.Any(e => e.AccidentId == id);
        }
    }
}
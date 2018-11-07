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
    [Route("api/Flag")]
    public class FlagController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FlagController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Flag
        [HttpGet]
        public IEnumerable<Flag> GetFlags()
        {
            return _context.Flags.OrderBy(x=>x.FlagId);
        }

        // GET: api/Flag/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFlag([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var flag = await _context.Flags.SingleOrDefaultAsync(m => m.FlagId == id);

            if (flag == null)
            {
                return NotFound();
            }

            return Ok(flag);
        }

        // PUT: api/Flag/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFlag([FromRoute] int id, [FromBody] Flag flag)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != flag.FlagId)
            {
                return BadRequest();
            }

            _context.Entry(flag).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FlagExists(id))
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

        // POST: api/Flag
        [HttpPost]
        public async Task<IActionResult> PostFlag([FromBody] Flag flag)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Flags.Add(flag);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFlag", new { id = flag.FlagId }, flag);
        }

        // DELETE: api/Flag/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFlag([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var flag = await _context.Flags.SingleOrDefaultAsync(m => m.FlagId == id);
            if (flag == null)
            {
                return NotFound();
            }

            _context.Flags.Remove(flag);
            await _context.SaveChangesAsync();

            return Ok(flag);
        }

        private bool FlagExists(int id)
        {
            return _context.Flags.Any(e => e.FlagId == id);
        }
    }
}
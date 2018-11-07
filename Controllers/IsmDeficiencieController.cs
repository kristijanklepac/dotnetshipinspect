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
    [Route("api/IsmDeficiencie")]
    public class IsmDeficiencieController : Controller
    {
        private readonly ApplicationDbContext _context;

        public IsmDeficiencieController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/IsmDeficiencie
        [HttpGet]
        public IEnumerable<IsmDeficiency> GetIsmDeficiencies()
        {
            return _context.IsmDeficiencies;
        }

        // GET: api/IsmDeficiencie/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetIsmDeficiency([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var ismDeficiency = await _context.IsmDeficiencies.SingleOrDefaultAsync(m => m.IsmDeficiencyId == id);

            if (ismDeficiency == null)
            {
                return NotFound();
            }

            return Ok(ismDeficiency);
        }

        // PUT: api/IsmDeficiencie/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIsmDeficiency([FromRoute] int id, [FromBody] IsmDeficiency ismDeficiency)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != ismDeficiency.IsmDeficiencyId)
            {
                return BadRequest();
            }

            _context.Entry(ismDeficiency).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IsmDeficiencyExists(id))
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

        // POST: api/IsmDeficiencie
        [HttpPost]
        public async Task<IActionResult> PostIsmDeficiency([FromBody] IsmDeficiency ismDeficiency)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.IsmDeficiencies.Add(ismDeficiency);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetIsmDeficiency", new { id = ismDeficiency.IsmDeficiencyId }, ismDeficiency);
        }

        // DELETE: api/IsmDeficiencie/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIsmDeficiency([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var ismDeficiency = await _context.IsmDeficiencies.SingleOrDefaultAsync(m => m.IsmDeficiencyId == id);
            if (ismDeficiency == null)
            {
                return NotFound();
            }

            _context.IsmDeficiencies.Remove(ismDeficiency);
            await _context.SaveChangesAsync();

            return Ok(ismDeficiency);
        }

        private bool IsmDeficiencyExists(int id)
        {
            return _context.IsmDeficiencies.Any(e => e.IsmDeficiencyId == id);
        }
    }
}
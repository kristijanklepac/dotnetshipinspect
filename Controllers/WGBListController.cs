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
    [Route("api/WGBList")]
    public class WGBListController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WGBListController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/WGBList
        [HttpGet]
        public IEnumerable<WGBList> GetWgbLists()
        {
            return _context.WgbLists;
        }

        // GET: api/WGBList/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetWGBList([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var wGBList = await _context.WgbLists.SingleOrDefaultAsync(m => m.WgbListId == id);

            if (wGBList == null)
            {
                return NotFound();
            }

            return Ok(wGBList);
        }

        // PUT: api/WGBList/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWGBList([FromRoute] int id, [FromBody] WGBList wGBList)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != wGBList.WgbListId)
            {
                return BadRequest();
            }

            _context.Entry(wGBList).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WGBListExists(id))
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

        // POST: api/WGBList
        [HttpPost]
        public async Task<IActionResult> PostWGBList([FromBody] WGBList wGBList)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.WgbLists.Add(wGBList);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWGBList", new { id = wGBList.WgbListId }, wGBList);
        }

        // DELETE: api/WGBList/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWGBList([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var wGBList = await _context.WgbLists.SingleOrDefaultAsync(m => m.WgbListId == id);
            if (wGBList == null)
            {
                return NotFound();
            }

            _context.WgbLists.Remove(wGBList);
            await _context.SaveChangesAsync();

            return Ok(wGBList);
        }

        private bool WGBListExists(int id)
        {
            return _context.WgbLists.Any(e => e.WgbListId == id);
        }
    }
}
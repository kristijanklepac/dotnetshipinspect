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
    [Route("api/TokyoWgbList")]
    public class TokyoWgbListController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TokyoWgbListController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/TokyoWgbList
        [HttpGet]
        public IEnumerable<TokyoWgbList> GetTokyoWgbLists()
        {
            return _context.TokyoWgbLists;
        }

        // GET: api/TokyoWgbList/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTokyoWgbList([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tokyoWgbList = await _context.TokyoWgbLists.SingleOrDefaultAsync(m => m.TokyoWgbListId == id);

            if (tokyoWgbList == null)
            {
                return NotFound();
            }

            return Ok(tokyoWgbList);
        }

        // PUT: api/TokyoWgbList/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTokyoWgbList([FromRoute] int id, [FromBody] TokyoWgbList tokyoWgbList)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tokyoWgbList.TokyoWgbListId)
            {
                return BadRequest();
            }

            _context.Entry(tokyoWgbList).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TokyoWgbListExists(id))
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

        // POST: api/TokyoWgbList
        [HttpPost]
        public async Task<IActionResult> PostTokyoWgbList([FromBody] TokyoWgbList tokyoWgbList)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.TokyoWgbLists.Add(tokyoWgbList);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTokyoWgbList", new { id = tokyoWgbList.TokyoWgbListId }, tokyoWgbList);
        }

        // DELETE: api/TokyoWgbList/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTokyoWgbList([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tokyoWgbList = await _context.TokyoWgbLists.SingleOrDefaultAsync(m => m.TokyoWgbListId == id);
            if (tokyoWgbList == null)
            {
                return NotFound();
            }

            _context.TokyoWgbLists.Remove(tokyoWgbList);
            await _context.SaveChangesAsync();

            return Ok(tokyoWgbList);
        }

        private bool TokyoWgbListExists(int id)
        {
            return _context.TokyoWgbLists.Any(e => e.TokyoWgbListId == id);
        }
    }
}
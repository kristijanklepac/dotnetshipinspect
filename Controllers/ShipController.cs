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
    [Route("api/Ship")]
    public class ShipController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ShipController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Ship
        [HttpGet]
        public IEnumerable<Ship> GetShips()
        {
            return _context.Ships;
        }

        // GET: api/Ship/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetShip([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var ship = await _context.Ships.SingleOrDefaultAsync(m => m.ShipId == id);

            if (ship == null)
            {
                return NotFound();
            }

            return Ok(ship);
        }

        // PUT: api/Ship/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutShip([FromRoute] int id, [FromBody] Ship ship)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != ship.ShipId)
            {
                return BadRequest();
            }

            _context.Entry(ship).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShipExists(id))
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

        // POST: api/Ship
        [HttpPost]
        public async Task<IActionResult> PostShip([FromBody] Ship ship)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Ships.Add(ship);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetShip", new { id = ship.ShipId }, ship);
        }

        // DELETE: api/Ship/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteShip([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var ship = await _context.Ships.SingleOrDefaultAsync(m => m.ShipId == id);
            if (ship == null)
            {
                return NotFound();
            }

            _context.Ships.Remove(ship);
            await _context.SaveChangesAsync();

            return Ok(ship);
        }

        private bool ShipExists(int id)
        {
            return _context.Ships.Any(e => e.ShipId == id);
        }
    }
}
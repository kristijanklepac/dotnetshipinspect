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
    [Route("api/ShipType")]
    public class ShipTypeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ShipTypeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ShipType
        [HttpGet]
        public IEnumerable<ShipType> GetShipTypes()
        {
            return _context.ShipTypes;
        }

        // GET: api/ShipType/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetShipType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var shipType = await _context.ShipTypes.SingleOrDefaultAsync(m => m.ShipTypeId == id);

            if (shipType == null)
            {
                return NotFound();
            }

            return Ok(shipType);
        }

        // PUT: api/ShipType/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutShipType([FromRoute] int id, [FromBody] ShipType shipType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != shipType.ShipTypeId)
            {
                return BadRequest();
            }

            _context.Entry(shipType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShipTypeExists(id))
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

        // POST: api/ShipType
        [HttpPost]
        public async Task<IActionResult> PostShipType([FromBody] ShipType shipType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.ShipTypes.Add(shipType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetShipType", new { id = shipType.ShipTypeId }, shipType);
        }

        // DELETE: api/ShipType/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteShipType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var shipType = await _context.ShipTypes.SingleOrDefaultAsync(m => m.ShipTypeId == id);
            if (shipType == null)
            {
                return NotFound();
            }

            _context.ShipTypes.Remove(shipType);
            await _context.SaveChangesAsync();

            return Ok(shipType);
        }

        private bool ShipTypeExists(int id)
        {
            return _context.ShipTypes.Any(e => e.ShipTypeId == id);
        }
    }
}
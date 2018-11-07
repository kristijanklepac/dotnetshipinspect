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
    [Route("api/RcaCode")]
    public class RcaCodeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RcaCodeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/RcaCode
        [HttpGet]
        public IEnumerable<RcaCode> GetRcaCodes()
        {
            return _context.RcaCodes;
        }

        // GET: api/

        [HttpGet("rca-mr")]
        public IEnumerable<RcaCode> GetRcaCodesMR()
        {
            return _context.RcaCodes.Where(rca=>rca.RelatedRootCodeId == "Monitoring Related");
        }

        [HttpGet("rca-pr")]
        public IEnumerable<RcaCode> GetRcaCodesPR()
        {
            return _context.RcaCodes.Where(rca => rca.RelatedRootCodeId == "People Related");
        }

        [HttpGet("rca-rr")]
        public IEnumerable<RcaCode> GetRcaCodesRR()
        {
            return _context.RcaCodes.Where(rca => rca.RelatedRootCodeId == "Resources Related");
        }

        // GET: api/RcaCode/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRcaCode([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var rcaCode = await _context.RcaCodes.SingleOrDefaultAsync(m => m.RcaCodeId == id);

            if (rcaCode == null)
            {
                return NotFound();
            }

            return Ok(rcaCode);
        }

        // PUT: api/RcaCode/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRcaCode([FromRoute] int id, [FromBody] RcaCode rcaCode)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != rcaCode.RcaCodeId)
            {
                return BadRequest();
            }

            _context.Entry(rcaCode).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RcaCodeExists(id))
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

        // POST: api/RcaCode
        [HttpPost]
        public async Task<IActionResult> PostRcaCode([FromBody] RcaCode rcaCode)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.RcaCodes.Add(rcaCode);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRcaCode", new { id = rcaCode.RcaCodeId }, rcaCode);
        }

        // DELETE: api/RcaCode/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRcaCode([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var rcaCode = await _context.RcaCodes.SingleOrDefaultAsync(m => m.RcaCodeId == id);
            if (rcaCode == null)
            {
                return NotFound();
            }

            _context.RcaCodes.Remove(rcaCode);
            await _context.SaveChangesAsync();

            return Ok(rcaCode);
        }

        private bool RcaCodeExists(int id)
        {
            return _context.RcaCodes.Any(e => e.RcaCodeId == id);
        }
    }
}
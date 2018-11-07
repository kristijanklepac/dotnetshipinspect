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
    [Route("api/ActionCode")]
    public class ActionCodeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ActionCodeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ActionCode
        [HttpGet]
        public IEnumerable<ActionCode> GetActions()
        {
            return _context.Actions;
        }

        [HttpGet("action-PSC")]
        public IEnumerable<ActionCode> GetActionsPSC()
        {
            return _context.Actions.Where(act => act.RelatedRootCodeId == "PSC");
        }

        [HttpGet("action-USCG")]
        public IEnumerable<ActionCode> GetActionsUSCG()
        {
            return _context.Actions.Where(act => act.RelatedRootCodeId == "USCG");
        }

        [HttpGet("action-TOKYO")]
        public IEnumerable<ActionCode> GetActionsTOKYO()
        {
            return _context.Actions.Where(act => act.RelatedRootCodeId == "TOKYO");
        }

        // GET: api/ActionCode/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetActionCode([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var actionCode = await _context.Actions.SingleOrDefaultAsync(m => m.ActionCodeId == id);

            if (actionCode == null)
            {
                return NotFound();
            }

            return Ok(actionCode);
        }

        // PUT: api/ActionCode/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutActionCode([FromRoute] int id, [FromBody] ActionCode actionCode)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != actionCode.ActionCodeId)
            {
                return BadRequest();
            }

            _context.Entry(actionCode).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ActionCodeExists(id))
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

        // POST: api/ActionCode
        [HttpPost]
        public async Task<IActionResult> PostActionCode([FromBody] ActionCode actionCode)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Actions.Add(actionCode);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetActionCode", new { id = actionCode.ActionCodeId }, actionCode);
        }

        // DELETE: api/ActionCode/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteActionCode([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var actionCode = await _context.Actions.SingleOrDefaultAsync(m => m.ActionCodeId == id);
            if (actionCode == null)
            {
                return NotFound();
            }

            _context.Actions.Remove(actionCode);
            await _context.SaveChangesAsync();

            return Ok(actionCode);
        }

        private bool ActionCodeExists(int id)
        {
            return _context.Actions.Any(e => e.ActionCodeId == id);
        }
    }
}
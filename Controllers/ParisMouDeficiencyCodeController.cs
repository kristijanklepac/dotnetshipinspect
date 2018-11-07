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
    [Route("api/ParisMouDeficiencyCode")]
    public class ParisMouDeficiencyCodeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ParisMouDeficiencyCodeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ParisMouDeficiencyCode
        [HttpGet]
        public IEnumerable<ParisMouDeficiencyCode> GetParisMouDeficiencyCodes()
        {
            return _context.ParisMouDeficiencyCodes;
        }

        // GET: api/ParisMouDeficiencyCode
        
        [HttpGet("thetis01-011")]
        public IEnumerable<ParisMouDeficiencyCode> GetParisMouDeficiencyCodes01011()
        {
            return _context.ParisMouDeficiencyCodes.Where(tc=>tc.ThetisGroup == "01 Certificates & Documentation").Where(tc=>tc.ThetisSubGroup == "011 - Certificates & Documentation - Ship Certificate");
        }

        [HttpGet("thetis01-012")]
        public IEnumerable<ParisMouDeficiencyCode> GetParisMouDeficiencyCodes01012()
        {
            return _context.ParisMouDeficiencyCodes.Where(tc => tc.ThetisGroup == "01 Certificates & Documentation").Where(tc => tc.ThetisSubGroup == "012 - Certificates & Documentation - Crew Certificate");
        }

        [HttpGet("thetis01-013")]
        public IEnumerable<ParisMouDeficiencyCode> GetParisMouDeficiencyCodes01013()
        {
            return _context.ParisMouDeficiencyCodes.Where(tc => tc.ThetisGroup == "01 Certificates & Documentation").Where(tc => tc.ThetisSubGroup == "013 - Certificates and Documentation – Document");
        }

        [HttpGet("thetis02-020")]
        public IEnumerable<ParisMouDeficiencyCode> GetParisMouDeficiencyCodes02020()
        {
            return _context.ParisMouDeficiencyCodes.Where(tc => tc.ThetisGroup == "02 - Structural condition").Where(tc => tc.ThetisSubGroup == "020");
        }

        [HttpGet("thetis03-030")]
        public IEnumerable<ParisMouDeficiencyCode> GetParisMouDeficiencyCodes03030()
        {
            return _context.ParisMouDeficiencyCodes.Where(tc => tc.ThetisGroup == "03 - Water/Weathertight condition").Where(tc => tc.ThetisSubGroup == "030");
        }

        [HttpGet("thetis04-040")]
        public IEnumerable<ParisMouDeficiencyCode> GetParisMouDeficiencyCodes04040()
        {
            return _context.ParisMouDeficiencyCodes.Where(tc => tc.ThetisGroup == "04 - Emergency Systems").Where(tc => tc.ThetisSubGroup == "040");
        }

        [HttpGet("thetis05-050")]
        public IEnumerable<ParisMouDeficiencyCode> GetParisMouDeficiencyCodes05050()
        {
            return _context.ParisMouDeficiencyCodes.Where(tc => tc.ThetisGroup == "05 - Radio communication").Where(tc => tc.ThetisSubGroup == "050");
        }

        [HttpGet("thetis06-060")]
        public IEnumerable<ParisMouDeficiencyCode> GetParisMouDeficiencyCodes06060()
        {
            return _context.ParisMouDeficiencyCodes.Where(tc => tc.ThetisGroup == "06 - Cargo operations including equipment").Where(tc => tc.ThetisSubGroup == "060");
        }

        [HttpGet("thetis07-070")]
        public IEnumerable<ParisMouDeficiencyCode> GetParisMouDeficiencyCodes07070()
        {
            return _context.ParisMouDeficiencyCodes.Where(tc => tc.ThetisGroup == "07 - Fire safety").Where(tc => tc.ThetisSubGroup == "070");
        }

        [HttpGet("thetis08-080")]
        public IEnumerable<ParisMouDeficiencyCode> GetParisMouDeficiencyCodes08080()
        {
            return _context.ParisMouDeficiencyCodes.Where(tc => tc.ThetisGroup == "08 – Alarms").Where(tc => tc.ThetisSubGroup == "080");
        }

        [HttpGet("thetis09-091")]
        public IEnumerable<ParisMouDeficiencyCode> GetParisMouDeficiencyCodes09091()
        {
            return _context.ParisMouDeficiencyCodes.Where(tc => tc.ThetisGroup == "09 - Working and Living Conditions").Where(tc => tc.ThetisSubGroup == "091 - Working and Living Conditions - Living conditions");
        }

        [HttpGet("thetis09-092")]
        public IEnumerable<ParisMouDeficiencyCode> GetParisMouDeficiencyCodes09092()
        {
            return _context.ParisMouDeficiencyCodes.Where(tc => tc.ThetisGroup == "09 - Working and Living Conditions").Where(tc => tc.ThetisSubGroup == "092 - Working and Living Conditions - Working Conditions");
        }

        [HttpGet("thetis10-100")]
        public IEnumerable<ParisMouDeficiencyCode> GetParisMouDeficiencyCodes10100()
        {
            return _context.ParisMouDeficiencyCodes.Where(tc => tc.ThetisGroup == "10 - Safety of Navigation").Where(tc => tc.ThetisSubGroup == "100");
        }

        [HttpGet("thetis11-110")]
        public IEnumerable<ParisMouDeficiencyCode> GetParisMouDeficiencyCodes11110()
        {
            return _context.ParisMouDeficiencyCodes.Where(tc => tc.ThetisGroup == "11 - Life saving appliances").Where(tc => tc.ThetisSubGroup == "110");
        }

        [HttpGet("thetis12-120")]
        public IEnumerable<ParisMouDeficiencyCode> GetParisMouDeficiencyCodes12120()
        {
            return _context.ParisMouDeficiencyCodes.Where(tc => tc.ThetisGroup == "12 - Dangerous Goods").Where(tc => tc.ThetisSubGroup == "120");
        }

        [HttpGet("thetis13-130")]
        public IEnumerable<ParisMouDeficiencyCode> GetParisMouDeficiencyCodes13130()
        {
            return _context.ParisMouDeficiencyCodes.Where(tc => tc.ThetisGroup == "13 - Propulsion and auxiliary machinery").Where(tc => tc.ThetisSubGroup == "130");
        }

        [HttpGet("thetis14-141")]
        public IEnumerable<ParisMouDeficiencyCode> GetParisMouDeficiencyCodes14141()
        {
            return _context.ParisMouDeficiencyCodes.Where(tc => tc.ThetisGroup == "14 - Pollution Prevention").Where(tc => tc.ThetisSubGroup == "141 - Pollution Prevention - MARPOL Annex I");
        }

        [HttpGet("thetis14-142")]
        public IEnumerable<ParisMouDeficiencyCode> GetParisMouDeficiencyCodes14142()
        {
            return _context.ParisMouDeficiencyCodes.Where(tc => tc.ThetisGroup == "14 - Pollution Prevention").Where(tc => tc.ThetisSubGroup == "142 - Pollution Prevention - MARPOL Annex II");
        }

        [HttpGet("thetis14-143")]
        public IEnumerable<ParisMouDeficiencyCode> GetParisMouDeficiencyCodes14143()
        {
            return _context.ParisMouDeficiencyCodes.Where(tc => tc.ThetisGroup == "14 - Pollution Prevention").Where(tc => tc.ThetisSubGroup == "143 - Pollution Prevention - MARPOL Annex III");
        }

        [HttpGet("thetis14-144")]
        public IEnumerable<ParisMouDeficiencyCode> GetParisMouDeficiencyCodes14144()
        {
            return _context.ParisMouDeficiencyCodes.Where(tc => tc.ThetisGroup == "14 - Pollution Prevention").Where(tc => tc.ThetisSubGroup == "144 - Pollution Prevention - MARPOL Annex IV");
        }

        [HttpGet("thetis14-145")]
        public IEnumerable<ParisMouDeficiencyCode> GetParisMouDeficiencyCodes14145()
        {
            return _context.ParisMouDeficiencyCodes.Where(tc => tc.ThetisGroup == "14 - Pollution Prevention").Where(tc => tc.ThetisSubGroup == "145 - Pollution Prevention - MARPOL Annex V");
        }

        [HttpGet("thetis14-146")]
        public IEnumerable<ParisMouDeficiencyCode> GetParisMouDeficiencyCodes14146()
        {
            return _context.ParisMouDeficiencyCodes.Where(tc => tc.ThetisGroup == "14 - Pollution Prevention").Where(tc => tc.ThetisSubGroup == "146 - Pollution Prevention - MARPOL Annex VI");
        }

        [HttpGet("thetis14-147")]
        public IEnumerable<ParisMouDeficiencyCode> GetParisMouDeficiencyCodes14147()
        {
            return _context.ParisMouDeficiencyCodes.Where(tc => tc.ThetisGroup == "14 - Pollution Prevention").Where(tc => tc.ThetisSubGroup == "147 - Pollution Prevention - Anti Fouling");
        }

        [HttpGet("thetis14-148")]
        public IEnumerable<ParisMouDeficiencyCode> GetParisMouDeficiencyCodes14148()
        {
            return _context.ParisMouDeficiencyCodes.Where(tc => tc.ThetisGroup == "14 - Pollution Prevention").Where(tc => tc.ThetisSubGroup == "148 - Pollution Prevention – Ballast Water");
        }

        [HttpGet("thetis15-150")]
        public IEnumerable<ParisMouDeficiencyCode> GetParisMouDeficiencyCodes15150()
        {
            return _context.ParisMouDeficiencyCodes.Where(tc => tc.ThetisGroup == "15 – ISM").Where(tc => tc.ThetisSubGroup == "150");
        }

        [HttpGet("thetis16-160")]
        public IEnumerable<ParisMouDeficiencyCode> GetParisMouDeficiencyCodes16160()
        {
            return _context.ParisMouDeficiencyCodes.Where(tc => tc.ThetisGroup == "16 - ISPS").Where(tc => tc.ThetisSubGroup == "160");
        }

        [HttpGet("thetis18-181")]
        public IEnumerable<ParisMouDeficiencyCode> GetParisMouDeficiencyCodes18181()
        {
            return _context.ParisMouDeficiencyCodes.Where(tc => tc.ThetisGroup == "18 - MLC, 2006").Where(tc => tc.ThetisSubGroup == "181 - Minimum requirements to work on a ship");
        }

        [HttpGet("thetis18-182")]
        public IEnumerable<ParisMouDeficiencyCode> GetParisMouDeficiencyCodes18182()
        {
            return _context.ParisMouDeficiencyCodes.Where(tc => tc.ThetisGroup == "18 - MLC, 2006").Where(tc => tc.ThetisSubGroup == "182 - Conditions of employment");
        }

        [HttpGet("thetis18-183")]
        public IEnumerable<ParisMouDeficiencyCode> GetParisMouDeficiencyCodes18183()
        {
            return _context.ParisMouDeficiencyCodes.Where(tc => tc.ThetisGroup == "18 - MLC, 2006").Where(tc => tc.ThetisSubGroup == "183 - Accommodation, recreational facilities, food and catering");
        }

        [HttpGet("thetis18-184")]
        public IEnumerable<ParisMouDeficiencyCode> GetParisMouDeficiencyCodes18184()
        {
            return _context.ParisMouDeficiencyCodes.Where(tc => tc.ThetisGroup == "18 - MLC, 2006").Where(tc => tc.ThetisSubGroup == "184 - Health protection, medical care, social security");
        }

        [HttpGet("thetis99-990")]
        public IEnumerable<ParisMouDeficiencyCode> GetParisMouDeficiencyCodes99990()
        {
            return _context.ParisMouDeficiencyCodes.Where(tc => tc.ThetisGroup == "99  – Other").Where(tc => tc.ThetisSubGroup == "990");
        }

        // GET: api/ParisMouDeficiencyCode/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetParisMouDeficiencyCode([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var parisMouDeficiencyCode = await _context.ParisMouDeficiencyCodes.SingleOrDefaultAsync(m => m.ParisMouDeficiencyCodeId == id);

            if (parisMouDeficiencyCode == null)
            {
                return NotFound();
            }

            return Ok(parisMouDeficiencyCode);
        }

        // PUT: api/ParisMouDeficiencyCode/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutParisMouDeficiencyCode([FromRoute] int id, [FromBody] ParisMouDeficiencyCode parisMouDeficiencyCode)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != parisMouDeficiencyCode.ParisMouDeficiencyCodeId)
            {
                return BadRequest();
            }

            _context.Entry(parisMouDeficiencyCode).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ParisMouDeficiencyCodeExists(id))
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

        // POST: api/ParisMouDeficiencyCode
        [HttpPost]
        public async Task<IActionResult> PostParisMouDeficiencyCode([FromBody] ParisMouDeficiencyCode parisMouDeficiencyCode)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.ParisMouDeficiencyCodes.Add(parisMouDeficiencyCode);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetParisMouDeficiencyCode", new { id = parisMouDeficiencyCode.ParisMouDeficiencyCodeId }, parisMouDeficiencyCode);
        }

        // DELETE: api/ParisMouDeficiencyCode/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteParisMouDeficiencyCode([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var parisMouDeficiencyCode = await _context.ParisMouDeficiencyCodes.SingleOrDefaultAsync(m => m.ParisMouDeficiencyCodeId == id);
            if (parisMouDeficiencyCode == null)
            {
                return NotFound();
            }

            _context.ParisMouDeficiencyCodes.Remove(parisMouDeficiencyCode);
            await _context.SaveChangesAsync();

            return Ok(parisMouDeficiencyCode);
        }

        private bool ParisMouDeficiencyCodeExists(int id)
        {
            return _context.ParisMouDeficiencyCodes.Any(e => e.ParisMouDeficiencyCodeId == id);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NavCareApi.Models;

namespace NavCareApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicalFacilitiesController : ControllerBase
    {
        private readonly NavCareApiContext _context;

        public MedicalFacilitiesController(NavCareApiContext context)
        {
            _context = context;
        }

        // GET: api/MedicalFacilities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MedicalFacility>>> GetMedicalFacility()
        {
            return await _context.MedicalFacilities.ToListAsync();
        }

        // GET: api/MedicalFacilities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MedicalFacility>> GetMedicalFacility(int id)
        {
            var medicalFacility = await _context.MedicalFacilities.FindAsync(id);

            if (medicalFacility == null)
            {
                return NotFound();
            }

            return medicalFacility;
        }

        // PUT: api/MedicalFacilities/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMedicalFacility(int id, MedicalFacility medicalFacility)
        {
            if (id != medicalFacility.Id)
            {
                return BadRequest();
            }

            _context.Entry(medicalFacility).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MedicalFacilityExists(id))
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

        // POST: api/MedicalFacilities
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<MedicalFacility>> PostMedicalFacility(MedicalFacility medicalFacility)
        {
            _context.MedicalFacilities.Add(medicalFacility);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMedicalFacility", new { id = medicalFacility.Id }, medicalFacility);
        }

        // DELETE: api/MedicalFacilities/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MedicalFacility>> DeleteMedicalFacility(int id)
        {
            var medicalFacility = await _context.MedicalFacilities.FindAsync(id);
            if (medicalFacility == null)
            {
                return NotFound();
            }

            _context.MedicalFacilities.Remove(medicalFacility);
            await _context.SaveChangesAsync();

            return medicalFacility;
        }

        private bool MedicalFacilityExists(int id)
        {
            return _context.MedicalFacilities.Any(e => e.Id == id);
        }
    }
}

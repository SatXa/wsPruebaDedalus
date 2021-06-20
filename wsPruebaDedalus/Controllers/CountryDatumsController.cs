using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using wsPruebaDedalus.Models;

namespace wsPruebaDedalus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryDatumsController : ControllerBase
    {
        private readonly sdhh_tempContext _context;

        public CountryDatumsController(sdhh_tempContext context)
        {
            _context = context;
        }

        // GET: api/CountryDatums
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<CountryDatum>>> GetCountryData()
        //{
        //    return await _context.CountryData.ToListAsync();
        //}

        // GET: api/CountryDatums/ES
        [HttpGet("{countryIsoCode}")]
        public async Task<List<CountryDatum>> GetCountryDatumFromIsoCode(string countryIsoCode)
        {
            var countryDatum = await _context.CountryData.Where(x => x.CountryIsoCode == countryIsoCode).ToListAsync();

            return countryDatum;
        }

        // PUT: api/CountryDatums/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutCountryDatum(int id, CountryDatum countryDatum)
        //{
        //    if (id != countryDatum.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(countryDatum).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!CountryDatumExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        // POST: api/CountryDatums
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPost]
        //public async Task<ActionResult<CountryDatum>> PostCountryDatum(CountryDatum countryDatum)
        //{
        //    _context.CountryData.Add(countryDatum);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetCountryDatum", new { id = countryDatum.Id }, countryDatum);
        //}

        // DELETE: api/CountryDatums/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<CountryDatum>> DeleteCountryDatum(int id)
        //{
        //    var countryDatum = await _context.CountryData.FindAsync(id);
        //    if (countryDatum == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.CountryData.Remove(countryDatum);
        //    await _context.SaveChangesAsync();

        //    return countryDatum;
        //}

        private bool CountryDatumExists(int id)
        {
            return _context.CountryData.Any(e => e.Id == id);
        }
    }
}

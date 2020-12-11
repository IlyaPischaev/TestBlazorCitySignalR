using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorCity.Shared.Models;
using Microsoft.Extensions.Logging;
using BlazorCity.Server.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazorCity.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly CityDbContext _context;

        public CityController(CityDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<List<City>> Get()
        {
            return await _context.Cities.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<City>> GetCity(int id)
        {
            var city = await _context.Cities.FindAsync(id);

            if (city == null)
            {
                return NotFound();
            }

            return city;
        }

        [HttpPost]
        public async Task<ActionResult<City>> Post(City newCity)
        {
            _context.Cities.Add(newCity);
            await _context.SaveChangesAsync();

            return newCity;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, City city)
        {
            if (id != city.CityId)
            {
                return BadRequest();
            }

            _context.Entry(city).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Cities.Any(e => e.CityId == id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<City>> DeleteCity(int id)
        {
            var city = await _context.Cities.FindAsync(id);
            if (city == null)
            {
                return NotFound();
            }

            _context.Cities.Remove(city);
            await _context.SaveChangesAsync();

            return city;
        }
    }
}

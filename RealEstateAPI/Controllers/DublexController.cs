using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Real_Estate_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Classes;

namespace RealEstateAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DublexController : ControllerBase
    {
        private readonly RealStateDbContext _context;

        public DublexController(RealStateDbContext context)
        {
            _context = context;
        }

        //Get All Dublex
        [HttpGet]
        public async Task<IActionResult> getDublex([FromQuery] DublexQueryParameters dublexparam)
        {
            IQueryable<Dublex> dublixes = _context.Dublexes;

            if (!string.IsNullOrEmpty(dublexparam.Address))
            {
                dublixes = dublixes.Where(p => p.Address == dublexparam.Address);
            }
            if (!string.IsNullOrEmpty(dublexparam.Informations))
            {
                dublixes = dublixes.Where(p => p.Informations == dublexparam.Informations);
            }
            if (!string.IsNullOrEmpty(dublexparam.Payment))
            {
                dublixes = dublixes.Where(p => p.Payment == dublexparam.Payment);
            }            
            return Ok(await dublixes.ToArrayAsync());
        }

        //Get Element By Find Id and Handling Error by mark the tybe of parameter and make exception
       
        [HttpGet("{id}")]
        public async Task<IActionResult> getDublexById(int id)
        {
            var dublex = await _context.Dublexes.FindAsync(id);
            if (dublex == null)
            {
                return NotFound();
            }
            return Ok(dublex);
        }

        //Add Dublex
        [HttpPost]
        public async Task<ActionResult<Dublex>> PostProduct([FromBody] Dublex dublex)
        {
            _context.Dublexes.Add(dublex);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                "GetDublex",
                new { id = dublex.Id },
                dublex
            );
        }

        //Update Dublex  
        [HttpPut("{id}")]
        public async Task<IActionResult> updateProduct([FromRoute] int id, [FromBody] Dublex dublex)
        {
            if (id != dublex.Id)
            {
                return BadRequest();
            }
            _context.Entry(dublex).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_context.Dublexes.Find(id) == null)
                {
                    return NotFound();
                }
                throw;
            }
            return NoContent();
        }

         //Delete Dublex
        [HttpDelete("{id}")]
        public async Task<ActionResult<Dublex>> DeleteProduct(int id)
        {
            var dublex = await _context.Dublexes.FindAsync(id);
            if (dublex == null)
            {
                return NotFound();
            }
            _context.Dublexes.Remove(dublex);
            await _context.SaveChangesAsync();
            return dublex;
        }
    }
}

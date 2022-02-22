﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LabWebCars.Models;

namespace LabWebCars.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Producers1Controller : ControllerBase
    {
        private readonly CarsContext _context;

        public Producers1Controller(CarsContext context)
        {
            _context = context;
        }

        // GET: api/Producers1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Producer>>> GetProducers()
        {
            return await _context.Producers.ToListAsync();
        }

        [HttpGet("like/{name}")]
        public async Task<ActionResult<IEnumerable<Producer>>> GetProducersLike(string name)
        {
            return await _context.Producers.Where(p => p.Name.StartsWith(name)).ToListAsync();
        }
        // GET: api/Producers1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Producer>> GetProducer(int id)
        {
            var producer = await _context.Producers.FindAsync(id);

            if (producer == null)
            {
                return NotFound();
            }

            return producer;
        }

        // PUT: api/Producers1/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProducer(int id, Producer producer)
        {
            if (id != producer.Id)
            {
                return BadRequest();
            }

            _context.Entry(producer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProducerExists(id))
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

        // POST: api/Producers1
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Producer>> PostProducer(Producer producer)
        {
            _context.Producers.Add(producer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProducer", new { id = producer.Id }, producer);
        }

        // DELETE: api/Producers1/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Producer>> DeleteProducer(int id)
        {
            var producer = await _context.Producers.FindAsync(id);
            if (producer == null)
            {
                return NotFound();
            }

            _context.Producers.Remove(producer);
            await _context.SaveChangesAsync();

            return producer;
        }

        private bool ProducerExists(int id)
        {
            return _context.Producers.Any(e => e.Id == id);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using crud_accounts.Models;

namespace crudAccounts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TelefonesController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public TelefonesController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/Telefones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Telefone>>> GetTelefones()
        {
            return await _context.Telefones.ToListAsync();
        }

        // GET: api/Telefones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Telefone>> GetTelefone(Guid id)
        {
            var telefone = await _context.Telefones.FindAsync(id);

            if (telefone == null)
            {
                return NotFound();
            }

            return telefone;
        }

        // PUT: api/Telefones/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTelefone(Guid id, Telefone telefone)
        {
            if (id != telefone.Id)
            {
                return BadRequest();
            }

            _context.Entry(telefone).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TelefoneExists(id))
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

        // POST: api/Telefones
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Telefone>> PostTelefone(Telefone telefone)
        {
            _context.Telefones.Add(telefone);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTelefone", new { id = telefone.Id }, telefone);
        }

        // DELETE: api/Telefones/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Telefone>> DeleteTelefone(Guid id)
        {
            var telefone = await _context.Telefones.FindAsync(id);
            if (telefone == null)
            {
                return NotFound();
            }

            _context.Telefones.Remove(telefone);
            await _context.SaveChangesAsync();

            return telefone;
        }

        private bool TelefoneExists(Guid id)
        {
            return _context.Telefones.Any(e => e.Id == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using crud_accounts.Models;
using crudAccounts.Models.Services;
using AutoMapper;
using crudAccounts.Resources;
using crudAccounts.Extensions;

namespace crudAccounts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoasController : ControllerBase
    {
        //private readonly ApiDbContext _context;         
        private readonly IPessoaService _pessoaService;
        private readonly IMapper _mapper;
        

        public PessoasController(IPessoaService pessoaService, IMapper mapper)
        {
            _pessoaService = pessoaService;
            _mapper = mapper;
        }

        // GET: api/Pessoas
        [HttpGet]
        public async Task<IEnumerable<PessoaResource>> GetAllAsync()
        {
            var pessoas = await _pessoaService.ListAsync();
            var resources = _mapper.Map<IEnumerable<Pessoa>, IEnumerable<PessoaResource>>(pessoas);

            return resources;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SavePessoaResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());
            var pessoa = _mapper.Map<SavePessoaResource, Pessoa>(resource);
            var result = await _pessoaService.SaveAsync(pessoa);

            if (!result.Success)
                return BadRequest(result.Message);

            var pessoaResource = _mapper.Map<Pessoa, PessoaResource>(result.Pessoa);
            return Ok(pessoaResource);

        }
        
        
        /*
                public PessoasController(ApiDbContext context)
                {
                    _context = context;
                }

                // GET: api/Pessoas
                [HttpGet]
                public async Task<ActionResult<IEnumerable<Pessoa>>> GetPessoas()
                {
                    return await _context.Pessoas.ToListAsync();
                }

                // GET: api/Pessoas/5
                [HttpGet("{id}")]
                public async Task<ActionResult<Pessoa>> GetPessoa(Guid id)
                {
                    var pessoa = await _context.Pessoas.FindAsync(id);

                    if (pessoa == null)
                    {
                        return NotFound();
                    }

                    return pessoa;
                }

                // PUT: api/Pessoas/5
                // To protect from overposting attacks, enable the specific properties you want to bind to, for
                // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
                [HttpPut("{id}")]
                public async Task<IActionResult> PutPessoa(Guid id, Pessoa pessoa)
                {
                    if (id != pessoa.Id)
                    {
                        return BadRequest();
                    }

                    _context.Entry(pessoa).State = EntityState.Modified;

                    try
                    {
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!PessoaExists(id))
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

                // POST: api/Pessoas
                // To protect from overposting attacks, enable the specific properties you want to bind to, for
                // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
                [HttpPost]
                public async Task<ActionResult<Pessoa>> PostPessoa(Pessoa pessoa)
                {
                    _context.Pessoas.Add(pessoa);
                    await _context.SaveChangesAsync();

                    return CreatedAtAction("GetPessoa", new { id = pessoa.Id }, pessoa);
                }

                // DELETE: api/Pessoas/5
                [HttpDelete("{id}")]
                public async Task<ActionResult<Pessoa>> DeletePessoa(Guid id)
                {
                    var pessoa = await _context.Pessoas.FindAsync(id);
                    if (pessoa == null)
                    {
                        return NotFound();
                    }

                    _context.Pessoas.Remove(pessoa);
                    await _context.SaveChangesAsync();

                    return pessoa;
                }

                private bool PessoaExists(Guid id)
                {
                    return _context.Pessoas.Any(e => e.Id == id);
                }
        */
    }
}

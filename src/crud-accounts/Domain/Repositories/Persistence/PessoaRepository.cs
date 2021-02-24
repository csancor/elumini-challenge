using crud_accounts.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudAccounts.Domain.Repositories.Persistence
{
    public class PessoaRepository : BaseRepository, IPessoaRepository
    {
        public PessoaRepository(ApiDbContext context) : base(context)
        {

        }
        public async Task<IEnumerable<Pessoa>> ListAsync()
        {
            return await _context.Pessoas.ToListAsync();
        }

        public async Task AddAsync(Pessoa pessoa)
        {
            await _context.Pessoas.AddAsync(pessoa);
        }
    }
}

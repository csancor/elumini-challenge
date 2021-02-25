using crud_accounts.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudAccounts.Domain.Repositories.Persistence
{
    public class EnderecoRepository : BaseRepository, IEnderecoRepository
    {
        public EnderecoRepository(ApiDbContext context) : base(context)
        {

        }

        public async Task<IEnumerable<Endereco>> ListAsync()
        {
            return await _context.Enderecos.ToListAsync();
        }

        public async Task AddAsync(Endereco endereco)
        {
            await _context.Enderecos.AddAsync(endereco);
        }
    }
}

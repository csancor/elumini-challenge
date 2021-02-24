using crud_accounts.Models;
using crudAccounts.Domain.Repositories;
using crudAccounts.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudAccounts.Services
{
    public class PessoaService : IPessoaService
    {
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaService(IPessoaRepository pessoaRepository)
        {
            this. _pessoaRepository = pessoaRepository;
        }

        public async Task<IEnumerable<Pessoa>> ListAsync()
        {
            return await _pessoaRepository.ListAsync();
        }
    }
}

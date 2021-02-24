using crud_accounts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudAccounts.Domain.Repositories
{
    public interface IPessoaRepository
    {
        Task<IEnumerable<Pessoa>> ListAsync();
    }
}

using crud_accounts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudAccounts.Models.Services
{
    public interface IPessoaService
    {
        Task<IEnumerable<Pessoa>> ListAsync();

    }
}

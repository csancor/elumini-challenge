using crud_accounts.Models;
using crudAccounts.Domain.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudAccounts.Models.Services
{
    public interface IPessoaService
    {
        Task<IEnumerable<Pessoa>> ListAsync();
        Task<SavePessoaResponse> SaveAsync(Pessoa pessoa);

    }
}

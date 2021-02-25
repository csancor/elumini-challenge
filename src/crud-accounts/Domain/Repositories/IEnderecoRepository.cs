using crud_accounts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudAccounts.Domain.Repositories
{
    public interface IEnderecoRepository
    {
        Task<IEnumerable<Endereco>> ListAsync();
        Task AddAsync(Endereco endereco);
    }
}

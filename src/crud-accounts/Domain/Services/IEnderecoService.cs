using crud_accounts.Models;
using crudAccounts.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudAccounts.Domain.Services
{
    public interface IEnderecoService
    {
        Task<IEnumerable<Endereco>> ListAsync();
        Task<SaveEnderecoResource> SaveAsync(Endereco endereco);
    }
}

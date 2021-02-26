using crud_accounts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudAccounts.Services
{
    public interface ITelefoneRepository
    {
        IEnumerable<Telefone> GetTelefones();

        Telefone GetTelefoneById(Guid Id);
        void AddTelefone(Telefone telefone);
        bool Save();

    }
}

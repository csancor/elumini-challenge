using crud_accounts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudAccounts.Resources
{
    public class PessoaResource
    {

        public string Nome { get; set; }
        public int Cpf { get; set; }
        public int Rg { get; set; }

        public Guid Id { get; set; }

        

    }
}

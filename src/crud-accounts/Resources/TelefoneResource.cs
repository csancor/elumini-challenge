using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudAccounts.Resources
{
    public class TelefoneResource
    {
        public string Tipo { get; set; }
        public decimal Numero { get; set; }
        public Guid PessoaId { get; set; }
    }
}

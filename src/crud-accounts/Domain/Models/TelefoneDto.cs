using crud_accounts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudAccounts.Domain.Models
{
    public class TelefoneDto: EntityDto
    {
        public string Tipo { get; set; }
        public decimal Numero { get; set; }

        public Guid PessoaId { get; set; }
    }
}

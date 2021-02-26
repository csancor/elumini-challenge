using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud_accounts.Models
{
    public class Telefone : Entity
    {
        public string Tipo { get; set; }
        public decimal Numero { get; set; }

        public Guid TelefonePessoaId { get; set; }
        public Pessoa Pessoa { get; set; }

        public ICollection<Telefone> Telefones { get; set; }
            = new List<Telefone>();
    }
}

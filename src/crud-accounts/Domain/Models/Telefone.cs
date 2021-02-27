using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace crud_accounts.Models
{
    public class Telefone : Entity
    {
        public string Tipo { get; set; }
        public decimal Numero { get; set; }
        
        public Pessoa Pessoa { get; set; }

        public Guid PessoaId { get; set; }

        public  ICollection<Telefone>Telefones { get; internal set; } = new List<Telefone>();
    }
}

using System;
using System.Collections.Generic;

namespace crud_accounts.Models
{
    public class Pessoa : Entity
    {
        public string Nome { get; set; }
        public int Cpf { get; set; }
        public int Rg { get; set; }

        public ICollection<Telefone> Telefones { get; set; } = new List<Telefone>();

        public Endereco Endereco { get; set; }
        
    }
}

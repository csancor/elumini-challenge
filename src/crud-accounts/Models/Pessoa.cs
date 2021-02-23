using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud_accounts.Models
{
    public class Pessoa : Entity
    {
        public string Nome { get; set; }
        public int Cpf { get; set; }
        public int Rg { get; set; }
        public Telefone Telefone { get; set; }
        public Endereco Endereco { get; set; }
    }
}

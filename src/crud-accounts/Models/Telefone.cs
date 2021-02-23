using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud_accounts.Models
{
    public class Telefone : Entity
    {
        public string Tipo { get; set; }
        public int Numero { get; set; }
    }
}

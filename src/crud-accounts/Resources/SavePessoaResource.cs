using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace crudAccounts.Resources
{
    public class SavePessoaResource
    {
        [Required]
        [MaxLength(30)]
        public string Nome { get; set; }
        public int Cpf { get; set; }
        public int Rg { get; set; }

    }
}

using System;
using System.Collections.Generic;

namespace crud_accounts.Models
{
    public class Pessoa : Entity
    {
        public string Nome { get; set; }
        public int Cpf { get; set; } 
        public int Rg { get; set; }
        //public Telefone Telefone { get; set; }
        //public Endereco Endereco { get; set; }
        public virtual EnderecoPessoa Endereco  { get; set; }
        public virtual TelefonePessoa Telefone { get; set; }
      //  public ICollection<TelefonePessoa> Telefones { get; set; }
    }    

    public class EnderecoPessoa : Entity
    {
        public Guid PessoaId { get; set; }
        public Guid PessoaForeignKey { get; set; }
        public Pessoa Pessoa { get; set; }        
        public int Cep { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public string uf { get; set; }
    }

    public class TelefonePessoa : Entity
    {
        public Guid PessoaId { get; set; }
        public Guid PessoaForeignKey { get; set; }
        public string Tipo { get; set; }
        public int Numero { get; set; }
        public Pessoa Pessoa { get; set; }
    }
}

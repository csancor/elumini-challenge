using System;

namespace crud_accounts.Models
{
    public class Pessoa : Entity
    {
        public string Nome { get; set; }
        public decimal Cpf { get; set; }
        public decimal Rg { get; set; }
        //public Telefone Telefone { get; set; }
        //public Endereco Endereco { get; set; }
        public EnderecoPessoa Endereco  { get; set; }
    }

    public class EnderecoPessoa : Entity
    {
        public Guid PessoaId { get; set; }
        public Guid PessoaForeignKey { get; set; }
        public Pessoa Pessoa { get; set; }        
        public int Cep { get; set; }
        public string Logradouro { get; set; }
        public decimal Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public string uf { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud_accounts.Models
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Telefone> Telefones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApiDbContext).Assembly);
            base.OnModelCreating(modelBuilder);



            //seed Pessoa
            modelBuilder.Entity<Pessoa>().HasData(
                new Pessoa()
                {
                    Id = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                    Nome = "Herb Hancock",
                    Cpf = 00000111548,
                    Rg = 0021514151
                },
                 new Pessoa()
                 {
                     Id = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b32"),
                     Nome = "Chick Corea",
                     Cpf = 01252632545,
                     Rg = 0207255136
                 },
                  new Pessoa()
                  {
                      Id = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b31"),
                      Nome = "Charlie Parker",
                      Cpf = 00000111548,
                      Rg = 0153526548
                  });


            //seed Endereco
            modelBuilder.Entity<Endereco>().HasData(
                new Endereco()
                {
                    Id = Guid.NewGuid(),
                    EnderecoPessoaId = Guid.Parse("C890DDF9-139B-43E9-888A-2D5103E746FA"),
                    Logradouro = "Rua Sete de Setembro",
                    Numero = 15,
                    Complemento = "casa 23",
                    Bairro = "Centro",
                    Municipio = "Rio de Janeiro",
                    uf = "RJ",
                    Cep = 20260525
                },

                 new Endereco()
                 {
                     Id = Guid.NewGuid(),
                     EnderecoPessoaId = Guid.Parse("C890DDF9-139B-43E9-888A-2D5103E746FB"),
                     Logradouro = "Avenida Paulista",
                     Numero = 1205,
                     Complemento = "bloco 6 ap 306",
                     Bairro = "Centro",
                     Municipio = "São Paulo",
                     uf = "SP",
                     Cep = 11260525
                 },
                  new Endereco()
                  {
                      Id = Guid.NewGuid(),
                      EnderecoPessoaId = Guid.Parse("C890DDF9-139B-43E9-888A-2D5103E746FC"),
                      Logradouro = "Avenida Ministro Ary Franco",
                      Numero = 2255,
                      Complemento = "casa 5",
                      Bairro = "Bangu",
                      Municipio = "Rio de Janeiro",
                      uf = "RJ",
                      Cep = 21280525
                  });

            //seed Telefone
            modelBuilder.Entity<Telefone>().HasData(
                new Telefone()
                {
                    Id = Guid.NewGuid(),
                    PessoaId = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                    Tipo = "Celular",
                    Numero = 985635241
                },
                new Telefone()
                {
                    Id = Guid.NewGuid(),
                    PessoaId = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b32"),
                    Tipo = "Celular",
                    Numero = 975859654
                },
                new Telefone()
                {
                    Id = Guid.NewGuid(),
                    PessoaId = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b31"),
                    Tipo = "Fixo",
                    Numero = 312524684
                },
                new Telefone()
                {
                    Id = Guid.NewGuid(),
                    PessoaId = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b31"),
                    Tipo = "Celular",
                    Numero = 985652541
                });
        }
    }
}

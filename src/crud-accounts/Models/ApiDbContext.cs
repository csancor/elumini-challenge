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

            // 1 : 1 Relationship
            modelBuilder.Entity<Pessoa>()
             .HasOne(p => p.Endereco)
             .WithOne(e => e.Pessoa)
             .HasForeignKey<EnderecoPessoa>(pfk => pfk.PessoaForeignKey);



            //Student/Telefones - N -> Grade/Pessoa  - 1
            modelBuilder.Entity<TelefonePessoa>()
           .HasOne<Pessoa>(s => s.Pessoa)
           .WithMany(g => g.Telefones)
           .HasForeignKey(s => s.PessoaForeignKey);



            //seed Pessoa
            modelBuilder.Entity<Pessoa>().HasData(new Pessoa { Id = Guid.NewGuid() , Nome = "Herb Hancock",, Cpf = 00000111548, Rg = 0021514151 });
            modelBuilder.Entity<Pessoa>().HasData(new Pessoa { Id = Guid.NewGuid(), Nome = "Chick Corea", Cpf = 01252632545, Rg = 0207255136 });
            modelBuilder.Entity<Pessoa>().HasData(new Pessoa { Id = Guid.NewGuid(), Nome = "Charlie Parker", Cpf = 00000111548, Rg = 0153526548 });

            //seed Endereco
            modelBuilder.Entity<Endereco>().HasData(new Endereco { Id = Guid.NewGuid(), Logradouro ="Rua Sete de Setembro", Numero = 15, Complemento = "casa 23", Bairro= "Centro", Municipio = "Rio de Janeiro", uf= "RJ", Cep = 20260525   });
            modelBuilder.Entity<Endereco>().HasData(new Endereco { Id = Guid.NewGuid(), Logradouro = "Avenida Paulista", Numero = 1205, Complemento = "bloco 6 ap 306", Bairro = "Centro", Municipio = "São Paulo", uf = "SP", Cep = 11260525 });
            modelBuilder.Entity<Endereco>().HasData(new Endereco { Id = Guid.NewGuid(), Logradouro = "Avenida Ministro Ary Franco", Numero = 2255, Complemento = "casa 5", Bairro = "Bangu", Municipio = "Rio de Janeiro", uf = "RJ", Cep = 21280525 });

            //seed Telefone
            modelBuilder.Entity<Telefone>().HasData(new Telefone { Id = Guid.NewGuid(), Tipo = "Celular", Numero = 985635241});
            modelBuilder.Entity<Telefone>().HasData(new Telefone { Id = Guid.NewGuid(), Tipo = "Celular", Numero = 975859654 });
            modelBuilder.Entity<Telefone>().HasData(new Telefone { Id = Guid.NewGuid(), Tipo = "Fixo", Numero = 312524684 });

        }
    }
}

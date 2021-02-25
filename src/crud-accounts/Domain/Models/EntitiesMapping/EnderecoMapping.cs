using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud_accounts.Models.EntitiesMapping
{
    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();

            builder.Property(p => p.Cep).IsRequired().HasColumnType("varchar(8)");

            builder.Property(p => p.Logradouro).IsRequired().HasColumnType("varchar(200)");

            builder.Property(p => p.Numero).IsRequired().HasColumnType("varchar(50)");

            builder.Property(p => p.Complemento).IsRequired().HasColumnType("varchar(100)");

            builder.Property(p => p.Bairro).IsRequired().HasColumnType("varchar(100)");
            
            builder.Property(p => p.Municipio).IsRequired().HasColumnType("varchar(100)");
            
            builder.Property(p => p.uf).IsRequired().HasColumnType("varchar(2)");
            
            builder.ToTable("Enderecos");
        }
    }
}

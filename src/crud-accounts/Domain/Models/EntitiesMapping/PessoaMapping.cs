using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud_accounts.Models.EntitiesMapping
{
    public class PessoaMapping : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();

            builder.Property(p => p.Nome).IsRequired().HasColumnType("varchar(200)");
            
            builder.Property(p => p.Rg).IsRequired().HasColumnType("varchar(10)");

            builder.Property(p => p.Cpf).IsRequired().HasColumnType("varchar(11)");

            builder.ToTable("Pessoas");
        }
    }
}

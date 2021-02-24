using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud_accounts.Models.EntitiesMapping
{
    public class TelefoneMapping : IEntityTypeConfiguration<Telefone>
    {
        public void Configure(EntityTypeBuilder<Telefone> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();

            builder.Property(p => p.Tipo).IsRequired().HasColumnType("varchar(15)");
            
            builder.Property(p => p.Numero).IsRequired().HasColumnType("varchar(11)");
            
            builder.ToTable("Telefones");
        }
    }
}

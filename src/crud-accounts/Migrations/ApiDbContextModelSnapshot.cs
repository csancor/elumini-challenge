﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using crud_accounts.Models;

namespace crud_accounts.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    partial class ApiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("crud_accounts.Models.Endereco", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("varchar(8)");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Municipio")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("uf")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.HasKey("Id");

                    b.ToTable("Enderecos");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9ce65e5a-2f18-48ef-8536-8fe44f238b7d"),
                            Bairro = "Centro",
                            Cep = "20260525",
                            Complemento = "casa 23",
                            Logradouro = "Rua Sete de Setembro",
                            Municipio = "Rio de Janeiro",
                            Numero = "15",
                            uf = "RJ"
                        },
                        new
                        {
                            Id = new Guid("9e954313-7187-4a90-b7b6-ef8d56d55f4d"),
                            Bairro = "Centro",
                            Cep = "11260525",
                            Complemento = "bloco 6 ap 306",
                            Logradouro = "Avenida Paulista",
                            Municipio = "São Paulo",
                            Numero = "1205",
                            uf = "SP"
                        },
                        new
                        {
                            Id = new Guid("53c168cc-4dff-4a15-84bd-736f543e860a"),
                            Bairro = "Bangu",
                            Cep = "21280525",
                            Complemento = "casa 5",
                            Logradouro = "Avenida Ministro Ary Franco",
                            Municipio = "Rio de Janeiro",
                            Numero = "2255",
                            uf = "RJ"
                        });
                });

            modelBuilder.Entity("crud_accounts.Models.Pessoa", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("varchar(11)");

                    b.Property<Guid?>("EnderecoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Rg")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<Guid?>("TelefoneId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.HasIndex("TelefoneId");

                    b.ToTable("Pessoas");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b8cecb08-a52e-4e4b-bba4-7466177e10fc"),
                            Cpf = "111548",
                            Nome = "Herb Hancock",
                            Rg = "21514151"
                        },
                        new
                        {
                            Id = new Guid("aa2c742b-7063-409f-89a4-4e46f4583444"),
                            Cpf = "1252632545",
                            Nome = "Chick Corea",
                            Rg = "207255136"
                        },
                        new
                        {
                            Id = new Guid("628cf453-007c-4618-aacb-068403c15535"),
                            Cpf = "111548",
                            Nome = "Charlie Parker",
                            Rg = "153526548"
                        });
                });

            modelBuilder.Entity("crud_accounts.Models.Telefone", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("varchar(11)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.HasKey("Id");

                    b.ToTable("Telefones");

                    b.HasData(
                        new
                        {
                            Id = new Guid("96c33fe8-8b66-462a-9dc1-7148dd12fe57"),
                            Numero = "985635241",
                            Tipo = "Celular"
                        },
                        new
                        {
                            Id = new Guid("c0f4cc2c-d31d-492f-8636-6e35467ffb5b"),
                            Numero = "975859654",
                            Tipo = "Celular"
                        },
                        new
                        {
                            Id = new Guid("62c9af28-d520-4375-918f-447b8dce14dc"),
                            Numero = "312524684",
                            Tipo = "Fixo"
                        });
                });

            modelBuilder.Entity("crud_accounts.Models.Pessoa", b =>
                {
                    b.HasOne("crud_accounts.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId");

                    b.HasOne("crud_accounts.Models.Telefone", "Telefone")
                        .WithMany()
                        .HasForeignKey("TelefoneId");
                });
#pragma warning restore 612, 618
        }
    }
}

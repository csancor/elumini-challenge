using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace crudAccounts.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Cep = table.Column<string>(type: "varchar(8)", nullable: false),
                    Logradouro = table.Column<string>(type: "varchar(200)", nullable: false),
                    Numero = table.Column<string>(type: "varchar(50)", nullable: false),
                    Complemento = table.Column<string>(type: "varchar(100)", nullable: false),
                    Bairro = table.Column<string>(type: "varchar(100)", nullable: false),
                    Municipio = table.Column<string>(type: "varchar(100)", nullable: false),
                    uf = table.Column<string>(type: "varchar(2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(type: "varchar(200)", nullable: false),
                    Cpf = table.Column<string>(type: "varchar(11)", nullable: false),
                    Rg = table.Column<string>(type: "varchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Telefones",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Tipo = table.Column<string>(type: "varchar(15)", nullable: false),
                    Numero = table.Column<string>(type: "varchar(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EnderecoPessoa",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    PessoaId = table.Column<Guid>(nullable: false),
                    PessoaForeignKey = table.Column<Guid>(nullable: false),
                    Cep = table.Column<int>(nullable: false),
                    Logradouro = table.Column<string>(nullable: true),
                    Numero = table.Column<int>(nullable: false),
                    Complemento = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    Municipio = table.Column<string>(nullable: true),
                    uf = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnderecoPessoa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EnderecoPessoa_Pessoas_PessoaForeignKey",
                        column: x => x.PessoaForeignKey,
                        principalTable: "Pessoas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TelefonePessoa",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    PessoaId = table.Column<Guid>(nullable: false),
                    PessoaForeignKey = table.Column<Guid>(nullable: false),
                    Tipo = table.Column<string>(nullable: true),
                    Numero = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TelefonePessoa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TelefonePessoa_Pessoas_PessoaForeignKey",
                        column: x => x.PessoaForeignKey,
                        principalTable: "Pessoas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Enderecos",
                columns: new[] { "Id", "Bairro", "Cep", "Complemento", "Logradouro", "Municipio", "Numero", "uf" },
                values: new object[,]
                {
                    { new Guid("d7447105-ea62-4771-a355-7ac1ed141381"), "Centro", "20260525", "casa 23", "Rua Sete de Setembro", "Rio de Janeiro", "15", "RJ" },
                    { new Guid("448ae198-f4d7-4a97-8c30-bfba535b002d"), "Centro", "11260525", "bloco 6 ap 306", "Avenida Paulista", "São Paulo", "1205", "SP" },
                    { new Guid("4fc66958-bbd6-45d7-b102-80f149077eea"), "Bangu", "21280525", "casa 5", "Avenida Ministro Ary Franco", "Rio de Janeiro", "2255", "RJ" }
                });

            migrationBuilder.InsertData(
                table: "Pessoas",
                columns: new[] { "Id", "Cpf", "Nome", "Rg" },
                values: new object[,]
                {
                    { new Guid("634cefd1-c455-40c2-a0fd-6e6339a1f268"), "111548", "Herb Hancock", "21514151" },
                    { new Guid("3fde07f1-fae8-4178-b456-2b91dd7bf42d"), "1252632545", "Chick Corea", "207255136" },
                    { new Guid("2882353d-b88e-47a8-8122-41f4899854ab"), "111548", "Charlie Parker", "153526548" }
                });

            migrationBuilder.InsertData(
                table: "Telefones",
                columns: new[] { "Id", "Numero", "Tipo" },
                values: new object[,]
                {
                    { new Guid("e4657da0-4993-48b8-a2a8-6ec6322ddd6b"), "985635241", "Celular" },
                    { new Guid("ca8334ce-b16f-4542-8af3-c36ef0058b82"), "975859654", "Celular" },
                    { new Guid("1919ad87-d319-4ca3-8232-5cfe3abe4651"), "312524684", "Fixo" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EnderecoPessoa_PessoaForeignKey",
                table: "EnderecoPessoa",
                column: "PessoaForeignKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TelefonePessoa_PessoaForeignKey",
                table: "TelefonePessoa",
                column: "PessoaForeignKey",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EnderecoPessoa");

            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropTable(
                name: "TelefonePessoa");

            migrationBuilder.DropTable(
                name: "Telefones");

            migrationBuilder.DropTable(
                name: "Pessoas");
        }
    }
}

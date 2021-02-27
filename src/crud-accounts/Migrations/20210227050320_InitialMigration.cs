using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace crudAccounts.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    uf = table.Column<string>(type: "varchar(2)", nullable: false),
                    PessoaId = table.Column<Guid>(nullable: true),
                    EnderecoPessoaId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Enderecos_Pessoas_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Telefones",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Tipo = table.Column<string>(type: "varchar(15)", nullable: false),
                    Numero = table.Column<string>(type: "varchar(11)", nullable: false),
                    PessoaId = table.Column<Guid>(nullable: false),
                    TelefoneId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Telefones_Pessoas_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Telefones_Telefones_TelefoneId",
                        column: x => x.TelefoneId,
                        principalTable: "Telefones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Enderecos",
                columns: new[] { "Id", "Bairro", "Cep", "Complemento", "EnderecoPessoaId", "Logradouro", "Municipio", "Numero", "PessoaId", "uf" },
                values: new object[,]
                {
                    { new Guid("16ae4424-ba08-43c8-8c6d-88e0e35d7f45"), "Centro", "20260525", "casa 23", new Guid("c890ddf9-139b-43e9-888a-2d5103e746fa"), "Rua Sete de Setembro", "Rio de Janeiro", "15", null, "RJ" },
                    { new Guid("0e90ce45-3f25-435a-a1cf-bfd09585a164"), "Centro", "11260525", "bloco 6 ap 306", new Guid("c890ddf9-139b-43e9-888a-2d5103e746fb"), "Avenida Paulista", "São Paulo", "1205", null, "SP" },
                    { new Guid("0ae64d17-aec6-4cfd-b49e-67c48fdc70d4"), "Bangu", "21280525", "casa 5", new Guid("c890ddf9-139b-43e9-888a-2d5103e746fc"), "Avenida Ministro Ary Franco", "Rio de Janeiro", "2255", null, "RJ" }
                });

            migrationBuilder.InsertData(
                table: "Pessoas",
                columns: new[] { "Id", "Cpf", "Nome", "Rg" },
                values: new object[,]
                {
                    { new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), "111548", "Herb Hancock", "21514151" },
                    { new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b32"), "1252632545", "Chick Corea", "207255136" },
                    { new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b31"), "111548", "Charlie Parker", "153526548" }
                });

            migrationBuilder.InsertData(
                table: "Telefones",
                columns: new[] { "Id", "Numero", "PessoaId", "TelefoneId", "Tipo" },
                values: new object[,]
                {
                    { new Guid("152a89fb-fdb4-4d56-a193-df84edab174b"), "985635241", new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), null, "Celular" },
                    { new Guid("31b85c90-985d-4ecd-bfff-9ceef57f7872"), "975859654", new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b32"), null, "Celular" },
                    { new Guid("2d6db1c7-2f17-4ea9-bade-c73fbe69e3c7"), "312524684", new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b31"), null, "Fixo" },
                    { new Guid("35baccb9-1cc7-415d-a778-261a54c18e87"), "985652541", new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b31"), null, "Celular" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_PessoaId",
                table: "Enderecos",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefones_PessoaId",
                table: "Telefones",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefones_TelefoneId",
                table: "Telefones",
                column: "TelefoneId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropTable(
                name: "Telefones");

            migrationBuilder.DropTable(
                name: "Pessoas");
        }
    }
}

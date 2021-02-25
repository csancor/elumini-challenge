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
                    uf = table.Column<string>(type: "varchar(2)", nullable: false),
                    EnderecoPessoaId = table.Column<Guid>(nullable: false)
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
                    Rg = table.Column<string>(type: "varchar(10)", nullable: false),
                    EnderecoId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pessoas_Enderecos_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Enderecos",
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
                    TelefonePessoaId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Telefones_Pessoas_TelefonePessoaId",
                        column: x => x.TelefonePessoaId,
                        principalTable: "Pessoas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Enderecos",
                columns: new[] { "Id", "Bairro", "Cep", "Complemento", "EnderecoPessoaId", "Logradouro", "Municipio", "Numero", "uf" },
                values: new object[,]
                {
                    { new Guid("29685671-fd15-4279-a448-448170b4f3e1"), "Centro", "20260525", "casa 23", new Guid("c890ddf9-139b-43e9-888a-2d5103e746fa"), "Rua Sete de Setembro", "Rio de Janeiro", "15", "RJ" },
                    { new Guid("87fc46f1-186c-478e-a10b-b1b639beb4e9"), "Centro", "11260525", "bloco 6 ap 306", new Guid("c890ddf9-139b-43e9-888a-2d5103e746fb"), "Avenida Paulista", "São Paulo", "1205", "SP" },
                    { new Guid("871ff23b-1ef6-45ff-8052-65807537e78b"), "Bangu", "21280525", "casa 5", new Guid("c890ddf9-139b-43e9-888a-2d5103e746fc"), "Avenida Ministro Ary Franco", "Rio de Janeiro", "2255", "RJ" }
                });

            migrationBuilder.InsertData(
                table: "Pessoas",
                columns: new[] { "Id", "Cpf", "EnderecoId", "Nome", "Rg" },
                values: new object[,]
                {
                    { new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), "111548", null, "Herb Hancock", "21514151" },
                    { new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b32"), "1252632545", null, "Chick Corea", "207255136" },
                    { new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b31"), "111548", null, "Charlie Parker", "153526548" }
                });

            migrationBuilder.InsertData(
                table: "Telefones",
                columns: new[] { "Id", "Numero", "TelefonePessoaId", "Tipo" },
                values: new object[,]
                {
                    { new Guid("7716442a-f850-4123-ac51-40c3b1a7b7e2"), "985635241", new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), "Celular" },
                    { new Guid("1a54484a-a5e7-4e8a-9b12-a61d952b0cfe"), "975859654", new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b32"), "Celular" },
                    { new Guid("1cdaf6ee-2630-4cd0-853f-1c094501ba7a"), "312524684", new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b31"), "Fixo" },
                    { new Guid("7bc39bf5-c23e-4673-9a2e-1dafe3dca1c8"), "985652541", new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b31"), "Celular" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pessoas_EnderecoId",
                table: "Pessoas",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefones_TelefonePessoaId",
                table: "Telefones",
                column: "TelefonePessoaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Telefones");

            migrationBuilder.DropTable(
                name: "Pessoas");

            migrationBuilder.DropTable(
                name: "Enderecos");
        }
    }
}

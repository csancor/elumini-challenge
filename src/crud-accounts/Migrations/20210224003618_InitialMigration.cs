using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace crud_accounts.Migrations
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
                name: "Pessoas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(type: "varchar(200)", nullable: false),
                    Cpf = table.Column<string>(type: "varchar(11)", nullable: false),
                    Rg = table.Column<string>(type: "varchar(10)", nullable: false),
                    TelefoneId = table.Column<Guid>(nullable: true),
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
                    table.ForeignKey(
                        name: "FK_Pessoas_Telefones_TelefoneId",
                        column: x => x.TelefoneId,
                        principalTable: "Telefones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Enderecos",
                columns: new[] { "Id", "Bairro", "Cep", "Complemento", "Logradouro", "Municipio", "Numero", "uf" },
                values: new object[,]
                {
                    { new Guid("9ce65e5a-2f18-48ef-8536-8fe44f238b7d"), "Centro", "20260525", "casa 23", "Rua Sete de Setembro", "Rio de Janeiro", "15", "RJ" },
                    { new Guid("9e954313-7187-4a90-b7b6-ef8d56d55f4d"), "Centro", "11260525", "bloco 6 ap 306", "Avenida Paulista", "São Paulo", "1205", "SP" },
                    { new Guid("53c168cc-4dff-4a15-84bd-736f543e860a"), "Bangu", "21280525", "casa 5", "Avenida Ministro Ary Franco", "Rio de Janeiro", "2255", "RJ" }
                });

            migrationBuilder.InsertData(
                table: "Pessoas",
                columns: new[] { "Id", "Cpf", "EnderecoId", "Nome", "Rg", "TelefoneId" },
                values: new object[,]
                {
                    { new Guid("b8cecb08-a52e-4e4b-bba4-7466177e10fc"), "111548", null, "Herb Hancock", "21514151", null },
                    { new Guid("aa2c742b-7063-409f-89a4-4e46f4583444"), "1252632545", null, "Chick Corea", "207255136", null },
                    { new Guid("628cf453-007c-4618-aacb-068403c15535"), "111548", null, "Charlie Parker", "153526548", null }
                });

            migrationBuilder.InsertData(
                table: "Telefones",
                columns: new[] { "Id", "Numero", "Tipo" },
                values: new object[,]
                {
                    { new Guid("96c33fe8-8b66-462a-9dc1-7148dd12fe57"), "985635241", "Celular" },
                    { new Guid("c0f4cc2c-d31d-492f-8636-6e35467ffb5b"), "975859654", "Celular" },
                    { new Guid("62c9af28-d520-4375-918f-447b8dce14dc"), "312524684", "Fixo" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pessoas_EnderecoId",
                table: "Pessoas",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoas_TelefoneId",
                table: "Pessoas",
                column: "TelefoneId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pessoas");

            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropTable(
                name: "Telefones");
        }
    }
}

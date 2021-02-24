using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace crud_accounts.Migrations
{
    public partial class FKConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pessoas_Enderecos_EnderecoId",
                table: "Pessoas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pessoas_Telefones_TelefoneId",
                table: "Pessoas");

            migrationBuilder.DropIndex(
                name: "IX_Pessoas_EnderecoId",
                table: "Pessoas");

            migrationBuilder.DropIndex(
                name: "IX_Pessoas_TelefoneId",
                table: "Pessoas");

            migrationBuilder.DeleteData(
                table: "Enderecos",
                keyColumn: "Id",
                keyValue: new Guid("53c168cc-4dff-4a15-84bd-736f543e860a"));

            migrationBuilder.DeleteData(
                table: "Enderecos",
                keyColumn: "Id",
                keyValue: new Guid("9ce65e5a-2f18-48ef-8536-8fe44f238b7d"));

            migrationBuilder.DeleteData(
                table: "Enderecos",
                keyColumn: "Id",
                keyValue: new Guid("9e954313-7187-4a90-b7b6-ef8d56d55f4d"));

            migrationBuilder.DeleteData(
                table: "Pessoas",
                keyColumn: "Id",
                keyValue: new Guid("628cf453-007c-4618-aacb-068403c15535"));

            migrationBuilder.DeleteData(
                table: "Pessoas",
                keyColumn: "Id",
                keyValue: new Guid("aa2c742b-7063-409f-89a4-4e46f4583444"));

            migrationBuilder.DeleteData(
                table: "Pessoas",
                keyColumn: "Id",
                keyValue: new Guid("b8cecb08-a52e-4e4b-bba4-7466177e10fc"));

            migrationBuilder.DeleteData(
                table: "Telefones",
                keyColumn: "Id",
                keyValue: new Guid("62c9af28-d520-4375-918f-447b8dce14dc"));

            migrationBuilder.DeleteData(
                table: "Telefones",
                keyColumn: "Id",
                keyValue: new Guid("96c33fe8-8b66-462a-9dc1-7148dd12fe57"));

            migrationBuilder.DeleteData(
                table: "Telefones",
                keyColumn: "Id",
                keyValue: new Guid("c0f4cc2c-d31d-492f-8636-6e35467ffb5b"));

            migrationBuilder.DropColumn(
                name: "EnderecoId",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "TelefoneId",
                table: "Pessoas");

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

            migrationBuilder.InsertData(
                table: "Enderecos",
                columns: new[] { "Id", "Bairro", "Cep", "Complemento", "Logradouro", "Municipio", "Numero", "uf" },
                values: new object[,]
                {
                    { new Guid("8da9fd2c-0c15-49dc-9db5-510e1234df80"), "Centro", "20260525", "casa 23", "Rua Sete de Setembro", "Rio de Janeiro", "15", "RJ" },
                    { new Guid("e2605fac-e00f-4da9-b7c3-491a9c6379a9"), "Centro", "11260525", "bloco 6 ap 306", "Avenida Paulista", "São Paulo", "1205", "SP" },
                    { new Guid("53a73f88-a377-4e5e-9320-52e362ebecea"), "Bangu", "21280525", "casa 5", "Avenida Ministro Ary Franco", "Rio de Janeiro", "2255", "RJ" }
                });

            migrationBuilder.InsertData(
                table: "Pessoas",
                columns: new[] { "Id", "Cpf", "Nome", "Rg" },
                values: new object[,]
                {
                    { new Guid("8b2f7e4a-930d-4702-899d-18db38140cfd"), "111548", "Herb Hancock", "21514151" },
                    { new Guid("78020c1a-7ba1-4aa5-841e-28f2767498e2"), "1252632545", "Chick Corea", "207255136" },
                    { new Guid("1ec2f34f-34b2-40ed-a326-ba37c71dea22"), "111548", "Charlie Parker", "153526548" }
                });

            migrationBuilder.InsertData(
                table: "Telefones",
                columns: new[] { "Id", "Numero", "Tipo" },
                values: new object[,]
                {
                    { new Guid("662e9883-9ed6-47a7-a500-a82111440cb6"), "985635241", "Celular" },
                    { new Guid("590f1e4f-f2bf-4152-8cc7-30f86df878c0"), "975859654", "Celular" },
                    { new Guid("522f650a-a701-425c-b5fa-c54167df56eb"), "312524684", "Fixo" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EnderecoPessoa_PessoaForeignKey",
                table: "EnderecoPessoa",
                column: "PessoaForeignKey",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EnderecoPessoa");

            migrationBuilder.DeleteData(
                table: "Enderecos",
                keyColumn: "Id",
                keyValue: new Guid("53a73f88-a377-4e5e-9320-52e362ebecea"));

            migrationBuilder.DeleteData(
                table: "Enderecos",
                keyColumn: "Id",
                keyValue: new Guid("8da9fd2c-0c15-49dc-9db5-510e1234df80"));

            migrationBuilder.DeleteData(
                table: "Enderecos",
                keyColumn: "Id",
                keyValue: new Guid("e2605fac-e00f-4da9-b7c3-491a9c6379a9"));

            migrationBuilder.DeleteData(
                table: "Pessoas",
                keyColumn: "Id",
                keyValue: new Guid("1ec2f34f-34b2-40ed-a326-ba37c71dea22"));

            migrationBuilder.DeleteData(
                table: "Pessoas",
                keyColumn: "Id",
                keyValue: new Guid("78020c1a-7ba1-4aa5-841e-28f2767498e2"));

            migrationBuilder.DeleteData(
                table: "Pessoas",
                keyColumn: "Id",
                keyValue: new Guid("8b2f7e4a-930d-4702-899d-18db38140cfd"));

            migrationBuilder.DeleteData(
                table: "Telefones",
                keyColumn: "Id",
                keyValue: new Guid("522f650a-a701-425c-b5fa-c54167df56eb"));

            migrationBuilder.DeleteData(
                table: "Telefones",
                keyColumn: "Id",
                keyValue: new Guid("590f1e4f-f2bf-4152-8cc7-30f86df878c0"));

            migrationBuilder.DeleteData(
                table: "Telefones",
                keyColumn: "Id",
                keyValue: new Guid("662e9883-9ed6-47a7-a500-a82111440cb6"));

            migrationBuilder.AddColumn<Guid>(
                name: "EnderecoId",
                table: "Pessoas",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TelefoneId",
                table: "Pessoas",
                type: "uniqueidentifier",
                nullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoas_Enderecos_EnderecoId",
                table: "Pessoas",
                column: "EnderecoId",
                principalTable: "Enderecos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoas_Telefones_TelefoneId",
                table: "Pessoas",
                column: "TelefoneId",
                principalTable: "Telefones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

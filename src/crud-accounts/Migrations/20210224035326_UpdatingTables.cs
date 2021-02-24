using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace crud_accounts.Migrations
{
    public partial class UpdatingTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Enderecos",
                keyColumn: "Id",
                keyValue: new Guid("1e12b298-fb8c-45de-96dd-3e0280edfc25"));

            migrationBuilder.DeleteData(
                table: "Enderecos",
                keyColumn: "Id",
                keyValue: new Guid("62d6919d-73d3-4fa7-92b0-f2dcba69ee22"));

            migrationBuilder.DeleteData(
                table: "Enderecos",
                keyColumn: "Id",
                keyValue: new Guid("81bb69d7-881c-4a2c-871e-e8ce141cfa48"));

            migrationBuilder.DeleteData(
                table: "Pessoas",
                keyColumn: "Id",
                keyValue: new Guid("22334425-13f4-4537-b7da-69c55ecc819a"));

            migrationBuilder.DeleteData(
                table: "Pessoas",
                keyColumn: "Id",
                keyValue: new Guid("54c45cf0-4f94-4faf-9f6e-9e4d377ee8c9"));

            migrationBuilder.DeleteData(
                table: "Pessoas",
                keyColumn: "Id",
                keyValue: new Guid("9f114c06-0eca-4ac2-b730-9128eaf1074b"));

            migrationBuilder.DeleteData(
                table: "Telefones",
                keyColumn: "Id",
                keyValue: new Guid("20f76c41-4e53-4e82-970f-43b396172189"));

            migrationBuilder.DeleteData(
                table: "Telefones",
                keyColumn: "Id",
                keyValue: new Guid("33f0d0de-4601-4bea-bd59-2a2f20749021"));

            migrationBuilder.DeleteData(
                table: "Telefones",
                keyColumn: "Id",
                keyValue: new Guid("c5a2570a-5a0d-4e2f-a636-d54ecea94fc3"));

            migrationBuilder.AddColumn<Guid>(
                name: "EnderecoId",
                table: "Pessoas",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TelefoneId",
                table: "Pessoas",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Numero",
                table: "EnderecoPessoa",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.InsertData(
                table: "Enderecos",
                columns: new[] { "Id", "Bairro", "Cep", "Complemento", "Logradouro", "Municipio", "Numero", "uf" },
                values: new object[,]
                {
                    { new Guid("d2c25be2-d137-4545-80cb-d40bc41c3ad1"), "Centro", "20260525", "casa 23", "Rua Sete de Setembro", "Rio de Janeiro", "15", "RJ" },
                    { new Guid("178846ed-b269-48d1-b413-7f4aac828c59"), "Centro", "11260525", "bloco 6 ap 306", "Avenida Paulista", "São Paulo", "1205", "SP" },
                    { new Guid("92f6b75a-0004-4d04-bc13-f1b1722ed767"), "Bangu", "21280525", "casa 5", "Avenida Ministro Ary Franco", "Rio de Janeiro", "2255", "RJ" }
                });

            migrationBuilder.InsertData(
                table: "Pessoas",
                columns: new[] { "Id", "Cpf", "EnderecoId", "Nome", "Rg", "TelefoneId" },
                values: new object[,]
                {
                    { new Guid("808a421a-fad3-4c9d-9a6b-2b9955565a70"), "111548", null, "Herb Hancock", "21514151", null },
                    { new Guid("d0b6ac45-85ea-4f3b-b208-28846433e646"), "1252632545", null, "Chick Corea", "207255136", null },
                    { new Guid("528ee351-e73b-4f24-b920-9fe8cec4eaf9"), "111548", null, "Charlie Parker", "153526548", null }
                });

            migrationBuilder.InsertData(
                table: "Telefones",
                columns: new[] { "Id", "Numero", "Tipo" },
                values: new object[,]
                {
                    { new Guid("f1c9924f-1a43-4ce8-8114-3cde63623760"), "985635241", "Celular" },
                    { new Guid("286260f1-e6a4-4c76-a912-c6b395921ade"), "975859654", "Celular" },
                    { new Guid("9af8d178-ddcf-413b-ab24-f49735c18dbf"), "312524684", "Fixo" }
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: new Guid("178846ed-b269-48d1-b413-7f4aac828c59"));

            migrationBuilder.DeleteData(
                table: "Enderecos",
                keyColumn: "Id",
                keyValue: new Guid("92f6b75a-0004-4d04-bc13-f1b1722ed767"));

            migrationBuilder.DeleteData(
                table: "Enderecos",
                keyColumn: "Id",
                keyValue: new Guid("d2c25be2-d137-4545-80cb-d40bc41c3ad1"));

            migrationBuilder.DeleteData(
                table: "Pessoas",
                keyColumn: "Id",
                keyValue: new Guid("528ee351-e73b-4f24-b920-9fe8cec4eaf9"));

            migrationBuilder.DeleteData(
                table: "Pessoas",
                keyColumn: "Id",
                keyValue: new Guid("808a421a-fad3-4c9d-9a6b-2b9955565a70"));

            migrationBuilder.DeleteData(
                table: "Pessoas",
                keyColumn: "Id",
                keyValue: new Guid("d0b6ac45-85ea-4f3b-b208-28846433e646"));

            migrationBuilder.DeleteData(
                table: "Telefones",
                keyColumn: "Id",
                keyValue: new Guid("286260f1-e6a4-4c76-a912-c6b395921ade"));

            migrationBuilder.DeleteData(
                table: "Telefones",
                keyColumn: "Id",
                keyValue: new Guid("9af8d178-ddcf-413b-ab24-f49735c18dbf"));

            migrationBuilder.DeleteData(
                table: "Telefones",
                keyColumn: "Id",
                keyValue: new Guid("f1c9924f-1a43-4ce8-8114-3cde63623760"));

            migrationBuilder.DropColumn(
                name: "EnderecoId",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "TelefoneId",
                table: "Pessoas");

            migrationBuilder.AlterColumn<decimal>(
                name: "Numero",
                table: "EnderecoPessoa",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.InsertData(
                table: "Enderecos",
                columns: new[] { "Id", "Bairro", "Cep", "Complemento", "Logradouro", "Municipio", "Numero", "uf" },
                values: new object[,]
                {
                    { new Guid("62d6919d-73d3-4fa7-92b0-f2dcba69ee22"), "Centro", "20260525", "casa 23", "Rua Sete de Setembro", "Rio de Janeiro", "15", "RJ" },
                    { new Guid("1e12b298-fb8c-45de-96dd-3e0280edfc25"), "Centro", "11260525", "bloco 6 ap 306", "Avenida Paulista", "São Paulo", "1205", "SP" },
                    { new Guid("81bb69d7-881c-4a2c-871e-e8ce141cfa48"), "Bangu", "21280525", "casa 5", "Avenida Ministro Ary Franco", "Rio de Janeiro", "2255", "RJ" }
                });

            migrationBuilder.InsertData(
                table: "Pessoas",
                columns: new[] { "Id", "Cpf", "Nome", "Rg" },
                values: new object[,]
                {
                    { new Guid("54c45cf0-4f94-4faf-9f6e-9e4d377ee8c9"), "111548", "Herb Hancock", "21514151" },
                    { new Guid("9f114c06-0eca-4ac2-b730-9128eaf1074b"), "1252632545", "Chick Corea", "207255136" },
                    { new Guid("22334425-13f4-4537-b7da-69c55ecc819a"), "111548", "Charlie Parker", "153526548" }
                });

            migrationBuilder.InsertData(
                table: "Telefones",
                columns: new[] { "Id", "Numero", "Tipo" },
                values: new object[,]
                {
                    { new Guid("33f0d0de-4601-4bea-bd59-2a2f20749021"), "985635241", "Celular" },
                    { new Guid("c5a2570a-5a0d-4e2f-a636-d54ecea94fc3"), "975859654", "Celular" },
                    { new Guid("20f76c41-4e53-4e82-970f-43b396172189"), "312524684", "Fixo" }
                });
        }
    }
}

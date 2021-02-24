using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace crud_accounts.Migrations
{
    public partial class FKFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<decimal>(
                name: "Numero",
                table: "EnderecoPessoa",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "Numero",
                table: "EnderecoPessoa",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal));

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
        }
    }
}

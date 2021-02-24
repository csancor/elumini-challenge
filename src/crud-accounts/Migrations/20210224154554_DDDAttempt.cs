using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace crudAccounts.Migrations
{
    public partial class DDDAttempt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Enderecos",
                keyColumn: "Id",
                keyValue: new Guid("0dc5646e-d40d-47fb-8e46-858ed0c92c77"));

            migrationBuilder.DeleteData(
                table: "Enderecos",
                keyColumn: "Id",
                keyValue: new Guid("42c93df6-5dd4-4f53-9638-c5e2ae804ff3"));

            migrationBuilder.DeleteData(
                table: "Enderecos",
                keyColumn: "Id",
                keyValue: new Guid("65a751f9-a1b4-463a-aff7-e04291ca879d"));

            migrationBuilder.DeleteData(
                table: "Pessoas",
                keyColumn: "Id",
                keyValue: new Guid("17b27f89-096f-4277-9736-2a9924bd25f1"));

            migrationBuilder.DeleteData(
                table: "Pessoas",
                keyColumn: "Id",
                keyValue: new Guid("e236d793-1405-4898-b48a-9f0f3ae5c722"));

            migrationBuilder.DeleteData(
                table: "Pessoas",
                keyColumn: "Id",
                keyValue: new Guid("e6f2fd14-df75-474d-9fde-ce5d51ca12fe"));

            migrationBuilder.DeleteData(
                table: "Telefones",
                keyColumn: "Id",
                keyValue: new Guid("36e4c094-c773-4459-a571-2d3ebe14bab8"));

            migrationBuilder.DeleteData(
                table: "Telefones",
                keyColumn: "Id",
                keyValue: new Guid("5e519174-1db7-46cf-9e40-effe1c33ff3e"));

            migrationBuilder.DeleteData(
                table: "Telefones",
                keyColumn: "Id",
                keyValue: new Guid("b0c02e64-9847-4c6d-a583-713b981531ed"));

            migrationBuilder.InsertData(
                table: "Enderecos",
                columns: new[] { "Id", "Bairro", "Cep", "Complemento", "Logradouro", "Municipio", "Numero", "uf" },
                values: new object[,]
                {
                    { new Guid("8d86c8a7-ae56-4054-9887-91b44d9d91eb"), "Centro", "20260525", "casa 23", "Rua Sete de Setembro", "Rio de Janeiro", "15", "RJ" },
                    { new Guid("e7a63836-4d03-481b-954f-341e8019cac0"), "Centro", "11260525", "bloco 6 ap 306", "Avenida Paulista", "São Paulo", "1205", "SP" },
                    { new Guid("2fd4be26-b3e5-488a-a8f8-4aa8db628971"), "Bangu", "21280525", "casa 5", "Avenida Ministro Ary Franco", "Rio de Janeiro", "2255", "RJ" }
                });

            migrationBuilder.InsertData(
                table: "Pessoas",
                columns: new[] { "Id", "Cpf", "Nome", "Rg" },
                values: new object[,]
                {
                    { new Guid("d6e1b10c-3664-4edc-8bdb-5a777dcb9155"), "111548", "Herb Hancock", "21514151" },
                    { new Guid("b5d1ff7c-ab29-419b-86a2-18aac3b6a5e0"), "1252632545", "Chick Corea", "207255136" },
                    { new Guid("a82123cb-f661-4cf3-9870-39e911069543"), "111548", "Charlie Parker", "153526548" }
                });

            migrationBuilder.InsertData(
                table: "Telefones",
                columns: new[] { "Id", "Numero", "Tipo" },
                values: new object[,]
                {
                    { new Guid("b3899348-a40d-4c4a-ac93-f9bf2e78ac7a"), "985635241", "Celular" },
                    { new Guid("b6e02d24-4aa7-41b8-b3e0-dc9c183c11dd"), "975859654", "Celular" },
                    { new Guid("6175bf6c-dc01-47d7-9068-532c9f9ca596"), "312524684", "Fixo" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Enderecos",
                keyColumn: "Id",
                keyValue: new Guid("2fd4be26-b3e5-488a-a8f8-4aa8db628971"));

            migrationBuilder.DeleteData(
                table: "Enderecos",
                keyColumn: "Id",
                keyValue: new Guid("8d86c8a7-ae56-4054-9887-91b44d9d91eb"));

            migrationBuilder.DeleteData(
                table: "Enderecos",
                keyColumn: "Id",
                keyValue: new Guid("e7a63836-4d03-481b-954f-341e8019cac0"));

            migrationBuilder.DeleteData(
                table: "Pessoas",
                keyColumn: "Id",
                keyValue: new Guid("a82123cb-f661-4cf3-9870-39e911069543"));

            migrationBuilder.DeleteData(
                table: "Pessoas",
                keyColumn: "Id",
                keyValue: new Guid("b5d1ff7c-ab29-419b-86a2-18aac3b6a5e0"));

            migrationBuilder.DeleteData(
                table: "Pessoas",
                keyColumn: "Id",
                keyValue: new Guid("d6e1b10c-3664-4edc-8bdb-5a777dcb9155"));

            migrationBuilder.DeleteData(
                table: "Telefones",
                keyColumn: "Id",
                keyValue: new Guid("6175bf6c-dc01-47d7-9068-532c9f9ca596"));

            migrationBuilder.DeleteData(
                table: "Telefones",
                keyColumn: "Id",
                keyValue: new Guid("b3899348-a40d-4c4a-ac93-f9bf2e78ac7a"));

            migrationBuilder.DeleteData(
                table: "Telefones",
                keyColumn: "Id",
                keyValue: new Guid("b6e02d24-4aa7-41b8-b3e0-dc9c183c11dd"));

            migrationBuilder.InsertData(
                table: "Enderecos",
                columns: new[] { "Id", "Bairro", "Cep", "Complemento", "Logradouro", "Municipio", "Numero", "uf" },
                values: new object[,]
                {
                    { new Guid("0dc5646e-d40d-47fb-8e46-858ed0c92c77"), "Centro", "20260525", "casa 23", "Rua Sete de Setembro", "Rio de Janeiro", "15", "RJ" },
                    { new Guid("42c93df6-5dd4-4f53-9638-c5e2ae804ff3"), "Centro", "11260525", "bloco 6 ap 306", "Avenida Paulista", "São Paulo", "1205", "SP" },
                    { new Guid("65a751f9-a1b4-463a-aff7-e04291ca879d"), "Bangu", "21280525", "casa 5", "Avenida Ministro Ary Franco", "Rio de Janeiro", "2255", "RJ" }
                });

            migrationBuilder.InsertData(
                table: "Pessoas",
                columns: new[] { "Id", "Cpf", "Nome", "Rg" },
                values: new object[,]
                {
                    { new Guid("e236d793-1405-4898-b48a-9f0f3ae5c722"), "111548", "Herb Hancock", "21514151" },
                    { new Guid("17b27f89-096f-4277-9736-2a9924bd25f1"), "1252632545", "Chick Corea", "207255136" },
                    { new Guid("e6f2fd14-df75-474d-9fde-ce5d51ca12fe"), "111548", "Charlie Parker", "153526548" }
                });

            migrationBuilder.InsertData(
                table: "Telefones",
                columns: new[] { "Id", "Numero", "Tipo" },
                values: new object[,]
                {
                    { new Guid("b0c02e64-9847-4c6d-a583-713b981531ed"), "985635241", "Celular" },
                    { new Guid("36e4c094-c773-4459-a571-2d3ebe14bab8"), "975859654", "Celular" },
                    { new Guid("5e519174-1db7-46cf-9e40-effe1c33ff3e"), "312524684", "Fixo" }
                });
        }
    }
}

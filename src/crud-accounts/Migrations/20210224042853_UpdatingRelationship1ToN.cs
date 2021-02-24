using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace crud_accounts.Migrations
{
    public partial class UpdatingRelationship1ToN : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Enderecos",
                keyColumn: "Id",
                keyValue: new Guid("05d89a6b-b412-4a6b-b66c-62188d3f6d46"));

            migrationBuilder.DeleteData(
                table: "Enderecos",
                keyColumn: "Id",
                keyValue: new Guid("278a9af0-013f-4969-8e89-35f224c84ec1"));

            migrationBuilder.DeleteData(
                table: "Enderecos",
                keyColumn: "Id",
                keyValue: new Guid("423f9423-7cb6-46b8-bcb8-3156c5cacfd9"));

            migrationBuilder.DeleteData(
                table: "Pessoas",
                keyColumn: "Id",
                keyValue: new Guid("253720b2-071f-4736-8865-1cf767c8ef2a"));

            migrationBuilder.DeleteData(
                table: "Pessoas",
                keyColumn: "Id",
                keyValue: new Guid("6b224e01-558f-48f9-b020-a8dba297e3ae"));

            migrationBuilder.DeleteData(
                table: "Pessoas",
                keyColumn: "Id",
                keyValue: new Guid("9cd208e9-f889-4663-8053-e888be977d27"));

            migrationBuilder.DeleteData(
                table: "Telefones",
                keyColumn: "Id",
                keyValue: new Guid("32c17be6-ac5a-406b-b3e7-b8e7aca56aa1"));

            migrationBuilder.DeleteData(
                table: "Telefones",
                keyColumn: "Id",
                keyValue: new Guid("6d094974-98a3-440c-bd5b-b3efc5b9f9d5"));

            migrationBuilder.DeleteData(
                table: "Telefones",
                keyColumn: "Id",
                keyValue: new Guid("cf98921f-31ac-43b2-9021-6d30e5eda4e2"));

            migrationBuilder.InsertData(
                table: "Enderecos",
                columns: new[] { "Id", "Bairro", "Cep", "Complemento", "Logradouro", "Municipio", "Numero", "uf" },
                values: new object[,]
                {
                    { new Guid("ef13704e-529e-404a-be44-af1beabcd2e7"), "Centro", "20260525", "casa 23", "Rua Sete de Setembro", "Rio de Janeiro", "15", "RJ" },
                    { new Guid("4b62b5cb-298b-421e-aed8-5095def1107c"), "Centro", "11260525", "bloco 6 ap 306", "Avenida Paulista", "São Paulo", "1205", "SP" },
                    { new Guid("6306a51a-da84-4536-b6ba-2434eef98a62"), "Bangu", "21280525", "casa 5", "Avenida Ministro Ary Franco", "Rio de Janeiro", "2255", "RJ" }
                });

            migrationBuilder.InsertData(
                table: "Pessoas",
                columns: new[] { "Id", "Cpf", "Nome", "Rg" },
                values: new object[,]
                {
                    { new Guid("50b0558d-d9fa-46bc-b6a4-27f1bccea363"), "111548", "Herb Hancock", "21514151" },
                    { new Guid("45b28ca8-938f-4b16-b2de-780d255b7c44"), "1252632545", "Chick Corea", "207255136" },
                    { new Guid("ae6948bf-41c6-45c2-9c50-6a99f3eaeb8f"), "111548", "Charlie Parker", "153526548" }
                });

            migrationBuilder.InsertData(
                table: "Telefones",
                columns: new[] { "Id", "Numero", "Tipo" },
                values: new object[,]
                {
                    { new Guid("ca288b58-b155-4763-91bc-31409fa0098f"), "985635241", "Celular" },
                    { new Guid("fa79fb9a-7e91-4db8-b626-af61134909b2"), "975859654", "Celular" },
                    { new Guid("50d72c5b-d91c-4480-83da-e1cce9b9da04"), "312524684", "Fixo" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Enderecos",
                keyColumn: "Id",
                keyValue: new Guid("4b62b5cb-298b-421e-aed8-5095def1107c"));

            migrationBuilder.DeleteData(
                table: "Enderecos",
                keyColumn: "Id",
                keyValue: new Guid("6306a51a-da84-4536-b6ba-2434eef98a62"));

            migrationBuilder.DeleteData(
                table: "Enderecos",
                keyColumn: "Id",
                keyValue: new Guid("ef13704e-529e-404a-be44-af1beabcd2e7"));

            migrationBuilder.DeleteData(
                table: "Pessoas",
                keyColumn: "Id",
                keyValue: new Guid("45b28ca8-938f-4b16-b2de-780d255b7c44"));

            migrationBuilder.DeleteData(
                table: "Pessoas",
                keyColumn: "Id",
                keyValue: new Guid("50b0558d-d9fa-46bc-b6a4-27f1bccea363"));

            migrationBuilder.DeleteData(
                table: "Pessoas",
                keyColumn: "Id",
                keyValue: new Guid("ae6948bf-41c6-45c2-9c50-6a99f3eaeb8f"));

            migrationBuilder.DeleteData(
                table: "Telefones",
                keyColumn: "Id",
                keyValue: new Guid("50d72c5b-d91c-4480-83da-e1cce9b9da04"));

            migrationBuilder.DeleteData(
                table: "Telefones",
                keyColumn: "Id",
                keyValue: new Guid("ca288b58-b155-4763-91bc-31409fa0098f"));

            migrationBuilder.DeleteData(
                table: "Telefones",
                keyColumn: "Id",
                keyValue: new Guid("fa79fb9a-7e91-4db8-b626-af61134909b2"));

            migrationBuilder.InsertData(
                table: "Enderecos",
                columns: new[] { "Id", "Bairro", "Cep", "Complemento", "Logradouro", "Municipio", "Numero", "uf" },
                values: new object[,]
                {
                    { new Guid("278a9af0-013f-4969-8e89-35f224c84ec1"), "Centro", "20260525", "casa 23", "Rua Sete de Setembro", "Rio de Janeiro", "15", "RJ" },
                    { new Guid("423f9423-7cb6-46b8-bcb8-3156c5cacfd9"), "Centro", "11260525", "bloco 6 ap 306", "Avenida Paulista", "São Paulo", "1205", "SP" },
                    { new Guid("05d89a6b-b412-4a6b-b66c-62188d3f6d46"), "Bangu", "21280525", "casa 5", "Avenida Ministro Ary Franco", "Rio de Janeiro", "2255", "RJ" }
                });

            migrationBuilder.InsertData(
                table: "Pessoas",
                columns: new[] { "Id", "Cpf", "Nome", "Rg" },
                values: new object[,]
                {
                    { new Guid("9cd208e9-f889-4663-8053-e888be977d27"), "111548", "Herb Hancock", "21514151" },
                    { new Guid("6b224e01-558f-48f9-b020-a8dba297e3ae"), "1252632545", "Chick Corea", "207255136" },
                    { new Guid("253720b2-071f-4736-8865-1cf767c8ef2a"), "111548", "Charlie Parker", "153526548" }
                });

            migrationBuilder.InsertData(
                table: "Telefones",
                columns: new[] { "Id", "Numero", "Tipo" },
                values: new object[,]
                {
                    { new Guid("6d094974-98a3-440c-bd5b-b3efc5b9f9d5"), "985635241", "Celular" },
                    { new Guid("32c17be6-ac5a-406b-b3e7-b8e7aca56aa1"), "975859654", "Celular" },
                    { new Guid("cf98921f-31ac-43b2-9021-6d30e5eda4e2"), "312524684", "Fixo" }
                });
        }
    }
}

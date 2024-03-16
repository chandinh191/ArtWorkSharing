using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AWS_BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class secondinit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("2b13bc77-e8fb-42f2-90a1-2809b4d4862f"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("41386a78-4def-4b19-a72a-2e9a2982a515"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("6a2c80e6-2e37-4d14-b45a-9a5f8fa01589"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("9d109ace-3d7a-4d8a-8faa-c654a8664de9"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("a35b6db2-c3e9-44e6-9365-6e70aa136aa5"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("b22ed297-32cc-448e-868f-1589afd6fddc"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("c5d771b6-5865-4d93-9acf-18ad8618bee4"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("cd164bb7-fea6-4130-a46b-1b2b29d34cc5"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("fa0c5aaa-e320-4e1e-b82b-d01a0b2091e7"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("ffd4f8f8-ef3d-4c0f-81e9-6b5e8d641c9e"));

            migrationBuilder.DeleteData(
                table: "PackageDetails",
                keyColumn: "Id",
                keyValue: new Guid("85cf9e9b-d671-4afd-ac2a-8bb7bba9b81a"));

            migrationBuilder.DeleteData(
                table: "PackageDetails",
                keyColumn: "Id",
                keyValue: new Guid("86257e04-ec32-41ac-bc9c-f86747bff769"));

            migrationBuilder.DeleteData(
                table: "PackageDetails",
                keyColumn: "Id",
                keyValue: new Guid("b157598f-bb39-4f3a-bec1-33ac16a161ed"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("0d89dad3-b866-466f-8862-55b00aec82a5"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("1ecccaa0-5071-4c24-9bba-3b79d3de8a2a"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("886677d3-870b-4c73-ab7f-c80e6ccf924c"));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("1f35558f-a942-4837-81a4-720bae0e8bb1"),
                column: "Created",
                value: new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("26709dca-1906-4c50-a00e-1c63582ab644"),
                column: "Created",
                value: new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("7b76bf1f-d24c-4ac9-b466-4179e65605b2"),
                column: "Created",
                value: new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("8c44d5c8-a738-4b65-a88e-3ed38fce88c4"),
                column: "Created",
                value: new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("8e9acec5-54c9-4093-a450-19eb7b2109fb"),
                column: "Created",
                value: new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("9db314d0-6a55-492c-9a13-7ee6f2091cbf"),
                column: "Created",
                value: new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("a25e170e-7ddc-4bdc-9215-51c6fb9bcd96"),
                column: "Created",
                value: new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("b18dcaa1-d99a-4f15-a30c-5fd72c30280e"),
                column: "Created",
                value: new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("bd37c967-1817-495b-89eb-665c81b02d5e"),
                column: "Created",
                value: new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4653));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("d9d6b461-8efd-4395-8662-a58caa152200"),
                column: "Created",
                value: new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4664));

            migrationBuilder.InsertData(
                table: "ArtistAccount",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "UserAccountId" },
                values: new object[,]
                {
                    { new Guid("7e8027ba-2e73-4391-a971-d965bcef1216"), new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4517), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cg" },
                    { new Guid("83df969b-d585-412c-8b36-91ed342d0360"), new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4514), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cf" },
                    { new Guid("8da07c09-b31f-4b45-890c-f0e78ad504b3"), new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4524), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866ch" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cf",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f845d5ce-1bd3-4088-a5ea-7ef6a5f47235", "5c1bba25-3c6b-43c5-9281-828bf768c13f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cg",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4501c250-7033-44d9-8afa-b56aacdb7d1c", "cc983797-4e03-409b-b026-966716190b0c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866ch",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ddd254b9-e40b-4e5f-8526-98f09a68343a", "55c62358-7217-42d2-9fc2-a41af8231e9e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866ci",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "66d02e1f-436f-4ca6-aa1a-10003bdff324", "c9eefa6f-b77c-4963-824c-ceebae26f524" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cj",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4f0aa63d-60e5-4b4e-baa3-4c0b03e864c1", "899daf27-3853-47ca-aaba-33305e2fa2c4" });

            migrationBuilder.InsertData(
                table: "AudienceAccount",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "UserAccountId" },
                values: new object[,]
                {
                    { new Guid("92fe78b8-c98c-4a8e-958a-46a054413505"), new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4550), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866ci" },
                    { new Guid("ac8e7a1e-e480-451b-920e-9c543692db80"), new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4553), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cj" }
                });

            migrationBuilder.InsertData(
                table: "Interacts",
                columns: new[] { "Id", "ApplicationUserId", "ArtWorkID", "Comment", "Created", "CreatedBy", "Date", "IsDeleted", "IsLike", "LastModified", "LastModifiedBy" },
                values: new object[,]
                {
                    { new Guid("07a26cdd-ced7-43fe-ac22-928a90084dc2"), null, new Guid("9db314d0-6a55-492c-9a13-7ee6f2091cbf"), "Comment 9", new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4728), null, new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4729), false, true, null, null },
                    { new Guid("21f7105d-0323-48b5-9bb6-b7f12f48c5a1"), null, new Guid("1f35558f-a942-4837-81a4-720bae0e8bb1"), "Comment 8", new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4722), null, new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4723), false, true, null, null },
                    { new Guid("3604a2f4-d8bb-48dd-9790-75cc65aa27ec"), null, new Guid("b18dcaa1-d99a-4f15-a30c-5fd72c30280e"), "Comment 6", new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4715), null, new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4716), false, true, null, null },
                    { new Guid("69df4b23-2997-4e2b-91eb-b167fa92a951"), null, new Guid("7b76bf1f-d24c-4ac9-b466-4179e65605b2"), "Comment 4", new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4705), null, new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4706), false, true, null, null },
                    { new Guid("73ac74eb-f45e-4100-bfb9-d634b813c5db"), null, new Guid("8e9acec5-54c9-4093-a450-19eb7b2109fb"), "Comment 1", new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4691), null, new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4694), false, true, null, null },
                    { new Guid("7be956e9-67e9-4ff6-b44e-7caa56a4bbef"), null, new Guid("bd37c967-1817-495b-89eb-665c81b02d5e"), "Comment 7", new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4718), null, new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4720), false, true, null, null },
                    { new Guid("9aa97bd7-4d6a-45ee-a306-7b1e76c06edd"), null, new Guid("d9d6b461-8efd-4395-8662-a58caa152200"), "Comment 10", new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4731), null, new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4733), false, true, null, null },
                    { new Guid("a832a34c-b56b-44f1-8238-67d488491ff6"), null, new Guid("a25e170e-7ddc-4bdc-9215-51c6fb9bcd96"), "Comment 5", new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4711), null, new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4712), false, true, null, null },
                    { new Guid("b9bc604c-f2d1-4e9d-9b99-ca76ca63cc67"), null, new Guid("8c44d5c8-a738-4b65-a88e-3ed38fce88c4"), "Comment 3", new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4702), null, new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4703), false, true, null, null },
                    { new Guid("fbf53d92-1216-4441-ac41-cd2a61f61cba"), null, new Guid("26709dca-1906-4c50-a00e-1c63582ab644"), "Comment 2", new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4697), null, new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4699), false, true, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("871a809a-b3fa-495b-9cc2-c5d738a861cf"),
                column: "Created",
                value: new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4756));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("871a809a-b3fa-495b-9cc2-c5d738a862cf"),
                column: "Created",
                value: new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4760));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("871a809a-b3fa-495b-9cc2-c5d738a863cf"),
                column: "Created",
                value: new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4764));

            migrationBuilder.InsertData(
                table: "PackageDetails",
                columns: new[] { "Id", "ApplicationUserId", "Created", "CreatedBy", "EndDate", "IsDeleted", "LastModified", "LastModifiedBy", "PackageID", "PaymentMethodID", "StartDate", "UserAccountId" },
                values: new object[,]
                {
                    { new Guid("719f3036-fd0a-4eab-8632-8d6166bc94de"), null, new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4822), null, new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4821), false, null, null, new Guid("39b58807-f4b1-46bb-bdd2-597399a51c90"), new Guid("d3b9eb3f-8da2-40b2-8fd0-d0b09f287008"), new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4821), "871a809a-b3fa-495b-9cc2-c5d738a866cf" },
                    { new Guid("938dd76b-3e49-4df8-88b8-b3e6fd9c874f"), null, new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4827), null, new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4826), false, null, null, new Guid("a04d8c84-4698-4d73-a3cb-e1ce395d5bcf"), new Guid("d3b9eb3f-8da2-40b2-8fd0-d0b09f287008"), new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4826), "871a809a-b3fa-495b-9cc2-c5d738a866cf" },
                    { new Guid("beaa99a1-80ea-4c6a-83f5-9dc495073c5e"), null, new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4817), null, new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4816), false, null, null, new Guid("1ebe4b4b-e00b-4e82-b3be-418f58df9726"), new Guid("c466ed52-40d1-41a7-9a76-141526876859"), new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4816), "871a809a-b3fa-495b-9cc2-c5d738a866ch" }
                });

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("1ebe4b4b-e00b-4e82-b3be-418f58df9726"),
                column: "Created",
                value: new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4786));

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("39b58807-f4b1-46bb-bdd2-597399a51c90"),
                column: "Created",
                value: new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4792));

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("a04d8c84-4698-4d73-a3cb-e1ce395d5bcf"),
                column: "Created",
                value: new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("c466ed52-40d1-41a7-9a76-141526876859"),
                column: "Created",
                value: new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4845));

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("d3b9eb3f-8da2-40b2-8fd0-d0b09f287008"),
                column: "Created",
                value: new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4848));

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "IsDeleted", "LastModified", "LastModifiedBy", "OrderID", "Point" },
                values: new object[,]
                {
                    { new Guid("8be24e29-4f7e-4656-9c5f-9c8d15ffb1fe"), new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4899), null, "Description 2", false, null, null, new Guid("871a809a-b3fa-495b-9cc2-c5d738a862cf"), 4f },
                    { new Guid("e8950d94-4998-4e6c-8e52-1b0a4f4c588f"), new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4902), null, "Description 3", false, null, null, new Guid("871a809a-b3fa-495b-9cc2-c5d738a863cf"), 3f },
                    { new Guid("f0e3c2cb-682f-4021-962a-d5f07ab23cd2"), new DateTime(2024, 3, 16, 20, 33, 32, 760, DateTimeKind.Local).AddTicks(4895), null, "Description 1", false, null, null, new Guid("871a809a-b3fa-495b-9cc2-c5d738a861cf"), 5f }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArtistAccount",
                keyColumn: "Id",
                keyValue: new Guid("7e8027ba-2e73-4391-a971-d965bcef1216"));

            migrationBuilder.DeleteData(
                table: "ArtistAccount",
                keyColumn: "Id",
                keyValue: new Guid("83df969b-d585-412c-8b36-91ed342d0360"));

            migrationBuilder.DeleteData(
                table: "ArtistAccount",
                keyColumn: "Id",
                keyValue: new Guid("8da07c09-b31f-4b45-890c-f0e78ad504b3"));

            migrationBuilder.DeleteData(
                table: "AudienceAccount",
                keyColumn: "Id",
                keyValue: new Guid("92fe78b8-c98c-4a8e-958a-46a054413505"));

            migrationBuilder.DeleteData(
                table: "AudienceAccount",
                keyColumn: "Id",
                keyValue: new Guid("ac8e7a1e-e480-451b-920e-9c543692db80"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("07a26cdd-ced7-43fe-ac22-928a90084dc2"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("21f7105d-0323-48b5-9bb6-b7f12f48c5a1"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("3604a2f4-d8bb-48dd-9790-75cc65aa27ec"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("69df4b23-2997-4e2b-91eb-b167fa92a951"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("73ac74eb-f45e-4100-bfb9-d634b813c5db"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("7be956e9-67e9-4ff6-b44e-7caa56a4bbef"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("9aa97bd7-4d6a-45ee-a306-7b1e76c06edd"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("a832a34c-b56b-44f1-8238-67d488491ff6"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("b9bc604c-f2d1-4e9d-9b99-ca76ca63cc67"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("fbf53d92-1216-4441-ac41-cd2a61f61cba"));

            migrationBuilder.DeleteData(
                table: "PackageDetails",
                keyColumn: "Id",
                keyValue: new Guid("719f3036-fd0a-4eab-8632-8d6166bc94de"));

            migrationBuilder.DeleteData(
                table: "PackageDetails",
                keyColumn: "Id",
                keyValue: new Guid("938dd76b-3e49-4df8-88b8-b3e6fd9c874f"));

            migrationBuilder.DeleteData(
                table: "PackageDetails",
                keyColumn: "Id",
                keyValue: new Guid("beaa99a1-80ea-4c6a-83f5-9dc495073c5e"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("8be24e29-4f7e-4656-9c5f-9c8d15ffb1fe"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("e8950d94-4998-4e6c-8e52-1b0a4f4c588f"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("f0e3c2cb-682f-4021-962a-d5f07ab23cd2"));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("1f35558f-a942-4837-81a4-720bae0e8bb1"),
                column: "Created",
                value: new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("26709dca-1906-4c50-a00e-1c63582ab644"),
                column: "Created",
                value: new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2268));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("7b76bf1f-d24c-4ac9-b466-4179e65605b2"),
                column: "Created",
                value: new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2274));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("8c44d5c8-a738-4b65-a88e-3ed38fce88c4"),
                column: "Created",
                value: new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2271));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("8e9acec5-54c9-4093-a450-19eb7b2109fb"),
                column: "Created",
                value: new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("9db314d0-6a55-492c-9a13-7ee6f2091cbf"),
                column: "Created",
                value: new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2292));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("a25e170e-7ddc-4bdc-9215-51c6fb9bcd96"),
                column: "Created",
                value: new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2278));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("b18dcaa1-d99a-4f15-a30c-5fd72c30280e"),
                column: "Created",
                value: new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2281));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("bd37c967-1817-495b-89eb-665c81b02d5e"),
                column: "Created",
                value: new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2285));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("d9d6b461-8efd-4395-8662-a58caa152200"),
                column: "Created",
                value: new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2297));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cf",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c09ccb2b-aaf7-4254-9eb6-ef46611f2473", "e345fbe5-aab8-47d7-8dfe-dd04d3b23e79" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cg",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "22b48627-430d-4814-8b24-e69b2cde79f5", "06b86c88-9578-404a-9da9-0a6cf4e2d839" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866ch",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0969e3e7-8235-493a-aa1c-52262c7f4447", "d498bd36-f4ea-4a54-8d2b-f4fd3c54c8a0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866ci",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0c7ee9eb-494c-4a2b-a8c5-93d4ed2ae205", "9c3154c3-6081-494c-8a28-130d2cf1b2ef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cj",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b421bba5-da8a-4b67-b213-1e71c40c2483", "bcc79737-2356-4d0a-b3d9-034bb08f6ef8" });

            migrationBuilder.InsertData(
                table: "Interacts",
                columns: new[] { "Id", "ApplicationUserId", "ArtWorkID", "Comment", "Created", "CreatedBy", "Date", "IsDeleted", "IsLike", "LastModified", "LastModifiedBy" },
                values: new object[,]
                {
                    { new Guid("2b13bc77-e8fb-42f2-90a1-2809b4d4862f"), null, new Guid("bd37c967-1817-495b-89eb-665c81b02d5e"), "Comment 7", new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2348), null, new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2350), false, true, null, null },
                    { new Guid("41386a78-4def-4b19-a72a-2e9a2982a515"), null, new Guid("8c44d5c8-a738-4b65-a88e-3ed38fce88c4"), "Comment 3", new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2330), null, new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2332), false, true, null, null },
                    { new Guid("6a2c80e6-2e37-4d14-b45a-9a5f8fa01589"), null, new Guid("a25e170e-7ddc-4bdc-9215-51c6fb9bcd96"), "Comment 5", new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2340), null, new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2341), false, true, null, null },
                    { new Guid("9d109ace-3d7a-4d8a-8faa-c654a8664de9"), null, new Guid("26709dca-1906-4c50-a00e-1c63582ab644"), "Comment 2", new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2326), null, new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2328), false, true, null, null },
                    { new Guid("a35b6db2-c3e9-44e6-9365-6e70aa136aa5"), null, new Guid("9db314d0-6a55-492c-9a13-7ee6f2091cbf"), "Comment 9", new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2360), null, new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2362), false, true, null, null },
                    { new Guid("b22ed297-32cc-448e-868f-1589afd6fddc"), null, new Guid("b18dcaa1-d99a-4f15-a30c-5fd72c30280e"), "Comment 6", new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2344), null, new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2345), false, true, null, null },
                    { new Guid("c5d771b6-5865-4d93-9acf-18ad8618bee4"), null, new Guid("8e9acec5-54c9-4093-a450-19eb7b2109fb"), "Comment 1", new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2321), null, new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2323), false, true, null, null },
                    { new Guid("cd164bb7-fea6-4130-a46b-1b2b29d34cc5"), null, new Guid("d9d6b461-8efd-4395-8662-a58caa152200"), "Comment 10", new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2366), null, new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2367), false, true, null, null },
                    { new Guid("fa0c5aaa-e320-4e1e-b82b-d01a0b2091e7"), null, new Guid("7b76bf1f-d24c-4ac9-b466-4179e65605b2"), "Comment 4", new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2336), null, new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2337), false, true, null, null },
                    { new Guid("ffd4f8f8-ef3d-4c0f-81e9-6b5e8d641c9e"), null, new Guid("1f35558f-a942-4837-81a4-720bae0e8bb1"), "Comment 8", new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2355), null, new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2357), false, true, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("871a809a-b3fa-495b-9cc2-c5d738a861cf"),
                column: "Created",
                value: new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2428));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("871a809a-b3fa-495b-9cc2-c5d738a862cf"),
                column: "Created",
                value: new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("871a809a-b3fa-495b-9cc2-c5d738a863cf"),
                column: "Created",
                value: new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2435));

            migrationBuilder.InsertData(
                table: "PackageDetails",
                columns: new[] { "Id", "ApplicationUserId", "Created", "CreatedBy", "EndDate", "IsDeleted", "LastModified", "LastModifiedBy", "PackageID", "PaymentMethodID", "StartDate", "UserAccountId" },
                values: new object[,]
                {
                    { new Guid("85cf9e9b-d671-4afd-ac2a-8bb7bba9b81a"), null, new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2490), null, new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2489), false, null, null, new Guid("39b58807-f4b1-46bb-bdd2-597399a51c90"), new Guid("d3b9eb3f-8da2-40b2-8fd0-d0b09f287008"), new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2489), "871a809a-b3fa-495b-9cc2-c5d738a866cf" },
                    { new Guid("86257e04-ec32-41ac-bc9c-f86747bff769"), null, new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2485), null, new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2484), false, null, null, new Guid("1ebe4b4b-e00b-4e82-b3be-418f58df9726"), new Guid("c466ed52-40d1-41a7-9a76-141526876859"), new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2484), "871a809a-b3fa-495b-9cc2-c5d738a866ch" },
                    { new Guid("b157598f-bb39-4f3a-bec1-33ac16a161ed"), null, new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2496), null, new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2496), false, null, null, new Guid("a04d8c84-4698-4d73-a3cb-e1ce395d5bcf"), new Guid("d3b9eb3f-8da2-40b2-8fd0-d0b09f287008"), new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2496), "871a809a-b3fa-495b-9cc2-c5d738a866cf" }
                });

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("1ebe4b4b-e00b-4e82-b3be-418f58df9726"),
                column: "Created",
                value: new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2457));

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("39b58807-f4b1-46bb-bdd2-597399a51c90"),
                column: "Created",
                value: new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2461));

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("a04d8c84-4698-4d73-a3cb-e1ce395d5bcf"),
                column: "Created",
                value: new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2464));

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("c466ed52-40d1-41a7-9a76-141526876859"),
                column: "Created",
                value: new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2514));

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("d3b9eb3f-8da2-40b2-8fd0-d0b09f287008"),
                column: "Created",
                value: new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2517));

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "IsDeleted", "LastModified", "LastModifiedBy", "OrderID", "Point" },
                values: new object[,]
                {
                    { new Guid("0d89dad3-b866-466f-8862-55b00aec82a5"), new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2544), null, "Description 3", false, null, null, new Guid("871a809a-b3fa-495b-9cc2-c5d738a863cf"), 3f },
                    { new Guid("1ecccaa0-5071-4c24-9bba-3b79d3de8a2a"), new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2535), null, "Description 1", false, null, null, new Guid("871a809a-b3fa-495b-9cc2-c5d738a861cf"), 5f },
                    { new Guid("886677d3-870b-4c73-ab7f-c80e6ccf924c"), new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2539), null, "Description 2", false, null, null, new Guid("871a809a-b3fa-495b-9cc2-c5d738a862cf"), 4f }
                });
        }
    }
}

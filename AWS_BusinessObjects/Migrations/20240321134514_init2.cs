using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AWS_BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArtistAccount",
                keyColumn: "Id",
                keyValue: new Guid("3a7c7868-dde8-45e9-9702-f4e5d39f4ead"));

            migrationBuilder.DeleteData(
                table: "ArtistAccount",
                keyColumn: "Id",
                keyValue: new Guid("4f98c6ad-b87a-4197-85b8-c8527efb6240"));

            migrationBuilder.DeleteData(
                table: "ArtistAccount",
                keyColumn: "Id",
                keyValue: new Guid("797cae3c-817b-4365-97ea-2eeab8ba3486"));

            migrationBuilder.DeleteData(
                table: "AudienceAccount",
                keyColumn: "Id",
                keyValue: new Guid("0aeea278-445d-4746-a025-6ccb26f798dc"));

            migrationBuilder.DeleteData(
                table: "AudienceAccount",
                keyColumn: "Id",
                keyValue: new Guid("1f31a543-ca65-4a02-9d18-6bda4cd86243"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("66cd6199-a372-43d4-be3e-a5e46a34fb56"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("7695e96b-d1c8-45e2-b1ab-a3879eb8806c"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("7e423a54-b4d0-45a3-a6d9-cd3580f9cb51"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("84e20059-b5c2-40a6-9bae-af8f3a18f2da"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("8dc388a4-eb17-4f5d-b66d-28e9424db05f"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("bfa64fd2-cf6f-4d49-a186-663ea8f409fd"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("c8af4798-8ff1-4eb6-80dd-2ae1ea3e1da8"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("e0e5cb79-bdf5-4162-a57d-781e2a17e74c"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("fb8a1438-24ac-4ed7-ac79-743cc5713a68"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("ffcef4c6-beee-46b0-9f58-91d41c69a1b3"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("85280f51-c517-4da1-b10e-e9013ede236d"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("9756e7f3-0698-4c2f-bb35-c8a24b16479b"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("d11f2821-4a08-45e9-bf9a-1678f4776086"));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("1f35558f-a942-4837-81a4-720bae0e8bb1"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 20, 45, 13, 969, DateTimeKind.Local).AddTicks(7333));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("26709dca-1906-4c50-a00e-1c63582ab644"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 20, 45, 13, 969, DateTimeKind.Local).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("7b76bf1f-d24c-4ac9-b466-4179e65605b2"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 20, 45, 13, 969, DateTimeKind.Local).AddTicks(7315));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("8c44d5c8-a738-4b65-a88e-3ed38fce88c4"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 20, 45, 13, 969, DateTimeKind.Local).AddTicks(7311));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("8e9acec5-54c9-4093-a450-19eb7b2109fb"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 20, 45, 13, 969, DateTimeKind.Local).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("9db314d0-6a55-492c-9a13-7ee6f2091cbf"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 20, 45, 13, 969, DateTimeKind.Local).AddTicks(7337));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("a25e170e-7ddc-4bdc-9215-51c6fb9bcd96"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 20, 45, 13, 969, DateTimeKind.Local).AddTicks(7319));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("b18dcaa1-d99a-4f15-a30c-5fd72c30280e"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 20, 45, 13, 969, DateTimeKind.Local).AddTicks(7324));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("bd37c967-1817-495b-89eb-665c81b02d5e"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 20, 45, 13, 969, DateTimeKind.Local).AddTicks(7329));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("d9d6b461-8efd-4395-8662-a58caa152200"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 20, 45, 13, 969, DateTimeKind.Local).AddTicks(7343));

            migrationBuilder.InsertData(
                table: "ArtistAccount",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "UserAccountId" },
                values: new object[,]
                {
                    { new Guid("4b9619a5-13c6-43ad-af97-45c19e1ad2e6"), new DateTime(2024, 3, 21, 20, 45, 13, 969, DateTimeKind.Local).AddTicks(7260), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866ch" },
                    { new Guid("b7363edb-09c9-4273-ad4d-d245c4f93427"), new DateTime(2024, 3, 21, 20, 45, 13, 969, DateTimeKind.Local).AddTicks(7257), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cg" },
                    { new Guid("d1e6c5d1-d770-4f42-bb66-b1939a7c10d4"), new DateTime(2024, 3, 21, 20, 45, 13, 969, DateTimeKind.Local).AddTicks(7250), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cf" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cf",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a2af3e6d-f685-4ae5-9797-bdbf4576e13b", "98c403cf-7d42-463b-b92b-58627ed9ed69" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cg",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "900ac3ee-3dd9-49c8-a28b-3645bc52df96", "cb7f2ef4-34d5-43a1-8955-6d1d148f187c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866ch",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "528c05dd-9b1f-4b21-a4e6-b21564fae205", "b3b0073e-31c2-45b5-8110-27688e128975" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866ci",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ee18fdfe-8362-4b2b-817b-df19e37b60cb", "5f1e4c9e-db58-4ace-a8d4-95634f39ece0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cj",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "16fe96aa-e624-43d0-92c0-d212533a75ba", "d470581c-cd3e-4ebf-b52d-caf9f2aa3265" });

            migrationBuilder.InsertData(
                table: "AudienceAccount",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "UserAccountId" },
                values: new object[,]
                {
                    { new Guid("1d01d7b3-91d9-4d2b-a922-567f16780eba"), new DateTime(2024, 3, 21, 20, 45, 13, 969, DateTimeKind.Local).AddTicks(7277), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866ci" },
                    { new Guid("91b86083-8fff-4f1c-ab63-0a6f7d3ab564"), new DateTime(2024, 3, 21, 20, 45, 13, 969, DateTimeKind.Local).AddTicks(7281), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cj" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b1799e22-2212-43d2-a09a-6a0371f2d89c"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 20, 45, 13, 969, DateTimeKind.Local).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b3cb8ee0-c965-4970-8ef0-baad50ebf987"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 20, 45, 13, 969, DateTimeKind.Local).AddTicks(7029));

            migrationBuilder.InsertData(
                table: "Interacts",
                columns: new[] { "Id", "ApplicationUserId", "ArtWorkID", "Comment", "Created", "CreatedBy", "Date", "IsDeleted", "IsLike", "LastModified", "LastModifiedBy" },
                values: new object[,]
                {
                    { new Guid("087a7950-e27f-4de9-be0c-9e2b2c069af7"), null, new Guid("a25e170e-7ddc-4bdc-9215-51c6fb9bcd96"), "Comment 5", new DateTime(2024, 3, 21, 20, 45, 13, 969, DateTimeKind.Local).AddTicks(7417), null, new DateTime(2024, 3, 21, 20, 45, 13, 969, DateTimeKind.Local).AddTicks(7418), false, true, null, null },
                    { new Guid("18454367-8050-40ed-bbe1-da7b46393a05"), null, new Guid("8e9acec5-54c9-4093-a450-19eb7b2109fb"), "Comment 1", new DateTime(2024, 3, 21, 20, 45, 13, 969, DateTimeKind.Local).AddTicks(7399), null, new DateTime(2024, 3, 21, 20, 45, 13, 969, DateTimeKind.Local).AddTicks(7401), false, true, null, null },
                    { new Guid("41d740e4-2e3a-4a1b-ae74-a0b8bbae3781"), null, new Guid("bd37c967-1817-495b-89eb-665c81b02d5e"), "Comment 7", new DateTime(2024, 3, 21, 20, 45, 13, 969, DateTimeKind.Local).AddTicks(7425), null, new DateTime(2024, 3, 21, 20, 45, 13, 969, DateTimeKind.Local).AddTicks(7426), false, true, null, null },
                    { new Guid("47cecb57-85c3-4c45-9439-ce6100840261"), null, new Guid("9db314d0-6a55-492c-9a13-7ee6f2091cbf"), "Comment 9", new DateTime(2024, 3, 21, 20, 45, 13, 969, DateTimeKind.Local).AddTicks(7434), null, new DateTime(2024, 3, 21, 20, 45, 13, 969, DateTimeKind.Local).AddTicks(7435), false, true, null, null },
                    { new Guid("62f4cfe4-be5e-40d5-a0d6-e8cf540b7ebb"), null, new Guid("1f35558f-a942-4837-81a4-720bae0e8bb1"), "Comment 8", new DateTime(2024, 3, 21, 20, 45, 13, 969, DateTimeKind.Local).AddTicks(7430), null, new DateTime(2024, 3, 21, 20, 45, 13, 969, DateTimeKind.Local).AddTicks(7431), false, true, null, null },
                    { new Guid("84c834d6-b1fa-4e4a-aef0-19f7fd8acc0b"), null, new Guid("7b76bf1f-d24c-4ac9-b466-4179e65605b2"), "Comment 4", new DateTime(2024, 3, 21, 20, 45, 13, 969, DateTimeKind.Local).AddTicks(7413), null, new DateTime(2024, 3, 21, 20, 45, 13, 969, DateTimeKind.Local).AddTicks(7415), false, true, null, null },
                    { new Guid("982460db-74fa-4960-a12b-681b931c5271"), null, new Guid("26709dca-1906-4c50-a00e-1c63582ab644"), "Comment 2", new DateTime(2024, 3, 21, 20, 45, 13, 969, DateTimeKind.Local).AddTicks(7404), null, new DateTime(2024, 3, 21, 20, 45, 13, 969, DateTimeKind.Local).AddTicks(7405), false, true, null, null },
                    { new Guid("bd9c920b-fb57-4de2-980f-f247bf1950be"), null, new Guid("d9d6b461-8efd-4395-8662-a58caa152200"), "Comment 10", new DateTime(2024, 3, 21, 20, 45, 13, 969, DateTimeKind.Local).AddTicks(7438), null, new DateTime(2024, 3, 21, 20, 45, 13, 969, DateTimeKind.Local).AddTicks(7439), false, true, null, null },
                    { new Guid("cfb45b60-d9d4-408b-aaef-39f89b8b7ad4"), null, new Guid("8c44d5c8-a738-4b65-a88e-3ed38fce88c4"), "Comment 3", new DateTime(2024, 3, 21, 20, 45, 13, 969, DateTimeKind.Local).AddTicks(7408), null, new DateTime(2024, 3, 21, 20, 45, 13, 969, DateTimeKind.Local).AddTicks(7409), false, true, null, null },
                    { new Guid("df841c83-a5c1-43aa-a9c6-1a1f1623e0d6"), null, new Guid("b18dcaa1-d99a-4f15-a30c-5fd72c30280e"), "Comment 6", new DateTime(2024, 3, 21, 20, 45, 13, 969, DateTimeKind.Local).AddTicks(7421), null, new DateTime(2024, 3, 21, 20, 45, 13, 969, DateTimeKind.Local).AddTicks(7422), false, true, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("871a809a-b3fa-495b-9cc2-c5d738a861cf"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 20, 45, 13, 969, DateTimeKind.Local).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("871a809a-b3fa-495b-9cc2-c5d738a862cf"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 20, 45, 13, 969, DateTimeKind.Local).AddTicks(7464));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("871a809a-b3fa-495b-9cc2-c5d738a863cf"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 20, 45, 13, 969, DateTimeKind.Local).AddTicks(7467));

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "IsDeleted", "LastModified", "LastModifiedBy", "OrderID", "Point" },
                values: new object[,]
                {
                    { new Guid("27df8090-f679-4140-a881-82fd8b89e3c2"), new DateTime(2024, 3, 21, 20, 45, 13, 969, DateTimeKind.Local).AddTicks(7490), null, "Description 1", false, null, null, new Guid("871a809a-b3fa-495b-9cc2-c5d738a861cf"), 5f },
                    { new Guid("2d3a374b-1b77-4355-a0b4-b811e20c0407"), new DateTime(2024, 3, 21, 20, 45, 13, 969, DateTimeKind.Local).AddTicks(7497), null, "Description 3", false, null, null, new Guid("871a809a-b3fa-495b-9cc2-c5d738a863cf"), 3f },
                    { new Guid("c73f33fe-29ee-481c-9359-a76c9fdbc39e"), new DateTime(2024, 3, 21, 20, 45, 13, 969, DateTimeKind.Local).AddTicks(7493), null, "Description 2", false, null, null, new Guid("871a809a-b3fa-495b-9cc2-c5d738a862cf"), 4f }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArtistAccount",
                keyColumn: "Id",
                keyValue: new Guid("4b9619a5-13c6-43ad-af97-45c19e1ad2e6"));

            migrationBuilder.DeleteData(
                table: "ArtistAccount",
                keyColumn: "Id",
                keyValue: new Guid("b7363edb-09c9-4273-ad4d-d245c4f93427"));

            migrationBuilder.DeleteData(
                table: "ArtistAccount",
                keyColumn: "Id",
                keyValue: new Guid("d1e6c5d1-d770-4f42-bb66-b1939a7c10d4"));

            migrationBuilder.DeleteData(
                table: "AudienceAccount",
                keyColumn: "Id",
                keyValue: new Guid("1d01d7b3-91d9-4d2b-a922-567f16780eba"));

            migrationBuilder.DeleteData(
                table: "AudienceAccount",
                keyColumn: "Id",
                keyValue: new Guid("91b86083-8fff-4f1c-ab63-0a6f7d3ab564"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("087a7950-e27f-4de9-be0c-9e2b2c069af7"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("18454367-8050-40ed-bbe1-da7b46393a05"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("41d740e4-2e3a-4a1b-ae74-a0b8bbae3781"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("47cecb57-85c3-4c45-9439-ce6100840261"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("62f4cfe4-be5e-40d5-a0d6-e8cf540b7ebb"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("84c834d6-b1fa-4e4a-aef0-19f7fd8acc0b"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("982460db-74fa-4960-a12b-681b931c5271"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("bd9c920b-fb57-4de2-980f-f247bf1950be"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("cfb45b60-d9d4-408b-aaef-39f89b8b7ad4"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("df841c83-a5c1-43aa-a9c6-1a1f1623e0d6"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("27df8090-f679-4140-a881-82fd8b89e3c2"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("2d3a374b-1b77-4355-a0b4-b811e20c0407"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("c73f33fe-29ee-481c-9359-a76c9fdbc39e"));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("1f35558f-a942-4837-81a4-720bae0e8bb1"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 20, 38, 44, 327, DateTimeKind.Local).AddTicks(43));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("26709dca-1906-4c50-a00e-1c63582ab644"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 20, 38, 44, 327, DateTimeKind.Local).AddTicks(9));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("7b76bf1f-d24c-4ac9-b466-4179e65605b2"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 20, 38, 44, 327, DateTimeKind.Local).AddTicks(22));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("8c44d5c8-a738-4b65-a88e-3ed38fce88c4"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 20, 38, 44, 327, DateTimeKind.Local).AddTicks(14));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("8e9acec5-54c9-4093-a450-19eb7b2109fb"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 20, 38, 44, 327, DateTimeKind.Local).AddTicks(3));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("9db314d0-6a55-492c-9a13-7ee6f2091cbf"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 20, 38, 44, 327, DateTimeKind.Local).AddTicks(49));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("a25e170e-7ddc-4bdc-9215-51c6fb9bcd96"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 20, 38, 44, 327, DateTimeKind.Local).AddTicks(27));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("b18dcaa1-d99a-4f15-a30c-5fd72c30280e"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 20, 38, 44, 327, DateTimeKind.Local).AddTicks(33));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("bd37c967-1817-495b-89eb-665c81b02d5e"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 20, 38, 44, 327, DateTimeKind.Local).AddTicks(38));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("d9d6b461-8efd-4395-8662-a58caa152200"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 20, 38, 44, 327, DateTimeKind.Local).AddTicks(54));

            migrationBuilder.InsertData(
                table: "ArtistAccount",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "UserAccountId" },
                values: new object[,]
                {
                    { new Guid("3a7c7868-dde8-45e9-9702-f4e5d39f4ead"), new DateTime(2024, 3, 21, 20, 38, 44, 326, DateTimeKind.Local).AddTicks(9956), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866ch" },
                    { new Guid("4f98c6ad-b87a-4197-85b8-c8527efb6240"), new DateTime(2024, 3, 21, 20, 38, 44, 326, DateTimeKind.Local).AddTicks(9950), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cf" },
                    { new Guid("797cae3c-817b-4365-97ea-2eeab8ba3486"), new DateTime(2024, 3, 21, 20, 38, 44, 326, DateTimeKind.Local).AddTicks(9953), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cg" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cf",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "beedfc04-02a7-410d-9f1b-71f21eb9cc2b", "0b48aed8-45dc-4d01-b22a-d81aa12bc1e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cg",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "12913fde-8a53-4c42-8358-4e1ecc37db25", "0a010b27-b000-40e4-9183-c1e40fe8c18d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866ch",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5644e969-b2b9-46d0-ac3a-e2da59727bca", "87cc657c-2bea-43d7-9c31-cf467135a7ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866ci",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cdee8d47-0768-46ec-9109-431bc8e045f6", "39b5940b-4129-4fa6-b970-12f085f8709c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cj",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "af5901f8-75e1-4dc8-946c-bcbc7d5c5ca2", "730e2043-aea1-4472-ad3e-eaab16d91c27" });

            migrationBuilder.InsertData(
                table: "AudienceAccount",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "UserAccountId" },
                values: new object[,]
                {
                    { new Guid("0aeea278-445d-4746-a025-6ccb26f798dc"), new DateTime(2024, 3, 21, 20, 38, 44, 326, DateTimeKind.Local).AddTicks(9980), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cj" },
                    { new Guid("1f31a543-ca65-4a02-9d18-6bda4cd86243"), new DateTime(2024, 3, 21, 20, 38, 44, 326, DateTimeKind.Local).AddTicks(9977), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866ci" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b1799e22-2212-43d2-a09a-6a0371f2d89c"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 20, 38, 44, 326, DateTimeKind.Local).AddTicks(9602));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b3cb8ee0-c965-4970-8ef0-baad50ebf987"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 20, 38, 44, 326, DateTimeKind.Local).AddTicks(9630));

            migrationBuilder.InsertData(
                table: "Interacts",
                columns: new[] { "Id", "ApplicationUserId", "ArtWorkID", "Comment", "Created", "CreatedBy", "Date", "IsDeleted", "IsLike", "LastModified", "LastModifiedBy" },
                values: new object[,]
                {
                    { new Guid("66cd6199-a372-43d4-be3e-a5e46a34fb56"), null, new Guid("9db314d0-6a55-492c-9a13-7ee6f2091cbf"), "Comment 9", new DateTime(2024, 3, 21, 20, 38, 44, 327, DateTimeKind.Local).AddTicks(117), null, new DateTime(2024, 3, 21, 20, 38, 44, 327, DateTimeKind.Local).AddTicks(118), false, true, null, null },
                    { new Guid("7695e96b-d1c8-45e2-b1ab-a3879eb8806c"), null, new Guid("8c44d5c8-a738-4b65-a88e-3ed38fce88c4"), "Comment 3", new DateTime(2024, 3, 21, 20, 38, 44, 327, DateTimeKind.Local).AddTicks(90), null, new DateTime(2024, 3, 21, 20, 38, 44, 327, DateTimeKind.Local).AddTicks(91), false, true, null, null },
                    { new Guid("7e423a54-b4d0-45a3-a6d9-cd3580f9cb51"), null, new Guid("bd37c967-1817-495b-89eb-665c81b02d5e"), "Comment 7", new DateTime(2024, 3, 21, 20, 38, 44, 327, DateTimeKind.Local).AddTicks(108), null, new DateTime(2024, 3, 21, 20, 38, 44, 327, DateTimeKind.Local).AddTicks(110), false, true, null, null },
                    { new Guid("84e20059-b5c2-40a6-9bae-af8f3a18f2da"), null, new Guid("8e9acec5-54c9-4093-a450-19eb7b2109fb"), "Comment 1", new DateTime(2024, 3, 21, 20, 38, 44, 327, DateTimeKind.Local).AddTicks(78), null, new DateTime(2024, 3, 21, 20, 38, 44, 327, DateTimeKind.Local).AddTicks(80), false, true, null, null },
                    { new Guid("8dc388a4-eb17-4f5d-b66d-28e9424db05f"), null, new Guid("d9d6b461-8efd-4395-8662-a58caa152200"), "Comment 10", new DateTime(2024, 3, 21, 20, 38, 44, 327, DateTimeKind.Local).AddTicks(122), null, new DateTime(2024, 3, 21, 20, 38, 44, 327, DateTimeKind.Local).AddTicks(124), false, true, null, null },
                    { new Guid("bfa64fd2-cf6f-4d49-a186-663ea8f409fd"), null, new Guid("a25e170e-7ddc-4bdc-9215-51c6fb9bcd96"), "Comment 5", new DateTime(2024, 3, 21, 20, 38, 44, 327, DateTimeKind.Local).AddTicks(98), null, new DateTime(2024, 3, 21, 20, 38, 44, 327, DateTimeKind.Local).AddTicks(100), false, true, null, null },
                    { new Guid("c8af4798-8ff1-4eb6-80dd-2ae1ea3e1da8"), null, new Guid("7b76bf1f-d24c-4ac9-b466-4179e65605b2"), "Comment 4", new DateTime(2024, 3, 21, 20, 38, 44, 327, DateTimeKind.Local).AddTicks(94), null, new DateTime(2024, 3, 21, 20, 38, 44, 327, DateTimeKind.Local).AddTicks(95), false, true, null, null },
                    { new Guid("e0e5cb79-bdf5-4162-a57d-781e2a17e74c"), null, new Guid("26709dca-1906-4c50-a00e-1c63582ab644"), "Comment 2", new DateTime(2024, 3, 21, 20, 38, 44, 327, DateTimeKind.Local).AddTicks(85), null, new DateTime(2024, 3, 21, 20, 38, 44, 327, DateTimeKind.Local).AddTicks(86), false, true, null, null },
                    { new Guid("fb8a1438-24ac-4ed7-ac79-743cc5713a68"), null, new Guid("1f35558f-a942-4837-81a4-720bae0e8bb1"), "Comment 8", new DateTime(2024, 3, 21, 20, 38, 44, 327, DateTimeKind.Local).AddTicks(112), null, new DateTime(2024, 3, 21, 20, 38, 44, 327, DateTimeKind.Local).AddTicks(114), false, true, null, null },
                    { new Guid("ffcef4c6-beee-46b0-9f58-91d41c69a1b3"), null, new Guid("b18dcaa1-d99a-4f15-a30c-5fd72c30280e"), "Comment 6", new DateTime(2024, 3, 21, 20, 38, 44, 327, DateTimeKind.Local).AddTicks(104), null, new DateTime(2024, 3, 21, 20, 38, 44, 327, DateTimeKind.Local).AddTicks(105), false, true, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("871a809a-b3fa-495b-9cc2-c5d738a861cf"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 20, 38, 44, 327, DateTimeKind.Local).AddTicks(148));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("871a809a-b3fa-495b-9cc2-c5d738a862cf"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 20, 38, 44, 327, DateTimeKind.Local).AddTicks(152));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("871a809a-b3fa-495b-9cc2-c5d738a863cf"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 20, 38, 44, 327, DateTimeKind.Local).AddTicks(156));

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "IsDeleted", "LastModified", "LastModifiedBy", "OrderID", "Point" },
                values: new object[,]
                {
                    { new Guid("85280f51-c517-4da1-b10e-e9013ede236d"), new DateTime(2024, 3, 21, 20, 38, 44, 327, DateTimeKind.Local).AddTicks(216), null, "Description 1", false, null, null, new Guid("871a809a-b3fa-495b-9cc2-c5d738a861cf"), 5f },
                    { new Guid("9756e7f3-0698-4c2f-bb35-c8a24b16479b"), new DateTime(2024, 3, 21, 20, 38, 44, 327, DateTimeKind.Local).AddTicks(219), null, "Description 2", false, null, null, new Guid("871a809a-b3fa-495b-9cc2-c5d738a862cf"), 4f },
                    { new Guid("d11f2821-4a08-45e9-bf9a-1678f4776086"), new DateTime(2024, 3, 21, 20, 38, 44, 327, DateTimeKind.Local).AddTicks(225), null, "Description 3", false, null, null, new Guid("871a809a-b3fa-495b-9cc2-c5d738a863cf"), 3f }
                });
        }
    }
}

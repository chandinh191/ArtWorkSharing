using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AWS_BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class seeding_db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(912));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("26709dca-1906-4c50-a00e-1c63582ab644"),
                column: "Created",
                value: new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("7b76bf1f-d24c-4ac9-b466-4179e65605b2"),
                column: "Created",
                value: new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(895));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("8c44d5c8-a738-4b65-a88e-3ed38fce88c4"),
                column: "Created",
                value: new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(888));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("8e9acec5-54c9-4093-a450-19eb7b2109fb"),
                column: "Created",
                value: new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("9db314d0-6a55-492c-9a13-7ee6f2091cbf"),
                column: "Created",
                value: new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(917));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("a25e170e-7ddc-4bdc-9215-51c6fb9bcd96"),
                column: "Created",
                value: new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(899));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("b18dcaa1-d99a-4f15-a30c-5fd72c30280e"),
                column: "Created",
                value: new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(903));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("bd37c967-1817-495b-89eb-665c81b02d5e"),
                column: "Created",
                value: new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(908));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("d9d6b461-8efd-4395-8662-a58caa152200"),
                column: "Created",
                value: new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(922));

            migrationBuilder.InsertData(
                table: "ArtistAccount",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "UserAccountId" },
                values: new object[,]
                {
                    { new Guid("040549f1-d4aa-4d80-a53d-8c77863ba438"), new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(827), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866ch" },
                    { new Guid("7fff879a-ed0e-4b55-b95b-f5a3708050e8"), new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(761), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cf" },
                    { new Guid("96b200a0-7357-4921-be6b-eef7f3df1209"), new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(822), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cg" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cf",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0c7a9d74-28d1-4eeb-a73e-a8c0319b60ed", "62fed945-76ee-4062-9be4-6611bc773fa4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cg",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e3ba77f7-c90c-414f-a7b7-e62ac4557e95", "4801b023-725c-4d82-8dc1-df68967c4994" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866ch",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9efdffe6-127c-480b-b3c5-1c0ffb7a7fc0", "9385b0ed-fdc5-4fe7-80e1-f18d4992ef71" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866ci",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ddf5d303-d463-4658-9405-9f4e68dae966", "6bc0a748-addf-413c-83fd-295eae9a5dda" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cj",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "02f8efef-6137-4e84-9ca6-25a8fa871c42", "f64e18dc-cdc5-46a6-88de-745e48b83743" });

            migrationBuilder.InsertData(
                table: "AudienceAccount",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "UserAccountId" },
                values: new object[,]
                {
                    { new Guid("379d9adf-6e7b-468d-90bd-637b2f4aac68"), new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(853), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cj" },
                    { new Guid("d2886663-f54e-4815-9fb9-c2b3cd50eb14"), new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(850), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866ci" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b1799e22-2212-43d2-a09a-6a0371f2d89c"),
                columns: new[] { "CategoryName", "Created", "Description" },
                values: new object[] { "Category 1", new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(438), "Description Category 1" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b3cb8ee0-c965-4970-8ef0-baad50ebf987"),
                columns: new[] { "CategoryName", "Created", "Description" },
                values: new object[] { "Category 2", new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(468), "Description Category 2" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "Created", "CreatedBy", "Description", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[,]
                {
                    { new Guid("26b5fcea-c9cb-4c7c-ad93-100a6d8611d6"), "Category 6", new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(494), null, "Description Category 6", false, null, null },
                    { new Guid("53b50d7f-44eb-4dda-84b1-9d3c938eba22"), "Category 3", new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(483), null, "Description Category 3", false, null, null },
                    { new Guid("58c96dfc-1c31-429b-9c6c-378db1c68b2a"), "Category 4", new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(486), null, "Description Category 4", false, null, null },
                    { new Guid("5d935698-bc0f-4692-88a3-43234943be40"), "Category 5", new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(488), null, "Description Category 5", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Interacts",
                columns: new[] { "Id", "ApplicationUserId", "ArtWorkID", "Comment", "Created", "CreatedBy", "Date", "IsDeleted", "IsLike", "LastModified", "LastModifiedBy" },
                values: new object[,]
                {
                    { new Guid("12c72def-2519-4210-82a1-f42e9687525c"), null, new Guid("d9d6b461-8efd-4395-8662-a58caa152200"), "Comment 10", new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(991), null, new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(992), false, true, null, null },
                    { new Guid("14aa5da1-fa34-4f8c-b98a-f84c6909b72c"), null, new Guid("1f35558f-a942-4837-81a4-720bae0e8bb1"), "Comment 8", new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(982), null, new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(983), false, true, null, null },
                    { new Guid("438dd4b1-7f3a-4630-861f-6ef3a864df76"), null, new Guid("7b76bf1f-d24c-4ac9-b466-4179e65605b2"), "Comment 4", new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(962), null, new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(963), false, true, null, null },
                    { new Guid("64098bc2-f360-49cf-bf41-c7ad4f619e38"), null, new Guid("bd37c967-1817-495b-89eb-665c81b02d5e"), "Comment 7", new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(978), null, new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(979), false, true, null, null },
                    { new Guid("93f2aa40-a8a3-4687-b482-a885cea67e82"), null, new Guid("a25e170e-7ddc-4bdc-9215-51c6fb9bcd96"), "Comment 5", new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(967), null, new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(969), false, true, null, null },
                    { new Guid("a1fb9bad-7547-46fd-a8bd-b1dca0a132a3"), null, new Guid("9db314d0-6a55-492c-9a13-7ee6f2091cbf"), "Comment 9", new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(987), null, new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(989), false, true, null, null },
                    { new Guid("b051932a-57d9-4b48-9d09-2ce04fafdc87"), null, new Guid("26709dca-1906-4c50-a00e-1c63582ab644"), "Comment 2", new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(951), null, new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(953), false, true, null, null },
                    { new Guid("caf1849a-3041-45b9-98d4-28e65124753b"), null, new Guid("8c44d5c8-a738-4b65-a88e-3ed38fce88c4"), "Comment 3", new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(958), null, new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(959), false, true, null, null },
                    { new Guid("e7ab499b-e646-4984-8207-35aa1a3397ce"), null, new Guid("8e9acec5-54c9-4093-a450-19eb7b2109fb"), "Comment 1", new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(946), null, new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(948), false, true, null, null },
                    { new Guid("f4479804-4f82-4ce5-a5ac-eba754b8b433"), null, new Guid("b18dcaa1-d99a-4f15-a30c-5fd72c30280e"), "Comment 6", new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(974), null, new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(975), false, true, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("871a809a-b3fa-495b-9cc2-c5d738a861cf"),
                column: "Created",
                value: new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(1013));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("871a809a-b3fa-495b-9cc2-c5d738a862cf"),
                column: "Created",
                value: new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(1016));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("871a809a-b3fa-495b-9cc2-c5d738a863cf"),
                column: "Created",
                value: new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(1019));

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "IsDeleted", "LastModified", "LastModifiedBy", "OrderID", "Point" },
                values: new object[,]
                {
                    { new Guid("086f9e91-1d1e-4299-a155-285c218c1592"), new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(1038), null, "Description 1", false, null, null, new Guid("871a809a-b3fa-495b-9cc2-c5d738a861cf"), 5f },
                    { new Guid("4fae8a30-3fbe-43fb-b269-d8e6ddd78f75"), new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(1047), null, "Description 3", false, null, null, new Guid("871a809a-b3fa-495b-9cc2-c5d738a863cf"), 3f },
                    { new Guid("838f5203-a3c5-4d41-9f81-f2844d233472"), new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(1043), null, "Description 2", false, null, null, new Guid("871a809a-b3fa-495b-9cc2-c5d738a862cf"), 4f }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArtistAccount",
                keyColumn: "Id",
                keyValue: new Guid("040549f1-d4aa-4d80-a53d-8c77863ba438"));

            migrationBuilder.DeleteData(
                table: "ArtistAccount",
                keyColumn: "Id",
                keyValue: new Guid("7fff879a-ed0e-4b55-b95b-f5a3708050e8"));

            migrationBuilder.DeleteData(
                table: "ArtistAccount",
                keyColumn: "Id",
                keyValue: new Guid("96b200a0-7357-4921-be6b-eef7f3df1209"));

            migrationBuilder.DeleteData(
                table: "AudienceAccount",
                keyColumn: "Id",
                keyValue: new Guid("379d9adf-6e7b-468d-90bd-637b2f4aac68"));

            migrationBuilder.DeleteData(
                table: "AudienceAccount",
                keyColumn: "Id",
                keyValue: new Guid("d2886663-f54e-4815-9fb9-c2b3cd50eb14"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("26b5fcea-c9cb-4c7c-ad93-100a6d8611d6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("53b50d7f-44eb-4dda-84b1-9d3c938eba22"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("58c96dfc-1c31-429b-9c6c-378db1c68b2a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5d935698-bc0f-4692-88a3-43234943be40"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("12c72def-2519-4210-82a1-f42e9687525c"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("14aa5da1-fa34-4f8c-b98a-f84c6909b72c"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("438dd4b1-7f3a-4630-861f-6ef3a864df76"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("64098bc2-f360-49cf-bf41-c7ad4f619e38"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("93f2aa40-a8a3-4687-b482-a885cea67e82"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("a1fb9bad-7547-46fd-a8bd-b1dca0a132a3"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("b051932a-57d9-4b48-9d09-2ce04fafdc87"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("caf1849a-3041-45b9-98d4-28e65124753b"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("e7ab499b-e646-4984-8207-35aa1a3397ce"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("f4479804-4f82-4ce5-a5ac-eba754b8b433"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("086f9e91-1d1e-4299-a155-285c218c1592"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("4fae8a30-3fbe-43fb-b269-d8e6ddd78f75"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("838f5203-a3c5-4d41-9f81-f2844d233472"));

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
                columns: new[] { "CategoryName", "Created", "Description" },
                values: new object[] { "Category1", new DateTime(2024, 3, 21, 20, 45, 13, 969, DateTimeKind.Local).AddTicks(6995), "Description Category1" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b3cb8ee0-c965-4970-8ef0-baad50ebf987"),
                columns: new[] { "CategoryName", "Created", "Description" },
                values: new object[] { "Category2", new DateTime(2024, 3, 21, 20, 45, 13, 969, DateTimeKind.Local).AddTicks(7029), "Description Category2" });

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
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AWS_BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "isPreOrder",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("1f35558f-a942-4837-81a4-720bae0e8bb1"),
                column: "Created",
                value: new DateTime(2024, 3, 26, 2, 8, 39, 666, DateTimeKind.Local).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("26709dca-1906-4c50-a00e-1c63582ab644"),
                column: "Created",
                value: new DateTime(2024, 3, 26, 2, 8, 39, 666, DateTimeKind.Local).AddTicks(8988));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("7b76bf1f-d24c-4ac9-b466-4179e65605b2"),
                column: "Created",
                value: new DateTime(2024, 3, 26, 2, 8, 39, 666, DateTimeKind.Local).AddTicks(8998));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("8c44d5c8-a738-4b65-a88e-3ed38fce88c4"),
                column: "Created",
                value: new DateTime(2024, 3, 26, 2, 8, 39, 666, DateTimeKind.Local).AddTicks(8993));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("8e9acec5-54c9-4093-a450-19eb7b2109fb"),
                column: "Created",
                value: new DateTime(2024, 3, 26, 2, 8, 39, 666, DateTimeKind.Local).AddTicks(8980));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("9db314d0-6a55-492c-9a13-7ee6f2091cbf"),
                column: "Created",
                value: new DateTime(2024, 3, 26, 2, 8, 39, 666, DateTimeKind.Local).AddTicks(9037));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("a25e170e-7ddc-4bdc-9215-51c6fb9bcd96"),
                column: "Created",
                value: new DateTime(2024, 3, 26, 2, 8, 39, 666, DateTimeKind.Local).AddTicks(9003));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("b18dcaa1-d99a-4f15-a30c-5fd72c30280e"),
                column: "Created",
                value: new DateTime(2024, 3, 26, 2, 8, 39, 666, DateTimeKind.Local).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("bd37c967-1817-495b-89eb-665c81b02d5e"),
                column: "Created",
                value: new DateTime(2024, 3, 26, 2, 8, 39, 666, DateTimeKind.Local).AddTicks(9018));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("d9d6b461-8efd-4395-8662-a58caa152200"),
                column: "Created",
                value: new DateTime(2024, 3, 26, 2, 8, 39, 666, DateTimeKind.Local).AddTicks(9045));

            migrationBuilder.InsertData(
                table: "ArtistAccount",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "UserAccountId" },
                values: new object[,]
                {
                    { new Guid("a0d562ff-2388-4407-900c-d17426928671"), new DateTime(2024, 3, 26, 2, 8, 39, 666, DateTimeKind.Local).AddTicks(8918), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866ch" },
                    { new Guid("b42897f6-1944-4a57-88d6-eaac5427d109"), new DateTime(2024, 3, 26, 2, 8, 39, 666, DateTimeKind.Local).AddTicks(8915), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cg" },
                    { new Guid("d8040da4-d968-45f7-b336-49e31428d18c"), new DateTime(2024, 3, 26, 2, 8, 39, 666, DateTimeKind.Local).AddTicks(8908), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cf" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cf",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e4acb912-9ca3-40e1-a205-eb58f3640db4", "fe88f797-2499-49b7-a6f9-1d336606ae3d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cg",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f58a7120-3fe4-49ab-b7f1-9aea68ccc34a", "f1b96ce7-7706-4b3b-a279-25780469337e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866ch",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "912bcad7-59f3-4acc-b340-ccb07cde32a8", "927efc28-3c95-4561-9747-4d5bae858e11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866ci",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "49368ebb-ab07-4b9c-97de-d2471e4b6a68", "d6b793c1-8cd0-4e30-9254-142722d39658" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cj",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "86caee09-312f-4350-8d00-911a192e68d9", "b36514d2-e94a-49a6-ad0e-22996601c853" });

            migrationBuilder.InsertData(
                table: "AudienceAccount",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "UserAccountId" },
                values: new object[,]
                {
                    { new Guid("5b881eb8-13c7-459d-b615-a68e6cda0c47"), new DateTime(2024, 3, 26, 2, 8, 39, 666, DateTimeKind.Local).AddTicks(8947), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866ci" },
                    { new Guid("c7e608be-46d0-49c6-84bb-90128b238654"), new DateTime(2024, 3, 26, 2, 8, 39, 666, DateTimeKind.Local).AddTicks(8953), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cj" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("26b5fcea-c9cb-4c7c-ad93-100a6d8611d6"),
                column: "Created",
                value: new DateTime(2024, 3, 26, 2, 8, 39, 666, DateTimeKind.Local).AddTicks(8529));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("53b50d7f-44eb-4dda-84b1-9d3c938eba22"),
                column: "Created",
                value: new DateTime(2024, 3, 26, 2, 8, 39, 666, DateTimeKind.Local).AddTicks(8521));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("58c96dfc-1c31-429b-9c6c-378db1c68b2a"),
                column: "Created",
                value: new DateTime(2024, 3, 26, 2, 8, 39, 666, DateTimeKind.Local).AddTicks(8524));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5d935698-bc0f-4692-88a3-43234943be40"),
                column: "Created",
                value: new DateTime(2024, 3, 26, 2, 8, 39, 666, DateTimeKind.Local).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b1799e22-2212-43d2-a09a-6a0371f2d89c"),
                column: "Created",
                value: new DateTime(2024, 3, 26, 2, 8, 39, 666, DateTimeKind.Local).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b3cb8ee0-c965-4970-8ef0-baad50ebf987"),
                column: "Created",
                value: new DateTime(2024, 3, 26, 2, 8, 39, 666, DateTimeKind.Local).AddTicks(8518));

            migrationBuilder.InsertData(
                table: "Interacts",
                columns: new[] { "Id", "ApplicationUserId", "ArtWorkID", "Comment", "Created", "CreatedBy", "Date", "IsDeleted", "IsLike", "LastModified", "LastModifiedBy" },
                values: new object[,]
                {
                    { new Guid("0091189b-ef26-4365-b054-ba78e386d990"), null, new Guid("1f35558f-a942-4837-81a4-720bae0e8bb1"), "Comment 8", new DateTime(2024, 3, 26, 2, 8, 39, 666, DateTimeKind.Local).AddTicks(9124), null, new DateTime(2024, 3, 26, 2, 8, 39, 666, DateTimeKind.Local).AddTicks(9126), false, true, null, null },
                    { new Guid("1c500941-f52c-42f3-894b-1c2b2ef8c26a"), null, new Guid("d9d6b461-8efd-4395-8662-a58caa152200"), "Comment 10", new DateTime(2024, 3, 26, 2, 8, 39, 666, DateTimeKind.Local).AddTicks(9140), null, new DateTime(2024, 3, 26, 2, 8, 39, 666, DateTimeKind.Local).AddTicks(9142), false, true, null, null },
                    { new Guid("23e48a35-2f5b-49cf-81fd-5d1b80b4fc01"), null, new Guid("a25e170e-7ddc-4bdc-9215-51c6fb9bcd96"), "Comment 5", new DateTime(2024, 3, 26, 2, 8, 39, 666, DateTimeKind.Local).AddTicks(9110), null, new DateTime(2024, 3, 26, 2, 8, 39, 666, DateTimeKind.Local).AddTicks(9111), false, true, null, null },
                    { new Guid("259a141f-22f9-41dd-830b-3d5dcfa40183"), null, new Guid("8e9acec5-54c9-4093-a450-19eb7b2109fb"), "Comment 1", new DateTime(2024, 3, 26, 2, 8, 39, 666, DateTimeKind.Local).AddTicks(9075), null, new DateTime(2024, 3, 26, 2, 8, 39, 666, DateTimeKind.Local).AddTicks(9078), false, true, null, null },
                    { new Guid("452aba93-8f70-4a3f-ba8b-825454170cc8"), null, new Guid("9db314d0-6a55-492c-9a13-7ee6f2091cbf"), "Comment 9", new DateTime(2024, 3, 26, 2, 8, 39, 666, DateTimeKind.Local).AddTicks(9136), null, new DateTime(2024, 3, 26, 2, 8, 39, 666, DateTimeKind.Local).AddTicks(9138), false, true, null, null },
                    { new Guid("7da8c283-93f0-4189-acf5-2cc1a56b46dc"), null, new Guid("b18dcaa1-d99a-4f15-a30c-5fd72c30280e"), "Comment 6", new DateTime(2024, 3, 26, 2, 8, 39, 666, DateTimeKind.Local).AddTicks(9114), null, new DateTime(2024, 3, 26, 2, 8, 39, 666, DateTimeKind.Local).AddTicks(9115), false, true, null, null },
                    { new Guid("82215e9d-66e6-417b-9e49-3245bebba68a"), null, new Guid("bd37c967-1817-495b-89eb-665c81b02d5e"), "Comment 7", new DateTime(2024, 3, 26, 2, 8, 39, 666, DateTimeKind.Local).AddTicks(9118), null, new DateTime(2024, 3, 26, 2, 8, 39, 666, DateTimeKind.Local).AddTicks(9120), false, true, null, null },
                    { new Guid("97efc6ef-07dd-4c8e-9a56-31f57afd0895"), null, new Guid("8c44d5c8-a738-4b65-a88e-3ed38fce88c4"), "Comment 3", new DateTime(2024, 3, 26, 2, 8, 39, 666, DateTimeKind.Local).AddTicks(9085), null, new DateTime(2024, 3, 26, 2, 8, 39, 666, DateTimeKind.Local).AddTicks(9087), false, true, null, null },
                    { new Guid("a60a11a7-81ae-414d-b8e7-2ee20a32b3b3"), null, new Guid("7b76bf1f-d24c-4ac9-b466-4179e65605b2"), "Comment 4", new DateTime(2024, 3, 26, 2, 8, 39, 666, DateTimeKind.Local).AddTicks(9092), null, new DateTime(2024, 3, 26, 2, 8, 39, 666, DateTimeKind.Local).AddTicks(9107), false, true, null, null },
                    { new Guid("ddb975e7-ef58-4a2e-a60f-62f858032ceb"), null, new Guid("26709dca-1906-4c50-a00e-1c63582ab644"), "Comment 2", new DateTime(2024, 3, 26, 2, 8, 39, 666, DateTimeKind.Local).AddTicks(9081), null, new DateTime(2024, 3, 26, 2, 8, 39, 666, DateTimeKind.Local).AddTicks(9082), false, true, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("871a809a-b3fa-495b-9cc2-c5d738a861cf"),
                column: "Created",
                value: new DateTime(2024, 3, 26, 2, 8, 39, 666, DateTimeKind.Local).AddTicks(9169));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("871a809a-b3fa-495b-9cc2-c5d738a862cf"),
                column: "Created",
                value: new DateTime(2024, 3, 26, 2, 8, 39, 666, DateTimeKind.Local).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("871a809a-b3fa-495b-9cc2-c5d738a863cf"),
                column: "Created",
                value: new DateTime(2024, 3, 26, 2, 8, 39, 666, DateTimeKind.Local).AddTicks(9177));

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "IsDeleted", "LastModified", "LastModifiedBy", "OrderID", "Point" },
                values: new object[,]
                {
                    { new Guid("1ff6ec55-fb67-4cc4-9291-687202aadae0"), new DateTime(2024, 3, 26, 2, 8, 39, 666, DateTimeKind.Local).AddTicks(9205), null, "Description 2", false, null, null, new Guid("871a809a-b3fa-495b-9cc2-c5d738a862cf"), 4f },
                    { new Guid("5d71ff10-dd85-4de4-a8c2-61c5039122fa"), new DateTime(2024, 3, 26, 2, 8, 39, 666, DateTimeKind.Local).AddTicks(9201), null, "Description 1", false, null, null, new Guid("871a809a-b3fa-495b-9cc2-c5d738a861cf"), 5f },
                    { new Guid("f14c467a-dede-46f5-b04b-1f76ef138cb1"), new DateTime(2024, 3, 26, 2, 8, 39, 666, DateTimeKind.Local).AddTicks(9209), null, "Description 3", false, null, null, new Guid("871a809a-b3fa-495b-9cc2-c5d738a863cf"), 3f }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArtistAccount",
                keyColumn: "Id",
                keyValue: new Guid("a0d562ff-2388-4407-900c-d17426928671"));

            migrationBuilder.DeleteData(
                table: "ArtistAccount",
                keyColumn: "Id",
                keyValue: new Guid("b42897f6-1944-4a57-88d6-eaac5427d109"));

            migrationBuilder.DeleteData(
                table: "ArtistAccount",
                keyColumn: "Id",
                keyValue: new Guid("d8040da4-d968-45f7-b336-49e31428d18c"));

            migrationBuilder.DeleteData(
                table: "AudienceAccount",
                keyColumn: "Id",
                keyValue: new Guid("5b881eb8-13c7-459d-b615-a68e6cda0c47"));

            migrationBuilder.DeleteData(
                table: "AudienceAccount",
                keyColumn: "Id",
                keyValue: new Guid("c7e608be-46d0-49c6-84bb-90128b238654"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("0091189b-ef26-4365-b054-ba78e386d990"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("1c500941-f52c-42f3-894b-1c2b2ef8c26a"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("23e48a35-2f5b-49cf-81fd-5d1b80b4fc01"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("259a141f-22f9-41dd-830b-3d5dcfa40183"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("452aba93-8f70-4a3f-ba8b-825454170cc8"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("7da8c283-93f0-4189-acf5-2cc1a56b46dc"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("82215e9d-66e6-417b-9e49-3245bebba68a"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("97efc6ef-07dd-4c8e-9a56-31f57afd0895"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("a60a11a7-81ae-414d-b8e7-2ee20a32b3b3"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("ddb975e7-ef58-4a2e-a60f-62f858032ceb"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("1ff6ec55-fb67-4cc4-9291-687202aadae0"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("5d71ff10-dd85-4de4-a8c2-61c5039122fa"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("f14c467a-dede-46f5-b04b-1f76ef138cb1"));

            migrationBuilder.AddColumn<float>(
                name: "Price",
                table: "Orders",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<bool>(
                name: "isPreOrder",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
                keyValue: new Guid("26b5fcea-c9cb-4c7c-ad93-100a6d8611d6"),
                column: "Created",
                value: new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(494));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("53b50d7f-44eb-4dda-84b1-9d3c938eba22"),
                column: "Created",
                value: new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(483));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("58c96dfc-1c31-429b-9c6c-378db1c68b2a"),
                column: "Created",
                value: new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(486));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5d935698-bc0f-4692-88a3-43234943be40"),
                column: "Created",
                value: new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(488));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b1799e22-2212-43d2-a09a-6a0371f2d89c"),
                column: "Created",
                value: new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b3cb8ee0-c965-4970-8ef0-baad50ebf987"),
                column: "Created",
                value: new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(468));

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
                columns: new[] { "Created", "Price", "isPreOrder" },
                values: new object[] { new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(1013), 0f, false });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("871a809a-b3fa-495b-9cc2-c5d738a862cf"),
                columns: new[] { "Created", "Price", "isPreOrder" },
                values: new object[] { new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(1016), 0f, false });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("871a809a-b3fa-495b-9cc2-c5d738a863cf"),
                columns: new[] { "Created", "Price", "isPreOrder" },
                values: new object[] { new DateTime(2024, 3, 25, 3, 51, 46, 933, DateTimeKind.Local).AddTicks(1019), 0f, false });

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
    }
}

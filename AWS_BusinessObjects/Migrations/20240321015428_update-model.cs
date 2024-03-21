using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AWS_BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class updatemodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Reports",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Ratings",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "PaymentMethods",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "NamePacked",
                table: "Packages",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Packages",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ArtWorks",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ArtWorks",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserAccountId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ArtWorkId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Category_ArtWorks_ArtWorkId",
                        column: x => x.ArtWorkId,
                        principalTable: "ArtWorks",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("1f35558f-a942-4837-81a4-720bae0e8bb1"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9280));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("26709dca-1906-4c50-a00e-1c63582ab644"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("7b76bf1f-d24c-4ac9-b466-4179e65605b2"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9268));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("8c44d5c8-a738-4b65-a88e-3ed38fce88c4"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9264));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("8e9acec5-54c9-4093-a450-19eb7b2109fb"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9255));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("9db314d0-6a55-492c-9a13-7ee6f2091cbf"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9283));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("a25e170e-7ddc-4bdc-9215-51c6fb9bcd96"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9271));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("b18dcaa1-d99a-4f15-a30c-5fd72c30280e"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9274));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("bd37c967-1817-495b-89eb-665c81b02d5e"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9277));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("d9d6b461-8efd-4395-8662-a58caa152200"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9285));

            migrationBuilder.InsertData(
                table: "ArtistAccount",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "UserAccountId" },
                values: new object[,]
                {
                    { new Guid("4284cb44-4a3f-480e-b0cb-73db639995c1"), new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9145), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866ch" },
                    { new Guid("43c69ec1-4fd4-4b0a-ba9f-a233cca0e4a6"), new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9137), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cf" },
                    { new Guid("d51c7e66-7b34-4a9e-8805-10981fb72c0c"), new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9141), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cg" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cf",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d446c6ea-6718-416e-9d29-d707657c892c", "037d77a6-8981-45e4-8a01-c57236d8c5a3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cg",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cb97afed-8064-413e-a2e8-530a89a0d66c", "56ecacdd-88e4-4bd6-9db9-89e8018e00ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866ch",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b0c2a197-a4ce-45e0-aecb-6f83f402553c", "3935ecf3-db34-439f-bc2b-3411a61e4774" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866ci",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e078c043-9f34-4b3f-9fee-3f020f7da947", "9a778c6b-bef7-4869-b60e-bbe4d2ab5522" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cj",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bcb04be2-2977-451b-9671-3ee4bc171de9", "95342a3e-d9f1-4ce1-94ab-c25cbdada7ac" });

            migrationBuilder.InsertData(
                table: "AudienceAccount",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "UserAccountId" },
                values: new object[,]
                {
                    { new Guid("99b77cb8-65c8-42cc-82a5-75f5232f02f4"), new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9161), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866ci" },
                    { new Guid("bf17a659-5730-457e-84e1-107b916c0e35"), new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9164), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cj" }
                });

            migrationBuilder.InsertData(
                table: "Interacts",
                columns: new[] { "Id", "ApplicationUserId", "ArtWorkID", "Comment", "Created", "CreatedBy", "Date", "IsDeleted", "IsLike", "LastModified", "LastModifiedBy" },
                values: new object[,]
                {
                    { new Guid("24985afa-d6c7-40c7-ada6-d1ff9b2f0755"), null, new Guid("bd37c967-1817-495b-89eb-665c81b02d5e"), "Comment 7", new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9331), null, new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9332), false, true, null, null },
                    { new Guid("2eaef90f-349a-49b5-ad1f-12fb363593ee"), null, new Guid("8c44d5c8-a738-4b65-a88e-3ed38fce88c4"), "Comment 3", new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9315), null, new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9316), false, true, null, null },
                    { new Guid("3fe3d2a7-b8a9-4cd2-96c2-6c2a9677c4ae"), null, new Guid("8e9acec5-54c9-4093-a450-19eb7b2109fb"), "Comment 1", new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9306), null, new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9308), false, true, null, null },
                    { new Guid("57a0593c-639a-4b5b-a1f5-9b13aa307563"), null, new Guid("9db314d0-6a55-492c-9a13-7ee6f2091cbf"), "Comment 9", new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9339), null, new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9340), false, true, null, null },
                    { new Guid("6d9c4b6a-4057-494d-98ae-c918266cf0a3"), null, new Guid("d9d6b461-8efd-4395-8662-a58caa152200"), "Comment 10", new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9343), null, new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9344), false, true, null, null },
                    { new Guid("8da8f508-752b-49fe-a2b9-029d1fa9cee2"), null, new Guid("1f35558f-a942-4837-81a4-720bae0e8bb1"), "Comment 8", new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9334), null, new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9335), false, true, null, null },
                    { new Guid("a25fc1a5-4eab-494f-871b-92b5259d6324"), null, new Guid("b18dcaa1-d99a-4f15-a30c-5fd72c30280e"), "Comment 6", new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9327), null, new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9328), false, true, null, null },
                    { new Guid("ba464986-7237-4de2-bb97-4fbf1d19cfbd"), null, new Guid("a25e170e-7ddc-4bdc-9215-51c6fb9bcd96"), "Comment 5", new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9324), null, new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9325), false, true, null, null },
                    { new Guid("c8fc8abb-56f4-41f2-84c3-f8d7108f2ce5"), null, new Guid("7b76bf1f-d24c-4ac9-b466-4179e65605b2"), "Comment 4", new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9318), null, new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9320), false, true, null, null },
                    { new Guid("ede9392d-29e3-4dee-aa61-f307e7f2dc5a"), null, new Guid("26709dca-1906-4c50-a00e-1c63582ab644"), "Comment 2", new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9311), null, new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9312), false, true, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("871a809a-b3fa-495b-9cc2-c5d738a861cf"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9364));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("871a809a-b3fa-495b-9cc2-c5d738a862cf"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9367));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("871a809a-b3fa-495b-9cc2-c5d738a863cf"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9371));

            migrationBuilder.InsertData(
                table: "PackageDetails",
                columns: new[] { "Id", "ApplicationUserId", "Created", "CreatedBy", "EndDate", "IsDeleted", "LastModified", "LastModifiedBy", "PackageID", "PaymentMethodID", "StartDate", "UserAccountId" },
                values: new object[,]
                {
                    { new Guid("a2150bd6-bb9d-4f75-a4bc-fb491d355ebb"), null, new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9411), null, new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9410), false, null, null, new Guid("1ebe4b4b-e00b-4e82-b3be-418f58df9726"), new Guid("c466ed52-40d1-41a7-9a76-141526876859"), new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9410), "871a809a-b3fa-495b-9cc2-c5d738a866ch" },
                    { new Guid("ae8fc542-550c-40d6-a445-092bc88fadbb"), null, new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9420), null, new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9420), false, null, null, new Guid("a04d8c84-4698-4d73-a3cb-e1ce395d5bcf"), new Guid("d3b9eb3f-8da2-40b2-8fd0-d0b09f287008"), new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9419), "871a809a-b3fa-495b-9cc2-c5d738a866cf" },
                    { new Guid("af21e3c8-5e0a-4538-b654-317f775f17c9"), null, new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9416), null, new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9415), false, null, null, new Guid("39b58807-f4b1-46bb-bdd2-597399a51c90"), new Guid("d3b9eb3f-8da2-40b2-8fd0-d0b09f287008"), new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9415), "871a809a-b3fa-495b-9cc2-c5d738a866cf" }
                });

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("1ebe4b4b-e00b-4e82-b3be-418f58df9726"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("39b58807-f4b1-46bb-bdd2-597399a51c90"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("a04d8c84-4698-4d73-a3cb-e1ce395d5bcf"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9393));

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("c466ed52-40d1-41a7-9a76-141526876859"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9434));

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("d3b9eb3f-8da2-40b2-8fd0-d0b09f287008"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9436));

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "IsDeleted", "LastModified", "LastModifiedBy", "OrderID", "Point" },
                values: new object[,]
                {
                    { new Guid("039e175c-70d1-41cb-b553-45fc0d170aae"), new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9499), null, "Description 3", false, null, null, new Guid("871a809a-b3fa-495b-9cc2-c5d738a863cf"), 3f },
                    { new Guid("1e4da16d-7055-4ce3-9ac6-725ca43584ec"), new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9492), null, "Description 1", false, null, null, new Guid("871a809a-b3fa-495b-9cc2-c5d738a861cf"), 5f },
                    { new Guid("fafc8a3c-59ca-4c47-a9ee-a12cb48753e9"), new DateTime(2024, 3, 21, 8, 54, 28, 405, DateTimeKind.Local).AddTicks(9496), null, "Description 2", false, null, null, new Guid("871a809a-b3fa-495b-9cc2-c5d738a862cf"), 4f }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Category_ArtWorkId",
                table: "Category",
                column: "ArtWorkId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DeleteData(
                table: "ArtistAccount",
                keyColumn: "Id",
                keyValue: new Guid("4284cb44-4a3f-480e-b0cb-73db639995c1"));

            migrationBuilder.DeleteData(
                table: "ArtistAccount",
                keyColumn: "Id",
                keyValue: new Guid("43c69ec1-4fd4-4b0a-ba9f-a233cca0e4a6"));

            migrationBuilder.DeleteData(
                table: "ArtistAccount",
                keyColumn: "Id",
                keyValue: new Guid("d51c7e66-7b34-4a9e-8805-10981fb72c0c"));

            migrationBuilder.DeleteData(
                table: "AudienceAccount",
                keyColumn: "Id",
                keyValue: new Guid("99b77cb8-65c8-42cc-82a5-75f5232f02f4"));

            migrationBuilder.DeleteData(
                table: "AudienceAccount",
                keyColumn: "Id",
                keyValue: new Guid("bf17a659-5730-457e-84e1-107b916c0e35"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("24985afa-d6c7-40c7-ada6-d1ff9b2f0755"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("2eaef90f-349a-49b5-ad1f-12fb363593ee"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("3fe3d2a7-b8a9-4cd2-96c2-6c2a9677c4ae"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("57a0593c-639a-4b5b-a1f5-9b13aa307563"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("6d9c4b6a-4057-494d-98ae-c918266cf0a3"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("8da8f508-752b-49fe-a2b9-029d1fa9cee2"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("a25fc1a5-4eab-494f-871b-92b5259d6324"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("ba464986-7237-4de2-bb97-4fbf1d19cfbd"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("c8fc8abb-56f4-41f2-84c3-f8d7108f2ce5"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("ede9392d-29e3-4dee-aa61-f307e7f2dc5a"));

            migrationBuilder.DeleteData(
                table: "PackageDetails",
                keyColumn: "Id",
                keyValue: new Guid("a2150bd6-bb9d-4f75-a4bc-fb491d355ebb"));

            migrationBuilder.DeleteData(
                table: "PackageDetails",
                keyColumn: "Id",
                keyValue: new Guid("ae8fc542-550c-40d6-a445-092bc88fadbb"));

            migrationBuilder.DeleteData(
                table: "PackageDetails",
                keyColumn: "Id",
                keyValue: new Guid("af21e3c8-5e0a-4538-b654-317f775f17c9"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("039e175c-70d1-41cb-b553-45fc0d170aae"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("1e4da16d-7055-4ce3-9ac6-725ca43584ec"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("fafc8a3c-59ca-4c47-a9ee-a12cb48753e9"));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Reports",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Ratings",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "PaymentMethods",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "NamePacked",
                table: "Packages",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Packages",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ArtWorks",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ArtWorks",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

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
    }
}

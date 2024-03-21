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
                keyValue: new Guid("464927a3-37f9-4106-9319-67acebc62c83"));

            migrationBuilder.DeleteData(
                table: "ArtistAccount",
                keyColumn: "Id",
                keyValue: new Guid("f1cc2b0f-8500-450b-bebf-45ccb6519009"));

            migrationBuilder.DeleteData(
                table: "ArtistAccount",
                keyColumn: "Id",
                keyValue: new Guid("fb28caad-5aeb-4eca-9926-3e587182687f"));

            migrationBuilder.DeleteData(
                table: "AudienceAccount",
                keyColumn: "Id",
                keyValue: new Guid("e9ba8f4a-13a4-497e-a6f2-8a11b64f31b9"));

            migrationBuilder.DeleteData(
                table: "AudienceAccount",
                keyColumn: "Id",
                keyValue: new Guid("f763ad02-5434-47ce-97ff-c4c5d1bc2347"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("10eafe07-ab4a-4bbd-99b0-f6e26df752e0"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("1574f42e-b5f2-4c75-bcf1-3cd2c08fea84"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("1d877692-d37f-4114-aacc-4213d7d3ba1a"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("3a4809d2-4dec-4573-9c6b-cb9bbcc07348"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("4c31843e-a20d-43cc-a917-50f5dca68dc7"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("62eacbfc-44e2-4cdd-a12a-9d8d393c9ab5"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("a33822ec-255a-4ec3-b248-171333cf37a7"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("b32b5669-7cc7-4263-9391-4738d6dadd04"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("e6018e3b-0ef5-49ee-8a34-98fb8ce3db02"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("f0e84770-d000-49cd-9de9-c7e56a5c2571"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("438b7773-fc22-415b-a989-ec5b667fbcc7"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("c8780362-aa25-4bcb-b3c3-6de89cd1483e"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("ec19628b-5afe-485e-87f7-c41303caf449"));

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "WishList",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("1f35558f-a942-4837-81a4-720bae0e8bb1"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 19, 51, 41, 546, DateTimeKind.Local).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("26709dca-1906-4c50-a00e-1c63582ab644"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 19, 51, 41, 546, DateTimeKind.Local).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("7b76bf1f-d24c-4ac9-b466-4179e65605b2"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 19, 51, 41, 546, DateTimeKind.Local).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("8c44d5c8-a738-4b65-a88e-3ed38fce88c4"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 19, 51, 41, 546, DateTimeKind.Local).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("8e9acec5-54c9-4093-a450-19eb7b2109fb"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 19, 51, 41, 546, DateTimeKind.Local).AddTicks(8703));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("9db314d0-6a55-492c-9a13-7ee6f2091cbf"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 19, 51, 41, 546, DateTimeKind.Local).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("a25e170e-7ddc-4bdc-9215-51c6fb9bcd96"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 19, 51, 41, 546, DateTimeKind.Local).AddTicks(8717));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("b18dcaa1-d99a-4f15-a30c-5fd72c30280e"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 19, 51, 41, 546, DateTimeKind.Local).AddTicks(8721));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("bd37c967-1817-495b-89eb-665c81b02d5e"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 19, 51, 41, 546, DateTimeKind.Local).AddTicks(8724));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("d9d6b461-8efd-4395-8662-a58caa152200"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 19, 51, 41, 546, DateTimeKind.Local).AddTicks(8737));

            migrationBuilder.InsertData(
                table: "ArtistAccount",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "UserAccountId" },
                values: new object[,]
                {
                    { new Guid("3878ad0b-fae6-4882-b88a-99ff6df092c9"), new DateTime(2024, 3, 21, 19, 51, 41, 546, DateTimeKind.Local).AddTicks(8644), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cg" },
                    { new Guid("ab50d3b3-a70c-4e52-8c8f-b489520b921b"), new DateTime(2024, 3, 21, 19, 51, 41, 546, DateTimeKind.Local).AddTicks(8646), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866ch" },
                    { new Guid("b69ae46c-e0b0-4f62-a898-160843a706e1"), new DateTime(2024, 3, 21, 19, 51, 41, 546, DateTimeKind.Local).AddTicks(8640), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cf" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cf",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ac799272-3e3a-4a50-a817-54cabff3b47d", "79be15c4-6cbe-48ff-9dbd-59d555cbf9a0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cg",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "04ff464d-8472-4244-81f1-f751b27a2c6c", "ee410dd6-6ba4-49dc-97fc-f82059856124" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866ch",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4aa4d503-c34f-452d-88c2-50c062e9316c", "4d998308-2455-4f52-99fc-fc9e32d8f3c6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866ci",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6c0e0a7f-7971-4359-8157-768a39967de0", "0dd9683f-2aaa-4729-853d-7e4587f6503b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cj",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e1ca74ef-774f-4d38-9fce-1ed725dca46a", "5368010a-9fcb-44f1-ac42-f6f6e96826ef" });

            migrationBuilder.InsertData(
                table: "AudienceAccount",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "UserAccountId" },
                values: new object[,]
                {
                    { new Guid("83df80e1-5579-4537-9c47-610a6650db3a"), new DateTime(2024, 3, 21, 19, 51, 41, 546, DateTimeKind.Local).AddTicks(8668), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866ci" },
                    { new Guid("e3add75c-8373-4dfd-bb54-1d4529efeb3f"), new DateTime(2024, 3, 21, 19, 51, 41, 546, DateTimeKind.Local).AddTicks(8673), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cj" }
                });

            migrationBuilder.InsertData(
                table: "Interacts",
                columns: new[] { "Id", "ApplicationUserId", "ArtWorkID", "Comment", "Created", "CreatedBy", "Date", "IsDeleted", "IsLike", "LastModified", "LastModifiedBy" },
                values: new object[,]
                {
                    { new Guid("07ce019c-2db5-453a-a947-9bc9a8df326d"), null, new Guid("26709dca-1906-4c50-a00e-1c63582ab644"), "Comment 2", new DateTime(2024, 3, 21, 19, 51, 41, 546, DateTimeKind.Local).AddTicks(8764), null, new DateTime(2024, 3, 21, 19, 51, 41, 546, DateTimeKind.Local).AddTicks(8765), false, true, null, null },
                    { new Guid("15e3b5b1-2c41-4344-a5c0-8219c10ac94d"), null, new Guid("a25e170e-7ddc-4bdc-9215-51c6fb9bcd96"), "Comment 5", new DateTime(2024, 3, 21, 19, 51, 41, 546, DateTimeKind.Local).AddTicks(8778), null, new DateTime(2024, 3, 21, 19, 51, 41, 546, DateTimeKind.Local).AddTicks(8780), false, true, null, null },
                    { new Guid("179731f2-7623-4eef-8cb8-2f6a6290cf99"), null, new Guid("1f35558f-a942-4837-81a4-720bae0e8bb1"), "Comment 8", new DateTime(2024, 3, 21, 19, 51, 41, 546, DateTimeKind.Local).AddTicks(8823), null, new DateTime(2024, 3, 21, 19, 51, 41, 546, DateTimeKind.Local).AddTicks(8824), false, true, null, null },
                    { new Guid("3fa0d63f-5f23-474c-b5df-95430bea6537"), null, new Guid("8e9acec5-54c9-4093-a450-19eb7b2109fb"), "Comment 1", new DateTime(2024, 3, 21, 19, 51, 41, 546, DateTimeKind.Local).AddTicks(8757), null, new DateTime(2024, 3, 21, 19, 51, 41, 546, DateTimeKind.Local).AddTicks(8760), false, true, null, null },
                    { new Guid("4db8b70f-2224-4e03-9e14-40932425e37f"), null, new Guid("b18dcaa1-d99a-4f15-a30c-5fd72c30280e"), "Comment 6", new DateTime(2024, 3, 21, 19, 51, 41, 546, DateTimeKind.Local).AddTicks(8812), null, new DateTime(2024, 3, 21, 19, 51, 41, 546, DateTimeKind.Local).AddTicks(8814), false, true, null, null },
                    { new Guid("52ed48f6-acf1-43f2-9520-3029fe911a84"), null, new Guid("bd37c967-1817-495b-89eb-665c81b02d5e"), "Comment 7", new DateTime(2024, 3, 21, 19, 51, 41, 546, DateTimeKind.Local).AddTicks(8818), null, new DateTime(2024, 3, 21, 19, 51, 41, 546, DateTimeKind.Local).AddTicks(8820), false, true, null, null },
                    { new Guid("5b8091c9-c779-4762-bc37-c5368bf6c413"), null, new Guid("8c44d5c8-a738-4b65-a88e-3ed38fce88c4"), "Comment 3", new DateTime(2024, 3, 21, 19, 51, 41, 546, DateTimeKind.Local).AddTicks(8770), null, new DateTime(2024, 3, 21, 19, 51, 41, 546, DateTimeKind.Local).AddTicks(8771), false, true, null, null },
                    { new Guid("611b340a-8bb8-4655-815d-b3132eca221d"), null, new Guid("7b76bf1f-d24c-4ac9-b466-4179e65605b2"), "Comment 4", new DateTime(2024, 3, 21, 19, 51, 41, 546, DateTimeKind.Local).AddTicks(8774), null, new DateTime(2024, 3, 21, 19, 51, 41, 546, DateTimeKind.Local).AddTicks(8775), false, true, null, null },
                    { new Guid("b38adc0e-89b7-4452-a9d2-a06c0ebbe85d"), null, new Guid("9db314d0-6a55-492c-9a13-7ee6f2091cbf"), "Comment 9", new DateTime(2024, 3, 21, 19, 51, 41, 546, DateTimeKind.Local).AddTicks(8827), null, new DateTime(2024, 3, 21, 19, 51, 41, 546, DateTimeKind.Local).AddTicks(8828), false, true, null, null },
                    { new Guid("e909fc45-326e-45b6-b197-4e9946ec0586"), null, new Guid("d9d6b461-8efd-4395-8662-a58caa152200"), "Comment 10", new DateTime(2024, 3, 21, 19, 51, 41, 546, DateTimeKind.Local).AddTicks(8831), null, new DateTime(2024, 3, 21, 19, 51, 41, 546, DateTimeKind.Local).AddTicks(8832), false, true, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("871a809a-b3fa-495b-9cc2-c5d738a861cf"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 19, 51, 41, 546, DateTimeKind.Local).AddTicks(8855));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("871a809a-b3fa-495b-9cc2-c5d738a862cf"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 19, 51, 41, 546, DateTimeKind.Local).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("871a809a-b3fa-495b-9cc2-c5d738a863cf"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 19, 51, 41, 546, DateTimeKind.Local).AddTicks(8866));

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "IsDeleted", "LastModified", "LastModifiedBy", "OrderID", "Point" },
                values: new object[,]
                {
                    { new Guid("1737ee32-1a61-41c7-a163-b70fa944418b"), new DateTime(2024, 3, 21, 19, 51, 41, 546, DateTimeKind.Local).AddTicks(8890), null, "Description 2", false, null, null, new Guid("871a809a-b3fa-495b-9cc2-c5d738a862cf"), 4f },
                    { new Guid("9d2eef43-d200-4e3e-92b4-afcf82a23bb8"), new DateTime(2024, 3, 21, 19, 51, 41, 546, DateTimeKind.Local).AddTicks(8886), null, "Description 1", false, null, null, new Guid("871a809a-b3fa-495b-9cc2-c5d738a861cf"), 5f },
                    { new Guid("dbc65157-a95a-4851-832c-8c7c1454c064"), new DateTime(2024, 3, 21, 19, 51, 41, 546, DateTimeKind.Local).AddTicks(8894), null, "Description 3", false, null, null, new Guid("871a809a-b3fa-495b-9cc2-c5d738a863cf"), 3f }
                });

            migrationBuilder.CreateIndex(
                name: "IX_WishList_ApplicationUserId",
                table: "WishList",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_WishList_AspNetUsers_ApplicationUserId",
                table: "WishList",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WishList_AspNetUsers_ApplicationUserId",
                table: "WishList");

            migrationBuilder.DropIndex(
                name: "IX_WishList_ApplicationUserId",
                table: "WishList");

            migrationBuilder.DeleteData(
                table: "ArtistAccount",
                keyColumn: "Id",
                keyValue: new Guid("3878ad0b-fae6-4882-b88a-99ff6df092c9"));

            migrationBuilder.DeleteData(
                table: "ArtistAccount",
                keyColumn: "Id",
                keyValue: new Guid("ab50d3b3-a70c-4e52-8c8f-b489520b921b"));

            migrationBuilder.DeleteData(
                table: "ArtistAccount",
                keyColumn: "Id",
                keyValue: new Guid("b69ae46c-e0b0-4f62-a898-160843a706e1"));

            migrationBuilder.DeleteData(
                table: "AudienceAccount",
                keyColumn: "Id",
                keyValue: new Guid("83df80e1-5579-4537-9c47-610a6650db3a"));

            migrationBuilder.DeleteData(
                table: "AudienceAccount",
                keyColumn: "Id",
                keyValue: new Guid("e3add75c-8373-4dfd-bb54-1d4529efeb3f"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("07ce019c-2db5-453a-a947-9bc9a8df326d"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("15e3b5b1-2c41-4344-a5c0-8219c10ac94d"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("179731f2-7623-4eef-8cb8-2f6a6290cf99"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("3fa0d63f-5f23-474c-b5df-95430bea6537"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("4db8b70f-2224-4e03-9e14-40932425e37f"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("52ed48f6-acf1-43f2-9520-3029fe911a84"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("5b8091c9-c779-4762-bc37-c5368bf6c413"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("611b340a-8bb8-4655-815d-b3132eca221d"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("b38adc0e-89b7-4452-a9d2-a06c0ebbe85d"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("e909fc45-326e-45b6-b197-4e9946ec0586"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("1737ee32-1a61-41c7-a163-b70fa944418b"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("9d2eef43-d200-4e3e-92b4-afcf82a23bb8"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("dbc65157-a95a-4851-832c-8c7c1454c064"));

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "WishList");

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("1f35558f-a942-4837-81a4-720bae0e8bb1"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9455));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("26709dca-1906-4c50-a00e-1c63582ab644"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9433));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("7b76bf1f-d24c-4ac9-b466-4179e65605b2"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9439));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("8c44d5c8-a738-4b65-a88e-3ed38fce88c4"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9436));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("8e9acec5-54c9-4093-a450-19eb7b2109fb"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9428));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("9db314d0-6a55-492c-9a13-7ee6f2091cbf"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9458));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("a25e170e-7ddc-4bdc-9215-51c6fb9bcd96"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9443));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("b18dcaa1-d99a-4f15-a30c-5fd72c30280e"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9446));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("bd37c967-1817-495b-89eb-665c81b02d5e"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9449));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("d9d6b461-8efd-4395-8662-a58caa152200"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9462));

            migrationBuilder.InsertData(
                table: "ArtistAccount",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "UserAccountId" },
                values: new object[,]
                {
                    { new Guid("464927a3-37f9-4106-9319-67acebc62c83"), new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9329), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cg" },
                    { new Guid("f1cc2b0f-8500-450b-bebf-45ccb6519009"), new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9326), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cf" },
                    { new Guid("fb28caad-5aeb-4eca-9926-3e587182687f"), new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9332), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866ch" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cf",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7eec6d28-3767-4217-a0e3-72c4bee47ee9", "1830a9a1-22ea-43ff-bcdd-1dc3ecc20254" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cg",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f6852092-13ed-4086-a14a-3d0c54073b86", "bf017b21-ddd2-445d-88d8-b9cb95713630" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866ch",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d620ea5a-ca00-403d-ad7e-835844fb9201", "a8175b15-f232-4639-a06b-5c358a3641ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866ci",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8e25dc4b-d4b0-4cda-86d5-9d9ad72f36b2", "adecd246-5d11-4dbb-8869-0788bbdc2207" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cj",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d042ff8b-38cf-4368-8a75-a8f340f8a660", "3126fd18-aa51-4e9d-a355-2613c2eec196" });

            migrationBuilder.InsertData(
                table: "AudienceAccount",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "UserAccountId" },
                values: new object[,]
                {
                    { new Guid("e9ba8f4a-13a4-497e-a6f2-8a11b64f31b9"), new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9352), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866ci" },
                    { new Guid("f763ad02-5434-47ce-97ff-c4c5d1bc2347"), new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9358), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cj" }
                });

            migrationBuilder.InsertData(
                table: "Interacts",
                columns: new[] { "Id", "ApplicationUserId", "ArtWorkID", "Comment", "Created", "CreatedBy", "Date", "IsDeleted", "IsLike", "LastModified", "LastModifiedBy" },
                values: new object[,]
                {
                    { new Guid("10eafe07-ab4a-4bbd-99b0-f6e26df752e0"), null, new Guid("9db314d0-6a55-492c-9a13-7ee6f2091cbf"), "Comment 9", new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9524), null, new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9528), false, true, null, null },
                    { new Guid("1574f42e-b5f2-4c75-bcf1-3cd2c08fea84"), null, new Guid("a25e170e-7ddc-4bdc-9215-51c6fb9bcd96"), "Comment 5", new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9507), null, new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9508), false, true, null, null },
                    { new Guid("1d877692-d37f-4114-aacc-4213d7d3ba1a"), null, new Guid("8c44d5c8-a738-4b65-a88e-3ed38fce88c4"), "Comment 3", new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9498), null, new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9499), false, true, null, null },
                    { new Guid("3a4809d2-4dec-4573-9c6b-cb9bbcc07348"), null, new Guid("1f35558f-a942-4837-81a4-720bae0e8bb1"), "Comment 8", new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9521), null, new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9522), false, true, null, null },
                    { new Guid("4c31843e-a20d-43cc-a917-50f5dca68dc7"), null, new Guid("7b76bf1f-d24c-4ac9-b466-4179e65605b2"), "Comment 4", new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9503), null, new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9504), false, true, null, null },
                    { new Guid("62eacbfc-44e2-4cdd-a12a-9d8d393c9ab5"), null, new Guid("26709dca-1906-4c50-a00e-1c63582ab644"), "Comment 2", new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9491), null, new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9493), false, true, null, null },
                    { new Guid("a33822ec-255a-4ec3-b248-171333cf37a7"), null, new Guid("8e9acec5-54c9-4093-a450-19eb7b2109fb"), "Comment 1", new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9485), null, new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9487), false, true, null, null },
                    { new Guid("b32b5669-7cc7-4263-9391-4738d6dadd04"), null, new Guid("bd37c967-1817-495b-89eb-665c81b02d5e"), "Comment 7", new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9517), null, new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9518), false, true, null, null },
                    { new Guid("e6018e3b-0ef5-49ee-8a34-98fb8ce3db02"), null, new Guid("b18dcaa1-d99a-4f15-a30c-5fd72c30280e"), "Comment 6", new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9511), null, new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9512), false, true, null, null },
                    { new Guid("f0e84770-d000-49cd-9de9-c7e56a5c2571"), null, new Guid("d9d6b461-8efd-4395-8662-a58caa152200"), "Comment 10", new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9531), null, new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9532), false, true, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("871a809a-b3fa-495b-9cc2-c5d738a861cf"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("871a809a-b3fa-495b-9cc2-c5d738a862cf"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9559));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("871a809a-b3fa-495b-9cc2-c5d738a863cf"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9562));

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "IsDeleted", "LastModified", "LastModifiedBy", "OrderID", "Point" },
                values: new object[,]
                {
                    { new Guid("438b7773-fc22-415b-a989-ec5b667fbcc7"), new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9586), null, "Description 2", false, null, null, new Guid("871a809a-b3fa-495b-9cc2-c5d738a862cf"), 4f },
                    { new Guid("c8780362-aa25-4bcb-b3c3-6de89cd1483e"), new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9582), null, "Description 1", false, null, null, new Guid("871a809a-b3fa-495b-9cc2-c5d738a861cf"), 5f },
                    { new Guid("ec19628b-5afe-485e-87f7-c41303caf449"), new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9589), null, "Description 3", false, null, null, new Guid("871a809a-b3fa-495b-9cc2-c5d738a863cf"), 3f }
                });
        }
    }
}

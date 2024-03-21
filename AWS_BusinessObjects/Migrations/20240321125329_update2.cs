using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AWS_BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class update2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WishList_ArtWorks_ArtWorkID",
                table: "WishList");

            migrationBuilder.DropForeignKey(
                name: "FK_WishList_AspNetUsers_ApplicationUserId",
                table: "WishList");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WishList",
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

            migrationBuilder.RenameTable(
                name: "WishList",
                newName: "WishLists");

            migrationBuilder.RenameIndex(
                name: "IX_WishList_ArtWorkID",
                table: "WishLists",
                newName: "IX_WishLists_ArtWorkID");

            migrationBuilder.RenameIndex(
                name: "IX_WishList_ApplicationUserId",
                table: "WishLists",
                newName: "IX_WishLists_ApplicationUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WishLists",
                table: "WishLists",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("1f35558f-a942-4837-81a4-720bae0e8bb1"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 19, 53, 28, 865, DateTimeKind.Local).AddTicks(8996));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("26709dca-1906-4c50-a00e-1c63582ab644"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 19, 53, 28, 865, DateTimeKind.Local).AddTicks(8937));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("7b76bf1f-d24c-4ac9-b466-4179e65605b2"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 19, 53, 28, 865, DateTimeKind.Local).AddTicks(8944));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("8c44d5c8-a738-4b65-a88e-3ed38fce88c4"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 19, 53, 28, 865, DateTimeKind.Local).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("8e9acec5-54c9-4093-a450-19eb7b2109fb"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 19, 53, 28, 865, DateTimeKind.Local).AddTicks(8929));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("9db314d0-6a55-492c-9a13-7ee6f2091cbf"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 19, 53, 28, 865, DateTimeKind.Local).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("a25e170e-7ddc-4bdc-9215-51c6fb9bcd96"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 19, 53, 28, 865, DateTimeKind.Local).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("b18dcaa1-d99a-4f15-a30c-5fd72c30280e"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 19, 53, 28, 865, DateTimeKind.Local).AddTicks(8989));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("bd37c967-1817-495b-89eb-665c81b02d5e"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 19, 53, 28, 865, DateTimeKind.Local).AddTicks(8993));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("d9d6b461-8efd-4395-8662-a58caa152200"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 19, 53, 28, 865, DateTimeKind.Local).AddTicks(9006));

            migrationBuilder.InsertData(
                table: "ArtistAccount",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "UserAccountId" },
                values: new object[,]
                {
                    { new Guid("05307ad9-f233-4cb9-bab6-8b4150869a7d"), new DateTime(2024, 3, 21, 19, 53, 28, 865, DateTimeKind.Local).AddTicks(8853), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cf" },
                    { new Guid("0af072a6-d573-4962-bb68-63e96b33cf24"), new DateTime(2024, 3, 21, 19, 53, 28, 865, DateTimeKind.Local).AddTicks(8861), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cg" },
                    { new Guid("37494ef8-637d-488e-b9b4-e5ccf8bef19a"), new DateTime(2024, 3, 21, 19, 53, 28, 865, DateTimeKind.Local).AddTicks(8864), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866ch" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cf",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7006331e-57d3-4abc-aca3-ca598c5e8c59", "db783c7f-b60e-488e-b6cf-8dfe69a3a7a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cg",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "993cb6a3-dc4d-4a99-87e4-350c2062d307", "66cc2d2b-5897-482e-b361-ed8d0d5bffa9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866ch",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "241b8641-0136-4226-b620-42798cf2ab8c", "10ff66ea-eaf1-445a-8df5-b2c771a5b94a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866ci",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e215975b-0008-4acb-bced-4fae865e7d62", "b3aadb99-700f-43d3-a65d-e60739c9ca9b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cj",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "755b1986-d77c-4c53-8861-da43f52720ec", "d0e5102a-c25f-4c96-b888-ddac9c209841" });

            migrationBuilder.InsertData(
                table: "AudienceAccount",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "UserAccountId" },
                values: new object[,]
                {
                    { new Guid("4dab19b7-1795-4f90-8ea3-6879aba24557"), new DateTime(2024, 3, 21, 19, 53, 28, 865, DateTimeKind.Local).AddTicks(8896), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cj" },
                    { new Guid("d44fd4a9-7cee-498a-8122-08dbed138081"), new DateTime(2024, 3, 21, 19, 53, 28, 865, DateTimeKind.Local).AddTicks(8893), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866ci" }
                });

            migrationBuilder.InsertData(
                table: "Interacts",
                columns: new[] { "Id", "ApplicationUserId", "ArtWorkID", "Comment", "Created", "CreatedBy", "Date", "IsDeleted", "IsLike", "LastModified", "LastModifiedBy" },
                values: new object[,]
                {
                    { new Guid("326150ab-b8f5-4f06-8e19-5f9a82b91137"), null, new Guid("26709dca-1906-4c50-a00e-1c63582ab644"), "Comment 2", new DateTime(2024, 3, 21, 19, 53, 28, 865, DateTimeKind.Local).AddTicks(9042), null, new DateTime(2024, 3, 21, 19, 53, 28, 865, DateTimeKind.Local).AddTicks(9044), false, true, null, null },
                    { new Guid("39f78346-0d2a-4377-a583-d77fbd191982"), null, new Guid("7b76bf1f-d24c-4ac9-b466-4179e65605b2"), "Comment 4", new DateTime(2024, 3, 21, 19, 53, 28, 865, DateTimeKind.Local).AddTicks(9053), null, new DateTime(2024, 3, 21, 19, 53, 28, 865, DateTimeKind.Local).AddTicks(9054), false, true, null, null },
                    { new Guid("486174e6-b7f2-474b-b259-e8c1926eef12"), null, new Guid("9db314d0-6a55-492c-9a13-7ee6f2091cbf"), "Comment 9", new DateTime(2024, 3, 21, 19, 53, 28, 865, DateTimeKind.Local).AddTicks(9076), null, new DateTime(2024, 3, 21, 19, 53, 28, 865, DateTimeKind.Local).AddTicks(9077), false, true, null, null },
                    { new Guid("63a84473-e2c2-4a6f-aa28-ad1278d46ce5"), null, new Guid("1f35558f-a942-4837-81a4-720bae0e8bb1"), "Comment 8", new DateTime(2024, 3, 21, 19, 53, 28, 865, DateTimeKind.Local).AddTicks(9071), null, new DateTime(2024, 3, 21, 19, 53, 28, 865, DateTimeKind.Local).AddTicks(9073), false, true, null, null },
                    { new Guid("84cb1295-dee6-4dcf-bc92-6ceee2a1f390"), null, new Guid("8e9acec5-54c9-4093-a450-19eb7b2109fb"), "Comment 1", new DateTime(2024, 3, 21, 19, 53, 28, 865, DateTimeKind.Local).AddTicks(9036), null, new DateTime(2024, 3, 21, 19, 53, 28, 865, DateTimeKind.Local).AddTicks(9039), false, true, null, null },
                    { new Guid("8ad86663-f56e-47b4-8416-72b276a4dfbc"), null, new Guid("d9d6b461-8efd-4395-8662-a58caa152200"), "Comment 10", new DateTime(2024, 3, 21, 19, 53, 28, 865, DateTimeKind.Local).AddTicks(9079), null, new DateTime(2024, 3, 21, 19, 53, 28, 865, DateTimeKind.Local).AddTicks(9081), false, true, null, null },
                    { new Guid("8c73444f-5789-47b8-a41d-bae171121876"), null, new Guid("8c44d5c8-a738-4b65-a88e-3ed38fce88c4"), "Comment 3", new DateTime(2024, 3, 21, 19, 53, 28, 865, DateTimeKind.Local).AddTicks(9047), null, new DateTime(2024, 3, 21, 19, 53, 28, 865, DateTimeKind.Local).AddTicks(9048), false, true, null, null },
                    { new Guid("90df61dc-8e1f-4c57-9624-9b284e96534b"), null, new Guid("bd37c967-1817-495b-89eb-665c81b02d5e"), "Comment 7", new DateTime(2024, 3, 21, 19, 53, 28, 865, DateTimeKind.Local).AddTicks(9065), null, new DateTime(2024, 3, 21, 19, 53, 28, 865, DateTimeKind.Local).AddTicks(9067), false, true, null, null },
                    { new Guid("e85bf929-1601-49b1-8635-244daebebe27"), null, new Guid("a25e170e-7ddc-4bdc-9215-51c6fb9bcd96"), "Comment 5", new DateTime(2024, 3, 21, 19, 53, 28, 865, DateTimeKind.Local).AddTicks(9057), null, new DateTime(2024, 3, 21, 19, 53, 28, 865, DateTimeKind.Local).AddTicks(9058), false, true, null, null },
                    { new Guid("fb726e0a-df95-4bde-8c43-656c516755b5"), null, new Guid("b18dcaa1-d99a-4f15-a30c-5fd72c30280e"), "Comment 6", new DateTime(2024, 3, 21, 19, 53, 28, 865, DateTimeKind.Local).AddTicks(9061), null, new DateTime(2024, 3, 21, 19, 53, 28, 865, DateTimeKind.Local).AddTicks(9063), false, true, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("871a809a-b3fa-495b-9cc2-c5d738a861cf"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 19, 53, 28, 865, DateTimeKind.Local).AddTicks(9102));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("871a809a-b3fa-495b-9cc2-c5d738a862cf"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 19, 53, 28, 865, DateTimeKind.Local).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("871a809a-b3fa-495b-9cc2-c5d738a863cf"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 19, 53, 28, 865, DateTimeKind.Local).AddTicks(9110));

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "IsDeleted", "LastModified", "LastModifiedBy", "OrderID", "Point" },
                values: new object[,]
                {
                    { new Guid("52a25c9f-8313-459d-bba9-93195b3a2874"), new DateTime(2024, 3, 21, 19, 53, 28, 865, DateTimeKind.Local).AddTicks(9140), null, "Description 3", false, null, null, new Guid("871a809a-b3fa-495b-9cc2-c5d738a863cf"), 3f },
                    { new Guid("b915e48e-2d2e-4653-9965-a582e8206d30"), new DateTime(2024, 3, 21, 19, 53, 28, 865, DateTimeKind.Local).AddTicks(9136), null, "Description 2", false, null, null, new Guid("871a809a-b3fa-495b-9cc2-c5d738a862cf"), 4f },
                    { new Guid("c9f78b68-b736-4f8d-a60b-0437f29510c5"), new DateTime(2024, 3, 21, 19, 53, 28, 865, DateTimeKind.Local).AddTicks(9133), null, "Description 1", false, null, null, new Guid("871a809a-b3fa-495b-9cc2-c5d738a861cf"), 5f }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_WishLists_ArtWorks_ArtWorkID",
                table: "WishLists",
                column: "ArtWorkID",
                principalTable: "ArtWorks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WishLists_AspNetUsers_ApplicationUserId",
                table: "WishLists",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WishLists_ArtWorks_ArtWorkID",
                table: "WishLists");

            migrationBuilder.DropForeignKey(
                name: "FK_WishLists_AspNetUsers_ApplicationUserId",
                table: "WishLists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WishLists",
                table: "WishLists");

            migrationBuilder.DeleteData(
                table: "ArtistAccount",
                keyColumn: "Id",
                keyValue: new Guid("05307ad9-f233-4cb9-bab6-8b4150869a7d"));

            migrationBuilder.DeleteData(
                table: "ArtistAccount",
                keyColumn: "Id",
                keyValue: new Guid("0af072a6-d573-4962-bb68-63e96b33cf24"));

            migrationBuilder.DeleteData(
                table: "ArtistAccount",
                keyColumn: "Id",
                keyValue: new Guid("37494ef8-637d-488e-b9b4-e5ccf8bef19a"));

            migrationBuilder.DeleteData(
                table: "AudienceAccount",
                keyColumn: "Id",
                keyValue: new Guid("4dab19b7-1795-4f90-8ea3-6879aba24557"));

            migrationBuilder.DeleteData(
                table: "AudienceAccount",
                keyColumn: "Id",
                keyValue: new Guid("d44fd4a9-7cee-498a-8122-08dbed138081"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("326150ab-b8f5-4f06-8e19-5f9a82b91137"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("39f78346-0d2a-4377-a583-d77fbd191982"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("486174e6-b7f2-474b-b259-e8c1926eef12"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("63a84473-e2c2-4a6f-aa28-ad1278d46ce5"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("84cb1295-dee6-4dcf-bc92-6ceee2a1f390"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("8ad86663-f56e-47b4-8416-72b276a4dfbc"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("8c73444f-5789-47b8-a41d-bae171121876"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("90df61dc-8e1f-4c57-9624-9b284e96534b"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("e85bf929-1601-49b1-8635-244daebebe27"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("fb726e0a-df95-4bde-8c43-656c516755b5"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("52a25c9f-8313-459d-bba9-93195b3a2874"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("b915e48e-2d2e-4653-9965-a582e8206d30"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("c9f78b68-b736-4f8d-a60b-0437f29510c5"));

            migrationBuilder.RenameTable(
                name: "WishLists",
                newName: "WishList");

            migrationBuilder.RenameIndex(
                name: "IX_WishLists_ArtWorkID",
                table: "WishList",
                newName: "IX_WishList_ArtWorkID");

            migrationBuilder.RenameIndex(
                name: "IX_WishLists_ApplicationUserId",
                table: "WishList",
                newName: "IX_WishList_ApplicationUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WishList",
                table: "WishList",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_WishList_ArtWorks_ArtWorkID",
                table: "WishList",
                column: "ArtWorkID",
                principalTable: "ArtWorks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WishList_AspNetUsers_ApplicationUserId",
                table: "WishList",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AWS_BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class update3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtWorkCategory");

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

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("1f35558f-a942-4837-81a4-720bae0e8bb1"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 19, 54, 28, 722, DateTimeKind.Local).AddTicks(200));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("26709dca-1906-4c50-a00e-1c63582ab644"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 19, 54, 28, 722, DateTimeKind.Local).AddTicks(132));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("7b76bf1f-d24c-4ac9-b466-4179e65605b2"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 19, 54, 28, 722, DateTimeKind.Local).AddTicks(141));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("8c44d5c8-a738-4b65-a88e-3ed38fce88c4"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 19, 54, 28, 722, DateTimeKind.Local).AddTicks(137));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("8e9acec5-54c9-4093-a450-19eb7b2109fb"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 19, 54, 28, 722, DateTimeKind.Local).AddTicks(126));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("9db314d0-6a55-492c-9a13-7ee6f2091cbf"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 19, 54, 28, 722, DateTimeKind.Local).AddTicks(203));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("a25e170e-7ddc-4bdc-9215-51c6fb9bcd96"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 19, 54, 28, 722, DateTimeKind.Local).AddTicks(144));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("b18dcaa1-d99a-4f15-a30c-5fd72c30280e"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 19, 54, 28, 722, DateTimeKind.Local).AddTicks(148));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("bd37c967-1817-495b-89eb-665c81b02d5e"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 19, 54, 28, 722, DateTimeKind.Local).AddTicks(154));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("d9d6b461-8efd-4395-8662-a58caa152200"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 19, 54, 28, 722, DateTimeKind.Local).AddTicks(206));

            migrationBuilder.InsertData(
                table: "ArtistAccount",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "UserAccountId" },
                values: new object[,]
                {
                    { new Guid("4636d38e-1884-46e6-a9f9-fa2d54e7447b"), new DateTime(2024, 3, 21, 19, 54, 28, 722, DateTimeKind.Local).AddTicks(63), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cg" },
                    { new Guid("a83e16b2-6d3b-424f-ab31-02596b585b6a"), new DateTime(2024, 3, 21, 19, 54, 28, 722, DateTimeKind.Local).AddTicks(66), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866ch" },
                    { new Guid("bb7d48d0-b6a2-482f-acd5-374a000174c3"), new DateTime(2024, 3, 21, 19, 54, 28, 722, DateTimeKind.Local).AddTicks(59), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cf" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cf",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5c01d65a-92d4-4cc3-a08f-6146007a21e3", "71201ba2-27c3-4f55-84e3-de61c0ea3290" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cg",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d0eafd38-6be1-46c1-a821-022ddc648a3d", "b144d408-71ad-48b8-9f08-5c24aaf14b63" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866ch",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6e12adaf-b31a-4e8d-a951-2e2aadd8cd14", "9956a3fb-2187-4e31-ba0e-a2202371af2f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866ci",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "540380a3-b770-4246-a861-d3523f7847c4", "18c5527f-ef47-4bd1-98ac-edb23a129e45" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cj",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e7a0ffa1-ff1c-4f4e-9180-1b7716d5d2a9", "d232fcfc-864f-46ba-a662-33a0147fec80" });

            migrationBuilder.InsertData(
                table: "AudienceAccount",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "UserAccountId" },
                values: new object[,]
                {
                    { new Guid("6bb05e39-7f7c-46e8-b28f-16a78fc26712"), new DateTime(2024, 3, 21, 19, 54, 28, 722, DateTimeKind.Local).AddTicks(93), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cj" },
                    { new Guid("be74b842-a7dd-48bc-b6cd-e9d2cee4ffb9"), new DateTime(2024, 3, 21, 19, 54, 28, 722, DateTimeKind.Local).AddTicks(87), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866ci" }
                });

            migrationBuilder.InsertData(
                table: "Interacts",
                columns: new[] { "Id", "ApplicationUserId", "ArtWorkID", "Comment", "Created", "CreatedBy", "Date", "IsDeleted", "IsLike", "LastModified", "LastModifiedBy" },
                values: new object[,]
                {
                    { new Guid("3f1707f9-8112-4b62-9f1d-ce5f2dcdf50a"), null, new Guid("26709dca-1906-4c50-a00e-1c63582ab644"), "Comment 2", new DateTime(2024, 3, 21, 19, 54, 28, 722, DateTimeKind.Local).AddTicks(238), null, new DateTime(2024, 3, 21, 19, 54, 28, 722, DateTimeKind.Local).AddTicks(239), false, true, null, null },
                    { new Guid("71dc7120-b5e4-44dd-89a5-a5885581dae6"), null, new Guid("9db314d0-6a55-492c-9a13-7ee6f2091cbf"), "Comment 9", new DateTime(2024, 3, 21, 19, 54, 28, 722, DateTimeKind.Local).AddTicks(271), null, new DateTime(2024, 3, 21, 19, 54, 28, 722, DateTimeKind.Local).AddTicks(272), false, true, null, null },
                    { new Guid("737c152d-223a-4469-89df-a7dd286fa6b8"), null, new Guid("bd37c967-1817-495b-89eb-665c81b02d5e"), "Comment 7", new DateTime(2024, 3, 21, 19, 54, 28, 722, DateTimeKind.Local).AddTicks(263), null, new DateTime(2024, 3, 21, 19, 54, 28, 722, DateTimeKind.Local).AddTicks(264), false, true, null, null },
                    { new Guid("765fbcce-62d1-4145-81e9-24ab02672265"), null, new Guid("7b76bf1f-d24c-4ac9-b466-4179e65605b2"), "Comment 4", new DateTime(2024, 3, 21, 19, 54, 28, 722, DateTimeKind.Local).AddTicks(249), null, new DateTime(2024, 3, 21, 19, 54, 28, 722, DateTimeKind.Local).AddTicks(250), false, true, null, null },
                    { new Guid("a43abead-f7be-413c-81a9-f1d6ea675b0d"), null, new Guid("1f35558f-a942-4837-81a4-720bae0e8bb1"), "Comment 8", new DateTime(2024, 3, 21, 19, 54, 28, 722, DateTimeKind.Local).AddTicks(267), null, new DateTime(2024, 3, 21, 19, 54, 28, 722, DateTimeKind.Local).AddTicks(268), false, true, null, null },
                    { new Guid("a5303209-98ca-416f-8b9c-5932fa28322b"), null, new Guid("b18dcaa1-d99a-4f15-a30c-5fd72c30280e"), "Comment 6", new DateTime(2024, 3, 21, 19, 54, 28, 722, DateTimeKind.Local).AddTicks(257), null, new DateTime(2024, 3, 21, 19, 54, 28, 722, DateTimeKind.Local).AddTicks(258), false, true, null, null },
                    { new Guid("a8177835-6248-40cf-af30-08ae98f53d5d"), null, new Guid("8c44d5c8-a738-4b65-a88e-3ed38fce88c4"), "Comment 3", new DateTime(2024, 3, 21, 19, 54, 28, 722, DateTimeKind.Local).AddTicks(244), null, new DateTime(2024, 3, 21, 19, 54, 28, 722, DateTimeKind.Local).AddTicks(246), false, true, null, null },
                    { new Guid("d375ffed-fa6c-4534-8898-38a516e5fbb6"), null, new Guid("d9d6b461-8efd-4395-8662-a58caa152200"), "Comment 10", new DateTime(2024, 3, 21, 19, 54, 28, 722, DateTimeKind.Local).AddTicks(275), null, new DateTime(2024, 3, 21, 19, 54, 28, 722, DateTimeKind.Local).AddTicks(276), false, true, null, null },
                    { new Guid("d47bb0ad-1fe6-46f2-bf0c-ec80a577b16f"), null, new Guid("8e9acec5-54c9-4093-a450-19eb7b2109fb"), "Comment 1", new DateTime(2024, 3, 21, 19, 54, 28, 722, DateTimeKind.Local).AddTicks(232), null, new DateTime(2024, 3, 21, 19, 54, 28, 722, DateTimeKind.Local).AddTicks(234), false, true, null, null },
                    { new Guid("ec44f138-9d25-44cc-9a10-d87bc48d82ec"), null, new Guid("a25e170e-7ddc-4bdc-9215-51c6fb9bcd96"), "Comment 5", new DateTime(2024, 3, 21, 19, 54, 28, 722, DateTimeKind.Local).AddTicks(253), null, new DateTime(2024, 3, 21, 19, 54, 28, 722, DateTimeKind.Local).AddTicks(254), false, true, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("871a809a-b3fa-495b-9cc2-c5d738a861cf"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 19, 54, 28, 722, DateTimeKind.Local).AddTicks(298));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("871a809a-b3fa-495b-9cc2-c5d738a862cf"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 19, 54, 28, 722, DateTimeKind.Local).AddTicks(303));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("871a809a-b3fa-495b-9cc2-c5d738a863cf"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 19, 54, 28, 722, DateTimeKind.Local).AddTicks(307));

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "IsDeleted", "LastModified", "LastModifiedBy", "OrderID", "Point" },
                values: new object[,]
                {
                    { new Guid("7f654949-cd0b-4386-93c0-c547db73869c"), new DateTime(2024, 3, 21, 19, 54, 28, 722, DateTimeKind.Local).AddTicks(329), null, "Description 2", false, null, null, new Guid("871a809a-b3fa-495b-9cc2-c5d738a862cf"), 4f },
                    { new Guid("b8ff5608-b9f2-482a-b737-97707c4b9a38"), new DateTime(2024, 3, 21, 19, 54, 28, 722, DateTimeKind.Local).AddTicks(334), null, "Description 3", false, null, null, new Guid("871a809a-b3fa-495b-9cc2-c5d738a863cf"), 3f },
                    { new Guid("d8080722-d479-43b4-b4f2-594f4c798d2e"), new DateTime(2024, 3, 21, 19, 54, 28, 722, DateTimeKind.Local).AddTicks(325), null, "Description 1", false, null, null, new Guid("871a809a-b3fa-495b-9cc2-c5d738a861cf"), 5f }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArtWorks_CategoryId",
                table: "ArtWorks",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_ArtWorks_Categories_CategoryId",
                table: "ArtWorks",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArtWorks_Categories_CategoryId",
                table: "ArtWorks");

            migrationBuilder.DropIndex(
                name: "IX_ArtWorks_CategoryId",
                table: "ArtWorks");

            migrationBuilder.DeleteData(
                table: "ArtistAccount",
                keyColumn: "Id",
                keyValue: new Guid("4636d38e-1884-46e6-a9f9-fa2d54e7447b"));

            migrationBuilder.DeleteData(
                table: "ArtistAccount",
                keyColumn: "Id",
                keyValue: new Guid("a83e16b2-6d3b-424f-ab31-02596b585b6a"));

            migrationBuilder.DeleteData(
                table: "ArtistAccount",
                keyColumn: "Id",
                keyValue: new Guid("bb7d48d0-b6a2-482f-acd5-374a000174c3"));

            migrationBuilder.DeleteData(
                table: "AudienceAccount",
                keyColumn: "Id",
                keyValue: new Guid("6bb05e39-7f7c-46e8-b28f-16a78fc26712"));

            migrationBuilder.DeleteData(
                table: "AudienceAccount",
                keyColumn: "Id",
                keyValue: new Guid("be74b842-a7dd-48bc-b6cd-e9d2cee4ffb9"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("3f1707f9-8112-4b62-9f1d-ce5f2dcdf50a"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("71dc7120-b5e4-44dd-89a5-a5885581dae6"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("737c152d-223a-4469-89df-a7dd286fa6b8"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("765fbcce-62d1-4145-81e9-24ab02672265"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("a43abead-f7be-413c-81a9-f1d6ea675b0d"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("a5303209-98ca-416f-8b9c-5932fa28322b"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("a8177835-6248-40cf-af30-08ae98f53d5d"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("d375ffed-fa6c-4534-8898-38a516e5fbb6"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("d47bb0ad-1fe6-46f2-bf0c-ec80a577b16f"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("ec44f138-9d25-44cc-9a10-d87bc48d82ec"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("7f654949-cd0b-4386-93c0-c547db73869c"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("b8ff5608-b9f2-482a-b737-97707c4b9a38"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("d8080722-d479-43b4-b4f2-594f4c798d2e"));

            migrationBuilder.CreateTable(
                name: "ArtWorkCategory",
                columns: table => new
                {
                    ArtWorksId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoriesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtWorkCategory", x => new { x.ArtWorksId, x.CategoriesId });
                    table.ForeignKey(
                        name: "FK_ArtWorkCategory_ArtWorks_ArtWorksId",
                        column: x => x.ArtWorksId,
                        principalTable: "ArtWorks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtWorkCategory_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ArtWorkCategory_CategoriesId",
                table: "ArtWorkCategory",
                column: "CategoriesId");
        }
    }
}

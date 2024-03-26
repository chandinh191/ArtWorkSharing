﻿using System;
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
            migrationBuilder.DeleteData(
                table: "ArtistAccount",
                keyColumn: "Id",
                keyValue: new Guid("2faf0458-3928-4f00-832e-93bd1a425a06"));

            migrationBuilder.DeleteData(
                table: "ArtistAccount",
                keyColumn: "Id",
                keyValue: new Guid("725cc757-35ab-4adc-8aed-c6e6f1b08f64"));

            migrationBuilder.DeleteData(
                table: "ArtistAccount",
                keyColumn: "Id",
                keyValue: new Guid("b7b9068a-a245-4b34-bc6d-104e1f69d561"));

            migrationBuilder.DeleteData(
                table: "AudienceAccount",
                keyColumn: "Id",
                keyValue: new Guid("1e1f085d-2998-49ad-ad0d-9b182b610d11"));

            migrationBuilder.DeleteData(
                table: "AudienceAccount",
                keyColumn: "Id",
                keyValue: new Guid("f6b83e57-e360-4537-8368-27a3c98be349"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("3381518e-0176-469c-be6c-bd5fc445050a"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("44094f36-f103-4cd6-86d4-f89023546393"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("63b6f510-dda3-41ff-927a-21fc38d3167c"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("641b9768-1a0b-4fdc-9b34-6ba140818acd"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("b1080d50-33e4-415b-9984-e8e919d37e66"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("b1ceff87-8c0d-480b-8f98-bf17d864bc01"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("c1f3d88a-212c-4694-b6c8-accce65bedf6"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("c345caa7-8138-4c2f-b623-d71e801becce"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("d29dc285-e9f0-4af4-b045-6d8fc0a18caa"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("f6445393-e4d5-4814-85b5-de8163d76eaf"));

            migrationBuilder.DropColumn(
                name: "IsPreOrder",
                table: "ArtWorks");

            migrationBuilder.DropColumn(
                name: "IsSold",
                table: "ArtWorks");

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("1f35558f-a942-4837-81a4-720bae0e8bb1"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("26709dca-1906-4c50-a00e-1c63582ab644"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("7b76bf1f-d24c-4ac9-b466-4179e65605b2"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8337));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("8c44d5c8-a738-4b65-a88e-3ed38fce88c4"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("8e9acec5-54c9-4093-a450-19eb7b2109fb"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("9db314d0-6a55-492c-9a13-7ee6f2091cbf"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("a25e170e-7ddc-4bdc-9215-51c6fb9bcd96"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("b18dcaa1-d99a-4f15-a30c-5fd72c30280e"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("bd37c967-1817-495b-89eb-665c81b02d5e"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("d9d6b461-8efd-4395-8662-a58caa152200"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8428));

            migrationBuilder.InsertData(
                table: "ArtistAccount",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "UserAccountId" },
                values: new object[,]
                {
                    { new Guid("1cc24e6a-2346-4871-bc5b-f05ab0cfb506"), new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8279), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866ch" },
                    { new Guid("a53c5a0f-a45c-49f5-b14a-5bb5e4df6096"), new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8273), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cf" },
                    { new Guid("d6af9c10-5091-4334-9142-0d0cf16d63ff"), new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8276), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cg" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cf",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4c2afef9-58dd-4e6c-8d1c-2aaebfae32c7", "b42c3d98-0910-409e-8553-aaaca7c125b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cg",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "402cdb70-10b8-4c68-bec3-13000b656cef", "6189db8f-272b-461c-8c71-c28d626f449a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866ch",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "26e6ab37-15ff-4f75-9d08-ab6ae3f77747", "288fe1ed-1e7c-4705-ac6d-fa58c5fa8ab1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866ci",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b942ed3c-53b6-4c85-9d93-4e7ce1b3c554", "7f79e2ed-6cb6-44f3-b83a-7e696faafb44" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cj",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "442a02ed-1f08-4da8-9d99-9c7ce4d975f8", "2be6b765-c6da-496f-935d-b0cae2bc38ca" });

            migrationBuilder.InsertData(
                table: "AudienceAccount",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "UserAccountId" },
                values: new object[,]
                {
                    { new Guid("2349de24-cd57-472a-9386-5fa0a04546d8"), new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8298), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866ci" },
                    { new Guid("41c86f37-5bde-4614-a8d1-f93f7e24c2da"), new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8304), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cj" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("26b5fcea-c9cb-4c7c-ad93-100a6d8611d6"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8009));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("53b50d7f-44eb-4dda-84b1-9d3c938eba22"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8002));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("58c96dfc-1c31-429b-9c6c-378db1c68b2a"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8005));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5d935698-bc0f-4692-88a3-43234943be40"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8007));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b1799e22-2212-43d2-a09a-6a0371f2d89c"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(7973));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b3cb8ee0-c965-4970-8ef0-baad50ebf987"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(7999));

            migrationBuilder.InsertData(
                table: "Interacts",
                columns: new[] { "Id", "ApplicationUserId", "ArtWorkID", "Comment", "Created", "CreatedBy", "Date", "IsDeleted", "IsLike", "LastModified", "LastModifiedBy" },
                values: new object[,]
                {
                    { new Guid("063a2723-5c40-4b3d-98a0-3d53b2ec898d"), null, new Guid("a25e170e-7ddc-4bdc-9215-51c6fb9bcd96"), "Comment 5", new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8474), null, new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8475), false, true, null, null },
                    { new Guid("65dd7003-65ba-4e9a-91e8-bad26c267cb0"), null, new Guid("d9d6b461-8efd-4395-8662-a58caa152200"), "Comment 10", new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8496), null, new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8497), false, true, null, null },
                    { new Guid("6cd1c2ab-1da7-4779-9891-8a362a25bad0"), null, new Guid("26709dca-1906-4c50-a00e-1c63582ab644"), "Comment 2", new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8459), null, new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8460), false, true, null, null },
                    { new Guid("78adffc6-da3b-48f0-9ae3-122f8a3b0819"), null, new Guid("bd37c967-1817-495b-89eb-665c81b02d5e"), "Comment 7", new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8484), null, new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8485), false, true, null, null },
                    { new Guid("86baf719-84db-42fd-97fc-76cca75137aa"), null, new Guid("1f35558f-a942-4837-81a4-720bae0e8bb1"), "Comment 8", new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8488), null, new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8489), false, true, null, null },
                    { new Guid("8e329e08-e700-46fb-9ef7-276002800b59"), null, new Guid("8c44d5c8-a738-4b65-a88e-3ed38fce88c4"), "Comment 3", new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8466), null, new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8467), false, true, null, null },
                    { new Guid("90c0bd5a-c9cd-4399-b20c-043a012ec944"), null, new Guid("b18dcaa1-d99a-4f15-a30c-5fd72c30280e"), "Comment 6", new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8478), null, new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8479), false, true, null, null },
                    { new Guid("d805999d-84cf-4f91-9954-853004a5f459"), null, new Guid("9db314d0-6a55-492c-9a13-7ee6f2091cbf"), "Comment 9", new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8492), null, new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8493), false, true, null, null },
                    { new Guid("e4286c2d-6ece-4c45-837e-3216cd8c89dc"), null, new Guid("8e9acec5-54c9-4093-a450-19eb7b2109fb"), "Comment 1", new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8453), null, new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8456), false, true, null, null },
                    { new Guid("f19cfe37-08bd-43ba-9641-023311ff11cb"), null, new Guid("7b76bf1f-d24c-4ac9-b466-4179e65605b2"), "Comment 4", new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8470), null, new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8471), false, true, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArtistAccount",
                keyColumn: "Id",
                keyValue: new Guid("1cc24e6a-2346-4871-bc5b-f05ab0cfb506"));

            migrationBuilder.DeleteData(
                table: "ArtistAccount",
                keyColumn: "Id",
                keyValue: new Guid("a53c5a0f-a45c-49f5-b14a-5bb5e4df6096"));

            migrationBuilder.DeleteData(
                table: "ArtistAccount",
                keyColumn: "Id",
                keyValue: new Guid("d6af9c10-5091-4334-9142-0d0cf16d63ff"));

            migrationBuilder.DeleteData(
                table: "AudienceAccount",
                keyColumn: "Id",
                keyValue: new Guid("2349de24-cd57-472a-9386-5fa0a04546d8"));

            migrationBuilder.DeleteData(
                table: "AudienceAccount",
                keyColumn: "Id",
                keyValue: new Guid("41c86f37-5bde-4614-a8d1-f93f7e24c2da"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("063a2723-5c40-4b3d-98a0-3d53b2ec898d"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("65dd7003-65ba-4e9a-91e8-bad26c267cb0"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("6cd1c2ab-1da7-4779-9891-8a362a25bad0"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("78adffc6-da3b-48f0-9ae3-122f8a3b0819"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("86baf719-84db-42fd-97fc-76cca75137aa"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("8e329e08-e700-46fb-9ef7-276002800b59"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("90c0bd5a-c9cd-4399-b20c-043a012ec944"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("d805999d-84cf-4f91-9954-853004a5f459"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("e4286c2d-6ece-4c45-837e-3216cd8c89dc"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("f19cfe37-08bd-43ba-9641-023311ff11cb"));

            migrationBuilder.AddColumn<bool>(
                name: "IsPreOrder",
                table: "ArtWorks",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSold",
                table: "ArtWorks",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("1f35558f-a942-4837-81a4-720bae0e8bb1"),
                columns: new[] { "Created", "IsPreOrder", "IsSold" },
                values: new object[] { new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7871), false, false });

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("26709dca-1906-4c50-a00e-1c63582ab644"),
                columns: new[] { "Created", "IsPreOrder", "IsSold" },
                values: new object[] { new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7844), true, false });

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("7b76bf1f-d24c-4ac9-b466-4179e65605b2"),
                columns: new[] { "Created", "IsPreOrder", "IsSold" },
                values: new object[] { new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7853), false, false });

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("8c44d5c8-a738-4b65-a88e-3ed38fce88c4"),
                columns: new[] { "Created", "IsPreOrder", "IsSold" },
                values: new object[] { new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7848), true, false });

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("8e9acec5-54c9-4093-a450-19eb7b2109fb"),
                columns: new[] { "Created", "IsPreOrder", "IsSold" },
                values: new object[] { new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7838), false, false });

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("9db314d0-6a55-492c-9a13-7ee6f2091cbf"),
                columns: new[] { "Created", "IsPreOrder", "IsSold" },
                values: new object[] { new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7876), true, false });

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("a25e170e-7ddc-4bdc-9215-51c6fb9bcd96"),
                columns: new[] { "Created", "IsPreOrder", "IsSold" },
                values: new object[] { new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7857), false, false });

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("b18dcaa1-d99a-4f15-a30c-5fd72c30280e"),
                columns: new[] { "Created", "IsPreOrder", "IsSold" },
                values: new object[] { new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7863), false, false });

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("bd37c967-1817-495b-89eb-665c81b02d5e"),
                columns: new[] { "Created", "IsPreOrder", "IsSold" },
                values: new object[] { new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7867), false, false });

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("d9d6b461-8efd-4395-8662-a58caa152200"),
                columns: new[] { "Created", "IsPreOrder", "IsSold" },
                values: new object[] { new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7880), true, false });

            migrationBuilder.InsertData(
                table: "ArtistAccount",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "UserAccountId" },
                values: new object[,]
                {
                    { new Guid("2faf0458-3928-4f00-832e-93bd1a425a06"), new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7789), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cg" },
                    { new Guid("725cc757-35ab-4adc-8aed-c6e6f1b08f64"), new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7786), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cf" },
                    { new Guid("b7b9068a-a245-4b34-bc6d-104e1f69d561"), new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7791), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866ch" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cf",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f3f05e8c-bcab-44f5-91db-6b70ceb5c81f", "140cacd6-571b-4f0a-8c25-26654e26d96f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cg",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ce3dfe14-3cd2-4ce5-a0e5-fe99e1f1e1ee", "279aa2a4-b729-4b07-ad2f-765e165e062b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866ch",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a02f62a7-22d9-45a2-b2fd-b9837e7e379b", "605ff71d-3455-4001-8939-ee94022162c0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866ci",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "081e35f5-477e-4116-8c3d-f468f4578bf9", "530e329b-fbcb-4119-802a-afda0d753dbe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cj",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fc4a9a4f-5dfc-40cd-98fd-b2ac2c5e1b2f", "80f0da9c-8906-4848-9fb7-090c16da0f81" });

            migrationBuilder.InsertData(
                table: "AudienceAccount",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "UserAccountId" },
                values: new object[,]
                {
                    { new Guid("1e1f085d-2998-49ad-ad0d-9b182b610d11"), new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7815), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cj" },
                    { new Guid("f6b83e57-e360-4537-8368-27a3c98be349"), new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7812), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866ci" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("26b5fcea-c9cb-4c7c-ad93-100a6d8611d6"),
                column: "Created",
                value: new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7516));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("53b50d7f-44eb-4dda-84b1-9d3c938eba22"),
                column: "Created",
                value: new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7498));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("58c96dfc-1c31-429b-9c6c-378db1c68b2a"),
                column: "Created",
                value: new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5d935698-bc0f-4692-88a3-43234943be40"),
                column: "Created",
                value: new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b1799e22-2212-43d2-a09a-6a0371f2d89c"),
                column: "Created",
                value: new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b3cb8ee0-c965-4970-8ef0-baad50ebf987"),
                column: "Created",
                value: new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7495));

            migrationBuilder.InsertData(
                table: "Interacts",
                columns: new[] { "Id", "ApplicationUserId", "ArtWorkID", "Comment", "Created", "CreatedBy", "Date", "IsDeleted", "IsLike", "LastModified", "LastModifiedBy" },
                values: new object[,]
                {
                    { new Guid("3381518e-0176-469c-be6c-bd5fc445050a"), null, new Guid("8e9acec5-54c9-4093-a450-19eb7b2109fb"), "Comment 1", new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7901), null, new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7904), false, true, null, null },
                    { new Guid("44094f36-f103-4cd6-86d4-f89023546393"), null, new Guid("26709dca-1906-4c50-a00e-1c63582ab644"), "Comment 2", new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7909), null, new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7910), false, true, null, null },
                    { new Guid("63b6f510-dda3-41ff-927a-21fc38d3167c"), null, new Guid("bd37c967-1817-495b-89eb-665c81b02d5e"), "Comment 7", new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7929), null, new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7931), false, true, null, null },
                    { new Guid("641b9768-1a0b-4fdc-9b34-6ba140818acd"), null, new Guid("9db314d0-6a55-492c-9a13-7ee6f2091cbf"), "Comment 9", new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7937), null, new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7938), false, true, null, null },
                    { new Guid("b1080d50-33e4-415b-9984-e8e919d37e66"), null, new Guid("b18dcaa1-d99a-4f15-a30c-5fd72c30280e"), "Comment 6", new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7926), null, new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7927), false, true, null, null },
                    { new Guid("b1ceff87-8c0d-480b-8f98-bf17d864bc01"), null, new Guid("7b76bf1f-d24c-4ac9-b466-4179e65605b2"), "Comment 4", new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7917), null, new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7918), false, true, null, null },
                    { new Guid("c1f3d88a-212c-4694-b6c8-accce65bedf6"), null, new Guid("8c44d5c8-a738-4b65-a88e-3ed38fce88c4"), "Comment 3", new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7913), null, new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7914), false, true, null, null },
                    { new Guid("c345caa7-8138-4c2f-b623-d71e801becce"), null, new Guid("d9d6b461-8efd-4395-8662-a58caa152200"), "Comment 10", new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7942), null, new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7944), false, true, null, null },
                    { new Guid("d29dc285-e9f0-4af4-b045-6d8fc0a18caa"), null, new Guid("a25e170e-7ddc-4bdc-9215-51c6fb9bcd96"), "Comment 5", new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7920), null, new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7921), false, true, null, null },
                    { new Guid("f6445393-e4d5-4814-85b5-de8163d76eaf"), null, new Guid("1f35558f-a942-4837-81a4-720bae0e8bb1"), "Comment 8", new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7933), null, new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7934), false, true, null, null }
                });
        }
    }
}

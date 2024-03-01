using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AWS_Repository.Migrations
{
    /// <inheritdoc />
    public partial class init1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArtWorks_AspNetUsers_ApplicationUserId",
                table: "ArtWorks");

            migrationBuilder.DropIndex(
                name: "IX_ArtWorks_ApplicationUserId",
                table: "ArtWorks");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "ArtWorks");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Packages",
                newName: "NamePacked");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "ArtWorks",
                newName: "ArtWorkStatus");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Reports",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "PackageDetails",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ArtWorkId",
                table: "Orders",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Interacts",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ArtWorkID",
                table: "Interacts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Interacts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Interacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsLike",
                table: "Interacts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "UserAccountId",
                table: "Interacts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "UserOwnerId",
                table: "ArtWorks",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "UserAccountId",
                table: "ArtWorks",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateTable(
                name: "AdminAccount",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserAccountId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminAccount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdminAccount_AspNetUsers_UserAccountId",
                        column: x => x.UserAccountId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArtistAccount",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserAccountId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistAccount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArtistAccount_AspNetUsers_UserAccountId",
                        column: x => x.UserAccountId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AudienceAccount",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserAccountId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AudienceAccount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AudienceAccount_AspNetUsers_UserAccountId",
                        column: x => x.UserAccountId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_OrderID",
                table: "Ratings",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_PackageDetails_ApplicationUserId",
                table: "PackageDetails",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PackageDetails_PackageID",
                table: "PackageDetails",
                column: "PackageID");

            migrationBuilder.CreateIndex(
                name: "IX_PackageDetails_PaymentMethodID",
                table: "PackageDetails",
                column: "PaymentMethodID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ArtWorkId",
                table: "Orders",
                column: "ArtWorkId");

            migrationBuilder.CreateIndex(
                name: "IX_Interacts_ApplicationUserId",
                table: "Interacts",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Interacts_ArtWorkID",
                table: "Interacts",
                column: "ArtWorkID");

            migrationBuilder.CreateIndex(
                name: "IX_ArtWorks_UserAccountId",
                table: "ArtWorks",
                column: "UserAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_AdminAccount_UserAccountId",
                table: "AdminAccount",
                column: "UserAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtistAccount_UserAccountId",
                table: "ArtistAccount",
                column: "UserAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_AudienceAccount_UserAccountId",
                table: "AudienceAccount",
                column: "UserAccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_ArtWorks_AspNetUsers_UserAccountId",
                table: "ArtWorks",
                column: "UserAccountId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Interacts_ArtWorks_ArtWorkID",
                table: "Interacts",
                column: "ArtWorkID",
                principalTable: "ArtWorks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Interacts_AspNetUsers_ApplicationUserId",
                table: "Interacts",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_ArtWorks_ArtWorkId",
                table: "Orders",
                column: "ArtWorkId",
                principalTable: "ArtWorks",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PackageDetails_AspNetUsers_ApplicationUserId",
                table: "PackageDetails",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PackageDetails_Packages_PackageID",
                table: "PackageDetails",
                column: "PackageID",
                principalTable: "Packages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PackageDetails_PaymentMethods_PaymentMethodID",
                table: "PackageDetails",
                column: "PaymentMethodID",
                principalTable: "PaymentMethods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Orders_OrderID",
                table: "Ratings",
                column: "OrderID",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArtWorks_AspNetUsers_UserAccountId",
                table: "ArtWorks");

            migrationBuilder.DropForeignKey(
                name: "FK_Interacts_ArtWorks_ArtWorkID",
                table: "Interacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Interacts_AspNetUsers_ApplicationUserId",
                table: "Interacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_ArtWorks_ArtWorkId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_PackageDetails_AspNetUsers_ApplicationUserId",
                table: "PackageDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PackageDetails_Packages_PackageID",
                table: "PackageDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PackageDetails_PaymentMethods_PaymentMethodID",
                table: "PackageDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Orders_OrderID",
                table: "Ratings");

            migrationBuilder.DropTable(
                name: "AdminAccount");

            migrationBuilder.DropTable(
                name: "ArtistAccount");

            migrationBuilder.DropTable(
                name: "AudienceAccount");

            migrationBuilder.DropIndex(
                name: "IX_Ratings_OrderID",
                table: "Ratings");

            migrationBuilder.DropIndex(
                name: "IX_PackageDetails_ApplicationUserId",
                table: "PackageDetails");

            migrationBuilder.DropIndex(
                name: "IX_PackageDetails_PackageID",
                table: "PackageDetails");

            migrationBuilder.DropIndex(
                name: "IX_PackageDetails_PaymentMethodID",
                table: "PackageDetails");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ArtWorkId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Interacts_ApplicationUserId",
                table: "Interacts");

            migrationBuilder.DropIndex(
                name: "IX_Interacts_ArtWorkID",
                table: "Interacts");

            migrationBuilder.DropIndex(
                name: "IX_ArtWorks_UserAccountId",
                table: "ArtWorks");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "PackageDetails");

            migrationBuilder.DropColumn(
                name: "ArtWorkId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Interacts");

            migrationBuilder.DropColumn(
                name: "ArtWorkID",
                table: "Interacts");

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Interacts");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Interacts");

            migrationBuilder.DropColumn(
                name: "IsLike",
                table: "Interacts");

            migrationBuilder.DropColumn(
                name: "UserAccountId",
                table: "Interacts");

            migrationBuilder.RenameColumn(
                name: "NamePacked",
                table: "Packages",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ArtWorkStatus",
                table: "ArtWorks",
                newName: "Status");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Reports",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UserOwnerId",
                table: "ArtWorks",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserAccountId",
                table: "ArtWorks",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "ArtWorks",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ArtWorks_ApplicationUserId",
                table: "ArtWorks",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ArtWorks_AspNetUsers_ApplicationUserId",
                table: "ArtWorks",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}

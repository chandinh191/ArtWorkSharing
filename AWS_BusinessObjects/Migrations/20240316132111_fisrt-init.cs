using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AWS_BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class fisrtinit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeviceCodes",
                columns: table => new
                {
                    UserCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DeviceCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceCodes", x => x.UserCode);
                });

            migrationBuilder.CreateTable(
                name: "Keys",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Use = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Algorithm = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsX509Certificate = table.Column<bool>(type: "bit", nullable: false),
                    DataProtected = table.Column<bool>(type: "bit", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Packages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NamePacked = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PackageStatus = table.Column<int>(type: "int", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethods",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentMethodStatus = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersistedGrants",
                columns: table => new
                {
                    Key = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConsumedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersistedGrants", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "ArtWorks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserAccountId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserOwnerId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArtWorkStatus = table.Column<int>(type: "int", nullable: false),
                    IsSold = table.Column<bool>(type: "bit", nullable: false),
                    IsPreOrder = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtWorks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArtWorks_AspNetUsers_UserAccountId",
                        column: x => x.UserAccountId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
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

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    applicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserAccountID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserAccountIDReport = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reports_AspNetUsers_applicationUserId",
                        column: x => x.applicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PackageDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PackageID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserAccountId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentMethodID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackageDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PackageDetails_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PackageDetails_Packages_PackageID",
                        column: x => x.PackageID,
                        principalTable: "Packages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PackageDetails_PaymentMethods_PaymentMethodID",
                        column: x => x.PaymentMethodID,
                        principalTable: "PaymentMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Interacts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArtWorkID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsLike = table.Column<bool>(type: "bit", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Interacts_ArtWorks_ArtWorkID",
                        column: x => x.ArtWorkID,
                        principalTable: "ArtWorks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Interacts_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserAccountId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArtWordID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    isPreOrder = table.Column<bool>(type: "bit", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ArtWorkId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_ArtWorks_ArtWorkId",
                        column: x => x.ArtWorkId,
                        principalTable: "ArtWorks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Point = table.Column<float>(type: "real", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ratings_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "871a809a-b3fa-495b-9cc2-c5d738a866cf", 0, null, "c09ccb2b-aaf7-4254-9eb6-ef46611f2473", "hieu123@gmail.com", false, false, null, null, null, "TRANHIEU1", null, null, false, "e345fbe5-aab8-47d7-8dfe-dd04d3b23e79", false, "TranHieu1" },
                    { "871a809a-b3fa-495b-9cc2-c5d738a866cg", 0, null, "22b48627-430d-4814-8b24-e69b2cde79f5", "hieuaccount2@gmail.com", false, false, null, null, null, "TRANHIEU2", null, null, false, "06b86c88-9578-404a-9da9-0a6cf4e2d839", false, "TranHieu2" },
                    { "871a809a-b3fa-495b-9cc2-c5d738a866ch", 0, null, "0969e3e7-8235-493a-aa1c-52262c7f4447", "hieuaccount3@gmail.com", false, false, null, null, null, "TRANHIEU3", null, null, false, "d498bd36-f4ea-4a54-8d2b-f4fd3c54c8a0", false, "TranHieu3" },
                    { "871a809a-b3fa-495b-9cc2-c5d738a866ci", 0, null, "0c7ee9eb-494c-4a2b-a8c5-93d4ed2ae205", "hieuaccount4@gmail.com", false, false, null, null, null, "TRANHIEU4", null, null, false, "9c3154c3-6081-494c-8a28-130d2cf1b2ef", false, "TranHieu4" },
                    { "871a809a-b3fa-495b-9cc2-c5d738a866cj", 0, null, "b421bba5-da8a-4b67-b213-1e71c40c2483", "hieuaccount5@gmail.com", false, false, null, null, null, "TRANHIEU5", null, null, false, "bcc79737-2356-4d0a-b3d9-034bb08f6ef8", false, "TranHieu5" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "ApplicationUserId", "ArtWordID", "ArtWorkId", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "Price", "Status", "UserAccountId", "isPreOrder" },
                values: new object[,]
                {
                    { new Guid("871a809a-b3fa-495b-9cc2-c5d738a861cf"), null, new Guid("8e9acec5-54c9-4093-a450-19eb7b2109fb"), null, new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2428), null, false, null, null, 0f, 1, "871a809a-b3fa-495b-9cc2-c5d738a866cf", false },
                    { new Guid("871a809a-b3fa-495b-9cc2-c5d738a862cf"), null, new Guid("26709dca-1906-4c50-a00e-1c63582ab644"), null, new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2432), null, false, null, null, 0f, 1, "871a809a-b3fa-495b-9cc2-c5d738a866cg", false },
                    { new Guid("871a809a-b3fa-495b-9cc2-c5d738a863cf"), null, new Guid("8c44d5c8-a738-4b65-a88e-3ed38fce88c4"), null, new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2435), null, false, null, null, 0f, 1, "871a809a-b3fa-495b-9cc2-c5d738a866ch", false }
                });

            migrationBuilder.InsertData(
                table: "Packages",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "IsDeleted", "LastModified", "LastModifiedBy", "NamePacked", "PackageStatus" },
                values: new object[,]
                {
                    { new Guid("1ebe4b4b-e00b-4e82-b3be-418f58df9726"), new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2457), null, "Description 1", false, null, null, "Package 1", 1 },
                    { new Guid("39b58807-f4b1-46bb-bdd2-597399a51c90"), new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2461), null, "Description 2", false, null, null, "Package 2", 1 },
                    { new Guid("a04d8c84-4698-4d73-a3cb-e1ce395d5bcf"), new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2464), null, "Description 3", false, null, null, "Package 3", 1 }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethods",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "Name", "PaymentMethodStatus" },
                values: new object[,]
                {
                    { new Guid("c466ed52-40d1-41a7-9a76-141526876859"), new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2514), null, false, null, null, "MOMO", 1 },
                    { new Guid("d3b9eb3f-8da2-40b2-8fd0-d0b09f287008"), new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2517), null, false, null, null, "VN Pay", 1 }
                });

            migrationBuilder.InsertData(
                table: "ArtWorks",
                columns: new[] { "Id", "ArtWorkStatus", "Created", "CreatedBy", "Description", "ImageUrl", "IsDeleted", "IsPreOrder", "IsSold", "LastModified", "LastModifiedBy", "Name", "Price", "UserAccountId", "UserOwnerId" },
                values: new object[,]
                {
                    { new Guid("1f35558f-a942-4837-81a4-720bae0e8bb1"), 1, new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2288), null, "Description 8", "Image 8", false, false, false, null, null, "ArtWork 8", 800f, "871a809a-b3fa-495b-9cc2-c5d738a866ci", "871a809a-b3fa-495b-9cc2-c5d738a866cg" },
                    { new Guid("26709dca-1906-4c50-a00e-1c63582ab644"), 1, new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2268), null, "Description 2", "Image 2", false, false, false, null, null, "ArtWork 2", 200f, "871a809a-b3fa-495b-9cc2-c5d738a866cf", "871a809a-b3fa-495b-9cc2-c5d738a866cg" },
                    { new Guid("7b76bf1f-d24c-4ac9-b466-4179e65605b2"), 1, new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2274), null, "Description 4", "Image 4", false, false, false, null, null, "ArtWork 4", 400f, "871a809a-b3fa-495b-9cc2-c5d738a866cg", "871a809a-b3fa-495b-9cc2-c5d738a866ch" },
                    { new Guid("8c44d5c8-a738-4b65-a88e-3ed38fce88c4"), 1, new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2271), null, "Description 3", "Image 3", false, false, false, null, null, "ArtWork 3", 300f, "871a809a-b3fa-495b-9cc2-c5d738a866cg", "871a809a-b3fa-495b-9cc2-c5d738a866ch" },
                    { new Guid("8e9acec5-54c9-4093-a450-19eb7b2109fb"), 1, new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2260), null, "Description 1", "Image 1", false, false, false, null, null, "ArtWork 1", 100f, "871a809a-b3fa-495b-9cc2-c5d738a866cf", "871a809a-b3fa-495b-9cc2-c5d738a866cg" },
                    { new Guid("9db314d0-6a55-492c-9a13-7ee6f2091cbf"), 1, new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2292), null, "Description 9", "Image 9", false, false, false, null, null, "ArtWork 9", 900f, "871a809a-b3fa-495b-9cc2-c5d738a866cg", "871a809a-b3fa-495b-9cc2-c5d738a866cf" },
                    { new Guid("a25e170e-7ddc-4bdc-9215-51c6fb9bcd96"), 1, new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2278), null, "Description 5", "Image 5", false, false, false, null, null, "ArtWork 5", 500f, "871a809a-b3fa-495b-9cc2-c5d738a866cj", "871a809a-b3fa-495b-9cc2-c5d738a866ci" },
                    { new Guid("b18dcaa1-d99a-4f15-a30c-5fd72c30280e"), 1, new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2281), null, "Description 6", "Image 6", false, false, false, null, null, "ArtWork 6", 600f, "871a809a-b3fa-495b-9cc2-c5d738a866cj", "871a809a-b3fa-495b-9cc2-c5d738a866ci" },
                    { new Guid("bd37c967-1817-495b-89eb-665c81b02d5e"), 1, new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2285), null, "Description 7", "Image 7", false, false, false, null, null, "ArtWork 7", 700f, "871a809a-b3fa-495b-9cc2-c5d738a866ci", "871a809a-b3fa-495b-9cc2-c5d738a866cg" },
                    { new Guid("d9d6b461-8efd-4395-8662-a58caa152200"), 1, new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2297), null, "Description 10", "Image 10", false, false, false, null, null, "ArtWork 10", 1000f, "871a809a-b3fa-495b-9cc2-c5d738a866cg", "871a809a-b3fa-495b-9cc2-c5d738a866cf" }
                });

            migrationBuilder.InsertData(
                table: "PackageDetails",
                columns: new[] { "Id", "ApplicationUserId", "Created", "CreatedBy", "EndDate", "IsDeleted", "LastModified", "LastModifiedBy", "PackageID", "PaymentMethodID", "StartDate", "UserAccountId" },
                values: new object[,]
                {
                    { new Guid("85cf9e9b-d671-4afd-ac2a-8bb7bba9b81a"), null, new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2490), null, new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2489), false, null, null, new Guid("39b58807-f4b1-46bb-bdd2-597399a51c90"), new Guid("d3b9eb3f-8da2-40b2-8fd0-d0b09f287008"), new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2489), "871a809a-b3fa-495b-9cc2-c5d738a866cf" },
                    { new Guid("86257e04-ec32-41ac-bc9c-f86747bff769"), null, new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2485), null, new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2484), false, null, null, new Guid("1ebe4b4b-e00b-4e82-b3be-418f58df9726"), new Guid("c466ed52-40d1-41a7-9a76-141526876859"), new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2484), "871a809a-b3fa-495b-9cc2-c5d738a866ch" },
                    { new Guid("b157598f-bb39-4f3a-bec1-33ac16a161ed"), null, new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2496), null, new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2496), false, null, null, new Guid("a04d8c84-4698-4d73-a3cb-e1ce395d5bcf"), new Guid("d3b9eb3f-8da2-40b2-8fd0-d0b09f287008"), new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2496), "871a809a-b3fa-495b-9cc2-c5d738a866cf" }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "IsDeleted", "LastModified", "LastModifiedBy", "OrderID", "Point" },
                values: new object[,]
                {
                    { new Guid("0d89dad3-b866-466f-8862-55b00aec82a5"), new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2544), null, "Description 3", false, null, null, new Guid("871a809a-b3fa-495b-9cc2-c5d738a863cf"), 3f },
                    { new Guid("1ecccaa0-5071-4c24-9bba-3b79d3de8a2a"), new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2535), null, "Description 1", false, null, null, new Guid("871a809a-b3fa-495b-9cc2-c5d738a861cf"), 5f },
                    { new Guid("886677d3-870b-4c73-ab7f-c80e6ccf924c"), new DateTime(2024, 3, 16, 20, 21, 11, 559, DateTimeKind.Local).AddTicks(2539), null, "Description 2", false, null, null, new Guid("871a809a-b3fa-495b-9cc2-c5d738a862cf"), 4f }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AdminAccount_UserAccountId",
                table: "AdminAccount",
                column: "UserAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtistAccount_UserAccountId",
                table: "ArtistAccount",
                column: "UserAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtWorks_UserAccountId",
                table: "ArtWorks",
                column: "UserAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AudienceAccount_UserAccountId",
                table: "AudienceAccount",
                column: "UserAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_DeviceCode",
                table: "DeviceCodes",
                column: "DeviceCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_Expiration",
                table: "DeviceCodes",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_Interacts_ApplicationUserId",
                table: "Interacts",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Interacts_ArtWorkID",
                table: "Interacts",
                column: "ArtWorkID");

            migrationBuilder.CreateIndex(
                name: "IX_Keys_Use",
                table: "Keys",
                column: "Use");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ApplicationUserId",
                table: "Orders",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ArtWorkId",
                table: "Orders",
                column: "ArtWorkId");

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
                name: "IX_PersistedGrants_ConsumedTime",
                table: "PersistedGrants",
                column: "ConsumedTime");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_Expiration",
                table: "PersistedGrants",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_ClientId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "ClientId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_SessionId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "SessionId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_OrderID",
                table: "Ratings",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_applicationUserId",
                table: "Reports",
                column: "applicationUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminAccount");

            migrationBuilder.DropTable(
                name: "ArtistAccount");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AudienceAccount");

            migrationBuilder.DropTable(
                name: "DeviceCodes");

            migrationBuilder.DropTable(
                name: "Interacts");

            migrationBuilder.DropTable(
                name: "Keys");

            migrationBuilder.DropTable(
                name: "PackageDetails");

            migrationBuilder.DropTable(
                name: "PersistedGrants");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Packages");

            migrationBuilder.DropTable(
                name: "PaymentMethods");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ArtWorks");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}

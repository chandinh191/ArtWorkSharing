using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AWS_BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
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
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
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
                    UserAccountId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserOwnerId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArtWorkStatus = table.Column<int>(type: "int", nullable: false),
                    IsSold = table.Column<bool>(type: "bit", nullable: false),
                    IsPreOrder = table.Column<bool>(type: "bit", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
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
                        name: "FK_ArtWorks_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
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
                    ArtWorkID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    isPreOrder = table.Column<bool>(type: "bit", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
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
                        name: "FK_Orders_ArtWorks_ArtWorkID",
                        column: x => x.ArtWorkID,
                        principalTable: "ArtWorks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WishList",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserAccountId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArtWorkID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WishList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WishList_ArtWorks_ArtWorkID",
                        column: x => x.ArtWorkID,
                        principalTable: "ArtWorks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
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
                table: "ArtWorks",
                columns: new[] { "Id", "ApplicationUserId", "ArtWorkStatus", "CategoryId", "Created", "CreatedBy", "Description", "ImageUrl", "IsDeleted", "IsPreOrder", "IsSold", "LastModified", "LastModifiedBy", "Name", "Price", "UserAccountId", "UserOwnerId" },
                values: new object[,]
                {
                    { new Guid("1f35558f-a942-4837-81a4-720bae0e8bb1"), null, 1, null, new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9455), null, "Description 8", "Image 8", false, false, false, null, null, "ArtWork 8", 800f, "871a809a-b3fa-495b-9cc2-c5d738a866ci", "871a809a-b3fa-495b-9cc2-c5d738a866cg" },
                    { new Guid("26709dca-1906-4c50-a00e-1c63582ab644"), null, 1, null, new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9433), null, "Description 2", "Image 2", false, false, false, null, null, "ArtWork 2", 200f, "871a809a-b3fa-495b-9cc2-c5d738a866cf", "871a809a-b3fa-495b-9cc2-c5d738a866cg" },
                    { new Guid("7b76bf1f-d24c-4ac9-b466-4179e65605b2"), null, 1, null, new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9439), null, "Description 4", "Image 4", false, false, false, null, null, "ArtWork 4", 400f, "871a809a-b3fa-495b-9cc2-c5d738a866cg", "871a809a-b3fa-495b-9cc2-c5d738a866ch" },
                    { new Guid("8c44d5c8-a738-4b65-a88e-3ed38fce88c4"), null, 1, null, new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9436), null, "Description 3", "Image 3", false, false, false, null, null, "ArtWork 3", 300f, "871a809a-b3fa-495b-9cc2-c5d738a866cg", "871a809a-b3fa-495b-9cc2-c5d738a866ch" },
                    { new Guid("8e9acec5-54c9-4093-a450-19eb7b2109fb"), null, 1, null, new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9428), null, "Description 1", "Image 1", false, false, false, null, null, "ArtWork 1", 100f, "871a809a-b3fa-495b-9cc2-c5d738a866cf", "871a809a-b3fa-495b-9cc2-c5d738a866cg" },
                    { new Guid("9db314d0-6a55-492c-9a13-7ee6f2091cbf"), null, 1, null, new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9458), null, "Description 9", "Image 9", false, false, false, null, null, "ArtWork 9", 900f, "871a809a-b3fa-495b-9cc2-c5d738a866cg", "871a809a-b3fa-495b-9cc2-c5d738a866cf" },
                    { new Guid("a25e170e-7ddc-4bdc-9215-51c6fb9bcd96"), null, 1, null, new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9443), null, "Description 5", "Image 5", false, false, false, null, null, "ArtWork 5", 500f, "871a809a-b3fa-495b-9cc2-c5d738a866cj", "871a809a-b3fa-495b-9cc2-c5d738a866ci" },
                    { new Guid("b18dcaa1-d99a-4f15-a30c-5fd72c30280e"), null, 1, null, new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9446), null, "Description 6", "Image 6", false, false, false, null, null, "ArtWork 6", 600f, "871a809a-b3fa-495b-9cc2-c5d738a866cj", "871a809a-b3fa-495b-9cc2-c5d738a866ci" },
                    { new Guid("bd37c967-1817-495b-89eb-665c81b02d5e"), null, 1, null, new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9449), null, "Description 7", "Image 7", false, false, false, null, null, "ArtWork 7", 700f, "871a809a-b3fa-495b-9cc2-c5d738a866ci", "871a809a-b3fa-495b-9cc2-c5d738a866cg" },
                    { new Guid("d9d6b461-8efd-4395-8662-a58caa152200"), null, 1, null, new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9462), null, "Description 10", "Image 10", false, false, false, null, null, "ArtWork 10", 1000f, "871a809a-b3fa-495b-9cc2-c5d738a866cg", "871a809a-b3fa-495b-9cc2-c5d738a866cf" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "871a809a-b3fa-495b-9cc2-c5d738a866cf", 0, null, "7eec6d28-3767-4217-a0e3-72c4bee47ee9", "hieu123@gmail.com", false, false, null, null, null, "TRANHIEU1", null, null, false, "1830a9a1-22ea-43ff-bcdd-1dc3ecc20254", false, "TranHieu1" },
                    { "871a809a-b3fa-495b-9cc2-c5d738a866cg", 0, null, "f6852092-13ed-4086-a14a-3d0c54073b86", "hieuaccount2@gmail.com", false, false, null, null, null, "TRANHIEU2", null, null, false, "bf017b21-ddd2-445d-88d8-b9cb95713630", false, "TranHieu2" },
                    { "871a809a-b3fa-495b-9cc2-c5d738a866ch", 0, null, "d620ea5a-ca00-403d-ad7e-835844fb9201", "hieuaccount3@gmail.com", false, false, null, null, null, "TRANHIEU3", null, null, false, "a8175b15-f232-4639-a06b-5c358a3641ca", false, "TranHieu3" },
                    { "871a809a-b3fa-495b-9cc2-c5d738a866ci", 0, null, "8e25dc4b-d4b0-4cda-86d5-9d9ad72f36b2", "hieuaccount4@gmail.com", false, false, null, null, null, "TRANHIEU4", null, null, false, "adecd246-5d11-4dbb-8869-0788bbdc2207", false, "TranHieu4" },
                    { "871a809a-b3fa-495b-9cc2-c5d738a866cj", 0, null, "d042ff8b-38cf-4368-8a75-a8f340f8a660", "hieuaccount5@gmail.com", false, false, null, null, null, "TRANHIEU5", null, null, false, "3126fd18-aa51-4e9d-a355-2613c2eec196", false, "TranHieu5" }
                });

            migrationBuilder.InsertData(
                table: "ArtistAccount",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "UserAccountId" },
                values: new object[,]
                {
                    { new Guid("464927a3-37f9-4106-9319-67acebc62c83"), new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9329), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cg" },
                    { new Guid("f1cc2b0f-8500-450b-bebf-45ccb6519009"), new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9326), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cf" },
                    { new Guid("fb28caad-5aeb-4eca-9926-3e587182687f"), new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9332), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866ch" }
                });

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

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "ApplicationUserId", "ArtWorkID", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "Price", "Status", "UserAccountId", "isPreOrder" },
                values: new object[,]
                {
                    { new Guid("871a809a-b3fa-495b-9cc2-c5d738a861cf"), null, new Guid("8e9acec5-54c9-4093-a450-19eb7b2109fb"), new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9553), null, false, null, null, 0f, 1, "871a809a-b3fa-495b-9cc2-c5d738a866cf", false },
                    { new Guid("871a809a-b3fa-495b-9cc2-c5d738a862cf"), null, new Guid("26709dca-1906-4c50-a00e-1c63582ab644"), new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9559), null, false, null, null, 0f, 1, "871a809a-b3fa-495b-9cc2-c5d738a866cg", false },
                    { new Guid("871a809a-b3fa-495b-9cc2-c5d738a863cf"), null, new Guid("8c44d5c8-a738-4b65-a88e-3ed38fce88c4"), new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9562), null, false, null, null, 0f, 1, "871a809a-b3fa-495b-9cc2-c5d738a866ch", false }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "IsDeleted", "LastModified", "LastModifiedBy", "OrderID", "Point" },
                values: new object[,]
                {
                    { new Guid("438b7773-fc22-415b-a989-ec5b667fbcc7"), new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9586), null, "Description 2", false, null, null, new Guid("871a809a-b3fa-495b-9cc2-c5d738a862cf"), 4f },
                    { new Guid("c8780362-aa25-4bcb-b3c3-6de89cd1483e"), new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9582), null, "Description 1", false, null, null, new Guid("871a809a-b3fa-495b-9cc2-c5d738a861cf"), 5f },
                    { new Guid("ec19628b-5afe-485e-87f7-c41303caf449"), new DateTime(2024, 3, 21, 19, 49, 26, 898, DateTimeKind.Local).AddTicks(9589), null, "Description 3", false, null, null, new Guid("871a809a-b3fa-495b-9cc2-c5d738a863cf"), 3f }
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
                name: "IX_ArtWorkCategory_CategoriesId",
                table: "ArtWorkCategory",
                column: "CategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtWorks_ApplicationUserId",
                table: "ArtWorks",
                column: "ApplicationUserId");

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
                name: "IX_Orders_ArtWorkID",
                table: "Orders",
                column: "ArtWorkID");

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

            migrationBuilder.CreateIndex(
                name: "IX_WishList_ArtWorkID",
                table: "WishList",
                column: "ArtWorkID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminAccount");

            migrationBuilder.DropTable(
                name: "ArtistAccount");

            migrationBuilder.DropTable(
                name: "ArtWorkCategory");

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
                name: "PersistedGrants");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "WishList");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ArtWorks");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}

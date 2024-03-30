using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoAnNhom2_LTWEB.Migrations
{
    /// <inheritdoc />
    public partial class initdata : Migration
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
                    Discriminator = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
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
                name: "KINHNGHIEMs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAMKN = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KINHNGHIEMs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LOAINGANHs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TENLOAI = table.Column<int>(type: "int", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LOAINGANHs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MUCLUONGs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SOLUONG = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MUCLUONGs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TINHs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TENTINH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TRANGTHAI = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TINHs", x => x.Id);
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
                name: "DONUNGTUYENs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USERTKId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    USERTKId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FILECV = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DONUNGTUYENs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DONUNGTUYENs_AspNetUsers_USERTKId1",
                        column: x => x.USERTKId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "NGANHUNGTUYENs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TENNGANH = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LOAINGANHId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NGANHUNGTUYENs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NGANHUNGTUYENs_LOAINGANHs_LOAINGANHId",
                        column: x => x.LOAINGANHId,
                        principalTable: "LOAINGANHs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NHATUYENDUNGs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TENNTD = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    TINHId = table.Column<int>(type: "int", nullable: false),
                    DIADIEM = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    EMAIL = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    IMGDAIDIEN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IMGBANGTIN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TRANGTHAI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WEBSITE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QUYMO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MOTA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    USERTKId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    USERTKId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NHATUYENDUNGs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NHATUYENDUNGs_AspNetUsers_USERTKId1",
                        column: x => x.USERTKId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NHATUYENDUNGs_TINHs_TINHId",
                        column: x => x.TINHId,
                        principalTable: "TINHs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PHIEUDANGTUYENs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NHATUYENDUNGId = table.Column<int>(type: "int", nullable: true),
                    NGANHUNGTUYENId = table.Column<int>(type: "int", nullable: true),
                    KINHNGHIEMId = table.Column<int>(type: "int", nullable: true),
                    TINHId = table.Column<int>(type: "int", nullable: true),
                    TENVIECLAM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CHUCDANH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MUCLUONGId = table.Column<int>(type: "int", nullable: true),
                    MOTA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DIADIEM = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    NGAYLAP = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HANPHIEU = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PHIEUDANGTUYENs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PHIEUDANGTUYENs_KINHNGHIEMs_KINHNGHIEMId",
                        column: x => x.KINHNGHIEMId,
                        principalTable: "KINHNGHIEMs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PHIEUDANGTUYENs_MUCLUONGs_MUCLUONGId",
                        column: x => x.MUCLUONGId,
                        principalTable: "MUCLUONGs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PHIEUDANGTUYENs_NGANHUNGTUYENs_NGANHUNGTUYENId",
                        column: x => x.NGANHUNGTUYENId,
                        principalTable: "NGANHUNGTUYENs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PHIEUDANGTUYENs_NHATUYENDUNGs_NHATUYENDUNGId",
                        column: x => x.NHATUYENDUNGId,
                        principalTable: "NHATUYENDUNGs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PHIEUDANGTUYENs_TINHs_TINHId",
                        column: x => x.TINHId,
                        principalTable: "TINHs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BANGDANGTUYENs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PHIEUDANGTUYENId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BANGDANGTUYENs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BANGDANGTUYENs_PHIEUDANGTUYENs_PHIEUDANGTUYENId",
                        column: x => x.PHIEUDANGTUYENId,
                        principalTable: "PHIEUDANGTUYENs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "IX_BANGDANGTUYENs_PHIEUDANGTUYENId",
                table: "BANGDANGTUYENs",
                column: "PHIEUDANGTUYENId");

            migrationBuilder.CreateIndex(
                name: "IX_DONUNGTUYENs_USERTKId1",
                table: "DONUNGTUYENs",
                column: "USERTKId1");

            migrationBuilder.CreateIndex(
                name: "IX_NGANHUNGTUYENs_LOAINGANHId",
                table: "NGANHUNGTUYENs",
                column: "LOAINGANHId");

            migrationBuilder.CreateIndex(
                name: "IX_NHATUYENDUNGs_TINHId",
                table: "NHATUYENDUNGs",
                column: "TINHId");

            migrationBuilder.CreateIndex(
                name: "IX_NHATUYENDUNGs_USERTKId1",
                table: "NHATUYENDUNGs",
                column: "USERTKId1");

            migrationBuilder.CreateIndex(
                name: "IX_PHIEUDANGTUYENs_KINHNGHIEMId",
                table: "PHIEUDANGTUYENs",
                column: "KINHNGHIEMId");

            migrationBuilder.CreateIndex(
                name: "IX_PHIEUDANGTUYENs_MUCLUONGId",
                table: "PHIEUDANGTUYENs",
                column: "MUCLUONGId");

            migrationBuilder.CreateIndex(
                name: "IX_PHIEUDANGTUYENs_NGANHUNGTUYENId",
                table: "PHIEUDANGTUYENs",
                column: "NGANHUNGTUYENId");

            migrationBuilder.CreateIndex(
                name: "IX_PHIEUDANGTUYENs_NHATUYENDUNGId",
                table: "PHIEUDANGTUYENs",
                column: "NHATUYENDUNGId");

            migrationBuilder.CreateIndex(
                name: "IX_PHIEUDANGTUYENs_TINHId",
                table: "PHIEUDANGTUYENs",
                column: "TINHId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "BANGDANGTUYENs");

            migrationBuilder.DropTable(
                name: "DONUNGTUYENs");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "PHIEUDANGTUYENs");

            migrationBuilder.DropTable(
                name: "KINHNGHIEMs");

            migrationBuilder.DropTable(
                name: "MUCLUONGs");

            migrationBuilder.DropTable(
                name: "NGANHUNGTUYENs");

            migrationBuilder.DropTable(
                name: "NHATUYENDUNGs");

            migrationBuilder.DropTable(
                name: "LOAINGANHs");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "TINHs");
        }
    }
}

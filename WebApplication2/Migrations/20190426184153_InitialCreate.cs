using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Credit",
                columns: table => new
                {
                    CreditId = table.Column<int>(nullable: false),
                    CreditAbbr = table.Column<string>(maxLength: 10, nullable: true),
                    CreditName = table.Column<string>(maxLength: 20, nullable: true),
                    IsSummer = table.Column<int>(nullable: false),
                    IsSpring = table.Column<int>(nullable: false),
                    IsFall = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Credit", x => x.CreditId);
                });

            migrationBuilder.CreateTable(
                name: "Degree",
                columns: table => new
                {
                    DegreeId = table.Column<int>(nullable: false),
                    DegreeAbbr = table.Column<string>(maxLength: 10, nullable: true),
                    DegreeName = table.Column<string>(maxLength: 20, nullable: true),
                    NumberOfTerms = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Degree", x => x.DegreeId);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false),
                    Family = table.Column<string>(maxLength: 15, nullable: true),
                    Given = table.Column<string>(maxLength: 25, nullable: true),
                    N919 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "Todo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Todo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
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
                name: "Slot",
                columns: table => new
                {
                    SlotId = table.Column<int>(nullable: false),
                    DegreePlanSelected = table.Column<int>(nullable: false),
                    Term = table.Column<int>(nullable: false),
                    CreditId = table.Column<int>(nullable: false),
                    Status = table.Column<string>(maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slot", x => x.SlotId);
                    table.ForeignKey(
                        name: "FK_Slot_Credit_CreditId",
                        column: x => x.CreditId,
                        principalTable: "Credit",
                        principalColumn: "CreditId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DegreeCredit",
                columns: table => new
                {
                    DegreeCreditId = table.Column<int>(nullable: false),
                    DegreeId = table.Column<int>(nullable: false),
                    CreditId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DegreeCredit", x => x.DegreeCreditId);
                    table.ForeignKey(
                        name: "FK_DegreeCredit_Credit_CreditId",
                        column: x => x.CreditId,
                        principalTable: "Credit",
                        principalColumn: "CreditId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DegreeCredit_Degree_DegreeId",
                        column: x => x.DegreeId,
                        principalTable: "Degree",
                        principalColumn: "DegreeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DegreeRequirement",
                columns: table => new
                {
                    DegreeRequirementId = table.Column<int>(nullable: false),
                    DegreeId = table.Column<int>(nullable: false),
                    RequirementNumber = table.Column<int>(nullable: false),
                    RequirementAbbr = table.Column<string>(maxLength: 10, nullable: false),
                    RequirementName = table.Column<string>(maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DegreeRequirement", x => x.DegreeRequirementId);
                    table.ForeignKey(
                        name: "FK_DegreeRequirement_Degree_DegreeId",
                        column: x => x.DegreeId,
                        principalTable: "Degree",
                        principalColumn: "DegreeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DegreePlan",
                columns: table => new
                {
                    DegreePlanId = table.Column<int>(nullable: false),
                    StudentId = table.Column<int>(nullable: false),
                    DegreePlanAbbr = table.Column<string>(nullable: true),
                    DegreePlanName = table.Column<string>(maxLength: 25, nullable: true),
                    DegreePlanSelected = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DegreePlan", x => x.DegreePlanId);
                    table.ForeignKey(
                        name: "FK_DegreePlan_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentTerm",
                columns: table => new
                {
                    StudentTermId = table.Column<int>(nullable: false),
                    StudentId = table.Column<int>(nullable: false),
                    Term = table.Column<int>(nullable: false),
                    TermAbbr = table.Column<string>(maxLength: 10, nullable: true),
                    TermName = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentTerm", x => x.StudentTermId);
                    table.ForeignKey(
                        name: "FK_StudentTerm_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId",
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
                name: "IX_DegreeCredit_CreditId",
                table: "DegreeCredit",
                column: "CreditId");

            migrationBuilder.CreateIndex(
                name: "IX_DegreeCredit_DegreeId",
                table: "DegreeCredit",
                column: "DegreeId");

            migrationBuilder.CreateIndex(
                name: "IX_DegreePlan_StudentId",
                table: "DegreePlan",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_DegreeRequirement_DegreeId",
                table: "DegreeRequirement",
                column: "DegreeId");

            migrationBuilder.CreateIndex(
                name: "IX_Slot_CreditId",
                table: "Slot",
                column: "CreditId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentTerm_StudentId",
                table: "StudentTerm",
                column: "StudentId");
        }

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
                name: "DegreeCredit");

            migrationBuilder.DropTable(
                name: "DegreePlan");

            migrationBuilder.DropTable(
                name: "DegreeRequirement");

            migrationBuilder.DropTable(
                name: "Slot");

            migrationBuilder.DropTable(
                name: "StudentTerm");

            migrationBuilder.DropTable(
                name: "Todo");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Degree");

            migrationBuilder.DropTable(
                name: "Credit");

            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}

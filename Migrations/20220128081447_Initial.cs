using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace ZnajdzLekarza.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Localizations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    StreetName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    StreetNumber = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    ZipCode = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: false),
                    City = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localizations", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethods",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethods", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Specialists",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true),
                    Education = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialists", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Specializations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specializations", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LocalizationSpecialist",
                columns: table => new
                {
                    LocalizationsID = table.Column<int>(type: "int", nullable: false),
                    SpecialistsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalizationSpecialist", x => new { x.LocalizationsID, x.SpecialistsID });
                    table.ForeignKey(
                        name: "FK_LocalizationSpecialist_Localizations_LocalizationsID",
                        column: x => x.LocalizationsID,
                        principalTable: "Localizations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocalizationSpecialist_Specialists_SpecialistsID",
                        column: x => x.SpecialistsID,
                        principalTable: "Specialists",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServiceSpecialist",
                columns: table => new
                {
                    ServicesID = table.Column<int>(type: "int", nullable: false),
                    SpecialistsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceSpecialist", x => new { x.ServicesID, x.SpecialistsID });
                    table.ForeignKey(
                        name: "FK_ServiceSpecialist_Services_ServicesID",
                        column: x => x.ServicesID,
                        principalTable: "Services",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceSpecialist_Specialists_SpecialistsID",
                        column: x => x.SpecialistsID,
                        principalTable: "Specialists",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Visits",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    SpecialistID = table.Column<int>(type: "int", nullable: false),
                    LocalizationID = table.Column<int>(type: "int", nullable: false),
                    ServiceID = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visits", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Visits_Localizations_LocalizationID",
                        column: x => x.LocalizationID,
                        principalTable: "Localizations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Visits_Services_ServiceID",
                        column: x => x.ServiceID,
                        principalTable: "Services",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Visits_Specialists_SpecialistID",
                        column: x => x.SpecialistID,
                        principalTable: "Specialists",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpecialistSpecialization",
                columns: table => new
                {
                    SpecialistsID = table.Column<int>(type: "int", nullable: false),
                    SpecializationsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialistSpecialization", x => new { x.SpecialistsID, x.SpecializationsID });
                    table.ForeignKey(
                        name: "FK_SpecialistSpecialization_Specialists_SpecialistsID",
                        column: x => x.SpecialistsID,
                        principalTable: "Specialists",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpecialistSpecialization_Specializations_SpecializationsID",
                        column: x => x.SpecializationsID,
                        principalTable: "Specializations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LocalizationSpecialist_SpecialistsID",
                table: "LocalizationSpecialist",
                column: "SpecialistsID");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceSpecialist_SpecialistsID",
                table: "ServiceSpecialist",
                column: "SpecialistsID");

            migrationBuilder.CreateIndex(
                name: "IX_SpecialistSpecialization_SpecializationsID",
                table: "SpecialistSpecialization",
                column: "SpecializationsID");

            migrationBuilder.CreateIndex(
                name: "IX_Visits_LocalizationID",
                table: "Visits",
                column: "LocalizationID");

            migrationBuilder.CreateIndex(
                name: "IX_Visits_ServiceID",
                table: "Visits",
                column: "ServiceID");

            migrationBuilder.CreateIndex(
                name: "IX_Visits_SpecialistID",
                table: "Visits",
                column: "SpecialistID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocalizationSpecialist");

            migrationBuilder.DropTable(
                name: "PaymentMethods");

            migrationBuilder.DropTable(
                name: "ServiceSpecialist");

            migrationBuilder.DropTable(
                name: "SpecialistSpecialization");

            migrationBuilder.DropTable(
                name: "Visits");

            migrationBuilder.DropTable(
                name: "Specializations");

            migrationBuilder.DropTable(
                name: "Localizations");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Specialists");
        }
    }
}

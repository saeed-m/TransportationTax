using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TransportationTax.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class inital : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CarName = table.Column<string>(type: "TEXT", nullable: false),
                    CarPlateNumber = table.Column<string>(type: "TEXT", nullable: false),
                    CarColor = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "congestionTaxes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FromTime = table.Column<TimeOnly>(type: "TEXT", nullable: false),
                    ToTime = table.Column<TimeOnly>(type: "TEXT", nullable: false),
                    TaxAmount = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_congestionTaxes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "exemptVehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VehicleName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_exemptVehicles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "payTolls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PayTollName = table.Column<string>(type: "TEXT", nullable: false),
                    PayTollCode = table.Column<int>(type: "INTEGER", nullable: false),
                    PayTollDistance = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payTolls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "timeExemptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ExemptInMinite = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_timeExemptions", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "congestionTaxes");

            migrationBuilder.DropTable(
                name: "exemptVehicles");

            migrationBuilder.DropTable(
                name: "payTolls");

            migrationBuilder.DropTable(
                name: "timeExemptions");
        }
    }
}

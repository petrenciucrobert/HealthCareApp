using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthCareApp.Migrations
{
    public partial class BedAllotment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BedAllotment",
                columns: table => new
                {
                    BedAllotmentId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientName = table.Column<string>(nullable: false),
                    BedName = table.Column<string>(nullable: false),
                    BedCategory = table.Column<string>(nullable: true),
                    HospitalizationDate = table.Column<DateTime>(nullable: false),
                    DischargeDate = table.Column<DateTime>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BedAllotment", x => x.BedAllotmentId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BedAllotment");
        }
    }
}

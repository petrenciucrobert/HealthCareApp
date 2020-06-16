using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthCareApp.Migrations
{
    public partial class LaboratoryTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LaboratoryTest",
                columns: table => new
                {
                    LaboratoryTestId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LabTestCategoryName = table.Column<string>(nullable: false),
                    LabTestName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaboratoryTest", x => x.LaboratoryTestId);
                });

            migrationBuilder.CreateTable(
                name: "LaboratoryTestCategory",
                columns: table => new
                {
                    LaboratoryTestCategoryId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LabTestCategoryName = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaboratoryTestCategory", x => x.LaboratoryTestCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "PatientLaboratoryTest",
                columns: table => new
                {
                    PatientLaboratoryTestId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientName = table.Column<string>(nullable: false),
                    DoctorName = table.Column<string>(nullable: false),
                    LabTestName = table.Column<string>(nullable: false),
                    TestDate = table.Column<DateTime>(nullable: true),
                    Result = table.Column<string>(nullable: true),
                    Remarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientLaboratoryTest", x => x.PatientLaboratoryTestId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LaboratoryTest");

            migrationBuilder.DropTable(
                name: "LaboratoryTestCategory");

            migrationBuilder.DropTable(
                name: "PatientLaboratoryTest");
        }
    }
}

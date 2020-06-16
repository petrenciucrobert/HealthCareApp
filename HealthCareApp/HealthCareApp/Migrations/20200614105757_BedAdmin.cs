using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthCareApp.Migrations
{
    public partial class BedAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PrescriptionDetail");

            migrationBuilder.DropTable(
                name: "Prescription");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prescription",
                columns: table => new
                {
                    PrescriptionId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaseHistory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExtraNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientCheckupId = table.Column<long>(type: "bigint", nullable: false),
                    PatientId = table.Column<long>(type: "bigint", nullable: false),
                    PrescriptionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TreatmentId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescription", x => x.PrescriptionId);
                });

            migrationBuilder.CreateTable(
                name: "PrescriptionDetail",
                columns: table => new
                {
                    PrescriptionDetailId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsBeforeMeal = table.Column<bool>(type: "bit", nullable: false),
                    MedicineId = table.Column<long>(type: "bigint", nullable: false),
                    MedicineName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoOfDays = table.Column<int>(type: "int", nullable: false),
                    PatientId = table.Column<long>(type: "bigint", nullable: false),
                    PrescriptionId = table.Column<long>(type: "bigint", nullable: false),
                    WhenToTake = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrescriptionDetail", x => x.PrescriptionDetailId);
                    table.ForeignKey(
                        name: "FK_PrescriptionDetail_Prescription_PrescriptionId",
                        column: x => x.PrescriptionId,
                        principalTable: "Prescription",
                        principalColumn: "PrescriptionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PrescriptionDetail_PrescriptionId",
                table: "PrescriptionDetail",
                column: "PrescriptionId");
        }
    }
}

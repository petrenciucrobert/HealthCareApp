using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthCareApp.Migrations
{
    public partial class PatientCheckup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PatientCheckup",
                columns: table => new
                {
                    PatientCheckupId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<long>(nullable: false),
                    CheckupDate = table.Column<DateTime>(nullable: true),
                    DoctorId = table.Column<long>(nullable: false),
                    DoctorName = table.Column<string>(nullable: true),
                    Symptoms = table.Column<string>(nullable: false),
                    Diagnosis = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientCheckup", x => x.PatientCheckupId);
                });

            migrationBuilder.CreateTable(
                name: "Prescription",
                columns: table => new
                {
                    PrescriptionId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientCheckupId = table.Column<long>(nullable: false),
                    PatientId = table.Column<long>(nullable: false),
                    TreatmentId = table.Column<long>(nullable: false),
                    CaseHistory = table.Column<string>(nullable: true),
                    ExtraNotes = table.Column<string>(nullable: true),
                    PrescriptionDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescription", x => x.PrescriptionId);
                    table.ForeignKey(
                        name: "FK_Prescription_PatientCheckup_PatientCheckupId",
                        column: x => x.PatientCheckupId,
                        principalTable: "PatientCheckup",
                        principalColumn: "PatientCheckupId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PrescriptionDetail",
                columns: table => new
                {
                    PrescriptionDetailId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrescriptionId = table.Column<long>(nullable: false),
                    PatientId = table.Column<long>(nullable: false),
                    MedicineId = table.Column<long>(nullable: false),
                    MedicineName = table.Column<string>(nullable: true),
                    NoOfDays = table.Column<int>(nullable: false),
                    WhenToTake = table.Column<string>(nullable: false),
                    IsBeforeMeal = table.Column<bool>(nullable: false)
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
                name: "IX_Prescription_PatientCheckupId",
                table: "Prescription",
                column: "PatientCheckupId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PrescriptionDetail_PrescriptionId",
                table: "PrescriptionDetail",
                column: "PrescriptionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PrescriptionDetail");

            migrationBuilder.DropTable(
                name: "Prescription");

            migrationBuilder.DropTable(
                name: "PatientCheckup");
        }
    }
}

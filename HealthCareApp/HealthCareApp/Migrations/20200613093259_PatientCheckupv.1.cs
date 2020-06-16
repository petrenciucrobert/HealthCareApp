using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthCareApp.Migrations
{
    public partial class PatientCheckupv1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescription_PatientCheckup_PatientCheckupId",
                table: "Prescription");

            migrationBuilder.DropIndex(
                name: "IX_Prescription_PatientCheckupId",
                table: "Prescription");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "PatientCheckup");

            migrationBuilder.DropColumn(
                name: "DoctorName",
                table: "PatientCheckup");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "DoctorId",
                table: "PatientCheckup",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "DoctorName",
                table: "PatientCheckup",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_PatientCheckupId",
                table: "Prescription",
                column: "PatientCheckupId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescription_PatientCheckup_PatientCheckupId",
                table: "Prescription",
                column: "PatientCheckupId",
                principalTable: "PatientCheckup",
                principalColumn: "PatientCheckupId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

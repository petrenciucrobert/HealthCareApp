using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthCareApp.Migrations
{
    public partial class Personnel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CleaningStaff",
                columns: table => new
                {
                    CleaningStaffId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    MiddleName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CleaningStaff", x => x.CleaningStaffId);
                });

            migrationBuilder.CreateTable(
                name: "Nurse",
                columns: table => new
                {
                    NurseId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    MiddleName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nurse", x => x.NurseId);
                });

            migrationBuilder.CreateTable(
                name: "Receptionist",
                columns: table => new
                {
                    ReceptionistId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    MiddleName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receptionist", x => x.ReceptionistId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CleaningStaff");

            migrationBuilder.DropTable(
                name: "Nurse");

            migrationBuilder.DropTable(
                name: "Receptionist");
        }
    }
}

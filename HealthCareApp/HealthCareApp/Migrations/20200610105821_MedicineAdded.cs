using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthCareApp.Migrations
{
    public partial class MedicineAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Medicine",
                columns: table => new
                {
                    MedicineId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicineName = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    MedicineCategoryId = table.Column<long>(nullable: false),
                    MedicineCategoryName = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicine", x => x.MedicineId);
                });

            migrationBuilder.CreateTable(
                name: "MedicineCategory",
                columns: table => new
                {
                    MedicineCategoryId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicineCategoryName = table.Column<string>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicineCategory", x => x.MedicineCategoryId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Medicine");

            migrationBuilder.DropTable(
                name: "MedicineCategory");
        }
    }
}

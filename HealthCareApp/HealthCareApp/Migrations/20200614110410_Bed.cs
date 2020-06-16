using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthCareApp.Migrations
{
    public partial class Bed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bed",
                columns: table => new
                {
                    BedId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BedName = table.Column<string>(nullable: false),
                    BedCategoryId = table.Column<long>(nullable: false),
                    BedCategory = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bed", x => x.BedId);
                });

            migrationBuilder.CreateTable(
                name: "BedCategory",
                columns: table => new
                {
                    BedCategoryId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BedCategoryName = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BedCategory", x => x.BedCategoryId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bed");

            migrationBuilder.DropTable(
                name: "BedCategory");
        }
    }
}

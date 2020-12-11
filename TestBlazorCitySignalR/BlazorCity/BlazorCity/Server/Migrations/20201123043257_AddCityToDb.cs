using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorCity.Server.Migrations
{
    public partial class AddCityToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityPopulation = table.Column<int>(type: "int", nullable: false),
                    CityFoundationYear = table.Column<int>(type: "int", nullable: false),
                    CityDoundationMonth = table.Column<int>(type: "int", nullable: false),
                    CityDoundationDay = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}

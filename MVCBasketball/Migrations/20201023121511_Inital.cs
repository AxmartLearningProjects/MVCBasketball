using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCBasketball.Migrations
{
    public partial class Inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Raptors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerNumber = table.Column<int>(nullable: false),
                    PlayerName = table.Column<string>(nullable: true),
                    PlayerPosition = table.Column<string>(nullable: true),
                    PlayerHeight = table.Column<string>(nullable: true),
                    PlayerSalary = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Raptors", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Raptors");
        }
    }
}

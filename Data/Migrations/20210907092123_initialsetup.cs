using Microsoft.EntityFrameworkCore.Migrations;

namespace FutsalApp.Data.Migrations
{
    public partial class initialsetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Game",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsGame = table.Column<bool>(nullable: false),
                    IsValid = table.Column<bool>(nullable: false),
                    GameDate = table.Column<string>(nullable: true),
                    Player1 = table.Column<string>(nullable: true),
                    Player2 = table.Column<string>(nullable: true),
                    Player3 = table.Column<string>(nullable: true),
                    Player4 = table.Column<string>(nullable: true),
                    Player5 = table.Column<string>(nullable: true),
                    Player6 = table.Column<string>(nullable: true),
                    Player7 = table.Column<string>(nullable: true),
                    Player8 = table.Column<string>(nullable: true),
                    Player9 = table.Column<string>(nullable: true),
                    Player10 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Game");
        }
    }
}

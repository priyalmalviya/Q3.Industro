using Microsoft.EntityFrameworkCore.Migrations;

namespace Q3.Industro.DataLayer.Migrations
{
    public partial class IndustroTeams : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TeamTable",
                columns: table => new
                {
                    teamId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    teamDuration = table.Column<double>(nullable: false),
                    teamMember = table.Column<string>(nullable: true),
                    teamPosition = table.Column<string>(nullable: true),
                    teamImgUrl = table.Column<string>(nullable: true),
                    teamShow = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamTable", x => x.teamId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeamTable");
        }
    }
}

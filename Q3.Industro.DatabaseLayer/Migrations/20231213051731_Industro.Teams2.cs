using Microsoft.EntityFrameworkCore.Migrations;

namespace Q3.Industro.DataLayer.Migrations
{
    public partial class IndustroTeams2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "teamHead",
                table: "TeamTable",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "teamHead",
                table: "TeamTable");
        }
    }
}

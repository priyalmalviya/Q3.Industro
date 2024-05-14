using Microsoft.EntityFrameworkCore.Migrations;

namespace Q3.Industro.DataLayer.Migrations
{
    public partial class IndustroTestimonial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TestimonialTable",
                columns: table => new
                {
                    ClientId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientName = table.Column<string>(nullable: true),
                    ClientDesc = table.Column<string>(nullable: true),
                    ClientProf = table.Column<string>(nullable: true),
                    ClientImgUrl = table.Column<string>(nullable: true),
                    ClientShow = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestimonialTable", x => x.ClientId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TestimonialTable");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Q3.Industro.DataLayer.Migrations
{
    public partial class IndustroTestimonial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClientEmail",
                table: "TestimonialTable",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientEmail",
                table: "TestimonialTable");
        }
    }
}

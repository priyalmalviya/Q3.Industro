using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Q3.Industro.DataLayer.Migrations
{
    public partial class IndustroProject2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProjectAbout",
                table: "ProjectTable",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ProjectDate",
                table: "ProjectTable",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProjectAbout",
                table: "ProjectTable");

            migrationBuilder.DropColumn(
                name: "ProjectDate",
                table: "ProjectTable");
        }
    }
}

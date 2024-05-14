﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Q3.Industro.DataLayer.Migrations
{
    public partial class IndustroServices4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ServiceDate",
                table: "ServiceInformations",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ServiceDate",
                table: "ServiceInformations",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}

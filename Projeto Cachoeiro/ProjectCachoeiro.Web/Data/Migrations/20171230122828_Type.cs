using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ProjectCachoeiro.Web.Data.Migrations
{
    public partial class Type : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "Familia");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Familia",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Familia");

            migrationBuilder.AddColumn<int>(
                name: "Tipo",
                table: "Familia",
                nullable: false,
                defaultValue: 0);
        }
    }
}

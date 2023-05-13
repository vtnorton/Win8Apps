using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ProjectCachoeiro.Web.Data.Migrations
{
    public partial class NumeroProposta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NomeDaProposta",
                table: "Proposta");

            migrationBuilder.AddColumn<string>(
                name: "Numero",
                table: "Proposta",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Numero",
                table: "Proposta");

            migrationBuilder.AddColumn<string>(
                name: "NomeDaProposta",
                table: "Proposta",
                nullable: true);
        }
    }
}

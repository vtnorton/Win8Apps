using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ProjectCachoeiro.Web.Data.Migrations
{
    public partial class Propostas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ListaIdItems",
                table: "Proposta");

            migrationBuilder.AddColumn<int>(
                name: "IdProposta",
                table: "Item",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdProposta",
                table: "Item");

            migrationBuilder.AddColumn<string>(
                name: "ListaIdItems",
                table: "Proposta",
                nullable: true);
        }
    }
}

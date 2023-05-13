using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ProjectCachoeiro.Web.Data.Migrations
{
    public partial class Precos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrecoUnitarioVenda",
                table: "Produto");

            migrationBuilder.AddColumn<decimal>(
                name: "PrecoCusto",
                table: "Produto",
                type: "decimal(18, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PrecoVenda",
                table: "Produto",
                type: "decimal(18, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ValorComDesconto",
                table: "Item",
                type: "decimal(18, 2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrecoCusto",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "PrecoVenda",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "ValorComDesconto",
                table: "Item");

            migrationBuilder.AddColumn<decimal>(
                name: "PrecoUnitarioVenda",
                table: "Produto",
                nullable: false,
                defaultValue: 0m);
        }
    }
}

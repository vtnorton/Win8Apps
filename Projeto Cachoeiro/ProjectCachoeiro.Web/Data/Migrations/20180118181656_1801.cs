using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ProjectCachoeiro.Web.Data.Migrations
{
    public partial class _1801 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Produto");

            migrationBuilder.AddColumn<string>(
                name: "CodigoProduto",
                table: "Produto",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumeroBloco",
                table: "Produto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "InscricaoEstadual",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodigoProduto",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "NumeroBloco",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "InscricaoEstadual",
                table: "Cliente");

            migrationBuilder.AddColumn<int>(
                name: "Codigo",
                table: "Produto",
                nullable: false,
                defaultValue: 0);
        }
    }
}

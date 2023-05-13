using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ProjectCachoeiro.Web.Data.Migrations
{
    public partial class FormasPagamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NomeEmIngles",
                table: "OpcoesPagamento",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NomeNaOmie",
                table: "OpcoesPagamento",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NomeEmIngles",
                table: "OpcoesPagamento");

            migrationBuilder.DropColumn(
                name: "NomeNaOmie",
                table: "OpcoesPagamento");
        }
    }
}

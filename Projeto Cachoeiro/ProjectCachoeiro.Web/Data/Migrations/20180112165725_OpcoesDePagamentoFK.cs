using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ProjectCachoeiro.Web.Data.Migrations
{
    public partial class OpcoesDePagamentoFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OpcoesPagamento",
                table: "Proposta");

            migrationBuilder.AddColumn<int>(
                name: "IdOpcoesDePagamento",
                table: "Proposta",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdOpcoesDePagamento",
                table: "Proposta");

            migrationBuilder.AddColumn<string>(
                name: "OpcoesPagamento",
                table: "Proposta",
                nullable: true);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ProjectCachoeiro.Web.Data.Migrations
{
    public partial class Cliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ListaIdContatos",
                table: "Cliente");

            migrationBuilder.AddColumn<int>(
                name: "IdEmpresa",
                table: "Contato",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdEmpresa",
                table: "Contato");

            migrationBuilder.AddColumn<string>(
                name: "ListaIdContatos",
                table: "Cliente",
                nullable: true);
        }
    }
}

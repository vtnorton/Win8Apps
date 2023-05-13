using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ProjectCachoeiro.Web.Data.Migrations
{
    public partial class Siglas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Sigla",
                table: "Tipo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Sigla",
                table: "Qualidade",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Sigla",
                table: "Material",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Sigla",
                table: "Familia",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Sigla",
                table: "Estado",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sigla",
                table: "Tipo");

            migrationBuilder.DropColumn(
                name: "Sigla",
                table: "Qualidade");

            migrationBuilder.DropColumn(
                name: "Sigla",
                table: "Material");

            migrationBuilder.DropColumn(
                name: "Sigla",
                table: "Familia");

            migrationBuilder.DropColumn(
                name: "Sigla",
                table: "Estado");
        }
    }
}

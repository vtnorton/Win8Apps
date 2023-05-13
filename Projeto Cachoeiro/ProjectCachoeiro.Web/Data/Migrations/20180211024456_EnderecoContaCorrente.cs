using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ProjectCachoeiro.Web.Data.Migrations
{
    public partial class EnderecoContaCorrente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Endereco",
                table: "ContaCorrente",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "ContaCorrente",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CEP",
                table: "ContaCorrente",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "ContaCorrente",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Complemento",
                table: "ContaCorrente",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "ContaCorrente",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Numero",
                table: "ContaCorrente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Pais",
                table: "ContaCorrente",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bairro",
                table: "ContaCorrente");

            migrationBuilder.DropColumn(
                name: "CEP",
                table: "ContaCorrente");

            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "ContaCorrente");

            migrationBuilder.DropColumn(
                name: "Complemento",
                table: "ContaCorrente");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "ContaCorrente");

            migrationBuilder.DropColumn(
                name: "Numero",
                table: "ContaCorrente");

            migrationBuilder.DropColumn(
                name: "Pais",
                table: "ContaCorrente");

            migrationBuilder.AlterColumn<string>(
                name: "Endereco",
                table: "ContaCorrente",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300,
                oldNullable: true);
        }
    }
}

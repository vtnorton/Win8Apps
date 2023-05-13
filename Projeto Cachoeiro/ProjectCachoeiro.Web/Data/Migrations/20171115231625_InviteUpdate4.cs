using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ProjectCachoeiro.Web.Data.Migrations
{
    public partial class InviteUpdate4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Step",
                table: "Invite");

            migrationBuilder.AddColumn<bool>(
                name: "Valido",
                table: "Invite",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Valido",
                table: "Invite");

            migrationBuilder.AddColumn<double>(
                name: "Step",
                table: "Invite",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}

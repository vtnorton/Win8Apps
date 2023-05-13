using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ProjectCachoeiro.Web.Data.Migrations
{
    public partial class IdControles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_GrupoDeClientes_GrupoDeClientesId",
                table: "Cliente");

            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_Imagem_LogoEmpresaId",
                table: "Cliente");

            migrationBuilder.DropForeignKey(
                name: "FK_Contato_Cliente_ClienteId",
                table: "Contato");

            migrationBuilder.DropForeignKey(
                name: "FK_Contato_Imagem_FotoPerfilId",
                table: "Contato");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Material_ProdutoId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Proposta_PropostaId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Material_Familia_FamiliaId",
                table: "Material");

            migrationBuilder.DropForeignKey(
                name: "FK_Material_Imagem_IdImagemPrincipalId",
                table: "Material");

            migrationBuilder.DropForeignKey(
                name: "FK_Material_Material_MaterialDerivadoId",
                table: "Material");

            migrationBuilder.DropForeignKey(
                name: "FK_Material_Status_StatusId",
                table: "Material");

            migrationBuilder.DropForeignKey(
                name: "FK_Proposta_Cliente_ClienteId",
                table: "Proposta");

            migrationBuilder.DropForeignKey(
                name: "FK_Proposta_Contato_ContatoId",
                table: "Proposta");

            migrationBuilder.DropIndex(
                name: "IX_Proposta_ClienteId",
                table: "Proposta");

            migrationBuilder.DropIndex(
                name: "IX_Proposta_ContatoId",
                table: "Proposta");

            migrationBuilder.DropIndex(
                name: "IX_Material_FamiliaId",
                table: "Material");

            migrationBuilder.DropIndex(
                name: "IX_Material_IdImagemPrincipalId",
                table: "Material");

            migrationBuilder.DropIndex(
                name: "IX_Material_MaterialDerivadoId",
                table: "Material");

            migrationBuilder.DropIndex(
                name: "IX_Material_StatusId",
                table: "Material");

            migrationBuilder.DropIndex(
                name: "IX_Item_ProdutoId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_PropostaId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Contato_ClienteId",
                table: "Contato");

            migrationBuilder.DropIndex(
                name: "IX_Contato_FotoPerfilId",
                table: "Contato");

            migrationBuilder.DropIndex(
                name: "IX_Cliente_GrupoDeClientesId",
                table: "Cliente");

            migrationBuilder.DropIndex(
                name: "IX_Cliente_LogoEmpresaId",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Proposta");

            migrationBuilder.DropColumn(
                name: "ContatoId",
                table: "Proposta");

            migrationBuilder.DropColumn(
                name: "FamiliaId",
                table: "Material");

            migrationBuilder.DropColumn(
                name: "IdImagemPrincipalId",
                table: "Material");

            migrationBuilder.DropColumn(
                name: "MaterialDerivadoId",
                table: "Material");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Material");

            migrationBuilder.DropColumn(
                name: "ProdutoId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "PropostaId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Contato");

            migrationBuilder.DropColumn(
                name: "FotoPerfilId",
                table: "Contato");

            migrationBuilder.DropColumn(
                name: "GrupoDeClientesId",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "LogoEmpresaId",
                table: "Cliente");

            migrationBuilder.AddColumn<int>(
                name: "IdCliente",
                table: "Proposta",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdContato",
                table: "Proposta",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ListaIdItems",
                table: "Proposta",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdFamilia",
                table: "Material",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdImagemPrincipal",
                table: "Material",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdMaterialDerivado",
                table: "Material",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdStatus",
                table: "Material",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdProduto",
                table: "Item",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ListaIdClientes",
                table: "GrupoDeClientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdFotoPerfil",
                table: "Contato",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdLogoEmpresa",
                table: "Cliente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ListaIdContatos",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdCliente",
                table: "Proposta");

            migrationBuilder.DropColumn(
                name: "IdContato",
                table: "Proposta");

            migrationBuilder.DropColumn(
                name: "ListaIdItems",
                table: "Proposta");

            migrationBuilder.DropColumn(
                name: "IdFamilia",
                table: "Material");

            migrationBuilder.DropColumn(
                name: "IdImagemPrincipal",
                table: "Material");

            migrationBuilder.DropColumn(
                name: "IdMaterialDerivado",
                table: "Material");

            migrationBuilder.DropColumn(
                name: "IdStatus",
                table: "Material");

            migrationBuilder.DropColumn(
                name: "IdProduto",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "ListaIdClientes",
                table: "GrupoDeClientes");

            migrationBuilder.DropColumn(
                name: "IdFotoPerfil",
                table: "Contato");

            migrationBuilder.DropColumn(
                name: "IdLogoEmpresa",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "ListaIdContatos",
                table: "Cliente");

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Proposta",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ContatoId",
                table: "Proposta",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FamiliaId",
                table: "Material",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdImagemPrincipalId",
                table: "Material",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaterialDerivadoId",
                table: "Material",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "Material",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProdutoId",
                table: "Item",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PropostaId",
                table: "Item",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Contato",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FotoPerfilId",
                table: "Contato",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GrupoDeClientesId",
                table: "Cliente",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LogoEmpresaId",
                table: "Cliente",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Proposta_ClienteId",
                table: "Proposta",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Proposta_ContatoId",
                table: "Proposta",
                column: "ContatoId");

            migrationBuilder.CreateIndex(
                name: "IX_Material_FamiliaId",
                table: "Material",
                column: "FamiliaId");

            migrationBuilder.CreateIndex(
                name: "IX_Material_IdImagemPrincipalId",
                table: "Material",
                column: "IdImagemPrincipalId");

            migrationBuilder.CreateIndex(
                name: "IX_Material_MaterialDerivadoId",
                table: "Material",
                column: "MaterialDerivadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Material_StatusId",
                table: "Material",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_ProdutoId",
                table: "Item",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_PropostaId",
                table: "Item",
                column: "PropostaId");

            migrationBuilder.CreateIndex(
                name: "IX_Contato_ClienteId",
                table: "Contato",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Contato_FotoPerfilId",
                table: "Contato",
                column: "FotoPerfilId");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_GrupoDeClientesId",
                table: "Cliente",
                column: "GrupoDeClientesId");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_LogoEmpresaId",
                table: "Cliente",
                column: "LogoEmpresaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_GrupoDeClientes_GrupoDeClientesId",
                table: "Cliente",
                column: "GrupoDeClientesId",
                principalTable: "GrupoDeClientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_Imagem_LogoEmpresaId",
                table: "Cliente",
                column: "LogoEmpresaId",
                principalTable: "Imagem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contato_Cliente_ClienteId",
                table: "Contato",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contato_Imagem_FotoPerfilId",
                table: "Contato",
                column: "FotoPerfilId",
                principalTable: "Imagem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Material_ProdutoId",
                table: "Item",
                column: "ProdutoId",
                principalTable: "Material",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Proposta_PropostaId",
                table: "Item",
                column: "PropostaId",
                principalTable: "Proposta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Material_Familia_FamiliaId",
                table: "Material",
                column: "FamiliaId",
                principalTable: "Familia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Material_Imagem_IdImagemPrincipalId",
                table: "Material",
                column: "IdImagemPrincipalId",
                principalTable: "Imagem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Material_Material_MaterialDerivadoId",
                table: "Material",
                column: "MaterialDerivadoId",
                principalTable: "Material",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Material_Status_StatusId",
                table: "Material",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Proposta_Cliente_ClienteId",
                table: "Proposta",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Proposta_Contato_ContatoId",
                table: "Proposta",
                column: "ContatoId",
                principalTable: "Contato",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

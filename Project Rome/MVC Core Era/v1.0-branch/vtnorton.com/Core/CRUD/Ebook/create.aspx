<%@ Page Title="" Language="C#" MasterPageFile="~/Core/Internal.Master" AutoEventWireup="true" CodeBehind="create.aspx.cs" Inherits="VTNORTON.Core.CRUD.Ebook.create" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="header">
        <h2>Criar eBook</h2>
        <p><a href="index.aspx">Ver todos</a> | <a href="create.aspx">Criar novo</a></p>
    </div>
    <div class="row">
        <div class="col-md-12">
            <asp:TextBox ID="txtNome" placeholder="Nome do eBook" runat="server"></asp:TextBox><br />
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <asp:TextBox ID="txtDescricao" placeholder="Descrição do eBook" MaxLength="140" runat="server"></asp:TextBox><br />
        </div>
    </div>
    <div class="row">
        <div class="col s12">
            <asp:Button ID="btnSubmit" OnClick="btnSubmit_Click" runat="server" Text="Enviar novos dados" />
            <asp:Label ID="lblInfo" runat="server"></asp:Label>
        </div>
    </div>
</asp:Content>

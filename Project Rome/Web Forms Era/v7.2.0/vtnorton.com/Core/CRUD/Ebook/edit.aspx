<%@ Page Title="" Language="C#" MasterPageFile="~/Core/Internal.Master" AutoEventWireup="true" CodeBehind="edit.aspx.cs" Inherits="VTNORTON.Core.CRUD.Ebook.edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="header">
        <h2>Editar eBook</h2>
        <p><a href="index.aspx">Ver todos</a> | <a href="create.aspx">Criar novo</a></p>
    </div>
    <h4>Nome do livro digital</h4>
    <asp:TextBox ID="txtNome" placeholder="Nome do eBook" runat="server"></asp:TextBox><br />
    <h4>Descrição do livro digital</h4>
    <p>O número máximo de caracteres é de 140, então descreva o livro em apenas um twitte!</p>
    <asp:TextBox ID="txtDescricao" placeholder="Descrição do eBook" MaxLength="140" runat="server"></asp:TextBox><br />
    <br /><br />
    <asp:Button ID="btnSubmit" OnClick="btnSubmit_Click" runat="server" Text="Enviar novos dados" />
    <asp:Label ID="lblInfo" runat="server"></asp:Label>
</asp:Content>

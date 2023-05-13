<%@ Page Title="Detalhes de um tema" Language="C#" MasterPageFile="~/Core/Internal.Master" AutoEventWireup="true" CodeBehind="detail.aspx.cs" Inherits="VTNORTON.Core.CRUD.Temas.detail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="header">
        <h2>Detalhes de um tema</h2>
        <p>Visualize um tema da mesma maneira que os usuários cadastrados irão receber o email. Vale lembrar que o conteúdo Lorem Ipsum está aqui só para disfarçar um futuro conteúdo.</p>
        <p><a href="index.aspx">Ver todos</a> | <a href="create.aspx">Criar novo</a></p>
    </div>
    <p>Nome do tema: <asp:Label ID="lblNome" runat="server"></asp:Label></p>
    <p>Descrição do tema: <asp:Label ID="lblDescricao" runat="server"></asp:Label></p>
    <div style="width:800px; height:auto">
        <asp:Label ID="lblTema" runat="server"></asp:Label>
    </div>
</asp:Content>

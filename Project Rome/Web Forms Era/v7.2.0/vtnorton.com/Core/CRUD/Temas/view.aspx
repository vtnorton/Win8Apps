<%@ Page Title="Visualizar tema" Language="C#" MasterPageFile="~/Core/Internal.Master" AutoEventWireup="true" CodeBehind="view.aspx.cs" Inherits="VTNORTON.Core.CRUD.Temas.view" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="header">
        <h2>Visualizar tema</h2>
        <p>Visualize um tema para ter certeza do uso dele, e por qualquer outro motivo que você achar necessário visualiza-lo.</p>
        <p><a href="index.aspx">Ver todos</a> | <a href="create.aspx">Criar novo</a></p>
    </div>
    <p>Nome do tema: <asp:Label ID="lblNome" runat="server"></asp:Label><br />
    Descrição do tema: <asp:Label ID="lblDescricao" runat="server"></asp:Label></p>
    <iframe id="TheIframe" runat="server" src="zero-css.aspx?Id=" style="width:800px; height:auto; min-height:420px; background:#f5f5f5; border:1px solid #767676"></iframe>
    <p>Abrir visualizador de e-mail em nova página? <asp:Label ID="lblNewPage" runat="server"></asp:Label></p>
</asp:Content>

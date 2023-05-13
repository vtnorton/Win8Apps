<%@ Page Title="Páginas de ajuda" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="help-pages.aspx.cs" Inherits="HidraOnline.p.gdvw.help_pages" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul>
        <li><a class="on" href="help-pages.aspx">Nova página</a></li>
        <li><a href="manage-help-pages.aspx">Gerenciar páginas</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <h1>Nova página de ajuda</h1>
    <span>Crie uma página para ajudar os usuários da Hidra OS a usarem o sistema.</span>
    <h1>Em breve...</h1>
</asp:Content>

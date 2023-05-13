<%@ Page Title="Gerenciar páginas de ajuda" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="manage-help-pages.aspx.cs" Inherits="HidraOnline.p.gdvw.manage_help_pages" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul>
        <li><a href="help-pages.aspx">Nova página</a></li>
        <li><a class="on" href="manage-help-pages.aspx">Gerenciar páginas</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <h1>Páginas de ajuda</h1>
    <span>Veja as páginas criadas para ajudar os usuários da Hidra OS a usarem o sistema.</span>
    <h1>Em breve...</h1>
</asp:Content>

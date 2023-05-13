<%@ Page Title="God View" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="gdvw.aspx.cs" Inherits="HidraOnline.gdvw" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul>
        <li><a href="/p/gdvw/new-user.aspx">Novo usuário</a></li>
        <li><a href="/p/gdvw/push-notification.aspx">Notificações Push</a></li>
        <li><a href="/p/gdvw/help-pages.aspx">Nova página de ajuda</a></li>
        <li><a href="/p/gdvw/manage-help-pages.aspx">Gerenciar páginas de ajuda </a></li>
        <li><a href="/p/manage/bugs.aspx">Relatórios de bugs</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <h1>God View</h1>
    <span>Veja as páginas nessa sessão</span>
    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer nec odio. Praesent libero. Sed cursus ante dapibus diam. Sed nisi. Nulla quis sem at nibh elementum imperdiet. Duis sagittis ipsum. Praesent mauris. Fusce nec tellus sed augue semper porta.</p>
    <p>Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Nam nec ante.</p>
</asp:Content>

<%@ Page Title="Notificações push" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="push-notification.aspx.cs" Inherits="HidraOnline.p.gdvw.push_notification" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SUBMENU" runat="server">
        <ul>
        <li><a href="/p/gdvw/new-site.aspx">Novo site</a></li>
        <li><a href="/p/gdvw/edit-site.aspx">Gerenciar sites</a></li>
        <li><a class="on" href="/p/gdvw/push-notification.aspx">Notificações Push</a></li>
        <li><a href="/p/manage/bugs.aspx">Gerenciar feedback</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <h1>Notificação Push</h1>
    <span>Enviar notificações push para usuários dos aplicativos.</span>
    <h1>Em breve...</h1>
</asp:Content>

<%@ Page Title="Gerenciar listas de e-mail marketing" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="e-mail-marketing-list.aspx.cs" Inherits="HidraOnline.p.manage.e_mail_marketing_list" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul>
        <li><a href="/p/novo/e-mail-marketing-list.aspx">Nova lista</a></li>
        <li><a class="on" href="/p/manage/e-mail-marketing-list.aspx">Gerenciar listas</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <h1>Listas de e-mail</h1>
    <span>Veja, edite e exclua listas de e-mails para campanhas</span>

    <h1>Em breve...</h1>
</asp:Content>

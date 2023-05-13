<%@ Page Title="Gerenciar campanhas de e-mail marketing" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="e-mail-marketing-campanhe.aspx.cs" Inherits="HidraOnline.p.manage.e_mail_marketing_campanhe" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul>
        <li><a href="/p/novo/e-mail-marketign-campanhe.aspx">Criar campanha</a></li>
        <li><a class="on" href="/p/manage/e-mail-marketing-campanhe.aspx">Gerenciar campanhas</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <h1>Campanhas de e-mail marketing</h1>
    <span>Veja, edite e exclua campanhas de e-mails</span>
    <h1>Em breve...</h1>
</asp:Content>
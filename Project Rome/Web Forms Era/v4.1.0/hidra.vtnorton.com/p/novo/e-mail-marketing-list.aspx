<%@ Page Title="Nova lista de e-mail marketing" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="e-mail-marketing-list.aspx.cs" Inherits="HidraOnline.p.new.e_mail_marketing_list" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul>
        <li><a href="/p/novo/e-mail-marketign-campanhe.aspx">Criar campanha</a></li>
        <li><a class="on" href="/p/novo/e-mail-marketign-list.aspx">Criar lista</a></li>
        <li><a href="/p/manage/e-mail-marketing-list.aspx">Gerenciar listas</a></li>
        <li><a href="/p/manage/e-mail-marketing-campanhe.aspx">Gerenciar campanhas</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <h1>Lista de e-mail</h1>
    <span>Criar uma lista de e-mail marketing</span>
    <h1>Em breve...</h1>

</asp:Content>

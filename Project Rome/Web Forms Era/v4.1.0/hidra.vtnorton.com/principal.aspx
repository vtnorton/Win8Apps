<%@ Page Title="Principal" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="principal.aspx.cs" Inherits="HidraOnline.principal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul>
        <li><a href="/p/slides.aspx">Editar slides do site</a></li>
        <li><a href="/p/avaliacoes.aspx">Avaliações de usuários</a></li>
        <li><a href="/p/information.aspx">Informações gerais</a></li>
        <li><a href="/p/bugs.aspx">elatórios de bug</a></li>
        <li><a href="/p/email.aspx">Enviar e-mail</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <h1>Principais</h1>
    <span>Veja as páginas nessa sessão</span>
    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer nec odio. Praesent libero. Sed cursus ante dapibus diam. Sed nisi. Nulla quis sem at nibh elementum imperdiet. Duis sagittis ipsum. Praesent mauris. Fusce nec tellus sed augue semper porta.</p>
    <p>Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Nam nec ante.</p>
    
</asp:Content>

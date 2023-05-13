<%@ Page Title="Sobre + Ajuda" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="ajuda.aspx.cs" Inherits="HidraOnline.ajuda1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul>
        <li><a href="/p/about.aspx">Sobre a Hidra OS</a></li>
        <li><a href="/p/ajuda.aspx">Ajuda e suporte</a></li>
        <li><a href="/p/contato.aspx">Contato com o desenvolvedor</a></li>
        <li><a href="/p/novo/sugestion.aspx">Enviar sugestão</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <h1>Sobre, Suporte e ajuda</h1>
    <span>Veja as páginas nessa sessão</span>
    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer nec odio. Praesent libero. Sed cursus ante dapibus diam. Sed nisi. Nulla quis sem at nibh elementum imperdiet. Duis sagittis ipsum. Praesent mauris. Fusce nec tellus sed augue semper porta.</p>
    <p>Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Nam nec ante.</p>
</asp:Content>

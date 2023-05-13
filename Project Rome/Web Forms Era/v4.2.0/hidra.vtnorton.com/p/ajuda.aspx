<%@ Page Title="Sobre + Ajuda" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="ajuda.aspx.cs" Inherits="HidraOnline.ajuda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul>
        <li><a href="/p/about.aspx">Sobre a Hidra OS</a></li>
        <li><a class="on" href="/p/ajuda.aspx">Ajuda e suporte</a></li>
        <li><a href="/p/contato.aspx">Contato com o desenvolvedor</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="toggle-options-head">Ajuda + suporte</div>
    <hr />

    <p>Pagína em construção: disponibilidade somente na versão beta do sistema.</p>
</asp:Content>

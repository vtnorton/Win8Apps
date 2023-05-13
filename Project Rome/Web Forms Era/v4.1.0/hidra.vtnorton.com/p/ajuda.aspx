<%@ Page Title="Sobre + Ajuda" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="ajuda.aspx.cs" Inherits="HidraOnline.ajuda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul>
        <li><a href="/p/about.aspx">Sobre</a></li>
        <li><a class="on" href="/p/ajuda.aspx">Ajuda+Suporte</a></li>
        <li><a href="/p/contato.aspx">Contato</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <h1>Ajuda + suporte</h1>
    <span>Precisa de ajuda em algum serviço ou página?</span>
    <p>Pagína em construção: disponibilidade prevista para 02 de outubro</p>
</asp:Content>

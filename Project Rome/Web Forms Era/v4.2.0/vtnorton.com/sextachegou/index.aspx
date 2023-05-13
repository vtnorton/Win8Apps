<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="VTNORTON.tgif.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul style="margin-left: 0">
        <li><a class="ativo" href="index.aspx">Amamos a sexta-feira</a></li>
        <li><a href="/blog/tag.aspx?tag=tgif">Blog</a></li>
        <li><a href="whathappens.aspx">O que acontece com a #TGIF</a></li>
        <li><a href="compartilhe.aspx">Ajude a #TGIF crescer!</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>

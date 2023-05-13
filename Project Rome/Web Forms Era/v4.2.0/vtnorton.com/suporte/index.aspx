<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="VTNORTON.suporte.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul style="margin-left: 0">
        <%--<li><a href="bsharp.aspx">B#</a></li>--%>
        <li><a class="ativo" href="index.aspx">Geral</a></li>
        <li><a href="build.aspx">Build</a></li>
        <li><a href="hidra.aspx">Hidra</a></li>
        <li><a href="apps.aspx">Aplicativos</a></li>
        <li><a href="historico.aspx">Histórico de versões</a></li>
        <li><a href="suporte.aspx">Suporte</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>

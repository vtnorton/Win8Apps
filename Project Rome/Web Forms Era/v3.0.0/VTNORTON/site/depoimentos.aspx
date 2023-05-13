<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="depoimentos.aspx.cs" Inherits="VTNORTON.connect.depoimentos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Depoimentos | Tenha seu site | VTNORTON</title>
    <meta name="description" content="Estamos oferecendo para 20 empresas da cidade de Espera Feliz - MG sites a preços especiais, sem taxas mensais, e com ótimos diferenciais para que as empresas da cidade tenham maior conectividade, maior engajamento e logo mais clientes." />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul style="margin-left: 0;">
        <li><a href="Index.aspx?=submenu">Conheça o projeto</a></li>
        <li><a href="motivos.aspx?=submenu">Por que ter um site?</a></li>
        <li><a class="ativo" href="depoimentos.aspx?=submenu">Depoimentos</a></li>
        <%--<li><a href="cadastro.aspx?=submenu">Cadastre-se</a></li>--%>
        <li><a href="faq.aspx?=submenu">Perguntas Frequentes</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>

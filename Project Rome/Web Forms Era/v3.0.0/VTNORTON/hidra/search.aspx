<%@ Page Title="Resultado da Pesquisa do Search | VTNORTON" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="search.aspx.cs" Inherits="VTNORTON.search.Search" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta http-equiv="content-type" content="text/html; charset=iso-8859-1" />
    <meta name="description" content="Pesquise por vídeos e músicas com o Search. Sem pop-ups, botões de Downloads, anúncios e Captchas. O Search tira tudo isso e facilita o seu download." />
    <meta name="author" content="Vítor Norton" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul style="margin-left: 0;">
        <li><a class="ativo" href="/hidra/index.aspx">Pesquisar</a></li>
        <li><a href="sobre.aspx">Sobre</a></li>
        <li><a href="opiniao.aspx">Mande a sua sugestão</a></li>
        <li><a href="adicionarnavegador.aspx">Adicione o Hidra em seu navegador</a></li>
        <%--<li><a href="/mixer/Index.aspx">M!xer</a></li>--%>
        <%--<li><a href="#">Novidades</a></li>--%>
        <%--<li><a href="#">Diferencial</a></li>--%>
        <%--<li><a href="#">Pirataria</a></li>--%>
        <%--<li><a href="#">Ajuda</a></li>--%>
    </ul>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Nós estamos de mudança. Por favor, atualize-se.
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="opiniao.aspx.cs" Inherits="VTNORTON.search.opiniao" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/Search.css" rel="stylesheet" />
    <link href="Search.css" rel="stylesheet" />
    <title>Sua opinião é importante para nós | VTNORTON</title>
    <meta name="description" content="Pesquise por vídeos e músicas com o Search. Sem pop-ups, botões de Downloads, anúncios e Captchas. O Search tira tudo isso e facilita o seu download." />
    <meta name="author" content="Vítor Norton" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul style="margin-left: 0;">
        <li><a href="/search/Index.aspx">Pesquisar</a></li>
        <li><a href="sobre.aspx">Sobre</a></li>
        <li><a class="ativo" href="opiniao.aspx">Mande a sua sugestão</a></li>
        <li><a href="adicionarnavegador.aspx">Adicione o Search em seu navegador</a></li>
        <%--<li><a href="/mixer/Index.aspx">M!xer</a></li>--%>
        <%--<li><a href="#">Novidades</a></li>--%>
        <%--<li><a href="#">Diferencial</a></li>--%>
        <%--<li><a href="#">Pirataria</a></li>--%>
        <%--<li><a href="#">Ajuda</a></li>--%>
    </ul>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="content">
        <div id="slogan" class="inner">
            <h1>Queremos saber a sua opinião</h1>
            <h3 style="margin-top:-5px;">mande para nós suas ideias, sugestões e criticas</h3>
        </div>
        <form id="form2" runat="server">
            <asp:TextBox ID="txtNome" runat="server" CssClass="span8" placeholder="Digite seu nome"></asp:TextBox><br /><br />
            <asp:TextBox ID="txtEmail" runat="server" CssClass="span8" placeholder="Digite seu Endereço de e-mail"></asp:TextBox><br /><br />
            <asp:TextBox ID="txtMensagem" runat="server" CssClass="span8" placeholder="Digite sua mensagem"></asp:TextBox><br /><br />
            <asp:Label ID="Label4" runat="server" Text=""></asp:Label><br />
            <asp:Button ID="Button1" runat="server" CssClass="btn-success btn" OnClick="Button1_Click" Text="Enviar" />
        </form>
    </div>
</asp:Content>

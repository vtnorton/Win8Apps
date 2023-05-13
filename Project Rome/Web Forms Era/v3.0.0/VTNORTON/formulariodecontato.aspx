<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="formulariodecontato.aspx.cs" Inherits="VTNORTON.FormularioDeContato" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul style="margin-left:0;">
        <li><a href="/sobre.aspx">Sobre</a></li>
        <li><a href="/biografia.aspx">Biografia</a></li>
        <li><a href="/linha-do-tempo.aspx">Linha do tempo</a></li>
        <li><a href="/projetos.aspx">Projetos</a></li>
        <li><a href="/planosfuturos.aspx">Planos futuros</a></li>
        <li><a href="/redes-sociais.aspx">Redes Sociais</a></li>
        <li><a href="/faq.aspx">FAQ</a></li>
        <li><a class="ativo" href="/formulariodecontato.aspx">Contato</a></li>
        <li><a href="/status.aspx">Histórico de versões</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="content">
        <div id="slogan" class="inner">
            <h1>Use este formulario de contato</h1>
            <h3 style="margin-top:-5px;">ideias, sugestões, criticas, ou simplesmente bate-papo</h3>
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

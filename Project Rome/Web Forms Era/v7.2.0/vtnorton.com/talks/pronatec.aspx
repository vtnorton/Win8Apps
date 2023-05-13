<%@ Page Title="Baixe grátis o Formula | Vítor Norton" Language="C#" MasterPageFile="~/healtthrob.Master" AutoEventWireup="true" CodeBehind="pronatec.aspx.cs" Inherits="VTNORTON.talks.pronatec" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderSubMenu" runat="server">
    <ul>
        <li><a href="http://twitter.com/vt_norton">Siga-me no Twitter</a></li>
        <li><a href="http://facebook.com/vitor.norton">Curta o Facebook</a></li>
        <li><a href="/">Veja os meus projetos</a></li>
        <li><a href="http://vtnorton.com/onenote">eBook gratuito do Onenote</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="wrapper">
        <h1>Baixe grátis o <a href="/formula">Formula - Universal Code Editor</a></h1>
        <p>Cadastre-se agora e receba em seu email promoções e atualizações.</p>
        <form runat="server">
            <p><strong>Insira o seu nome:</strong></p>
            <asp:TextBox ID="txtUser" placeholder="Nome" runat="server"></asp:TextBox><br />
            <p><strong>Insira o seu e-mail:</strong></p>
            <asp:TextBox ID="txtMail" placeholder="E-mail" runat="server"></asp:TextBox><br />
            <br />
            <asp:Button OnClick="Unnamed_Click" runat="server" Text="Receber gratuitamente o Formula" Height="50" /><br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </form>
    </div>
</asp:Content>

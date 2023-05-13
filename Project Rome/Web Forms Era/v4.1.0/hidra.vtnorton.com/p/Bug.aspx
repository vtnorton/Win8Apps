<%@ Page Title="Reportar bug" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Bug.aspx.cs" Inherits="HidraOnline.p.Bug" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SUBMENU" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <h1>Reportar bug</h1>
    <span>Informe a existência de um bug para que possamos concerta-lo.</span>
    <br />
    <p>
        Por favor, me informe o erro que você encontrou. Vale de tudo, erros de português, algumas coisa que não deveria estar onde está. O que está faltando? Quanto mais feedback melhor o sistema vai ficar.
        <br />
        Por favor, me informe seu e-mail para que eu possa te responder o mais rapído possível quando o bug for concertado!
    </p>
    <asp:TextBox ID="txtEmail" placeholder="E-mail" TextMode="Email" CssClass="full" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:TextBox ID="txtDescricao" placeholder="Descrição do bug" CssClass="full" TextMode="MultiLine" Height="80" runat="server"></asp:TextBox>
    <br />

    <asp:Button ID="btnEnivar" OnClick="btnEnivar_Click" runat="server" Text="Enviar" /><br />
    <br />
    <asp:Label ID="lblInfo" runat="server" Text=""></asp:Label>
</asp:Content>

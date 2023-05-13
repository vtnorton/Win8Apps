<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="sugestion.aspx.cs" Inherits="VTNORTON.sugestion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul>
        <li><a href="/">Pagina Inicial</a></li>
        <li><a onclick="parent.history.back()" href="#">Voltar para a pagina anterior</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="box-content">
        <h1 style="margin-bottom:10px">Enviar sugestão</h1>
        <asp:TextBox ID="txtInvalidSpam" runat="server" CssClass="displaynone" placeholder="Não preencha esse campo"></asp:TextBox><br />
        <br />
        <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" placeholder="Digite seu e-mail"></asp:TextBox><br />
        <br />
        <asp:TextBox ID="txtMensagem" runat="server" CssClass="full" placeholder="Digite sua mensagem" TextMode="MultiLine" Wrap="False"></asp:TextBox><br />
        <br />
        <asp:Label ID="lblTexto" runat="server" Text=""></asp:Label><br />
        <asp:Button ID="btnEnviar" runat="server" CssClass="btn" OnClick="btnEnviar_Click" Text="Enviar" />
    </div>
    <div class="box-content">
        <h4>Observações</h4>
        <p>#observação | Levo denuncias e avisos de bug muito a sério. Por favor, descreva o seu problema em detalhes.</p>
        <p>#privacidade | Você receberá uma cópia de e-mail com todos os dados compartilhados comigo.</p>
    </div>
</asp:Content>

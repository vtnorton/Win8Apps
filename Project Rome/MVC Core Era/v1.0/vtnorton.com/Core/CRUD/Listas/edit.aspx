<%@ Page Title="Editar lista de e-mails" Language="C#" MasterPageFile="~/Core/Internal.Master" AutoEventWireup="true" CodeBehind="edit.aspx.cs" Inherits="VTNORTON.Core.CRUD.Listas.edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="header">
        <h2>Editar lista de e-mails</h2>
        <p>Remova um e-mail da lista e veja os emails cadastrados. Altere também o nome e a descrição da lista. <br /> O nome e descrição da lista são visíveis somente para o administrador do sistema.</p>
        <!--Colocar o Id aqui -->
        <p><a href="index.aspx">Ver todos</a> | <a href="create.aspx">Criar nova</a> 
    </div>
    <h4>Título da lista</h4>
    <p>Escreva o título da lista de e-mail. </p>
    <asp:TextBox ID="txtTitulo" MaxLength="80" placeholder="Título da lista de e-mail" runat="server"></asp:TextBox><br />
    <h4>Descrição da lista</h4>
    <p>Escreva a descrição, com no máximo de 140 caracteres da lista de e-mail.</p>
    <asp:TextBox ID="txtDescricao" TextMode="MultiLine" placeholder="Descrição da lista de e-mail" MaxLength="140" runat="server"></asp:TextBox><br />
    <h4>Mensagem de rodapé</h4>
    <p>Esta é a mensagem que irá ficar no rodapé do e-mail e que irá mostrar ao usuário o motivo que ele se cadastrou no e-mail.</p>
    <asp:TextBox ID="txtFooter" placeholder="Mensagem no footer do e-mail" MaxLength="140" runat="server"></asp:TextBox><br />

    <br />

    <asp:Button ID="btnSubmit" OnClick="btnSubmit_Click" runat="server" Text="Enviar novos dados" />
    <asp:Label ID="lblInfo" runat="server"></asp:Label>
</asp:Content>

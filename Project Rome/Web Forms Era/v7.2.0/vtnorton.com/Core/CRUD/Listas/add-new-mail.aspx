<%@ Page Title="" Language="C#" MasterPageFile="~/Core/Internal.Master" AutoEventWireup="true" CodeBehind="add-new-mail.aspx.cs" Inherits="VTNORTON.Core.CRUD.Listas.add_new_mail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="header">
        <h2>Adicionar e-mail para uma lista</h2>
        <p><a href="index.aspx">Ver todas as listas de e-mail</a></p>
    </div>
    <h3>Você está adicionando um e-mail na lista: <asp:Label ID="lblLista" runat="server"></asp:Label></h3>
    
    <h4>Adicione e-mail individual</h4>
    <p>Adicione apenas um e-mail na lista</p>
    <p>Mantenha esta caixa vazia para ignorar ela.</p>
    <asp:TextBox ID="txtEmail" placeholder="E-mail" MaxLength="140" runat="server"></asp:TextBox><br />

    <h4>Adicione vários e-mails</h4>
    <p>Adicione vários emails, utilizando a caixa abaixo. Tenha certeza de colocar em e-mail por linha</p>
    <p>Mantenha esta caixa vazia para ignorar ela.</p>
    <asp:TextBox ID="txtEmailMultiplos" TextMode="MultiLine" placeholder="E-mail" runat="server"></asp:TextBox><br />

    <br /><br />

    <asp:Button ID="btnSubmit" OnClick="btnSubmit_Click" runat="server" Text="Enviar novos dados" />
    <asp:Label ID="lblInfo" runat="server"></asp:Label>
</asp:Content>

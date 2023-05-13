<%@ Page Title="Editar lista de e-mails" Language="C#" MasterPageFile="~/Core/Internal.Master" AutoEventWireup="true" CodeBehind="edit.aspx.cs" Inherits="VTNORTON.Core.CRUD.Listas.edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="header">
        <h2>Editar lista de e-mails</h2>
        <p>Remova um e-mail da lista e veja os emails cadastrados. Altere também o nome e a descrição da lista. <br /> O nome e descrição da lista são visíveis somente para o administrador do sistema.</p>
        <!--Colocar o Id aqui -->
        <p><a href="index.aspx">Ver todos</a> | <a href="create.aspx">Criar nova</a> | <a href="add-new-mail.aspx?Id=">Adicionar um novo e-mail nesta lista</a></p>
    </div>
    <div class="row">
        <div class="col-md-12">
            <asp:TextBox ID="txtTitulo" placeholder="Título da lista de e-mail" runat="server"></asp:TextBox><br />
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <asp:TextBox ID="txtDescricao" placeholder="Descrição da lista de e-mail" MaxLength="140" runat="server"></asp:TextBox><br />
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <asp:TextBox ID="txtFooter" placeholder="Mensagem no footer do e-mail" MaxLength="140" runat="server"></asp:TextBox><br />
        </div>
    </div>
    <div class="row">
        <div class="col s12">
            <asp:Button ID="btnSubmit" OnClick="btnSubmit_Click" runat="server" Text="Enviar novos dados" />
            <asp:Label ID="lblInfo" runat="server"></asp:Label>
        </div>
    </div>
</asp:Content>

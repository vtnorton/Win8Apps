<%@ Page Title="" Language="C#" MasterPageFile="~/Core/Internal.Master" AutoEventWireup="true" CodeBehind="add-new-mail.aspx.cs" Inherits="VTNORTON.Core.CRUD.Listas.add_new_mail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="header">
        <h2>Adicionar e-mail para uma lista</h2>
        <%--<p><a href="index.aspx">Ver todos</a> | <a href="create.aspx">Criar novo</a></p>--%>
    </div>
    <div class="row">
        <div class="col-md-12">
            Você está adicionando um e-mail na lista: <asp:Label ID="lblLista" runat="server"></asp:Label>
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <asp:TextBox ID="txtEmail" placeholder="E-mail" MaxLength="140" runat="server"></asp:TextBox><br />
        </div>
    </div>
    <div class="row">
        <div class="col s12">
            <asp:Button ID="btnSubmit" OnClick="btnSubmit_Click" runat="server" Text="Enviar novos dados" />
            <asp:Label ID="lblInfo" runat="server"></asp:Label>
        </div>
    </div>
</asp:Content>

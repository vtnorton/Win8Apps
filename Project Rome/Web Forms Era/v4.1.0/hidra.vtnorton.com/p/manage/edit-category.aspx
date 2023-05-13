<%@ Page Title="Editar categoria" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="edit-category.aspx.cs" Inherits="HidraOnline.p.manage.edit_category" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul>
        <li><a href="/p/novo/post.aspx">Novo post</a></li>
        <li><a href="/p/novo/category.aspx">Nova categoria</a></li>
        <li><a href="/p/manage/post.aspx">Todos os posts</a></li>
        <li><a href="/p/manage/category.aspx">Todos as categorias</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <h1>Editar categoria</h1>
    <span>Edite a categoria selecionada</span>
    <asp:TextBox ID="txtName" placeholder="Nome da categoria" MaxLength="15" runat="server"></asp:TextBox><br />
    <asp:TextBox ID="txtDescricao" placeholder="Descrição da categoria (140 caracteres)" Height="100" TextMode="MultiLine" MaxLength="140" runat="server"></asp:TextBox><br />
    <asp:TextBox ID="txtURLIcon" placeholder="URL do ícone da categoria" runat="server"></asp:TextBox><br />
    <asp:TextBox ID="txtURLCover" placeholder="URL da capa da categoria" runat="server"></asp:TextBox><br />
    <asp:Button ID="btnCreate" OnClick="btnCreate_Click" runat="server" Text="Atualizar categoria" />
    <asp:Label ID="Label1" runat="server"></asp:Label>
</asp:Content>

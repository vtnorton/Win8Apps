<%@ Page Title="Gerenciar categorias" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="category.aspx.cs" Inherits="HidraOnline.p.manage.category" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul>
        <li><a href="/p/novo/post.aspx">Novo post</a></li>
        <li><a href="/p/novo/category.aspx">Nova categoria</a></li>
        <li><a href="/p/manage/post.aspx">Todos os posts</a></li>
        <li><a class="on" href="/p/manage/category.aspx">Todos as categorias</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <h1>Todas as categorias</h1>
    <span>Veja, edite e exclua categorias do blog</span>


    <h1>Em breve...</h1>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</asp:Content>

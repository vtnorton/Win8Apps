<%@ Page Title="Gerenciar posts" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="post.aspx.cs" Inherits="HidraOnline.p.manage.post" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul>
        <li><a href="/p/novo/post.aspx">Novo post</a></li>
        <li><a href="/p/novo/category.aspx">Nova categoria</a></li>
        <li><a class="on" href="/p/manage/post.aspx">Todos os posts</a></li>
        <li><a href="/p/manage/category.aspx">Todos as categorias</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <h1>Todos os posts</h1>
    <span>Veja, edite e gerencie todos os posts</span>
    <br />
    <asp:PlaceHolder ID="listPost" runat="server"></asp:PlaceHolder>
</asp:Content>

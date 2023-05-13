<%@ Page Title="Nova categoria" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="category.aspx.cs" Inherits="HidraOnline.p.novo.category" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul>
        <li><a href="post.aspx">Novo post</a></li>
        <li><a class="on" href="/p/novo/category.aspx">Nova categoria</a></li>
        <li><a href="/p/manage/post.aspx">Todos os posts</a></li>
        <li><a href="/p/manage/category.aspx">Todos as categorias</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="left seventyfivepercent">
        <asp:TextBox ID="txtName" placeholder="Nome da categoria" MaxLength="50" runat="server"></asp:TextBox><br />
        <asp:TextBox ID="txtDescricao" placeholder="Descrição da categoria (240 caracteres)" Height="100" TextMode="MultiLine" MaxLength="240" runat="server"></asp:TextBox><br />
        <asp:TextBox ID="txtURLIcon" placeholder="URL do ícone da categoria" runat="server"></asp:TextBox><br />
        <asp:TextBox ID="txtURLCover" placeholder="URL da capa da categoria" runat="server"></asp:TextBox><br />
    </div>
    <div class="right twentyfivepercent">
        <asp:Button ID="btnCreate" OnClick="btnCreate_Click" runat="server" Text="Criar categoria" />
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </div>
    <div class="clean"></div>
</asp:Content>
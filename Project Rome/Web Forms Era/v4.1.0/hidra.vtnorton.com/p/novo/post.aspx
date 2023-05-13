<%@ Page Title="Novo post" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="post.aspx.cs" Inherits="HidraOnline.crud.create.post" %>

<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .cbx {
            position: relative;
            top: -10px;
            margin-left: -4px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul>
        <li><a class="on" href="post.aspx">Novo post</a></li>
        <li><a href="/p/novo/category.aspx">Nova categoria</a></li>
        <li><a href="/p/manage/post.aspx">Todos os posts</a></li>
        <li><a href="/p/manage/category.aspx">Todos as categorias</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="left seventyfivepercent">
        <asp:TextBox ID="txtTitle" Text="" placeholder="Título do post" runat="server"></asp:TextBox><br />
        <br />
        <CKEditor:CKEditorControl ID="CKEditor1" BasePath="/plugins/ckeditor/" Height="400px" runat="server"></CKEditor:CKEditorControl><br />
        <asp:Label ID="lblInfo" runat="server" Text=""></asp:Label>
    </div>
    <div class="right twentyfivepercent">
        <div class="toggle-options-head">Configurações do post + publicar</div>
        <div class="toggle-options-main">
            <p>Insira aqui algumas breves configurações como data de publicação, categorias, tags, e publique o seu conteúdo.</p>
            <h5>Opções:</h5>
            <hr />
            <div class="left">
                Categorias:<br />
                <br />
                Visível:
                <br />
                <br />
            </div>
            <div class="right">
                <asp:DropDownList ID="ddlCategory" runat="server"></asp:DropDownList>
                <br />
                <br />
                <asp:CheckBox ID="cbxAvabible" Checked="true" CssClass="cbx" runat="server" /><br />
            </div>
            <div class="clean"></div>

            <h5>Publicar</h5>
            <hr />
            Verifique se está tudo certo antes de publicar.
            <br />
            <br />
                <asp:Button ID="btnPublish" OnClick="btnPublish_Click" runat="server" CssClass="full" Height="50" Text="Publicar" />

        </div>
    </div>
    <div class="clean"></div>
</asp:Content>

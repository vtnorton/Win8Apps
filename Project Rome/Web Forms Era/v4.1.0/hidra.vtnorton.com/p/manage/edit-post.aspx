<%@ Page Title="Editar post" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="edit-post.aspx.cs" Inherits="HidraOnline.p.manage.edit_post" %>

<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
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
    <h1>Editar post</h1>

    <span>Edite o post selecionado</span>
    <asp:TextBox ID="txtTitle" Text="" placeholder="Título do post" runat="server"></asp:TextBox><br />
    <CKEditor:CKEditorControl ID="CKEditor1" BasePath="/plugins/ckeditor/" runat="server"></CKEditor:CKEditorControl><br />
    <asp:Label ID="lblInfo" runat="server" Text=""></asp:Label>
    <div class="toggle-options-head">Configurações do post + atualizar</div>
    <div class="toggle-options-main">
        <p>Insira aqui algumas breves configurações como data de publicação, categorias, tags, e publique o seu conteúdo.</p>
        <div class="left half">
            <h5>Opções:</h5>
            <hr />
            <div class="left half">
                Categorias:<br />
                <br />
                Visível:
                <br />
                <br />
            </div>
            <div class="right half">
                <asp:DropDownList ID="ddlCategoria" CssClass="full" runat="server">
                    <asp:ListItem Text="Sem categoria" Enabled="true" Selected="True" Value="0"></asp:ListItem>
                </asp:DropDownList><br />
                <br />
                <asp:CheckBox ID="cbxAvabible" Checked="true" CssClass="cbx" runat="server" /><br />
            </div>
            <div class="clean"></div>
        </div>
        <div class="right half">
            <h5>Publicar</h5>
            <hr />
            Verifique se está tudo certo antes de publicar.
            <br />
            <br />
            <div class="right half">
                <asp:Button ID="btnPublish" OnClick="btnPublish_Click" runat="server" CssClass="full" Height="50" Text="Atualizar" />

            </div>
            <div class="clean"></div>
        </div>
        <div class="clean"></div>
    </div>
</asp:Content>

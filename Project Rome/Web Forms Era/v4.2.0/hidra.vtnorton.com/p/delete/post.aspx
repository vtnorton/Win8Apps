<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="post.aspx.cs" Inherits="HidraOnline.p.delete.post" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul>
        <li><a href="/p/novo/post.aspx">Novo post</a></li>
        <li><a href="/p/novo/category.aspx">Nova categoria</a></li>
        <li><a href="/p/manage/post.aspx">Todos os posts</a></li>
        <li><a href="/p/manage/category.aspx">Todos as categorias</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Content" runat="server">
    <div class="seventyfivepercent left">
        <div class="toggle-options-head">
            <asp:Label ID="lblTitle" runat="server" Text=""></asp:Label>
        </div>
        <hr />
        <article>
            <asp:Label ID="lblContent" runat="server" Text=""></asp:Label>
        </article>
    </div>
    <div class="twentyfivepercent right sidebar">
        <div class="toggle-options-head">Deseja excluir este post?</div>
        <hr />
        <p>Ao deletar um post, não há como voltar atras. Sério, não há lixeira. Uma vez deletado, é pra sempre! Então tenha certeza disso! Dê uma olhada em algumas informações do post para ter certeza de é isso mesmo que você quer!</p>
        <br />
        <p>
            <strong>Categoria: </strong>
            <asp:Label ID="lblCategoria" runat="server" Text=""></asp:Label><br />
            <strong>Autor: </strong>
            <asp:Label ID="lblAuthor" runat="server" Text=""></asp:Label><br />
            <strong>Data de modificação: </strong>
            <asp:Label ID="lblUpdatedDate" runat="server" Text=""></asp:Label><br />
            <strong>Data de publicação: </strong>
            <asp:Label ID="lblPublishedDate" runat="server" Text=""></asp:Label><br />
            <strong>Número de visitas: </strong>
            <asp:Label ID="lblVitis" runat="server" Text=""></asp:Label><br />
            <asp:Label ID="lblOnline" runat="server" Text=""></asp:Label>
        </p>
        <br />
        <asp:Label ID="lblEdit" CssClass="blue" runat="server" Text=""></asp:Label><br />
        <br />
        <br />
        <asp:Button ID="btnCancelar" OnClick="btnCancelar_Click" Height="50" CssClass="half btn-grey left" runat="server" Text="Cancelar" /><asp:Button OnClick="btnExcluir_Click" ID="btnExcluir" Height="50" CssClass="half btn-red right" runat="server" Text="Excluir" /><br />

        <div class="clean"></div>
        <asp:Label ID="lblInfo" runat="server" Text=""></asp:Label>
    </div>
    <div class="clean"></div>
</asp:Content>

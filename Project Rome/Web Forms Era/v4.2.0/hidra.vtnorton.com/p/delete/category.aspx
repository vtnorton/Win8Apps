<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="category.aspx.cs" Inherits="HidraOnline.p.delete.category" %>

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
            <asp:Label ID="lblImg" runat="server" Text=""></asp:Label>
            <p>
                <asp:Label ID="lblDescription" runat="server" Text=""></asp:Label>
            </p>

        </article>
        <div class="clean"></div>
    </div>
    <div class="twentyfivepercent right sidebar">
        <div class="toggle-options-head">Deseja excluir esta categoria?</div>
        <hr />
        <p>Atenção: não há como voltar atras. Sério, não há lixeira. Uma vez deletado, é pra sempre! Então tenha certeza disso! Dê uma olhada em algumas informações da categoria para ter certeza de é isso mesmo que você quer!</p>
        <br />
        <p>
            <asp:CheckBox ID="ckbEMailMe" Checked="true" Text="Enviar por e-mail os posts desta categoria." runat="server" /><br />
            <asp:CheckBox ID="ckbExiberPosts" runat="server" Checked="true" Text="Exibir posts que precisam de atenção." /><br />
            <br />
            <strong>Ao deletar esta categoria os posts desta não serão afetados, devendo assim ter que manualmente mudar tais posts de categoria. Estes posts serão listados ao excluir a categoria.</strong>
        </p>
        <br />
        <asp:Label ID="lblEdit" CssClass="blue" runat="server" Text=""></asp:Label><br />
        <br />
        <asp:Button ID="btnCancelar" OnClick="btnCancelar_Click" Height="50" CssClass="half btn-grey left" runat="server" Text="Cancelar" /><asp:Button OnClick="btnExcluir_Click" ID="btnExcluir" Height="50" CssClass="half btn-red right" runat="server" Text="Excluir" /><br />
        <div class="clean"></div>
        <p>
            <asp:Label ID="lblInfo" runat="server" Text=""></asp:Label>
        </p>
    </div>
    <div class="clean"></div>
</asp:Content>

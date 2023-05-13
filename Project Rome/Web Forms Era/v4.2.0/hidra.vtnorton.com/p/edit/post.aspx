<%@ Page Title="Editar post" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="post.aspx.cs" Inherits="HidraOnline.p.edit.post" %>

<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul>
        <li><a href="/p/novo/post.aspx">Novo post</a></li>
        <li><a href="/p/novo/category.aspx">Nova categoria</a></li>
        <li><a href="/p/manage/post.aspx">Gerenciar posts</a></li>
        <li><a href="/p/manage/category.aspx">Gerenciar categorias</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Content" runat="server">
    <div class="left seventyfivepercent">
        <asp:TextBox ID="txtTitle" Text="" onKeyUp="CountChar('Content_txtTitle', 120, 'Count_txtTitle')" placeholder="Título do post" MaxLength="120" runat="server"></asp:TextBox><br />
        <div class="lblCountChar">
            <span id="Count_txtTitle">Nenhum caractere inserido até o momento.</span>
        </div>
        <br />
        <CKEditor:CKEditorControl ID="CKEditor1" BasePath="/plugins/ckeditor/" Height="400px" runat="server"></CKEditor:CKEditorControl><br />
        <asp:Label ID="lblInfo" runat="server" Text=""></asp:Label>
    </div>
    <div class="right twentyfivepercent sidebar">
        <div class="toggle-options-head">Informações do post + atualizar</div>
        <hr />
        <p>
            <asp:Label ID="lblVisibilit" runat="server" Text=""></asp:Label><br />
            Autor da postagem:
            <asp:Label ID="lblAuthor" runat="server" Text=""></asp:Label><br />
            Data de publicação:
            <asp:Label ID="lblPostedDate" runat="server" Text=""></asp:Label><br />
            Data da última atualização:
            <asp:Label ID="lblUpdatedDate" runat="server" Text=""></asp:Label><br />
            Número de visitas desde a última atualização:
            <asp:Label ID="lblVisits" runat="server" Text=""></asp:Label>
        </p>
        <h5>Opções:</h5>
        <hr />
        <p>Altere alguma das opções de postagem, como categoria, visibilidade e data de publicação.</p>
        <div class="left">
            <p>Categorias:</p>
        </div>
        <div class="right">
            <asp:DropDownList ID="ddlCategory" runat="server">
            </asp:DropDownList><br />
            <asp:CheckBox ID="cbxAvabible" Checked="true" Text="Marcar como visível" runat="server" /><br />
            <asp:CheckBox ID="cbxNullVisits" Checked="false" Text="Zerar número de visitas" runat="server" />
        </div>
        <div class="clean"></div>
        <h5>Ao atualizar</h5>
        <hr />
        <article>
            <p>Antes de atualizar verifique os seguintes pontos para que o post fique de acordo com o padrão Vítor Norton e para que não dê erros inesperados.</p>
            <ul>
                <li>Verifique se está tudo certo antes de atualizar.</li>
                <li>As imagens devem ter 350px por 350px, no formato .jpg e devem estar hospedadas no site vtnorton.com.</li>
                <li>Verifique a ortografia.</li>
                <%-- <li>No codigo fonte, coloque a imagem com class='left'.</li> --%>
            </ul>
        </article>
        <br />
        <br />
        <asp:Button ID="btnPublish" OnClick="btnPublish_Click" runat="server" CssClass="full100 btn-green" Height="50" Text="Atualizar" />
    </div>
    <div class="clean"></div>
</asp:Content>

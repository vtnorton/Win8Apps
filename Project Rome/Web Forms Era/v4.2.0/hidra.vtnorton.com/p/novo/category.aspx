<%@ Page Title="Nova categoria" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="category.aspx.cs" Inherits="HidraOnline.p.novo.category" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul>
        <li><a href="/p/novo/post.aspx">Novo post</a></li>
        <li><a class="on" href="/p/novo/category.aspx">Nova categoria</a></li>
        <li><a href="/p/manage/post.aspx">Gerenciar posts</a></li>
        <li><a href="/p/manage/category.aspx">Gerenciar categorias</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="left seventyfivepercent">
        <asp:TextBox ID="txtName" onKeyUp="CountChar('Content_txtName', 50, 'Count_txtName')" placeholder="Nome da categoria" MaxLength="50" runat="server"></asp:TextBox><br />
        <div class="lblCountChar">
            <span id="Count_txtName">Nenhum caractere inserido até o momento.</span>
        </div>
        <asp:TextBox ID="txtDescricao" onKeyUp="CountChar('Content_txtDescricao', 540, 'Count_txtDescricao')" CssClass="full" placeholder="Descrição da categoria (540 caracteres)" Height="100" TextMode="MultiLine" MaxLength="540" runat="server"></asp:TextBox><br />
        <div class="lblCountCharFull">
            <span id="Count_txtDescricao">Nenhum caractere inserido até o momento.</span>
        </div>
        <asp:TextBox ID="txtURLIcon" placeholder="URL do ícone da categoria" runat="server"></asp:TextBox><br />
        <asp:TextBox ID="txtURLCover" placeholder="URL da capa da categoria" runat="server"></asp:TextBox><br />
        <asp:Label ID="lblInfo" runat="server"></asp:Label>
    </div>
    <div class="right twentyfivepercent">
        <div class="toggle-options-head">Configurações da categoria + publicar</div>
        <hr />
        <p>Use a categoria para identificar os principais tópicos do blog.</p>

        <h5>Ao criar uma categoria</h5>
        <hr />
        <article>
            <p>Antes de criar uma categoria verifique os seguintes pontos para que ela fique de acordo com o padrão Vítor Norton e para que não dê erros inesperados.</p>
            <ul>
                <li>Verifique se está tudo certo antes de publicar.</li>
                <li>A imagem da capa deve ter 989px por 500px, no formato .jpg e deve estar hospedada no site vtnorton.com, de acordo com a diretriz de criação de capas (ver documentação).</li>
                <li>A imagem de perfil deve ter 120px por 120px, no formato .jpg e deve estar hospedada no site vtnorton.com.</li>
                <li>Verifique a ortografia.</li>
            </ul>
        </article>
        <br />
        <br />
        <asp:Button ID="btnCreate" OnClick="btnCreate_Click" CssClass="full100 btn-green" Height="50" runat="server" Text="Criar categoria" />
    </div>
    <div class="clean"></div>
</asp:Content>

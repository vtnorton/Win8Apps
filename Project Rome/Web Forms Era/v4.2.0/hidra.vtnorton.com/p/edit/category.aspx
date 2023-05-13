<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="category.aspx.cs" Inherits="HidraOnline.p.edit.category" %>

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
        <div class="left" style="width: 170px">
            <asp:Label ID="lblImage" runat="server" Text="Label"></asp:Label>
        </div>
        <div class="right" style="width: calc(100% - 200px)">
            <asp:TextBox ID="txtTitle" Text="" Width="60%" onKeyUp="CountChar('Content_txtTitle', 120, 'Count_txtTitle')" placeholder="Nome da categoria" MaxLength="120" runat="server"></asp:TextBox><br />
            <div class="lblCountChar" style="width: calc(60% + 10px)">
                <span id="Count_txtTitle">Nenhum caractere inserido até o momento.</span>
            </div>
            <br />
            <asp:TextBox ID="txtDescription" Width="60%" TextMode="MultiLine" Text="" onKeyUp="CountChar('Content_txtDescription', 540, 'Count_txtDescription')" placeholder="Descrição da categoria" MaxLength="540" runat="server"></asp:TextBox><br />
            <div class="lblCountChar" style="width: calc(60% + 10px)">
                <span id="Count_txtDescription">Nenhum caractere inserido até o momento.</span>
            </div>
        </div>
        <div class="clean"></div>
        <br />
        <asp:TextBox ID="txtUrlIcon" OnTextChanged="txtUrlIcon_TextChanged" AutoPostBack="true" placeholder="URL do ícone da categoria" runat="server"></asp:TextBox><br />
        <asp:TextBox ID="txtUrlCover" runat="server" placeholder="URL da capa da categoria"></asp:TextBox><br />
        <asp:Label ID="lblInfo" runat="server" Text=""></asp:Label>
    </div>
    <div class="right twentyfivepercent sidebar">
        <div class="toggle-options-head">Atualizar categoria</div>
        <hr />
        <p>Ao mudar o nome de um post saiba que só novos posts serão afetasdos. Para corrigir o nome da categoria nos posts antigos, você deverá fazer a correção manualmente.</p>
        <p>

            <asp:CheckBox ID="ckbExiberPosts" runat="server" Checked="true" Text="Exibir posts que precisam de atenção (Somente se alterar o nome da categoria)." /><br />
            <asp:CheckBox ID="ckbEnviarEmail" Checked="true" runat="server" Text="Envie-me por e-mail os posts que precisam de atenção (Somente se alterar o nome da categoria)." />
        </p>
        <article>
            <p>Antes de atualizar verifique os seguintes pontos para que a categoria fique de acordo com o padrão Vítor Norton e para que não dê erros inesperados.</p>
            <ul>
                <li>Verifique se está tudo certo antes de publicar.</li>
                <li>A imagem da capa deve ter 989px por 500px, no formato .jpg e deve estar hospedada no site vtnorton.com, de acordo com a diretriz de criação de capas (ver documentação).</li>
                <li>A imagem de perfil deve ter 120px por 120px, no formato .jpg e deve estar hospedada no site vtnorton.com.</li>
                <li>Verifique a ortografia.</li>
            </ul>
        </article>
        <br />
        <br />
        <asp:Button ID="btnAtualizar" OnClick="btnAtualizar_Click" runat="server" CssClass="full100 btn-green" Height="50" Text="Atualizar" />
    </div>
    <div class="clean"></div>
</asp:Content>

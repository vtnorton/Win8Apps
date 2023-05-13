<%@ Page Title="Início" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="dashboard.aspx.cs" Inherits="HidraOnline.dashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul>
        <li><a href="/p/email.aspx">Enviar e-mail</a></li>
        <li><a href="/p/novo/post.aspx">Adicionar novo post</a></li>
        <li><a href="/p/manage/post.aspx">Gerenciar posts</a></li>
        <li><a href="/p/manage/bugs.aspx">Gerenciar feedback</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="seventyfivepercent left">
        <div class="toggle-options-head">Dashboard</div>
        <hr />
        <div class='info'>
            <h1 class="green">Atenção! Você está rodando um sistema em alpha</h1>
            <hr />
            Estou trabalhando para melhorar a Hidra OS, e trabalho diariamente nesta versão do sistema, então ela pode conter diversos bugs e ferramentas inutilizaveis. Por favor, se ver algum erro, de todos os tipo, entre em contato para que então posso corrigir. Aceito sugestões. #Feedback

        </div>
        <br />
        <br />
        <h5>Enquanto você esteve fora...</h5>
        <hr />
        <p>Enquanto você esteve fora algumas coisas aconteceram...</p>

        <h5>Informações úteis</h5>
        <hr />
        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer nec odio. Praesent libero. Sed cursus ante dapibus diam. Sed nisi. Nulla quis sem at nibh elementum imperdiet.</p>
    </div>

    <div class="twentyfivepercent right">
        <div class="toggle-options-head">Informações</div>
        <hr />
                <p>
            Constantemente estou atualizando o sistema trazendo novas funcionalidades, correções de erros e melhorias de desempenho. Sempre que possível lanço um changelog com as alterações realizada, que pode ser acessado em meu <a target="_blank" title="Acessar o meu blog" href="http://www.vtnorton.com/blog" class="green">blog</a>. 
        </p>        <p>
            vtnorton.com:
                <asp:Label ID="lblSite" runat="server" Text=""></asp:Label><br />
            Hidra OS:
                <asp:Label ID="lblHiraOnline" runat="server" Text=""></asp:Label><br />
            Heartthrob:
                <asp:Label ID="lblHeartthrob" runat="server" Text=""></asp:Label><br />
            Hidra framework:
            <asp:Label ID="lblHidra" runat="server" Text=""></asp:Label><br />
            Ladon framework:
                <asp:Label ID="lblLadon" runat="server" Text=""></asp:Label><br />
            B#! framework:
                <asp:Label ID="lblBuildFramework" runat="server" Text=""></asp:Label><br />
            OpenSearch:
                <asp:Label ID="lblOpenSearch" runat="server" Text=""></asp:Label><br /><br />
            <strong>Build atual:
                <asp:Label ID="lblBuild" runat="server" Text=""></asp:Label><br />
            </strong>
        </p>
        <a href="/p/about.aspx" title="Mais informações" class="green">Mais informações</a>
    </div>
    <div class="clean"></div>
</asp:Content>

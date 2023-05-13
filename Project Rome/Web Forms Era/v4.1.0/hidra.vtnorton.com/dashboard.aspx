<%@ Page Title="Início" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="dashboard.aspx.cs" Inherits="HidraOnline.dashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul>
        <li><a class="on" href="#">Iníco</a></li>
        <li><a href="/p/novo/post.aspx">Adicionar novo post</a></li>
        <li><a href="/p/manage/post.aspx">Gerenciar posts</a></li>
        <li><a href="/p/novo/post.aspx">Adicionar novo post</a></li>
        <li><a href="/p/manage/post.aspx">Gerenciar posts</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class='info'>
        <h1>Atenção! Você está rodando um sistema em alpha</h1>
        <hr />
        Estou trabalhando para melhorar a Hidra OS, e trabalho diariamente nesta versão do sistema, então ela pode conter diversos bugs e ferramentas inutilizaveis. Por favor, se ver algum erro, de todos os tipo, entre em contato para que então posso corrigir. Aceito sugestões. #Feedback

    </div><br /><br />
    <h1>O que você deseja fazer?</h1>
    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer nec odio. Praesent libero. Sed cursus ante dapibus diam. Sed nisi. Nulla quis sem at nibh elementum imperdiet. Duis sagittis ipsum. Praesent mauris. Fusce nec tellus sed augue semper porta. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Nam nec ante.</p>

    <h1>Informações úteis</h1>
    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer nec odio. Praesent libero. Sed cursus ante dapibus diam. Sed nisi. Nulla quis sem at nibh elementum imperdiet.</p>
    <div class="left half">
        <h>Links utéis</h>
        <hr />
    </div>
    <div class="right half">
        <h5>Informações do sistemas</h5>
        <hr />
        <p>
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
                <asp:Label ID="lblOpenSearch" runat="server" Text=""></asp:Label><br />
            <strong>Build atual: <asp:Label ID="lblBuild" runat="server" Text=""></asp:Label><br />
            </strong>
        </p>
    </div>
    <div class="clean"></div>
</asp:Content>

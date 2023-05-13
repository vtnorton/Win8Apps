<%@ Page Title="Sobre + Ajuda" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="about.aspx.cs" Inherits="HidraOnline.p.about" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul>
        <li><a class="on" href="/p/about.aspx">Sobre</a></li>
        <li><a href="/p/ajuda.aspx">Ajuda+Suporte</a></li>
        <li><a href="/p/contato.aspx">Contato</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <h1>Sobre</h1>
    <span>Veja mais informações sobra a Hidra OS</span>
    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer nec odio. Praesent libero. Sed cursus ante dapibus diam. Sed nisi. Nulla quis sem at nibh elementum imperdiet. Duis sagittis ipsum. Praesent mauris. Fusce nec tellus sed augue semper porta.</p>
    <p>Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Nam nec ante.</p>
    <div class="left half">
        <h5>Versões</h5>
        <hr />
        <p>
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
            <strong>Build atual:
                <asp:Label ID="lblBuild" runat="server" Text=""></asp:Label><br />
            </strong>
        </p>
    </div>
    <div class="right half">
        <h5>Agradescimentos</h5>
        <hr />
        <p>
            Plugins que fazem a sua expêriencia com a Hidra OS serem melhores: 
            <ul class="list">
                <li><a href="http://ricostacruz.com/nprogress/">NProgress</a></li>
                <li><a href="http://noraesae.github.io/perfect-scrollbar/">Perfect Scrollbar</a></li>
                <li><a href="http://cksource.com/ckeditor">CKEditor</a></li>
            </ul>
        </p>
    </div>
    <div class="clean"></div>
    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer nec odio. Praesent libero. Sed cursus ante dapibus diam. Sed nisi. Nulla quis sem at nibh elementum imperdiet. Duis sagittis ipsum. Praesent mauris. Fusce nec tellus sed augue semper porta. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Nam nec ante.</p>
</asp:Content>

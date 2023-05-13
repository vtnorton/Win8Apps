<%@ Page Title="Nova campanha de e-mail marketing" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="e-mail-marketing-campanhe.aspx.cs" Inherits="HidraOnline.p.new.e_mail_marketing_campanhe" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul>
        <li><a class="on" href="/p/novo/e-mail-marketign-campanhe.aspx">Criar campanha</a></li>
        <li><a href="/p/novo/e-mail-marketign-list.aspx">Criar lista</a></li>
        <li><a href="/p/manage/e-mail-marketing-list.aspx">Gerenciar listas</a></li>
        <li><a href="/p/manage/e-mail-marketing-campanhe.aspx">Gerenciar campanhas</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <h1>Campanha de e-mail marketing</h1>
    <span>Criar uma campanha de e-mail marketing</span>

    <h1>Em breve...</h1>
    <div class="form-content">
        <div class="form-title-content">
            <h1>Criar e-mail marketing</h1>
            <div class="form-title-sub-content">
                <div class="left"><span>Criar uma campanhas de e-mail marketing</span></div>
                <div class="right">
                    <a href="#">
                        <div class="help-buttom"></div>
                    </a>
                    <a href="#">
                        <div class="bug-buttom"></div>
                    </a>
                </div>
                <div class="clean"></div>
            </div>
        </div>
        <div class="form">
            <div class="line menu-rapido">
                <ul>
                </ul>
            </div>
            <div class="line">
                <div class="s3">Título</div>
                <div class="s7">
                    <asp:TextBox ID="txtTitulo" runat="server"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="last-line">
            <asp:Button ID="btnCadastrar" runat="server" Text="Novo Post" />
        </div>
    </div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="clock.aspx.cs" Inherits="VTNORTON.clock" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul>
        <li><a href="/">Principal</a></li>
        <li><a href="/clock" class="on">E quando chegar a zero?</a></li>
        <li><a href="#">Invista em mim!</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="box-content">
        <article>
            <h2>Um pouco mais de informações</h2>
            <h2>Adicione ao seu calendário</h2>
        </article>
    </div>
</asp:Content>

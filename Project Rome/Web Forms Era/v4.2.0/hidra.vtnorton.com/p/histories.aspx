<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="histories.aspx.cs" Inherits="HidraOnline.p.histories" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul>
        <li><a href="/p/novo/chapter.aspx">Novo capítulo</a></li>
        <li><a href="/p/novo/season.aspx">Nova temporada</a></li>
        <li><a href="/p/novo/history.aspx">Nova história</a></li>
        <li><a href="/p/manage/chapter.aspx">Gerenciar capítulos</a></li>
        <li><a href="/p/manage/season.aspx">Gerenciar temporadas</a></li>
        <li><a href="/p/manage/history.aspx">Gerenciar histórias</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Content" runat="server">
    <div class="seventyfivepercent left">
        <div class="toggle-options-head">Histórias</div>
        <hr />


        <h5>Informações úteis</h5>
        <hr />
        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer nec odio. Praesent libero. Sed cursus ante dapibus diam. Sed nisi. Nulla quis sem at nibh elementum imperdiet.</p>
    </div>

    <div class="twentyfivepercent right">
        <div class="toggle-options-head">Informações</div>
        <hr />

    </div>
    <div class="clean"></div>
</asp:Content>

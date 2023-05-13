<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="history.aspx.cs" Inherits="HidraOnline.p.manage.history" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul>
        <li><a href="/p/novo/chapter.aspx">Novo capítulo</a></li>
        <li><a href="/p/novo/season.aspx">Nova temporada</a></li>
        <li><a href="/p/novo/history.aspx">Nova história</a></li>
        <li><a href="/p/manage/chapter.aspx">Gerenciar capítulos</a></li>
        <li><a href="/p/manage/season.aspx">Gerenciar temporadas</a></li>
        <li><a class="on" href="/p/manage/history.aspx">Gerenciar histórias</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Content" runat="server">
    <div class="seventyfivepercent left">
        <div class="toggle-options-head">Aplicativos</div>
        <hr />
     

    </div>

    <div class="twentyfivepercent right">
        <div class="toggle-options-head">Informações</div>
        <hr />
       
    </div>
    <div class="clean"></div>
</asp:Content>

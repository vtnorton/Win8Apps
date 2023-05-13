<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="application.aspx.cs" Inherits="HidraOnline.p.novo.application" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul>
        <li><a class="on" href="/p/novo/application.aspx">Cadastrar aplicativo</a></li>
        <li><a href="/p/manage/application.aspx">Gerenciar aplicativos</a></li>
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

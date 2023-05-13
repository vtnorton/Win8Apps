<%@ Page Title="God View" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="gdvw.aspx.cs" Inherits="HidraOnline.gdvw" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul>
        <li><a href="/p/manage/bugs.aspx">Gerenciar feedback</a></li>
        <li><a href="/p/manage/advanced-bugs.aspx">Gerenciamento avançado de feedback</a></li>
        <li><a href="/p/manage/advanced-posts.aspx">Gerenciamento avançado do blog</a></li>
        <li><a href="/p/gdvw/push-notification.aspx">Notificações Push</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="seventyfivepercent left">
        <div class="toggle-options-head">God View</div>
        <hr />

    </div>

    <div class="twentyfivepercent right">

    </div>
    <div class="clean"></div>
</asp:Content>

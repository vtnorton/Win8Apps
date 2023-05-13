<%@ Page Title="Somethign is not here | Vítor Norton" Language="C#" MasterPageFile="~/healtthrob.Master" AutoEventWireup="true" CodeBehind="404.aspx.cs" Inherits="VTNORTON.erro._404" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderSubMenu" runat="server">
    <ul>
        <li><a href="http://blog.vtnorton.com"><%=VTNORTON.Resources.heartthrob.erroBlog %></a></li>
        <li><a href="http://garotodeprograma.vtnorton.com"><%=VTNORTON.Resources.heartthrob.erroGaroto %></a></li>
        <li><a href="http://dev.vtnorton.com"><%=VTNORTON.Resources.heartthrob.erroDev %></a></li>
        <li><a href="/eventos"><%=VTNORTON.Resources.heartthrob.erroEventos %></a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section style="margin-top: -50px; padding-bottom: 30px">
        <div class="section-image-left flexslider">
            <img class="section-image-left-img" style="padding: 80px; margin-left: 20%; padding-bottom: 40px" src="/erro/404.gif" />
        </div>
        <div class="section-wrapper">
            <div class="section-content-right">
                <h1><%=VTNORTON.Resources.heartthrob.erro404Title %></h1>
                <p><%=VTNORTON.Resources.heartthrob.erro404Description %></p>
            </div>
            <div class="clean"></div>
        </div>
    </section>
</asp:Content>

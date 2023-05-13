<%@ Page Title="Configurações" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="configuracoes.aspx.cs" Inherits="HidraOnline.configuracoes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul>
        <li><a href="#">Minha conta</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="seventyfivepercent left">
    </div>
    <div class="twentyfivepercent right sidebar">
        <div class="toggle-options-head">Links rápidos</div>
        <hr />
        <article>
            <p>Aqui está uma pequena coleção de links disponíveis para você administrar o site. </p>
            <ul>
                <li><a class="green" href="#">Minha conta</a></li>
            </ul>
        </article>
    </div>
    <div class="clean"></div>
</asp:Content>

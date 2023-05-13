<%@ Page Title="Nova sugestão" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="sugestion.aspx.cs" Inherits="HidraOnline.p.novo.sugestion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SUBMENU" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <h1>Nova sugestão</h1>
    <span>Sugira alguma alteração no sistema e em breve ela séra incluida, caso seja válidada.</span>
    <br />
    <asp:TextBox ID="txtEmail" placeholder="E-mail" TextMode="Email" CssClass="full" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:TextBox ID="txtDescricao" placeholder="Descrição do bug" CssClass="full" TextMode="MultiLine" Height="80" runat="server"></asp:TextBox>
    <br />

    <asp:Button ID="btnEnivar" OnClick="btnEnivar_Click" runat="server" Text="Enviar" /><br />
    <br />
    <asp:Label ID="lblInfo" runat="server" Text=""></asp:Label>
</asp:Content>

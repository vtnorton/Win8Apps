<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="delete-farm.aspx.cs" Inherits="SunWeb.delete_farm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    Tem certeza que deseja deletar essa fazenda?<br />
    Fazenda a ser deletada: <asp:Label ID="lblUser" runat="server" Text="Label"></asp:Label><br />
    <asp:Button ID="btnDelete" OnClick="btnDelete_Click" runat="server" Text="Deletar" />
</asp:Content>

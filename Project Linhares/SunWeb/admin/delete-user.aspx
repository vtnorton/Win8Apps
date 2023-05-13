<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="delete-user.aspx.cs" Inherits="SunWeb.admin.delete_user" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Tem certeza que deseja deletar o usuário do sistema? Ele não terá mais acesso ao sistema!<br />
    Usuário a ser deletado: <asp:Label ID="lblUser" runat="server" Text="Label"></asp:Label><br />
    <asp:Button ID="btnDelete" OnClick="btnDelete_Click" runat="server" Text="Deletar" />
</asp:Content>

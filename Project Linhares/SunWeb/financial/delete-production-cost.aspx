<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="delete-production-cost.aspx.cs" Inherits="SunWeb.financial.delete_production_cost" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    Tem certeza que deseja deletar esse custo de produção?<br />
    <asp:Button ID="btnDelete" OnClick="btnDelete_Click" runat="server" Text="Deletar" />
</asp:Content>

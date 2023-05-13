<%@ Page Title="" Language="C#" MasterPageFile="~/Core/Internal.Master" AutoEventWireup="true" CodeBehind="manage-ebook.aspx.cs" Inherits="VTNORTON.Core.eBook.manage_ebook" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="header">
        <h2>eBooks</h2>
        <p>Lista com todos os eBooks publicados</p>
    </div>
    <table>
        <tr class="header">
            <td>Id</td>
            <td>Name</td>
            <td>Downloads</td>
            <td style="max-width: 51px; min-width: 51px">Opções</td>
        </tr>
        <asp:Repeater ID="rptClient" runat="server">
            <ItemTemplate>
                <tr class="dark" id="employee<%#Eval("Id") %>">
                    <td><%#Eval("Id") %></td>
                    <td><%#Eval("Name") %></td>
                    <td><%#Eval("Downloads") %></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    <asp:Label ID="lblErro" runat="server" Text=""></asp:Label>
</asp:Content>

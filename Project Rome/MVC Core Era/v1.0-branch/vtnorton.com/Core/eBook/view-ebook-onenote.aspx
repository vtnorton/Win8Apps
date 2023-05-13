<%@ Page Title="" Language="C#" MasterPageFile="~/Core/Internal.Master" AutoEventWireup="true" CodeBehind="view-ebook-onenote.aspx.cs" Inherits="VTNORTON.Core.eBook.view_ebook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="header">
        <h2>eBook: OneNote</h2>
        <p>Lista com os e-mails cadastrados para download do eBook do OneNote</p>
    </div>
        <table>
        <tr class="header">
            <td>Id</td>
            <td>Email</td>
            <td style="max-width: 51px; min-width: 51px">Opções</td>
        </tr>
        <asp:Repeater ID="rptClient" runat="server">
            <ItemTemplate>
                <tr class="dark" id="employee<%#Eval("Id") %>">
                    <td><%#Eval("Id") %></td>
                    <td><%#Eval("Email") %></td>
                    <td style="min-width: 108px; max-width: 108px; width: 108px !important">
                        <asp:LinkButton ID="delete" CommandArgument='<%#Eval("Id") %>' Style="margin-right: -10px; color: #ff0000" title="Deletar Email" OnCommand="delete_Command" runat="server"><i class="fa fa-trash-o"></i></asp:LinkButton>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    <asp:Label ID="lblErro" runat="server" Text=""></asp:Label>
</asp:Content>

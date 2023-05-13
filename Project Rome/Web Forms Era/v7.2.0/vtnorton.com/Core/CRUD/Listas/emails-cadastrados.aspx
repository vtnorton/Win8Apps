<%@ Page Title="Ver e-mails cadastrados" Language="C#" MasterPageFile="~/Core/Internal.Master" AutoEventWireup="true" CodeBehind="emails-cadastrados.aspx.cs" Inherits="VTNORTON.Core.CRUD.Listas.emails_cadastrados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <div class="header">
        <h2>E-mails cadastrados</h2>
        <p>Aqui estão os e-mails cadastrados</p>
        <p><a href="index.aspx">Ver todos</a> | <a href="create.aspx">Criar nova lista</a> </p>
    </div>
    <table>
        <tr class="header">
            <td>Id</td>
            <td>Endereço de e-mail</td>
            <td>Data</td>
            <td style="max-width: 51px; min-width: 51px">Opções</td>
        </tr>
        <asp:Repeater ID="rptIndex" runat="server">
            <ItemTemplate>
                <tr class="dark" id="item<%#Eval("Id") %>">
                    <td><%#Eval("Id") %></td>
                    <td><%#Eval("Mail") %></td>
                    <td><%#Eval("Data") %></td>
                    <td style="min-width: 108px; max-width: 108px; width: 108px !important">
                        <asp:LinkButton ID="delete" CommandArgument='<%#Eval("Id") %>' Style="margin-right: -10px; color: #ff0000" title="Deletar" OnCommand="delete_Command" runat="server"><i class="fa fa-trash-o"></i></asp:LinkButton>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    <asp:Label ID="lblErro" runat="server" Text=""></asp:Label>
</asp:Content>

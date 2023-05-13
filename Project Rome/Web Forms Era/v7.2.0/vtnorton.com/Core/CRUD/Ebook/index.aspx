<%@ Page Title="Lista de eBooks" Language="C#" MasterPageFile="~/Core/Internal.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="VTNORTON.Core.CRUD.Ebook.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="header">
        <h2>eBooks</h2>
        <p><a href="index.aspx">Ver todos</a> | <a href="create.aspx">Criar novo</a></p>
        <%--<p>Lista de todos os eventos</p>--%>
    </div>
    <table>
        <tr class="header">
            <td>Id</td>
            <td>Título</td>
            <td>Descriçao</td>
            <td>Nº de Downloads</td>
            <td style="max-width: 51px; min-width: 51px">Opções</td>
        </tr>
        <asp:Repeater ID="rptIndex" runat="server">
            <ItemTemplate>
                <tr class="dark" id="employee<%#Eval("Id") %>">
                    <td><%#Eval("Id") %></td>
                    <td><%#Eval("Name") %></td>
                    <td><%#Eval("Descricao") %></td>
                    <td><%#Eval("Downloads") %></td>
                    <td style="min-width: 108px; max-width: 108px; width: 108px !important">
                        <a href="/Core/CRUD/Ebook/edit.aspx?Id=<%#Eval("Id") %>"><i class="fa fa-edit"></i></a>
                        <asp:LinkButton ID="delete" CommandArgument='<%#Eval("Id") %>' Style="margin-right: -10px; color: #ff0000" title="Deletar" OnCommand="delete_Command" runat="server"><i class="fa fa-trash-o"></i></asp:LinkButton>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    <asp:Label ID="lblErro" runat="server" Text=""></asp:Label>
</asp:Content>

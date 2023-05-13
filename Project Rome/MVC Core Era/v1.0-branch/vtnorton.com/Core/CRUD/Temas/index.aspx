<%@ Page Title="Temas" Language="C#" MasterPageFile="~/Core/Internal.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="VTNORTON.Core.CRUD.Temas.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="header">
        <h2>Temas</h2>
        <p>Lista de todos temas cadastrados para o envio de e-mail marketing. Adicione e gerencie um tema por aqui.</p>
        <p><a href="index.aspx">Ver todos</a> | <a href="create.aspx">Criar novo</a></p>
    </div>
    <table>
        <tr class="header">
            <td>Id</td>
            <td>Nome</td>
            <td>Descriçao</td>
            <td style="max-width: 51px; min-width: 51px">Opções</td>
        </tr>
        <asp:Repeater ID="rptIndex" runat="server">
            <ItemTemplate>
                <tr class="dark" id="item<%#Eval("Id") %>">
                    <td><%#Eval("Id") %></td>
                    <td><%#Eval("Nome") %></td>
                    <td><%#Eval("Descricao") %></td>
                    <td style="min-width: 108px; max-width: 108px; width: 108px !important">
                        <a href="/Core/CRUD/Temas/edit.aspx?Id=<%#Eval("Id") %>"><i class="fa fa-edit"></i></a>
                        <asp:LinkButton ID="delete" CommandArgument='<%#Eval("Id") %>' Style="margin-right: -10px; color: #ff0000" title="Deletar" OnCommand="delete_Command" runat="server"><i class="fa fa-trash-o"></i></asp:LinkButton>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    <asp:Label ID="lblErro" runat="server" Text=""></asp:Label>
</asp:Content>

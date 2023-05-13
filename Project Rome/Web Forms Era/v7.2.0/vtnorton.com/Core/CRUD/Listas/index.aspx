<%@ Page Title="Listas de e-mail" Language="C#" MasterPageFile="~/Core/Internal.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="VTNORTON.Core.CRUD.Listas.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="header">
        <h2>Listas de e-mail</h2>
        <p>Aqui estão as listas existentes de e-mails</p>
        <p><a href="index.aspx">Ver todos</a> | <a href="create.aspx">Criar nova</a> </p>
    </div>
    <table>
        <tr class="header">
            <td>Id</td>
            <td>Título</td>
            <td>Descriçao</td>
            <td>Nº de Inscritos</td>
            <td style="max-width: 51px; min-width: 51px">Opções</td>
        </tr>
        <asp:Repeater ID="rptIndex" runat="server">
            <ItemTemplate>
                <tr class="dark" id="item<%#Eval("Id") %>">
                    <td><%#Eval("Id") %></td>
                    <td><%#Eval("Titulo") %></td>
                    <td><%#Eval("Descricao") %></td>
                    <td><%#Eval("Inscritos") %></td>
                    <td style="min-width: 108px; max-width: 108px; width: 108px !important">
                        <a href="/Core/CRUD/Listas/add-new-mail.aspx?Id=<%#Eval("Id") %>"><i class="fa fa-plus"></i></a>
                        <a href="/Core/CRUD/Listas/emails-cadastrados.aspx?Id=<%#Eval("Id") %>"><i class="fa fa-list"></i></a>
                        <a href="/Core/CRUD/Listas/edit.aspx?Id=<%#Eval("Id") %>"><i class="fa fa-edit"></i></a>
                        <asp:LinkButton ID="delete" CommandArgument='<%#Eval("Id") %>' Style="margin-right: -10px; color: #ff0000" title="Deletar" OnCommand="delete_Command" runat="server"><i class="fa fa-trash-o"></i></asp:LinkButton>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    <asp:Label ID="lblErro" runat="server" Text=""></asp:Label>
</asp:Content>

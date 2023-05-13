<%@ Page Title="Gerenciar usuários | AgroAssistant" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="manage-users.aspx.cs" Inherits="SunWeb.admin.manage_users" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Gerenciar usuários</h3>
    <h4><a href="add-user.aspx">Adicionar usuário</a></h4>

    <br />
    <table class="table">
        <tr>
            <td>Nome</td>
            <td>Email</td>
            <td>Opções</td>
        </tr>
        <asp:Repeater ID="rptUsers" runat="server">
            <ItemTemplate>
                <tr id="post<%#Eval("Id") %>">
                    <td><%#Eval("Name") %> <%#Eval("LastName") %></td>
                    <td><%#Eval("Email") %></td>
                    <td style="min-width: 40px; max-width: 40px">
                        <a href="/admin/delete-user.aspx?Id=<%#Eval("Id") %>" style="margin-right: 5px" title="Deletar usuário">
                            <i class="fa fa-trash-o"></i>
                        </a>
                        <a href="/admin/edit-user.aspx?Id=<%#Eval("Id") %>" style="margin-right: 5px" title="Editar usuário">
                            <i class="fa fa-edit"></i>
                        </a>
                        <a href="#" title="Ver mais informações">
                            <i class="fa fa-angle-down"></i>
                        </a>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>

    </table>
    <asp:Label ID="lblErro" runat="server" Text=""></asp:Label>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="farms.aspx.cs" Inherits="SunWeb.farms" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <h3>Gerenciar fazendas</h3>
    <h4><a href="add-farm.aspx">Adicionar fazenda</a></h4>
    <table class="table">
        <tr>
            <td>Nome</td>
            <td>Proprietário</td>
            <td>Opções</td>
        </tr>
        <asp:Repeater ID="rptFarms" runat="server">
            <ItemTemplate>
                <tr id="post<%#Eval("Id") %>">
                    <td><%#Eval("Name") %> </td>
                    <td><%#Eval("Owner") %></td>
                    <td style="min-width: 40px; max-width: 40px">
                         <a href="delete-farm.aspx?Id=<%#Eval("Id") %>" style="margin-right: 5px" title="Deletar fazenda">
                            <i class="fa fa-trash-o"></i>
                        </a>
                        <a href="edit-farm.aspx?Id=<%#Eval("Id") %>" style="margin-right: 5px" title="Editar fazenda">
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

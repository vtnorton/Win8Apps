<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="manage-production-cost.aspx.cs" Inherits="SunWeb.financial.manage_production_cost" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <h3>Gerenciar custo de produção</h3>
    <h4><a href="add-production-cost.aspx">Adicionar novos custos</a></h4>

    <br />
    <table class="table">
        <tr>
            <td>Período</td>
            <td>Valor total</td>
        </tr>
        <asp:Repeater ID="rptProductionCost" runat="server">
            <ItemTemplate>
                <tr id="post<%#Eval("Id") %>">
                    <td><%#Eval("MonthOfReference") %></td>
                    <td><%#Eval("TotalCost") %></td>
                    <td style="min-width: 40px; max-width: 40px">
                         <a href="delete-production-cost.aspx?Id=<%#Eval("Id") %>" style="margin-right: 5px" title="Deletar custo de produção">
                            <i class="fa fa-trash-o"></i>
                        </a>
                        <a href="edit-production-cost.aspx?Id=<%#Eval("Id") %>" style="margin-right: 5px" title="Editar custo de produção">
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

<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="agronomy-dashboard.aspx.cs" Inherits="SunWeb.agronomy.agronomy_dashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="padding: 20px">
        <ul>
            <li><a href="/agronomy/plantation/add-coffee.aspx">Adicionar plantação de café</a></li>

        </ul>
        <table class="table">
            <tr>
                <td>Nome</td>
                <td>Plantio</td>
                <td>Florada</td>
                <td>Colheita</td>
                <td>Processamento</td>
                <td>Secagem</td>
                <td>Torra</td>
                <td>Moagem</td>
                <td>Classificação</td>
                <td>Embalagem</td>
                <td>Encaixotamento</td>
                <td>Opções</td>
            </tr>
            <asp:Repeater ID="rptCoffee" runat="server">
                <ItemTemplate>
                    <tr id="post<%#Eval("Id") %>">
                        <td><%#Eval("Name") %> </td>

                        <td><%#Eval("BeginningOfPlantation") %> - <%#Eval("AfterPlantation") %></td>
                        <td><%#Eval("BeginningOfFlowering") %> - <%#Eval("AfterFlorewing") %></td>
                        <td><%#Eval("BeginningOfHarvest") %> - <%#Eval("AfterHarvest") %></td>
                        <td><%#Eval("BeginningOfProcessing") %> - <%#Eval("AfterProcessing") %></td>
                        <td><%#Eval("BeginningOfDrying") %> - <%#Eval("AfterDrying") %></td>
                        <td><%#Eval("BeginningOfRoasting") %> - <%#Eval("AfterRoasting") %></td>
                        <td><%#Eval("BeginningOfFrinding") %> - <%#Eval("AfterGrinding") %></td>
                        <td><%#Eval("BeginningOfClassification") %> - <%#Eval("AfterClassification") %></td>
                        <td><%#Eval("BeginningOfPacking") %> - <%#Eval("AfterPacking") %></td>
                        <td><%#Eval("BeginningOfBoxing") %> - <%#Eval("AfterBoxing") %></td>
                        <td style="min-width: 40px; max-width: 40px">
                            <a href="/plantation/delete-coffee.aspx?Id=<%#Eval("Id") %>" style="margin-right: 5px" title="Deletar fazenda">
                                <i class="fa fa-trash-o"></i>
                            </a>
                            <a href="/plantation/edite-coffee.aspx?Id=<%#Eval("Id") %>" style="margin-right: 5px" title="Editar fazenda">
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
    </div>
</asp:Content>

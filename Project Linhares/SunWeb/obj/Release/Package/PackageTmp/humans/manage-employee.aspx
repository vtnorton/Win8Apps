<%@ Page Title="Gerenciar funionários | AgroAssistant" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="manage-employee.aspx.cs" Inherits="SunWeb.humans.manage_employee" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
        function OpenPane(xId) {
            var IdSelecionado = "#openEmployee" + xId;
            var IdSelecionado2 = "#openEmployee2" + xId;
            $(IdSelecionado).slideToggle("slow");
            $(IdSelecionado2).slideToggle("slow");
        }
        $(document).ready(function () {
            var url = window.location.href;
            if (url.indexOf('temp=1') != -1)
                $(".temp").addClass("active");
            else if (url.indexOf('temp=2') != -1)
                $(".all").addClass("active");
            else
                $(".fixo").addClass("active");
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="menu">
        <div class="container">
            <div class="row">
                <div class="col-md-4 text-center">
                    <div class="wrap-about">
                        <div class="icon-box">
                            <i class="fa fa-th-list fa-2x"></i>
                        </div>
                        <div class="about-content text-center">
                            <h3>Gerenciar funcionários</h3>
                            <p>Lorem ipsum dolor sit amet, duo nostrum corrumpit ne, id nam quem diam, vel ut justo soleat reformidans.</p>
                        </div>
                    </div>
                    <div class="all-post text-center">
                        <a class="btn btn-transparent" href="#read">Gerenciar</a>
                    </div>
                </div>
                <div class="col-md-4 text-center">
                    <div class="wrap-about kill-margin-bottom">
                        <div class="icon-box">
                            <i class="fa fa-quote-left fa-2x"></i>
                        </div>
                        <div class="about-content text-center">
                            <h3>Funcionários temporários</h3>
                            <p>Lorem ipsum dolor sit amet, duo nostrum corrumpit ne, id nam quem diam, vel ut justo soleat reformidans.</p>
                        </div>
                    </div>
                    <div class="all-post text-center">
                        <a class="btn btn-transparent" href="#view">Visualizar</a>
                    </div>
                </div>
                <div class="col-md-4 text-center">
                    <div class="wrap-about">
                        <div class="icon-box">
                            <i class="fa fa-plus fa-2x"></i>
                        </div>
                        <div class="about-content text-center">
                            <h3>Adicione funcionários</h3>
                            <p>Lorem ipsum dolor sit amet, duo nostrum corrumpit ne, id nam quem diam, vel ut justo soleat reformidans.</p>
                        </div>
                    </div>
                    <div class="all-post text-center">
                        <a class="btn btn-transparent" href="add-employee.aspx">Novo funcionário</a>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <section id="read">
        <div class="post-pagination">
            <div class="left">
                <asp:Label ID="lblMorePostTop" runat="server" Text=""></asp:Label>
            </div>
            <div class="right">
                <ul class="table-filter">
                    <li><a href="#"><i class="fa fa-search" style="margin-right: 0 !important; margin-top: -2px"></i></a></li>
                    <li><a href="#"><i class="fa fa-sliders" style="margin-right: 10px;"></i>Filtro</a></li>
                    <li style="border-right: 1px solid #e5e5e5; height: 36px"></li>
                    <li class="all">
                        <asp:LinkButton ID="hplAll" OnClick="hplAll_Click" runat="server">Todos</asp:LinkButton></li>
                    <li class="fixo">
                        <asp:LinkButton ID="hplFixos" OnClick="hplFixos_Click" runat="server">Fixos</asp:LinkButton></li>
                    <li class="temp">
                        <asp:LinkButton ID="hplTemp" OnClick="hplTemp_Click" runat="server">Temporários</asp:LinkButton></li>
                    <li><a href="add-employee.aspx"><i class="fa fa-plus" style="margin-right: 0 !important;"></i></a></li>
                </ul>
            </div>
            <div class="clean"></div>
        </div>
        <table>
            <tr class="header">
                <td>Nome</td>
                <td>Telefone</td>
                <td>Email</td>
                <td style="max-width: 51px; min-width: 51px">Opções</td>
            </tr>
            <asp:Repeater ID="rptEmployee" runat="server">
                <ItemTemplate>
                    <tr class="dark" id="employee<%#Eval("Id") %>">
                        <td><%#Eval("Name") %> <%#Eval("LastName") %> (<%#Eval("NickName") %>)</td>
                        <td><%#Eval("Phone") %></td>
                        <td><%#Eval("Email") %></td>
                        <td style="min-width:108px; max-width: 108px; width:108px !important">
                            <asp:LinkButton ID="delete" CommandArgument='<%#Eval("Id") %>' style="margin-right: -10px; color: #ff0000" title="Deletar funcionário" OnCommand="delete_Command" runat="server"><i class="fa fa-trash-o"></i></asp:LinkButton>
                            <a href="edit-employee.aspx?Id=<%#Eval("Id") %>" style="margin-right: -10px; color: #15992A" title="Editar funcionário">
                                <i class="fa fa-edit"></i>
                            </a>
                            <a href="#employee<%#Eval("Id") %>" onclick="OpenPane(<%#Eval("Id") %>)" style="color: #15992A" title="Ver mais informações">
                                <i class="fa fa-angle-down"></i>
                            </a>
                        </td>
                    </tr>
                    <tr id="openEmployee2<%#Eval("Id") %>" style="display: none">
                        <td style="padding: 0; margin: 0"></td>
                        <td colspan="3" style="padding: 0; margin: 0">
                            <p style="font-size: 12px; font-weight: 600; margin-left: 12px; margin-bottom: -4px"><i>Endereço</i></p>
                        </td>
                    </tr>
                    <tr id="openEmployee<%#Eval("Id") %>" style="display: none">
                        <td></td>
                        <td colspan="2"><%#Eval("Address") %> - <%#Eval("Neighborhood") %>, <%#Eval("City") %> - <%#Eval("State") %>
                        </td>
                        <td style="max-width: 51px; min-width: 51px; margin-left: 3px;">
                            <a href="edit-employee.aspx?Id=<%#Eval("Id") %>" title="Editar" style="color: #15992A; position: relative; top: -6px; left: 3px">Editar <i class="fa fa-plus" style="margin-left: 15px; margin-right: 0"></i>
                            </a>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>

        <div class="text-center">
            <asp:Label ID="lblErro" runat="server" Text=""></asp:Label>
        </div>
        <div class="post-pagination" style="margin-top: -40px">
            <asp:Label ID="lblMorePosts" runat="server" Text=""></asp:Label>
        </div>
    </section>
    
</asp:Content>

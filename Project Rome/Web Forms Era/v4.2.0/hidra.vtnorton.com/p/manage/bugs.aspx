<%@ Page Title="Gerenciar feedbacks" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="bugs.aspx.cs" Inherits="HidraOnline.p.manage.bugs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/css/bug.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul>
        <li><a href="/p/Bug.aspx">Relatar problema</a></li>
        <li><a href="/p/novo/sugestion.aspx">Nova sugestão</a></li>
        <li><a class="on" href="/p/manage/bugs.aspx">Gerenciar feedback</a></li>
        <li><a href="/p/manage/advanced-bugs.aspx">Gerenciamento avançado de feedback</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="seventyfivepercent left">
        <table>
            <tr>
                <td>Tipo</td>
                <td>Projeto</td>
                <td>Menssagem</td>
                <td>Status</td>
                <td>Data</td>
                <td>Votos</td>
                <td>Opções</td>
            </tr>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr class="<%#Eval("StatusCSSClass")%>">
                        <td><%#Eval("Type") %></td>
                        <td><%#Eval("Project") %></td>
                        <td><%#Eval("Menssage") %></td>
                        <td style="min-width: 90px"><%#Eval("Status") %></td>
                        <td><%#Eval("Date") %></td>
                        <td style="text-align: center"><%#Eval("UpVotes") %></td>
                        <td style="min-width: 30px; max-width: 30px">
                            <a href="/p/edit/bug.aspx?Id=<%#Eval("Id") %>" title="Ver detalhes do bug">
                                <div class="view-details" style="margin-left: 15px"></div>
                            </a>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
        <br />
        <asp:Label ID="lblErro" runat="server" Text=""></asp:Label>
        <br />
        <div style="text-align: center; width: 100%">
            <!-- Carregar automatico no scroll da página -->
            <asp:Button ID="btnLoadMore" CssClass="btn-green half" OnClick="btnLoadMore_Click" runat="server" Text="Carregar mais" Height="50" />
        </div>
    </div>
    <div class="twentyfivepercent right sidebar">
        <div class="toggle-options-head">Gerenciar feedback</div>
        <hr />
        <p>Veja o feedback dos seus usuários, os erros que eles tem encontrado no sistema, e sugestões que podem ser implementadas.</p>
        <p>Para acessar mais informações de um feedback e editar eles, clique no ícone de engrenagens.</p>

        <p>
            <asp:Label ID="lblSelecionado" runat="server" Text="Você está vendo todos os feedbacks. Use as opções do filtro abaixo para ver menos."></asp:Label>
        </p>
        <h5>Opções do filtro</h5>
        <hr />
        <asp:TextBox OnTextChanged="txtSearchBox_TextChanged" AutoPostBack="true" ID="txtSearchBox" CssClass="full100" Width="100%" placeholder="Pesquisar nos posts" runat="server"></asp:TextBox>
        <asp:RadioButtonList ID="rblSystem" CssClass="nostyle" runat="server" OnSelectedIndexChanged="rblSystem_SelectedIndexChanged" AutoPostBack="true">
            <asp:ListItem Enabled="true" Selected="True" Text="Mostrar todos os feedbacks." Value="0"></asp:ListItem>
            <asp:ListItem Enabled="true" Selected="False" Text="Mostrar somente feedbacks do sistema." Value="1"></asp:ListItem>
            <asp:ListItem Enabled="true" Selected="False" Text="Mostrar somente feedback dos usuários." Value="2"></asp:ListItem>
        </asp:RadioButtonList><br />
        <div class="left">
            <p>Tipo:</p>
        </div>
        <div class="right">
            <asp:DropDownList AutoPostBack="true" ID="ddlType" OnSelectedIndexChanged="ddlType_SelectedIndexChanged" runat="server">
                <asp:ListItem Enabled="true" Selected="True" Text="Sugestões e problemas" Value="0"></asp:ListItem>
                <asp:ListItem Enabled="true" Selected="False" Text="Somente sugestões" Value="1"></asp:ListItem>
                <asp:ListItem Enabled="true" Selected="False" Text="Somente problemas" Value="2"></asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="clean"></div>
        <div class="left">
            <p>Status:</p>
        </div>
        <div class="right">
            <asp:DropDownList AutoPostBack="true" ID="ddlStatus" OnSelectedIndexChanged="ddlStatus_SelectedIndexChanged" runat="server">
                <asp:ListItem Enabled="true" Selected="True" Text="Todos" Value="0"></asp:ListItem>
                <asp:ListItem Enabled="true" Selected="False" Text="Não recebidos" Value="6"></asp:ListItem>
                <asp:ListItem Enabled="true" Selected="False" Text="Recebidos" Value="1"></asp:ListItem>
                <asp:ListItem Enabled="true" Selected="False" Text="Em andamento" Value="2"></asp:ListItem>
                <asp:ListItem Enabled="true" Selected="False" Text="Disponível atualização" Value="3"></asp:ListItem>
                <asp:ListItem Enabled="true" Selected="False" Text="Cancelados" Value="4"></asp:ListItem>
                <asp:ListItem Enabled="true" Selected="False" Text="Concluidos" Value="5"></asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="clean"></div>

        <div class="left">
            <p>Ordernar por:</p>
        </div>
        <div class="right">
            <asp:DropDownList AutoPostBack="true" ID="ddlOrdenar" OnSelectedIndexChanged="ddlOrdenar_SelectedIndexChanged" runat="server">
                <asp:ListItem Enabled="true" Selected="True" Text="Data de publicação" Value="1"></asp:ListItem>
                <asp:ListItem Enabled="true" Selected="False" Text="Votos" Value="2"></asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="clean"></div>
        <div class="left">
            <p>Mostrar:</p>
        </div>
        <div class="right">
            <asp:DropDownList AutoPostBack="true" ID="ddlCarregar" OnSelectedIndexChanged="ddlCarregar_SelectedIndexChanged" runat="server">
                <asp:ListItem Enabled="true" Selected="True" Text="25 bugs" Value="25"></asp:ListItem>
                <asp:ListItem Enabled="true" Selected="False" Text="50 bugs" Value="50"></asp:ListItem>
                <asp:ListItem Enabled="true" Selected="False" Text="100 bugs" Value="100"></asp:ListItem>
                <asp:ListItem Enabled="true" Selected="False" Text="150 bugs" Value="150"></asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="clean"></div>
        <p>
            <strong>
                <asp:Label ID="lblFiltroSelecionado" runat="server" Text=""></asp:Label></strong>
        </p>
        <asp:Button ID="btnFiltrar" OnClick="btnFiltrar_Click" Height="50" CssClass="full100 btn-green" runat="server" Text="Filtrar" />

    </div>
    <div class="clean"></div>

</asp:Content>

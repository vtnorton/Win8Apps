<%@ Page Title="Gerenciar feedbacks" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="bugs.aspx.cs" Inherits="HidraOnline.p.manage.bugs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul>
        <li><a href="/p/Bug.aspx">Novo bug</a></li>
        <li><a href="/p/novo/sugestion.aspx">Nova sugestão</a></li>
        <li><a class="on" href="/p/manage/bugs.aspx">Gerenciar feedback</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="filter">
        Tipo:
        <asp:DropDownList AutoPostBack="true" ID="ddlType" OnSelectedIndexChanged="ddlType_SelectedIndexChanged" runat="server">
            <asp:ListItem Enabled="true" Selected="True" Text="Sugestões e problemas" Value="Both"></asp:ListItem>
            <asp:ListItem Enabled="true" Selected="False" Text="Somente sugestões" Value="Sugestion"></asp:ListItem>
            <asp:ListItem Enabled="true" Selected="False" Text="Somente problemas" Value="Bugs"></asp:ListItem>
        </asp:DropDownList>
        Status:
         <asp:DropDownList AutoPostBack="true" ID="ddlStatus" OnSelectedIndexChanged="ddlStatus_SelectedIndexChanged" runat="server">
             <asp:ListItem Enabled="true" Selected="True" Text="Todas" Value="All"></asp:ListItem>
             <asp:ListItem Enabled="true" Selected="False" Text="Não recebidas" Value="NonRecived"></asp:ListItem>
             <asp:ListItem Enabled="true" Selected="False" Text="Recebidas" Value="Recived"></asp:ListItem>
             <asp:ListItem Enabled="true" Selected="False" Text="Em andamento" Value="GoingOn"></asp:ListItem>
             <asp:ListItem Enabled="true" Selected="False" Text="Na proxíma atualização" Value="NextUpdate"></asp:ListItem>
             <asp:ListItem Enabled="true" Selected="False" Text="Cancelado" Value="Canceled"></asp:ListItem>
             <asp:ListItem Enabled="true" Selected="False" Text="Concluidas" Value="Done"></asp:ListItem>
         </asp:DropDownList>
        Carregar:
         <asp:DropDownList AutoPostBack="true" ID="ddlCarregar" OnSelectedIndexChanged="ddlCarregar_SelectedIndexChanged" runat="server">
             <asp:ListItem Enabled="true" Selected="True" Text="25 bugs" Value="25"></asp:ListItem>
             <asp:ListItem Enabled="true" Selected="False" Text="50 bugs" Value="50"></asp:ListItem>
             <asp:ListItem Enabled="true" Selected="False" Text="100 bugs" Value="100"></asp:ListItem>
             <asp:ListItem Enabled="true" Selected="False" Text="150 bugs" Value="150"></asp:ListItem>
         </asp:DropDownList>
    </div>
    <br />
    <asp:Label ID="lblSelecionado" runat="server" Text=""></asp:Label>
    <br />
    <hr />
    <table>
        <tr>
            <td>Tipo</td>
            <td>Projeto</td>
            <td>Menssagem</td>
            <td>Status</td>
            <td>Votos</td>
            <td>Opções</td>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr class="<%#Eval("StatusCSSClass")%>">
                    <td><%#Eval("Type") %></td>
                    <td><%#Eval("Project") %></td>
                    <td><%#Eval("Menssage") %></td>
                    <td><%#Eval("Status") %></td>
                    <td><%#Eval("UpVotes") %></td>
                    <td>
                        <div class="left half">
                            <a href='/p/manage/bug-detail.aspx?id=<%#Eval("Id") %>'>
                                <div style="height: 20px; width: 20px; background: #b6ff00" class="view-details"></div>
                            </a>
                        </div>
                        <div class="right half">
                            <a href='/p/email-bug.aspx?email=<%#Eval("Email") %>' target="_blank">
                                <div style="height: 20px; width: 20px; background: #ff6a00; margin-right: 45px" class="send-email"></div>
                            </a>
                        </div>
                        <div class="clean"></div>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    <asp:Label ID="lblErro" runat="server" Text=""></asp:Label>
    <br />
    <hr />
    <br />
    <div class="left half">
        <asp:Label ID="lblLessBugs" runat="server" Text=""></asp:Label>
    </div>
    <div class="right half" style="text-align: right">
        <asp:Label ID="lblMoreBugs" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>

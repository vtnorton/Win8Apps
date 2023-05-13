<%@ Page Title="Gerenciar categorias" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="category.aspx.cs" Inherits="HidraOnline.p.manage.category" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul>
        <li><a href="/p/novo/post.aspx">Novo post</a></li>
        <li><a href="/p/novo/category.aspx">Nova categoria</a></li>
        <li><a href="/p/manage/post.aspx">Gerenciar posts</a></li>
        <li><a class="on" href="/p/manage/category.aspx">Gerenciar categorias</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="seventyfivepercent left">
        <table>
            <tr>
                <td>Nome da categoria</td>
                <td>Descrição</td>
                <td>Opções</td>
            </tr>
            <asp:Repeater ID="rptCategoria" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("Name") %></td>
                        <td><%#Eval("Description") %></td>
                        <td style="min-width:50px; max-width:50px">
                            <a href="/p/edit/category.aspx?Id=<%#Eval("Id") %>" title="Editar categoria">
                                <div class="view-details"></div>
                            </a>
                             <a href="/p/delete/category.aspx?Id=<%#Eval("Id") %>" title="Deletar categoria">
                                <div class="delete"></div>
                            </a>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
        <br />
        <br />
        <asp:Label ID="lblErro" runat="server" Text=""></asp:Label><br /><br />
        <div class="left half">
            <asp:Label ID="lblLessPost" runat="server" Text=""></asp:Label>
        </div>
        <div class="right half" style="text-align: right">
            <asp:Label ID="lblMorePost" runat="server" Text=""></asp:Label>
        </div>
    </div>
    <div class="twentyfivepercent right sidebar">
        <div class="toggle-options-head">Gerenciar categorias</div>
        <hr />
        <p>Veja, edite e gerencie as categorias dos posts publicados no site.</p>
        <p>Para acessar mais informações de uma categoria e editar elas, clique no ícone de engrenagens. Para deletar, clique no X.</p>
        <p>
            <asp:Label ID="lblSelecionado" runat="server" Text="Você está vendo todas as categorias. Use as opções do filtro abaixo para ver menos."></asp:Label>
        </p>
        <h5>Opções do filtro</h5>
        <hr />
        <asp:TextBox ID="txtSearchBox" OnTextChanged="txtSearchBox_TextChanged"  AutoPostBack="true" CssClass="full100" Width="100%" placeholder="Pesquisar nos posts" runat="server" ></asp:TextBox>
        <div class="left">
            <p>Ordernar Por:</p>
        </div>
        <div class="right">
            <asp:DropDownList OnTextChanged="ddlOrderBy_TextChanged" AutoPostBack="true" ID="ddlOrderBy" runat="server">
                <asp:ListItem Enabled="true" Selected="True" Text="Normal" Value="0"></asp:ListItem>
                <asp:ListItem Enabled="true" Selected="False" Text="Ordem alfabética crescente" Value="1"></asp:ListItem>
                <asp:ListItem Enabled="true" Selected="False" Text="Ordem alfabética decrescente" Value="2"></asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="clean"></div>
        <div class="left">
            <p>Mostrar:</p>
        </div>
        <div class="right">
            <asp:DropDownList OnTextChanged="ddlMostrar_TextChanged" AutoPostBack="true" ID="ddlMostrar" runat="server">
                <asp:ListItem Enabled="true" Selected="True" Text="10 posts" Value="10"></asp:ListItem>
                <asp:ListItem Enabled="true" Selected="False" Text="25 posts" Value="25"></asp:ListItem>
                <asp:ListItem Enabled="true" Selected="False" Text="50 posts" Value="50"></asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="clean"></div>
        <br />
        <p><strong><asp:Label ID="lblFiltroSelecionado" runat="server" Text=""></asp:Label></strong></p>
        
        <br /><br />
        <asp:Button OnClick="btnFiltrar_Click" ID="btnFiltrar" CssClass="full100 btn-green" Height="50" runat="server" Text="Filtrar" />
    
    </div>
    <div class="clean"></div>
</asp:Content>

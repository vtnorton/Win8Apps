<%@ Page Title="Gerenciar posts" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="post.aspx.cs" Inherits="HidraOnline.p.manage.post" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul>
        <li><a href="/p/novo/post.aspx">Novo post</a></li>
        <li><a href="/p/novo/category.aspx">Nova categoria</a></li>
        <li><a class="on" href="/p/manage/post.aspx">Gerenciar posts</a></li>
        <li><a href="/p/manage/category.aspx">Gerenciar categorias</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="seventyfivepercent left">
        <table>
            <tr>
                <td>Título</td>
                <td>Categoria</td>
                <td>Autor</td>
                <td>Data de postagem</td>
                <td>Visitas</td>
                <td>Opções</td>
            </tr>
            <asp:Repeater ID="rptPosts" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("Title") %></td><!-- Via SQL -->
                        <td><%#Eval("CategoryName") %></td>
                        <td><%#Eval("AuthorName") %></td>
                        <td><%#Eval("PostedDate") %></td>
                        <td><span style="margin-left: 15px"><%#Eval("Visits") %></span></td>
                        <td style="min-width:50px; max-width:50px">
                            <a href="/p/edit/post.aspx?Id=<%#Eval("Id") %>" title="Editar post">
                                <div class="view-details"></div>
                            </a>
                             <a href="/p/delete/post.aspx?Id=<%#Eval("Id") %>" title="Deletar post">
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
        <div class="toggle-options-head">Gerenciar posts</div>
        <hr />
        <p>Veja, edite e gerencie os posts publicados no site.</p>
        <p>Para acessar mais informações de um post e editar eles, clique no ícone de engrenagens. Para deletar, clique no X.</p>
        <p>
            <asp:Label ID="lblSelecionado" runat="server" Text="Você está vendo todos os posts. Use as opções do filtro abaixo para ver menos."></asp:Label>
        </p>
        <h5>Opções do filtro</h5>
        <hr />
        <asp:TextBox OnTextChanged="txtSearchBox_TextChanged" AutoPostBack="true" ID="txtSearchBox" CssClass="full100" Width="100%" placeholder="Pesquisar nos posts" runat="server" ></asp:TextBox>
        <p>
            <asp:RadioButtonList OnSelectedIndexChanged="rbtPostOnline_SelectedIndexChanged" AutoPostBack="true" ID="rbtPostOnline" CssClass="nostyle" runat="server">
                <asp:ListItem Enabled="true" Selected="True" Text="Todos os posts" Value="108"></asp:ListItem>
                <asp:ListItem Enabled="true" Selected="False" Text="Somente os posts publicados" Value="1"></asp:ListItem>
                <asp:ListItem Enabled="true" Selected="False" Text="Somente os posts não publicados" Value="0"></asp:ListItem>
            </asp:RadioButtonList>
        </p>

        <div class="left">
            <p>Ver por autor:</p>
        </div>
        <div class="right">
            <asp:DropDownList OnSelectedIndexChanged="ddlAuthor_SelectedIndexChanged" AutoPostBack="true" ID="ddlAuthor" runat="server">
            </asp:DropDownList>
        </div>
        <div class="clean"></div>
        <div class="left">
            <p>Ver por categoria:</p>
        </div>
        <div class="right">
            <asp:DropDownList ID="ddlCategory" OnSelectedIndexChanged="ddlCategory_SelectedIndexChanged" AutoPostBack="true" runat="server">
            </asp:DropDownList>
        </div>
        <div class="clean"></div>
        <div class="left">
            <p>Mostrar:</p>
        </div>
        <div class="right">
            <asp:DropDownList OnSelectedIndexChanged="ddlMostrar_SelectedIndexChanged" AutoPostBack="true" ID="ddlMostrar" runat="server">
                <asp:ListItem Enabled="true" Selected="True" Text="25 posts" Value="25"></asp:ListItem>
                <asp:ListItem Enabled="true" Selected="False" Text="50 posts" Value="50"></asp:ListItem>
                <asp:ListItem Enabled="true" Selected="False" Text="100 posts" Value="100"></asp:ListItem>
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

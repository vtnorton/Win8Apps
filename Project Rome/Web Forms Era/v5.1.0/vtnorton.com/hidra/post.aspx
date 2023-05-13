<%@ Page Title="Hidra | Gerenciamento de post" Language="C#" MasterPageFile="~/hidra/master.Master" AutoEventWireup="true" CodeBehind="post.aspx.cs" Inherits="VTNORTON.hidra.post"%>

<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .new-title {
            border: medium none !important;
            text-align: center !important;
            color: white !important;
            font-weight: 300 !important;
            font-size: 28px !important;
            margin-bottom: -5px !important;
        }

        .font10 p {
            font-size: 11px !important;
        }

        .postimage img {
            max-width: 80px;
            min-width: 80px;
            min-height: 80px;
            max-height: 80px;
        }
    </style>
    <script>
        function OpenPane(xId) {
            var IdSelecionado = "#openPost" + xId;
            $(IdSelecionado).toggle();
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="team-skills" class="parallax-section">
        <div class="container">
            <div class="row wow fadeInDown" data-wow-duration="500ms">
                <div class="title text-center">
                    <h2>gerenciar o <span class="color">blog</span></h2>
                    <div class="border"></div>
                </div>

                <div class="col-md-4 text-center wow fadeInUp" data-wow-duration="500ms" data-wow-delay="250ms">
                    <div class="wrap-about">
                        <div class="icon-box">
                            <i class="fa fa-th-list fa-4x"></i>
                        </div>
                        <div class="about-content text-center">
                            <h3>Gerenciar os posts</h3>
                            <p>Edite postagens antigas, altere-as, sinta-se livre para fazer o que bem entender.</p>
                        </div>
                    </div>
                    <div class="all-post text-center">
                        <a class="btn btn-transparent" href="#manage">Gerenciar posts</a>
                    </div>
                </div>
                <div class="col-md-4 text-center wow fadeInUp" data-wow-duration="500ms" data-wow-delay="500ms">
                    <div class="wrap-about kill-margin-bottom">
                        <div class="icon-box">
                            <i class="fa fa-quote-left fa-4x"></i>
                        </div>
                        <div class="about-content text-center">
                            <h3>Social</h3>
                            <p>Compartilhe nas redes sociais para aumentar o número de visitantes!</p>
                        </div>
                    </div>
                    <div class="all-post text-center">
                        <a class="btn btn-transparent" href="#share">Compartilhar</a>
                    </div>
                </div>
                <div class="col-md-4 text-center wow fadeInUp" data-wow-duration="500ms">
                    <div class="wrap-about">
                        <div class="icon-box">
                            <i class="fa fa-plus fa-4x"></i>
                        </div>
                        <div class="about-content text-center">
                            <h3 class="ddd">Novo post</h3>
                            <p>As pessoas querem saber o que há de novo, escreva para elas no seu blog!</p>
                        </div>
                    </div>
                    <div class="all-post text-center">
                        <a class="btn btn-transparent" href="#newpost">Novo post</a>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <section id="manage" class="bg-one">
        <div class="container">
            <div class="row">
                <div class="title text-center wow fadeIn" style="padding-bottom: 20px !important" data-wow-duration="1500ms">
                    <h2><span class="color">gerenciar</span> posts</h2>
                    <div class="border"></div>
                    <div class="about-content text-center">
                        <br />
                        <h3 class="ddd">Veja, edite e gerencie os posts publicados no site.</h3>
                        <p>
                            <p>Você está vendo todos os posts. Use as opções do filtro abaixo para ver menos.</p>
                        </p>
                        <br />
                        <p>
                            <strong>
                                <asp:Label ID="lblFiltroSelecionado" runat="server" Text=""></asp:Label></strong>
                        </p>
                        <asp:TextBox Width="50%" AutoPostBack="true" ID="txtSearchBox" placeholder="Pesquisar nos posts" runat="server"></asp:TextBox>
                        <br />
                        </div>
                        <div style="clear: both"></div>
                        <div class="mais-opcoes" style="display: none">
                            <asp:DropDownList ID="ddlCategory" AutoPostBack="true" runat="server">
                            </asp:DropDownList>
                        </div>
                    </div>
                </div>
                <!-- Gerenciar posts -->
                <div class="post-pagination" style="width:100%">
                    <div style="float:left">
                        <asp:Label ID="lblMorePostTop" runat="server" Text=""></asp:Label>
                    </div>
                    <div style="float:right">
                        <ul class="table-filter">
                            <li><a href="#"><i class="fa fa-search" style="margin-right: 0 !important; margin-top: -2px"></i></a></li>
                            <li><asp:LinkButton OnClick="btnFiltrar_Click" runat="server"><i class="fa fa-sliders" style="margin-right: 10px"></i>Filtro</asp:LinkButton></li>
                            <li style="border-right: 1px solid #e5e5e5; height: 36px"></li>
                            <li><a href="#newpost"><i class="fa fa-plus" style="margin-right: 0 !important;"></i></a></li>
                        </ul>
                    </div>
                    <div class="clean"></div>
                </div>
                <table id="allposts" class="table">
                    <tr>
                        <td><i class="fa fa-paragraph"></i>Título</td>
                        <td><i class="fa fa-tags"></i>Categoria</td>
                        <td><i class="fa fa-calendar-o"></i>Data de postagem</td>
                        <td><i class="fa fa-bar-chart-o"></i>Visitas</td>
                        <td><i class="fa fa-gears"></i>Opções</td>
                    </tr>
                    <asp:Repeater ID="rptPosts" runat="server">
                        <ItemTemplate>
                            <tr id="post<%#Eval("Id") %>">
                                <td><%#Eval("Title") %></td>
                                <td><%#Eval("CategoryName") %></td>
                                <td style="min-width: 160px; max-width: 160px"><%#Eval("PostedDate") %></td>
                                <td style="text-align: left"><%#Eval("Visits") %></td>
                                <td style="min-width: 40px; max-width: 40px">
                                    <a href="#" style="margin-right: 6px" title="Deletar post">
                                        <asp:LinkButton ID="delete" CommandArgument='<%#Eval("Id") %>' style="color: #ff0000" title="Deletar post" OnCommand="delete_Command" runat="server"><i class="fa fa-trash-o"></i></asp:LinkButton>
                                    </a>
                                    <a href="?IdEditar=<%#Eval("Id") %>#newpost" style="margin-right: 5px" title="Editar post">
                                        <i class="fa fa-edit"></i>
                                    </a>
                                    <a href="#post<%#Eval("Id") %>" onclick="OpenPane(<%#Eval("Id") %>)" title="Ver mais informações">
                                        <i class="fa fa-angle-down"></i>
                                    </a>
                                </td>
                            </tr>
                            <tr id="openPost<%#Eval("Id") %>" class="noborder" style="display: none">

                                <td class="font10" colspan="4">
                                    <%#Eval("FirstParagraph") %>
                                </td>
                                <td class="postimage">
                                    <%#Eval("URLImage") %>
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </table>
                <div class="text-center">
                    <asp:Label ID="lblErro" runat="server" Text=""></asp:Label>
                </div>
                <div class="post-pagination">
                    <asp:Label ID="lblMorePosts" runat="server" Text=""></asp:Label>
                </div>
                <br />
                <br />
                <br />
                <!-- Gerenciar posts -->
            </div>
        </div>
    </section>
    <section id="share" class="parallax-section">
        <div class="container">
            <div class="row">
            </div>
        </div>
    </section>
    <section id="newpost">
        <div class="container">
            <div class="row">
                <div class="title text-center wow fadeIn" style="padding-bottom: 20px !important" data-wow-duration="1500ms">
                    <h2>
                        <asp:TextBox ID="txtTitle" CssClass="new-title" Text="" placeholder="inserir título" MaxLength="120" runat="server"></asp:TextBox><br />
                    </h2>
                    <div class="border"></div>
                    <div class="about-content text-center">
                        <br />
                        <p>Informe para os seus visitantes o que está acontecendo de novidade!</p>
                    </div>
                </div>
            </div>
            <CKEditor:CKEditorControl ID="CKEditor1" BasePath="ckeditor/" runat="server"></CKEditor:CKEditorControl>
            <div id="more-options-post" style="width: 6%; float: right; margin: 0 -12px;">
                <a style="text-align: right; color: #2572EB" href="#newpost">Opções &raquo;</a>
            </div>
            <div style="clear: both"></div>
            <div id="mais-opcoes-post" style="display: none">
                <div class="about-content text-center">
                    <asp:DropDownList ID="ddlCategoryNP" Width="30%" runat="server">
                    </asp:DropDownList>
                </div>
            </div>
            <br />
            <br />
            <div id="sucesso" class="about-content text-center">
                <asp:Label ID="lblInfo" runat="server" Text=""></asp:Label>
                <asp:LinkButton ID="btnPublish" OnClick="btnPublish_Click" runat="server"><span class="btn btn-transparent"><i class="fa fa-cloud-upload" style="margin-right: 15px"></i>Publicar post</span></asp:LinkButton>
            </div>
            <br />
            <br />
            <br />
        </div>
    </section>
</asp:Content>

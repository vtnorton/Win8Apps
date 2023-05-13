<%@ Page Title="" Language="C#" MasterPageFile="~/healtthrob.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="VTNORTON.onenote.index1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Guia definitivo para OneNote - eBook gratuito por Vítor Norton</title>
    <meta name="description" content="Trabalhe em equipe, em todos os lugares com essa incrível ferramenta!">
    <link href="/onenote/css/styles.min.css" rel="stylesheet">
    <link href="/onenote/css/main.css" rel="stylesheet">
    <meta name="url" content="http://www.vtnorton.com/OneNote" />
    <meta name="identifier-URL" content="http://www.vtnorton.com/OneNote" />
    <link rel="apple-touch-icon" sizes="180x180" href="apple-touch-icon.png?v=9BayaKbYGb"/>
    <link rel="icon" type="image/png" href="favicon-32x32.png?v=9BayaKbYGb" sizes="32x32"/>
    <link rel="icon" type="image/png" href="favicon-16x16.png?v=9BayaKbYGb" sizes="16x16"/>
    <link rel="manifest" href="manifest.json?v=9BayaKbYGb"/>
    <link rel="mask-icon" href="safari-pinned-tab.svg?v=9BayaKbYGb" color="#5bbad5"/>
    <link rel="shortcut icon" href="favicon.ico?v=9BayaKbYGb"/>
    <meta name="msapplication-TileColor" content="#9f00a7"/>
    <meta name="msapplication-TileImage" content="mstile-144x144.png?v=9BayaKbYGb"/>
    <meta name="theme-color" content="#ffffff"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderSubMenu" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="hero" id="Home">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="logo">
                        <a href="#">
                            <img src="/onenote/img/logo.png" alt="Guia definitivo para o OneNote">
                        </a>
                    </div>
                </div>
            </div>
            <div class="row" data-0="opacity: 1" data-800="opacity: 0">
                <div class="col-md-7">
                    <div class="welcome-message">
                        <h1>Guia definitivo para o OneNote</h1>
                        <h2>Trabalhe em equipe, em todos os lugares com essa incrível ferramenta.</h2>
                    </div>
                    <div class="action-button">
                        <a href="#Features" class="button learn-more text-center">Saiba mais <i class="fa fa-arrow-right"></i></a><a href="#Subscribe" class="button buy text-center">Baixe agora <i class="fa fa-download"></i></a>
                        <%--<p>*Disponível em PDF, ePUB, Mobi e Kindle.</p>--%>
                        <p>*Disponível somente em PDF, por enquanto.</p>
                    </div>
                    <div>
                        <br />
                        <script async src="//pagead2.googlesyndication.com/pagead/js/adsbygoogle.js"></script>
                        <!-- 2ad.vnext.com.br -->
                        <ins class="adsbygoogle"
                            style="display: block"
                            data-ad-client="ca-pub-5584056449430370"
                            data-ad-slot="9072010449"
                            data-ad-format="auto"></ins>
                        <script>
                            (adsbygoogle = window.adsbygoogle || []).push({});
                        </script>
                    </div>
                </div>
                <div class="col-md-5 text-center">
                    <img src="/onenote/img/ebook.png" alt="ebook" style="box-shadow: 0 0 19px -6px rgb(0, 0, 0)" class="book-cover" data-no-retina>
                </div>
            </div>
        </div>
    </section>
    <!--Hero section end-->

    <!--counter-->
    <div class="counter text-center" id="Features">
        <!--container-->
        <div class="container">
            <div>
                <h2>Guia definitivo para o OneNote</h2>
                <h4>Quais os pontos que este livro gratuito oferece?</h4>
                <br />
            </div>
            <div class="row">
                <div class="slide-left col-sm-4">
                    <i class="fa fa-4x fa-check-square-o"></i>
                    <h4 style="font-weight: 500">OneNote, o básico</h4>
                    <hr>
                    <p>OneNote é um caderno virtual de anotações que permite que os usuários criem anotações escritas ou desenhadas e compartilhar elas!</p>
                </div>
                <div class="slide-top col-sm-4">
                    <i class="fa fa-4x fa-list-ol"></i>
                    <h4 style="font-weight: 500">Organize suas ideias</h4>
                    <hr>
                    <p>Quando estamos falando de estudos ou algum projeto grande, é preciso organizar bem as anotações e o OneNote irá facilitar e muito para você!</p>
                </div>
                <div class="slide-right col-sm-4">
                    <i class="fa fa-4x fa-users"></i>
                    <h4 style="font-weight: 500">OneNote para equipes</h4>
                    <hr>
                    <p>O OneNote é fantástico para equipes, pois várias pessoas podem editar anotações ao mesmo tempo.</p>
                </div>
            </div>
            <br />
            <br />
            <div class="row">
                <div class="slide-left col-sm-4">
                    <i class="fa fa-4x fa-edit"></i>
                    <h4 style="font-weight: 500">Desenho com o OneNote</h4>
                    <hr>
                    <p>Se é anotações, tem que ser possível desenhar né? E não é que dá para fazer muita coisa com os desenhos no OneNote?</p>
                </div>
                <div class="slide-top col-sm-4">
                    <i class="fa fa-4x fa-thumbs-up"></i>
                    <h4 style="font-weight: 500">Dicas para o OneNote</h4>
                    <hr>
                    <p>Neste espaço eu reuni algumas dicas de ferramentas do OneNote que podem ser extremamente úteis para você.</p>
                </div>
            </div>
        </div>
        <!--container end-->
    </div>
    <!--counter end-->

    <!--Author-->

    <section class="author section-spacing" id="Author">
        <div class="container">
            <div class="text-center">
                <h2>Sobre o autor</h2>
            </div>
            <div class="row">
                <div class="slide-left col-md-5 text-center">
                    <img src="/devnasnuvens/img/norton.jpg" alt="author" class="author-img">
                </div>
                <div class="col-md-7">
                    <h4 class="slide-right">Vítor Norton</h4>
                    <hr class="slide-right">
                    <p class="slide-right">Venho trabalhando com o OneNote já tem alguns anos, uso-o constantemente para gerenciar os conteúdos da minha faculdade, escrever as aulas e palestras que eu dou, organizar as minhas ideias e os feedbacks que eu recebo nos meus aplicativos, que são publicados pela Y’APP e para controlar a pauta do meu podcast favorito o Nextcast, o melhor podcast sobre a Microsoft do Brasil, ele é produzido e distribuído pelo vNext Brasil.</p>
                    <p class="slide-right">Sou Microsoft MVP em Windows Experience, e venho, no meu primeiro eBook trazer um pouco da experiência que tive com o OneNote e como ele pode te ajudar a alcançar mais nas suas anotações, seja em casa, na escola ou no trabalho. </p>
                </div>
            </div>
        </div>
    </section>
    <!--Author end-->

    <!--buy now-->
    <div class="buy-now text-center" id="Subscribe">
        <div class="container" id="prebaixar">
            <div class="text-center">
                <h2 style="color: #fff">Cadastre-se</h2>
                <h4 style="color: #ddd">Informe seu e-mail para poder baixar o eBook. Não irei enviar spam, prometo!</h4>
            </div>
            <form runat="server">
                <div style="margin-bottom: 22px; margin-top: 20px">
                    <asp:TextBox ID="txtEmail" MaxLength="120" CssClass="slide-bottom emailbox form-control" placeholer="Email" runat="server" TextMode="Email"></asp:TextBox>
                </div>
                <div class="row text-center" style="color: #fff !important">
                    <h4>
                        <asp:Label ID="Label1" runat="server" Text=""></asp:Label></h4>
                </div>
                <div class="row">
                    <asp:Button ID="btnBaixar" OnClick="btnBaixar_Click" CssClass="button buy" runat="server" Text="Baixar agora" />
                </div>
                <br /><br />
                <script async src="//pagead2.googlesyndication.com/pagead/js/adsbygoogle.js"></script>
                <!-- 2ad.vnext.com.br -->
                <ins class="adsbygoogle"
                    style="display: block"
                    data-ad-client="ca-pub-5584056449430370"
                    data-ad-slot="9072010449"
                    data-ad-format="auto"></ins>
                <script>
                    (adsbygoogle = window.adsbygoogle || []).push({});
                </script>
            </form>
        </div>
    </div>
    <!--buy now end-->
    <script src="/onenote/js/scripts.min.js"></script>
    <script src="/onenote/js/main.js"></script>
</asp:Content>

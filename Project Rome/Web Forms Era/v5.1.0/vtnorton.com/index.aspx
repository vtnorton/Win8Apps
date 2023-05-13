<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="VTNORTON.index" MaintainScrollPositionOnPostback="true" %>

<!DOCTYPE html>
<!--[if lt IE 7]>      <html class="no-js lt-ie9 lt-ie8 lt-ie7"> <![endif]-->
<!--[if IE 7]>         <html class="no-js lt-ie9 lt-ie8"> <![endif]-->
<!--[if IE 8]>         <html class="no-js lt-ie9"> <![endif]-->
<!--[if gt IE 8]><!-->
<html class="no-js">
<!--<![endif]-->
<head runat="server">
    <!-- CSS -->
    <link rel="stylesheet" href="/css/font-awesome.min.css">
    <link rel="stylesheet" href="/css/bootstrap.min.css" />
    <link rel="stylesheet" href="/css/animate.css" />
    <link rel="stylesheet" href="/css/owl.carousel.css" />
    <link rel="stylesheet" href="/css/component.css" />
    <link rel="stylesheet" href="/css/slit-slider.css" />
    <link rel="stylesheet" href="/css/main.css" />
    <link rel="stylesheet" href="/css/media-queries.css" />
    <!-- Fim do CSS -->

    <!-- Metadados/SEO -->
    <title><%=VTNORTON.Resources.master.srtTitle %></title>
    <meta name="description" content="I have a few apps published on the Store, here is the place that you can find everything about it and about me." />
    <meta name="keywords" content="design, desenvolvimento, windows phone, windows, vitor norton, kachu, surface, mixer, heartthrob, criação de sites" />
    <meta name="image" content="http://www.vtnorton.com/images/logos/logo.vtnorton.thumbnail.png" />
    <meta name="thumbnail" content="http://www.vtnorton.com/images/logos/logo.vtnorton.thumbnail.png" />
    <meta name="author" content="Vítor Norton, contato@vtnorton.com" />
    <meta name="designer" content="Vítor Norton" />
    <meta name="copyright" content="vtnorton" />
    <meta name="reply-to" content="contato@vtnorton.com" />
    <meta name="owner" content="Vítor Norton" />
    <meta name="url" content="http://www.vtnorton.com" />
    <meta name="identifier-URL" content="http://www.vtnorton.com" />
    <meta name="directory" content="submission" />
    <meta name="category" content="software" />
    <meta name="coverage" content="Worldwide" />
    <meta name="distribution" content="Global" />
    <meta name="rating" content="General" />
    <meta name="revisit-after" content="1 day" />
    <meta name="application-name" content="vtnorton.com" />
    <meta content="@vt_norton" name="twitter:site" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta name="msvalidate.01" content="56DFA045266F286D4EDE0D2B401CC585" />
    <!-- Fim do Metadados/SEO -->

    <!-- Tecnologias -->
    <meta charset="utf-8" />
    <link href="http://www.vtnorton.com/opensearch.xml" rel="search" title="Pesquisar vtnorton.com" type="application/opensearchdescription+xml" />
    <link rel="shortcut icon" href="/favicon.ico" />
    <meta name="msapplication-starturl" content="http://www.vtnorton.com/?=ie-starturl" />
    <meta name="msapplication-tooltip" content="Entrar em www.vtnorton.com" />
    <meta name="msapplication-navbutton-color" content="black" />
    <link rel="apple-touch-icon" href="/img/icones/touch-icon-iphone.png" />
    <link rel="apple-touch-icon" sizes="76x76" href="/img/icones/touch-icon-ipad.png" />
    <link rel="apple-touch-icon" sizes="120x120" href="/img/icones/touch-icon-iphone-retina.png" />
    <link rel="apple-touch-icon" sizes="152x152" href="/img/icones/touch-icon-ipad-retina.png" />
    <link rel="apple-touch-startup-image" href="/img/icones/startup.png" />
    <meta name="apple-mobile-web-app-capable" content="yes" />
    <!-- Fim de Tecnologias -->
</head>
<body id="body">
    <form runat="server">
        <!-- Start Preloader -->
        <div id="loading-mask">
            <div class="loading-img">
                <img alt="Loading" style="max-height: 200px; max-width: 200px" src="img/preloader.gif" />
            </div>
        </div>
        <!-- End Preloader -->

        <section id="home">
            <div id="slitSlider" class="sl-slider-wrapper">
                <div class="sl-slider">
                    <div class="sl-slide" data-orientation="horizontal" data-slice1-rotation="-25" data-slice2-rotation="-25" data-slice1-scale="2" data-slice2-scale="2">
                        <div class="sl-slide-inner">
                            <div class="bg-img bg-img-1"></div>
                            <div class="carousel-caption">
                                <div>
                                    <img class="wow fadeInUp" src="img/logos/logo.385.png" alt="Vítor Norton">
                                </div>
                            </div>
                        </div>
                    </div>
                    <%--<div class="sl-slide" data-orientation="vertical" data-slice1-rotation="10" data-slice2-rotation="-15" data-slice1-scale="1.5" data-slice2-scale="1.5">
                        <div class="sl-slide-inner">
                            <div class="bg-img bg-img-2"></div>
                            <div class="carousel-caption">
                                <div>
                                    <h2 class="heading animated fadeInDown"><%=VTNORTON.Resources.index.slideOneTitle %></h2>
                                    <h3 class="animated fadeInUp"><%=VTNORTON.Resources.index.slideOneDescription %></h3>
                                    <a class="btn btn-green animated fadeInUp" href="#showcase"><%=VTNORTON.Resources.index.slideOneButton %></a>
                                </div>
                            </div>
                        </div>
                    </div>--%>

                    <%--<div class="sl-slide" data-orientation="horizontal" data-slice1-rotation="3" data-slice2-rotation="3" data-slice1-scale="2" data-slice2-scale="1">
                        <div class="sl-slide-inner">
                            <div class="bg-img bg-img-3"></div>
                            <div class="carousel-caption">
                                <div>
                                    <h2 class="heading animated fadeInRight">One Page Parallax HTML Template</h2>
                                    <h3 class="animated fadeInLeft">Clean and Professional Design</h3>
                                    <a class="btn btn-green animated fadeInUp" href="#">Learn More</a>
                                </div>
                            </div>
                        </div>
                    </div>--%>
                </div>
                <nav id="nav-arrows" class="nav-arrows">
                    <span class="nav-arrow-prev"><%=VTNORTON.Resources.index.Previous %></span>
                    <span class="nav-arrow-next"><%=VTNORTON.Resources.index.Next %></span>
                </nav>
                <nav id="nav-dots" class="nav-dots">
                    <span class="nav-dot-current"></span>
                    <span></span>
                    <span></span>
                </nav>
            </div>
        </section>
        <header id="navigation" class="navbar navbar-inverse">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" href="#body">
                        <h1 id="logo">
                            <img src="/img/logos/logo.vtnorton.45.png" alt="Vítor Norton" />
                        </h1>
                    </a>
                </div>
                <nav class="collapse navbar-collapse navbar-right" role="Navigation">
                    <ul id="nav" class="nav navbar-nav">
                        <li class="current"><a href="#body"><%=VTNORTON.Resources.master.srtHome %></a></li>
                        <li><a href="#showcase">apps</a></li>
                        <li><a href="#blog">blog</a></li>
                        <li><a href="#about"><%=VTNORTON.Resources.master.srtAbout %></a></li>
                        <li><a href="#contact-us"><%=VTNORTON.Resources.master.srtContact %></a></li>
                    </ul>
                </nav>
            </div>
        </header>

        <section id="showcase">
            <div class="container">
                <div class="row wow fadeInDown" data-wow-duration="500ms">
                    <div class="col-lg-12">
                        <div class="title text-center">
                            <%=VTNORTON.Resources.master.MyApps %>
                            <div class="border"></div>
                        </div>
                        <div class="portfolio-filter clearfix">
                            <ul class="text-center">
                                <li><a href="javascript:void(0)" class="filter" data-filter="all"><%=VTNORTON.Resources.master.All %></a></li>
                                <li><a href="javascript:void(0)" class="filter" data-filter=".tool"><%=VTNORTON.Resources.master.Tools %></a></li>
                                <li><a href="javascript:void(0)" class="filter" data-filter=".fun"><%=VTNORTON.Resources.master.Fun %></a></li>
                                <li><a href="javascript:void(0)" class="filter" data-filter=".education"><%=VTNORTON.Resources.master.Education %></a></li>
                                <%--<li><a href="javascript:void(0)" class="filter" data-filter=".others"><%=VTNORTON.Resources.master.Others %></a></li>--%>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
            <div class="portfolio-item-wrapper wow fadeInUp" data-wow-duration="500ms">
                <ul id="og-grid" class="og-grid">

                    <li class="mix fun">
                        <a href="#showcase" data-largesrc="img/portfolio/ProjectLasVegas.png" data-title="<%=Core.Resources.ProjectUSA.LasVegasTitle %>" data-description="<%=Core.Resources.ProjectUSA.LasVegasShortDescription %>">
                            <img src="img/portfolio/ProjectLasVegas.png" alt="<%=Core.Resources.ProjectUSA.LasVegasTitle %>">
                            <div class="hover-mask">
                                <h3><%=Core.Resources.ProjectUSA.LasVegasTitle %></h3>
                                <span>
                                    <i class="fa fa-plus fa-2x"></i>
                                </span>
                            </div>
                        </a>
                    </li>
                    <li class="mix education">
                        <a href="javascript:void(0)" data-largesrc="img/portfolio/projectDouai.png" data-title="<%=Core.Resources.ProjectFrance.DouaiTitle %>" data-description="<%=Core.Resources.ProjectFrance.DouaiShortDescription %>">
                            <img src="img/portfolio/projectDouai.png" alt="<%=Core.Resources.ProjectFrance.DouaiTitle %>">
                            <div class="hover-mask">
                                <h3><%=Core.Resources.ProjectFrance.DouaiTitle %></h3>
                                <span>
                                    <i class="fa fa-plus fa-2x"></i>
                                </span>
                            </div>
                        </a>
                    </li>
                    <li class="mix tool">
                        <a href="javascript:void(0)" data-largesrc="img/portfolio/projectLyon.jpg" data-title="<%=Core.Resources.ProjectFrance.LyonTitle %>" data-description="<%=Core.Resources.ProjectFrance.LyonShortDescription %>">
                            <img src="img/portfolio/projectLyon.jpg" alt="<%=Core.Resources.ProjectFrance.LyonTitle %>">
                            <div class="hover-mask">
                                <h3><%=Core.Resources.ProjectFrance.LyonTitle %></h3>
                                <span>
                                    <i class="fa fa-plus fa-2x"></i>
                                </span>
                            </div>
                        </a>
                    </li>
                    <li class="mix tool">
                        <a href="javascript:void(0)" data-largesrc="img/portfolio/projectNice.png" data-title="<%=Core.Resources.ProjectFrance.NiceTitle %>" data-description="<%=Core.Resources.ProjectFrance.NiceShortDescription %>">
                            <img src="img/portfolio/projectNice.png" alt="<%=Core.Resources.ProjectFrance.NiceTitle %>">
                            <div class="hover-mask">
                                <h3><%=Core.Resources.ProjectFrance.NiceTitle %></h3>
                                <span>
                                    <i class="fa fa-plus fa-2x"></i>
                                </span>
                            </div>
                        </a>
                    </li>
                    <li class="mix fun">
                        <a href="javascript:void(0)" data-largesrc="img/portfolio/ProjectPasadena.jpg" data-title="<%=Core.Resources.ProjectUSA.PasadenaTitle %>" data-description="<%=Core.Resources.ProjectUSA.PasadenaShortDescription %>">
                            <img src="img/portfolio/ProjectPasadena.jpg" alt="<%=Core.Resources.ProjectUSA.PasadenaTitle %>">
                            <div class="hover-mask">
                                <h3><%=Core.Resources.ProjectUSA.PasadenaTitle %></h3>
                                <span>
                                    <i class="fa fa-plus fa-2x"></i>
                                </span>
                            </div>
                        </a>
                    </li>

                </ul>
            </div>
        </section>
        <section id="blog" class="bg-one">
            <div class="container">
                <div class="row">
                    <div class="title text-center wow fadeInDown">
                        <%=VTNORTON.Resources.master.srtLastPosts%>
                        <div class="border"></div>
                    </div>
                    <div class="clearfix">
                        <asp:Repeater ID="rptBlog" runat="server">
                            <ItemTemplate>
                                <article class="col-md-4 col-sm-6 col-xs-12 clearfix wow fadeInUp" data-wow-duration="500ms">
                                    <div class="note">
                                        <div class="media-wrapper">
                                            <%#Eval("URLImage")%>
                                            <%--<%#Eval("PostHTML")%>--%>
                                        </div>

                                        <div class="excerpt">
                                            <h3><%#Eval("Title") %></h3>
                                            <p><%#Eval("FirstParagraph")%></p>
                                            <div class="text-center">
                                                <a class="btn btn-transparent" href="/blog/post.aspx?id=<%#Eval("Id") %>"><i class="fa fa-file-text-o" style="margin-right: 10px;"></i><%=VTNORTON.Resources.index.srtReadMore %></a>
                                            </div>
                                        </div>
                                    </div>
                                </article>
                            </ItemTemplate>

                        </asp:Repeater>
                    </div>
                    <div class="all-post text-center">
                        <a class="btn btn-transparent" href="/blog/"><i class="fa fa-th-list" style="margin-right: 10px"></i><%=VTNORTON.Resources.index.srtAllPosts %></a>
                    </div>
                </div>
            </div>
        </section>

        <section id="counter" class="parallax-section">
            <div class="container">
                <div class="row">
                    <div class="col-md-3 col-sm-6 col-xs-12 text-center wow fadeInDown" data-wow-duration="500ms">
                        <div class="counters-item">
                            <div>
                                <span>+</span>
                                <span data-speed="3000" data-to="10000">+10.000</span>

                            </div>
                            <i class="fa fa-users fa-3x"></i>
                            <h3>Downloads</h3>
                        </div>
                    </div>
                    <div class="col-md-3 col-sm-6 col-xs-12 text-center wow fadeInDown" data-wow-duration="500ms" data-wow-delay="200ms">
                        <div class="counters-item">
                            <div>
                                <span data-speed="3000" data-to="5">5</span>
                            </div>
                            <i class="fa fa-check-square fa-3x"></i>
                            <h3><%=VTNORTON.Resources.index.srtPublishedApps %></h3>
                        </div>
                    </div>
                    <div class="col-md-3 col-sm-6 col-xs-12 text-center wow fadeInDown" data-wow-duration="500ms" data-wow-delay="400ms">
                        <div class="counters-item">
                            <div>
                                <span data-speed="3000" data-to="85">85</span>
                                <span>%</span>
                            </div>
                            <i class="fa fa-thumbs-up fa-3x"></i>
                            <h3><%=VTNORTON.Resources.index.srtPositiveFeedback %></h3>

                        </div>
                    </div>
                    <div class="col-md-3 col-sm-6 col-xs-12 text-center wow fadeInDown" data-wow-duration="500ms" data-wow-delay="600ms">
                        <div class="counters-item kill-margin-bottom">
                            <div>
                                <asp:Label ID="lblLinesOfCode" runat="server" Text=""></asp:Label>

                            </div>
                            <i class="fa fa-code fa-3x"></i>
                            <h3><%=VTNORTON.Resources.index.srtLinesOfCode %></h3>
                        </div>
                    </div>
                </div>
            </div>
        </section>

        <section id="about" class="bg-one">
            <div class="container">
                <div class="row">

                    <div class="title text-center wow fadeIn" data-wow-duration="1500ms">
                        <%=VTNORTON.Resources.index.srtAboutMe %>
                        <div class="border"></div>
                    </div>
                    <div class="col-md-4 text-center wow fadeInUp" data-wow-duration="500ms">
                        <div class="wrap-about">
                            <div class="icon-box">
                                <i class="fa fa-lightbulb-o fa-4x"></i>
                            </div>
                            <div class="about-content text-center">
                                <h3 class="ddd"><%=VTNORTON.Resources.index.srtTheProject %></h3>
                                <p><%=VTNORTON.Resources.index.srtTheProjectDescription %></p>
                            </div>
                        </div>
                        <div class="all-post text-center">
                            <a class="btn btn-transparent" href="/sobre"><%=VTNORTON.Resources.index.srtTheProjectButton %></a>
                        </div>
                    </div>
                    <div class="col-md-4 text-center wow fadeInUp" data-wow-duration="500ms" data-wow-delay="250ms">
                        <div class="wrap-about">
                            <div class="icon-box">
                                <i class="fa fa-users fa-4x"></i>
                            </div>
                            <div class="about-content text-center">
                                <h3><%=VTNORTON.Resources.index.srtFAQTitle %></h3>
                                <p><%=VTNORTON.Resources.index.srtFAQDescription %></p>
                            </div>
                        </div>
                        <div class="all-post text-center">
                            <a class="btn btn-transparent" href="/faq">FAQ</a>
                        </div>
                    </div>
                    <div class="col-md-4 text-center wow fadeInUp" data-wow-duration="500ms" data-wow-delay="500ms">
                        <div class="wrap-about kill-margin-bottom">
                            <div class="icon-box">
                                <i class="fa fa-users fa-4x"></i>
                            </div>
                            <div class="about-content text-center">
                                <h3>Vítor Norton</h3>
                                <p><%=VTNORTON.Resources.index.srtBio %></p>
                            </div>
                        </div>
                        <div class="all-post text-center">
                            <a class="btn btn-transparent" href="/vitor"><%=VTNORTON.Resources.index.srtBioButton %></a>
                        </div>
                    </div>
                </div>
            </div>
        </section>

        <section id="team-skills" class="parallax-section">
            <div class="container">
                <div class="row wow fadeInDown" data-wow-duration="500ms">
                    <div class="title text-center">
                        <%=VTNORTON.Resources.index.srtSkills %>
                        <div class="border"></div>
                    </div>
                    <div class="col-md-3 col-sm-6 col-xs-12 wow fadeInUp" data-wow-duration="500ms">
                        <div class="skill-chart text-center">
                            <span class="chart" data-percent="35">
                                <span class="percent"></span>
                            </span>
                            <h3><i class="fa fa-file-picture-o"></i>Design</h3>
                            <p><%=VTNORTON.Resources.index.srtDesign %></p>
                        </div>
                    </div>
                    <div class="col-md-3 col-sm-6 col-xs-12 wow fadeInUp" data-wow-duration="500ms" data-wow-delay="200ms">
                        <div class="skill-chart text-center">
                            <span class="chart" data-percent="65">
                                <span class="percent"></span>
                            </span>
                            <h3><i class="fa fa-mobile-phone"></i>Mobile</h3>
                            <p><%=VTNORTON.Resources.index.srtMobile %></p>
                        </div>
                    </div>
                    <div class="col-md-3 col-sm-6 col-xs-12 wow fadeInUp" data-wow-duration="500ms" data-wow-delay="400ms">
                        <div class="skill-chart text-center">
                            <span class="chart" data-percent="80">
                                <span class="percent"></span>
                            </span>
                            <h3><i class="fa fa-html5"></i>Web</h3>
                            <p><%=VTNORTON.Resources.index.srtWeb %></p>
                        </div>
                    </div>
                    <div class="col-md-3 col-sm-6 col-xs-12 wow fadeInUp" data-wow-duration="500ms" data-wow-delay="600ms">
                        <div class="skill-chart text-center">
                            <span class="chart" data-percent="90">
                                <span class="percent"></span>
                            </span>
                            <h3><i class="fa fa-windows"></i>Windows</h3>
                            <p><%=VTNORTON.Resources.index.srtWindows %></p>
                        </div>
                    </div>
                </div>
            </div>
        </section>

        <section id="contact-us">
            <div class="container">
                <div class="row">
                    <div class="title text-center wow fadeIn" data-wow-duration="500ms">
                        <%=VTNORTON.Resources.master.srtContact1 %>
                        <div class="border"></div>
                    </div>
                    <div class="contact-info col-md-6 wow fadeInUp" data-wow-duration="500ms">
                        <h3><%=VTNORTON.Resources.master.srtContactTile %></h3>
                        <p>
                            <%=VTNORTON.Resources.master.srtContactText %>
                        </p>
                        <div class="contact-details">
                            <div class="con-info clearfix">
                                <i class="fa fa-home fa-lg"></i>
                                <span>Cachoeiro de Itapemirim, ES - Brasil</span>
                            </div>

                            <div class="con-info clearfix">
                                <i class="fa fa-envelope fa-lg"></i>
                                <span>E-mail: contato@vtnorton.com</span>
                            </div>

                        </div>
                    </div>
                    <div class="contact-form col-md-6 wow fadeInUp" data-wow-duration="500ms" data-wow-delay="300ms">
                        <div id="contact-form">
                            <br />
                            <div class="form-group" style="display: none">
                                <asp:TextBox ID="txtKillRobots" placeholder="Não preencha" CssClass="form-control" Width="100%" runat="server"></asp:TextBox>
                            </div>

                            <div class="form-group">
                                <asp:TextBox ID="txtNome" CssClass="form-control" runat="server" Width="100%"></asp:TextBox>
                            </div>

                            <div class="form-group">
                                <asp:TextBox ID="txtEmail" TextMode="Email" CssClass="form-control" Width="100%" runat="server"></asp:TextBox>
                            </div>

                            <div class="form-group">
                                <asp:TextBox ID="txtMenssagem" Rows="6" TextMode="MultiLine" CssClass="form-control" runat="server" Width="100%"></asp:TextBox>
                            </div>

                            <div id="cf-submit">
                                <asp:Label ID="lblInfoContatct" runat="server" Text=""></asp:Label>
                                <asp:Button ID="btnContactInfo" CssClass="btn btn-transparent" runat="server" Text="Enviar" OnClick="btnContactInfo_Click" />
                            </div>

                        </div>
                    </div>

                </div>
            </div>
        </section>

        <footer id="footer" class="bg-one">
            <div class="container">
                <div class="row wow fadeInUp" data-wow-duration="500ms">
                    <div class="col-lg-12">
                        <br />
                        <br />
                        <asp:Label CssClass="social-icon" ID="lblSocialIcons" runat="server" Text=""></asp:Label>
                    </div>
                </div>
            </div>
        </footer>

        <a href="javascript:;" id="scrollUp">
            <i class="fa fa-angle-up fa-2x"></i>
        </a>
    </form>
</body>

<!-- JavaScript -->
<script src="/js/modernizr-2.6.2.min.js"></script>
<script src="/js/jquery-1.11.0.min.js"></script>
<script src="/js/bootstrap.min.js"></script>
<script src="/js/jquery.slitslider.js"></script>
<script src="/js/jquery.ba-cond.min.js"></script>
<script src="/js/jquery.parallax-1.1.3.js"></script>
<script src="/js/owl.carousel.min.js"></script>
<script src="/js/jquery.mixitup.min.js"></script>
<script src="/js/jquery.nicescroll.min.js"></script>
<script src="/js/jquery.appear.js"></script>
<script src="/js/easyPieChart.js"></script>
<script src="/js/jquery.easing-1.3.pack.js"></script>
<script src="/js/tweetie.min.js"></script>
<script src="/js/jquery.nav.js"></script>
<script src="/js/jquery.sticky.js"></script>
<script src="/js/jquery.countTo.js"></script>
<script src="/js/wow.min.js"></script>
<script src="/js/grid.js"></script>
<script src="/js/jquery.fitvids.js"></script>
<script src="/js/jquery.gridder.min.js"></script>
<script src="/js/custom.js"></script>
<!-- Fim do JavaScript -->


<%--<script>
    var $buoop = { c: 2 };
    function $buo_f() {
        var e = document.createElement("script");
        e.src = "//browser-update.org/update.js";
        document.body.appendChild(e);
    };
    try { document.addEventListener("DOMContentLoaded", $buo_f, false) }
    catch (e) { window.attachEvent("onload", $buo_f) }
    NProgress.start();
    setTimeout(function () { NProgress.done(); $('.fade').removeClass('out'); }, 1000);
    (function (i, s, o, g, r, a, m) {
        i['GoogleAnalyticsObject'] = r; i[r] = i[r] || function () {
            (i[r].q = i[r].q || []).push(arguments)
        }, i[r].l = 1 * new Date(); a = s.createElement(o),
        m = s.getElementsByTagName(o)[0]; a.async = 1; a.src = g; m.parentNode.insertBefore(a, m)
    })(window, document, 'script', '//www.google-analytics.com/analytics.js', 'ga');

    ga('create', 'UA-50145252-1', 'auto');
    ga('send', 'pageview');

</script>--%>
<%--<script type="text/javascript">
    var appInsights = window.appInsights || function (config) {
        function r(config) { t[config] = function () { var i = arguments; t.queue.push(function () { t[config].apply(t, i) }) } } var t = { config: config }, u = document, e = window, o = "script", s = u.createElement(o), i, f; for (s.src = config.url || "//az416426.vo.msecnd.net/scripts/a/ai.0.js", u.getElementsByTagName(o)[0].parentNode.appendChild(s), t.cookie = u.cookie, t.queue = [], i = ["Event", "Exception", "Metric", "PageView", "Trace"]; i.length;) r("track" + i.pop()); return r("setAuthenticatedUserContext"), r("clearAuthenticatedUserContext"), config.disableExceptionTracking || (i = "onerror", r("_" + i), f = e[i], e[i] = function (config, r, u, e, o) { var s = f && f(config, r, u, e, o); return s !== !0 && t["_" + i](config, r, u, e, o), s }), t
    }({
        instrumentationKey: "109b46e2-88e6-4f04-8535-266fc1728338"
    });

    window.appInsights = appInsights;
    appInsights.trackPageView();
</script>--%>
</html>

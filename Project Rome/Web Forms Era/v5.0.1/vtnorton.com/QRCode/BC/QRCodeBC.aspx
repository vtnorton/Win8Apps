<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QRCodeBC.aspx.cs" Inherits="VTNORTON.QRCode.BC.QRCodeBC" %>

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

    <!-- Metadados/SEO -->
    <title>Vítor Norton</title>
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
                        <li><a href="/"><%=VTNORTON.Resources.qrcodebc.Site %></a></li>
                    </ul>
                </nav>
            </div>
        </header>
        <section id="site" class="bg-one">
            <div class="container">
                <div class="row">

                    <div class="title text-center wow fadeIn" data-wow-duration="1500ms">
                        <%=VTNORTON.Resources.qrcodebc.ExclusiveSite %>
                        <div class="border"></div>
                    </div>


                </div>
            </div>
        </section>

        <section id="social" class="parallax-section">
        </section>

        <section id="patreon" class="bg-one">
            <div class="container">
                <div class="row">

                    <div class="title text-center wow fadeIn" data-wow-duration="1500ms">
                        <%=VTNORTON.Resources.qrcodebc.Patreon %>
                        <div class="border"></div>
                    </div>


                </div>
            </div>
        </section>
        <section id="counter" class="parallax-section">
            <div class="container">
                <div class="row">
                    <div class="col-md-3 text-center wow fadeInUp" data-wow-duration="500ms">
                        <div class="wrap-about">
                            <div class="icon-box">
                                <i class="fa fa-windows fa-4x"></i>
                            </div>
                            <div class="about-content text-center">
                                <h3><%=VTNORTON.Resources.qrcodebc.WallpaperTitle %></h3>
                                <p><%=VTNORTON.Resources.qrcodebc.WallpaperDescription %></p>
                            </div>
                        </div>
                        <div class="all-post text-center">
                            <a class="btn btn-transparent" href="/downloads/wallpaper-patreon.rar">Download</a>
                        </div>
                    </div>
                    <div class="col-md-3 text-center wow fadeInUp" data-wow-duration="500ms" data-wow-delay="250ms">
                        <div class="wrap-about">
                            <div class="icon-box">
                                <i class="fa fa-calendar fa-4x"></i>
                            </div>
                            <div class="about-content text-center">
                                <h3><%=VTNORTON.Resources.qrcodebc.CalendarioTitle %></h3>
                                <p><%=VTNORTON.Resources.qrcodebc.CalendarDescription %></p>
                            </div>
                        </div>
                        <div class="all-post text-center">
                            <a class="btn btn-transparent" href="webcals://sharing.calendar.live.com/calendar/private/247960fc-5ed7-4317-a1b2-5253a8fd4bed/56320fa2-ec6c-4056-85a4-3db5da09369e/cid-ef627bed23a6ef8c/calendar.ics"><%=VTNORTON.Resources.qrcodebc.Subscription %></a>
                        </div>
                    </div>
                    <div class="col-md-3 text-center wow fadeInUp" data-wow-duration="500ms" data-wow-delay="500ms">
                        <div class="wrap-about kill-margin-bottom">
                            <div class="icon-box">
                                <i class="fa fa-users fa-4x"></i>
                            </div>
                            <div class="about-content text-center">
                                <h3><%=VTNORTON.Resources.qrcodebc.MIDTitle %></h3>
                                <p><%=VTNORTON.Resources.qrcodebc.MIDDescription %></p>
                            </div>
                        </div>
                        <div class="all-post text-center">
                            <a class="btn btn-transparent" href="#">Download</a>
                        </div>
                    </div>
                    <div class="col-md-3 text-center wow fadeInUp" data-wow-duration="500ms" data-wow-delay="500ms">
                        <div class="wrap-about kill-margin-bottom">
                            <div class="icon-box">
                                <i class="fa fa-phone fa-4x"></i>
                            </div>
                            <div class="about-content text-center">
                                <h3><%=VTNORTON.Resources.qrcodebc.ContactTitle %></h3>
                                <p><%=VTNORTON.Resources.qrcodebc.ContactDescription %></p>
                            </div>
                        </div>
                        <div class="all-post text-center">
                            <a class="btn btn-transparent" href="#">Download</a>
                        </div>
                    </div>
                </div>
            </div>
        </section>

        <section id="about" class="bg-one">
            <div class="container">
                <div class="row">
                    <div class="title text-center wow fadeIn" data-wow-duration="1500ms">
                        <%=VTNORTON.Resources.qrcodebc.Talks %>
                        <div class="border"></div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-3 text-center wow fadeInUp" data-wow-duration="500ms" data-wow-delay="250ms">
                        <div class="wrap-about">
                            <div class="about-content text-center">
                                <img src="/img/others/author/ProfilePic.350.jpg" style="max-width: 100%; min-width: 100%" />
                            </div>
                        </div>
                    </div>
                    <div class="col-md-9 contact-info wow fadeInUp" data-wow-duration="500ms" data-wow-delay="500ms">
                        <div class="contact-details">
                            <div class="con-info clearfix">
                                <p>
                                    Lorem ipsum
                                </p>
                            </div>

                            <a class="btn btn-transparent" href="#"><%=VTNORTON.Resources.qrcodebc.CallForTalk %></a>
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
                            <div class="con-info clearfix">
                                <i class="fa fa-envelope fa-lg"></i>
                                <span>E-mail: vitor@vtnorton.com</span>
                            </div>
                            <div class="con-info clearfix">
                                <i class="fa fa-phone fa-lg"></i>
                                <span>+55 (28) 98114-1657 (Whatsapp)</span>
                            </div>
                            <div class="con-info clearfix">
                                <i class="fa fa-skype fa-lg"></i>
                                <span>vtnorton</span>
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
<script type="text/javascript">
    var appInsights = window.appInsights || function (config) {
        function r(config) { t[config] = function () { var i = arguments; t.queue.push(function () { t[config].apply(t, i) }) } } var t = { config: config }, u = document, e = window, o = "script", s = u.createElement(o), i, f; for (s.src = config.url || "//az416426.vo.msecnd.net/scripts/a/ai.0.js", u.getElementsByTagName(o)[0].parentNode.appendChild(s), t.cookie = u.cookie, t.queue = [], i = ["Event", "Exception", "Metric", "PageView", "Trace"]; i.length;) r("track" + i.pop()); return r("setAuthenticatedUserContext"), r("clearAuthenticatedUserContext"), config.disableExceptionTracking || (i = "onerror", r("_" + i), f = e[i], e[i] = function (config, r, u, e, o) { var s = f && f(config, r, u, e, o); return s !== !0 && t["_" + i](config, r, u, e, o), s }), t
    }({
        instrumentationKey: "109b46e2-88e6-4f04-8535-266fc1728338"
    });

    window.appInsights = appInsights;
    appInsights.trackPageView();
</script>

</html>

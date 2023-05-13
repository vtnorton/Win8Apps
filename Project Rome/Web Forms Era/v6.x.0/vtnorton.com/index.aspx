<%--%@ Page Language="C#" AutoEventWireup="false" CodeBehind="index.aspx.cs" Inherits="VTNORTON.index" %>--%>

<!doctype html>
<html style="height: 100%">
<head runat="server">
    <!-- CSS -->
    <link rel="stylesheet" href="/css/main.css" />
    <link rel="stylesheet" href="/css/font-awesome.min.css">
    <link id="clink" href="css/style-blue.css" title="style" rel="stylesheet" type="text/css" media="screen" />
    <!-- Fim do CSS -->

    <!-- Metadados/SEO -->
    <title>Vítor Norton</title>
    <meta name="description" content="Palestras, cursos gratuitos e pagos. Desenvolvimento de sites e aplicativos (via yapp.vtnorton.com) e um monte de outras coisas que eu faço." />
    <meta name="keywords" content="design, desenvolvimento, windows phone, windows, vitor norton, mixer, heartthrob, criação de sites, yapp, vnext, mvp, cursos online, cursos gratuitos, cursos de desenvolvimento gratuitos, cursos de desenvolvimento online" />
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
    <meta name="viewport" content="width=device-width; initial-scale=1.0; maximum-scale=1.0; user-scalable=0;" />
    <meta name="msvalidate.01" content="56DFA045266F286D4EDE0D2B401CC585" />
    <link rel="alternate" href="http://vtnorton.com/" hreflang="pt-br" />
    <!-- Fim do Metadados/SEO -->

    <!-- Tecnologias -->
    <meta charset="utf-8" />
    <link rel="shortcut icon" href="/favicon.ico" />
    <meta name="msapplication-starturl" content="http://www.vtnorton.com/?=ie-starturl" />
    <meta name="msapplication-tooltip" content="Entrar em www.vtnorton.com" />
    <meta name="msapplication-navbutton-color" content="black" />
    <meta name="apple-mobile-web-app-capable" content="yes" />
    <!-- Fim de Tecnologias -->
    <%--    <script type="application/ld+json">
        {
          "@context" : "http://schema.org",
          "@type" : "Person",
          "name" : "Vítor Norton",
          "url": "http://www.vtnorton.com/",
          "sameAs" : [
            "https://www.facebook.com/vitor.norton/",
            "https://instagram.com/vt_norton/",
            "https://twitter.com/vt_norton/",
            "https://www.youtube.com/user/vtnortondev/"
          ]
        }
    </script>--%>
</head>
<body style="height: 100%">
    
    <div class="left-sidebar">
        <header>
            <img src="/images/squarewithborder.png" />
            <h1>Vítor Norton</h1>
        </header>
        <nav>
            <ul>
                <li><a href="#">Projetos</a></li>
                <li><a href="#">Cursos</a></li>
                <li><a href="#">Palestras</a></li>
                <li><a href="#">Contato</a></li>
            </ul>
        </nav>
        <footer>
            <ul>
                <li><a href="https://twitter.com/vt_norton/" target="_blank"><i class="fa fa-twitter fa-2x"></i></a></li>
                <li><a href="https://www.facebook.com/vitor.norton/" target="_blank"><i style="margin-left: 3px" class="fa fa-facebook fa-2x"></i></a></li>
                <li><a href="https://instagram.com/vt_norton/" target="_blank"><i class="fa fa-instagram fa-2x"></i></a></li>
                <li><a href="https://instagram.com/vt_norton/" target="_blank"><i class="fa fa-snapchat-ghost fa-2x"></i></a></li>
                <li><a href="https://instagram.com/vt_norton/" target="_blank"><i class="fa fa-youtube fa-2x"></i></a></li>
                <li><a href="https://github.com/vtnorton/" target="_blank"><i class="fa fa-github fa-2x"></i></a></li>
            </ul>
        </footer>
    </div>
    <div id="container">
        <div id="loader"></div>
    <div id="video"></div>    
        <section id="mainpage-mos">
            <section id="content-mos" class="centered clearfix">
                <!-- Tile 1: Yapp -->
                <a href="#article-1" class="lightbox projects" rel="section">
                    <div class="tile large live" data-stops="0,20%,80%,100%" data-speed="2000" data-delay="1500" data-direction="horizontal" data-stack="true">
                        <div class="live-front">
                            <img class="live-img" src="images/yapp.tile.front.png" alt="Yapp, desenvolvendo aplicativos para você" />
                        </div>
                        <div class="live-back">
                            <img class="live-img" src="images/yapp.tile.back.png" alt="Yapp, desenvolvendo aplicativos para você" />
                        </div>
                        <span class="tile-cat blue">YAPP</span>
                    </div>
                </a>
                <!-- Lightbox Article Preview -->
                <div class="tile-pre">
                    <article id="article-1" class="lb-portfolio">
                        <div class="portfolio-img">
                            <img class="tile-pre-img" src="images/yapp.tile.back.png" alt="YAPP" />
                        </div>
                        <div class="lb-port-cont">
                            <h1 class="lb-project"><a href="http://yapp.vtnorton.com">YAPP</a></h1>
                            <div class="lb-desc">
                                <p>A YAPP têm vários aplicativos publicados na Windows Store. A ídeia por tras deste projeto é criar uma produtora e distribuidora de aplicativos feitos por mim e por meus colegas de trabalho. Conheça os aplicativos lançados no site da YAPP (em inglês).</p>
                                <p><a class="exp-button" href="http://yapp.vtnorton.com">Visitar o site &#8594;</a></p>
                            </div>
                        </div>
                    </article>
                </div>

                <!-- Tile 3: NextCast -->
                <a href="#portfolio-1" class="lightbox projects" rel="section">
                    <div class="tile small live" data-stops="0,30%,75%,75%" data-speed="750" data-delay="2000" data-stack="true">
                        <div class="live-front blue">
                            <img class="live-img" src="images/tile.nextcast.png" alt="Nextcast" />
                        </div>
                        <div class="live-back green">
                            <img class="live-img" src="images/tile.nextcast.back.png" alt="Nextcast" />
                        </div>
                        <span class="tile-cat purple">Nextcast</span>
                    </div>

                </a>
                <!-- Lightbox Article Preview -->
                <div class="tile-pre">
                    <article id="portfolio-1" class="lb-portfolio">
                        <div class="portfolio-img">
                            <img class="live-img" src="images/tile.nextcast.png" alt="Nextcast" />
                        </div>
                        <div class="lb-port-cont">
                            <h1 class="lb-project"><a href="#">Nextcast</a></h1>
                            <div class="lb-desc">
                                <p>Confira o Nextcast, o melhor e mais divertido podcast dedicado a plataformas, produtos e serviços da Microsoft, como Windows, Xbox, Azure, Office e desenvolvimento entre outras coisas. O Nextcast é criação do vNext.com.br!</p>
                                <p><a class="exp-button" href="https://www.mixcloud.com/vNextbr/">Ouça agora &#8594;</a></p>
                            </div>
                        </div>
                    </article>
                </div>

                <!-- Tile 4 -->
                <a href="#portfolio-4" class="lightbox projects" rel="section">
                    <div class="tile small live" data-stops="0,33%,50%" data-speed="1750" data-delay="1000" data-direction="horizontal">
                        <div class="live-front blue">
                            <img class="live-img" src="images/tile.livecoding.tv.png" alt="Livecoding.tv" />
                        </div>
                        <div class="live-back green">
                            <img class="live-img" src="images/tile.livecoding.tv.back.png" alt="Livecoding.tv" />
                        </div>
                        <span class="tile-cat black">livecoding.tv</span>
                    </div>
                </a>
                <!-- Lightbox Article Preview -->
                <div class="tile-pre">
                    <article id="portfolio-4" class="lb-portfolio">
                        <div class="portfolio-img">
                            <img class="tile-pre-img" src="images/tile.livecoding.tv.png" alt="Livecoding.tv" />
                        </div>
                        <div class="lb-port-cont">
                            <h1 class="lb-project"><a href="#">Livecoding.tv</a></h1>
                            <div class="lb-desc">
                                <p>Ultimamente tenho gostado muito da idéia de fazer streaming dos meus códigos e do meu trabalho. Confira o meu canal no livecoding.tv aqui.</p>
                                <p><a class="exp-button" href="https://www.livecoding.tv/vtnorton/">Acessar meu canal &#8594;</a></p>
                            </div>
                        </div>
                    </article>
                </div>

                <!-- Tile 5 -->
                <a href="#portfolio-5" class="lightbox projects" rel="section">

                    <div class="tile small live" data-stops="0,40%" data-direction="horizontal" data-speed="1500" data-delay="1100" data-stack="true">
                        <div class="live-front blue">
                            <img class="live-img" src="images/tile.mvp.png" alt="Microsoft MVP Award" />
                        </div>
                        <div class="live-back green">
                            <img class="live-img" src="images/tile.mvp.back.png" alt="Microsoft MVP Award" />
                        </div>
                    </div>
                </a>
                <!-- Lightbox Article Preview -->
                <div class="tile-pre">
                    <article id="portfolio-5" class="lb-portfolio">
                        <div class="portfolio-img">
                            <img class="tile-pre-img" src="images/tile.mvp.back.png" alt="Microsoft MVP Award" />
                        </div>
                        <div class="lb-port-cont">
                            <h1 class="lb-project"><a href="https://mvp.microsoft.com/en-us/PublicProfile/5001646?fullName=Vitor%20%20Norton">Microsoft MVP Award</a></h1>
                            <div class="lb-desc">
                                <p>Microsoft Most Valuable Professionals, ou MVPs, são líderes comunitários que já demonstraram um compromisso exemplar ao ajudar os outros a obter o máximo de sua experiência com as tecnologias Microsoft. Eles compartilham sua paixão excepcional, o conhecimento do mundo real, e conhecimentos técnicos com a comunidade e com a Microsoft.</p>
                                <p><a class="exp-button" href="https://mvp.microsoft.com/en-us/PublicProfile/5001646?fullName=Vitor%20%20Norton">Veja a página &#8594;</a></p>
                            </div>
                        </div>
                    </article>
                </div>

                <%--                    <!-- Tile 6 -->
                    <a href="#portfolio-7" class="lightbox" rel="section">
                        <div class="tile small">
                            <img class="live-img" src="images/tile.snapchat.png" alt="MIT" />
                        </div>
                    </a>
                    <!-- Lightbox Article Preview -->
                    <div class="tile-pre">
                        <article id="portfolio-7" class="lb-portfolio">
                            <div class="portfolio-img">
                                <img class="tile-pre-img" src="images/tile.snapchat.back.png" alt="MIT" />
                            </div>
                            <div class="lb-port-cont">
                                <h1 class="lb-project"><a href="#">MIT</a></h1>
                                <div class="lb-desc">
                                    <p>--- </p>
                                </div>
                            </div>
                        </article>
                    </div>--%>

                <!-- Tile 9: Garoto de Programa -->
                <a href="#article-9" class="lightbox projects" rel="section">
                    <div class="tile large">
                        <img class="live-img" src="images/tile.garotodeprograma.png" alt="Garoto de programa" />
                    </div>
                </a>
                <!-- Lightbox Article Preview -->
                <div class="tile-pre">
                    <article id="article-9" class="lb-portfolio">
                        <div class="portfolio-img">
                            <img class="tile-pre-img" src="images/tile.garotodeprograma.png" alt="Garoto de programa" />
                        </div>
                        <div class="lb-port-cont">
                            <h1 class="lb-project"><a href="http://garotodeprograma.vtnorton.com">Garoto de programa</a></h1>
                            <div class="lb-desc">
                                <p>Todos os dias no Garoto de Programa eu coloco novas dicas e novos tutoriais sobre programação em si e tudo o que um programador deve saber. O blog vai desde o começo da programação (do Hello World!) até a situações mais complicadas.</p>
                                <p><a class="exp-button" href="http://garotodeprograma.vtnorton.com">Visitar o blog &#8594;</a></p>
                            </div>
                        </div>
                    </article>
                </div>

                <!-- Tile 7: Blog do Norton -->
                <a href="#article-7" class="lightbox projects" rel="section">
                    <div class="tile medium live" data-stops="0,35%,100%,35%,100%" data-speed="1000" data-delay="1800" data-stack="true">
                        <div class="live-front blue">
                            <img class="live-img" src="images/tile.blog.png" alt="Blog do Norton" />
                        </div>
                        <div class="live-back green">
                            <img class="live-img" src="images/tile.blog.back.png" alt="Blog do Norton" />
                        </div>
                    </div>
                </a>
                <!-- Lightbox Article Preview -->
                <div class="tile-pre">
                    <article id="article-7" class="lb-portfolio">
                        <div class="portfolio-img">
                            <img class="tile-pre-img" src="images/tile.blog.small.png" alt="Blog do Norton" />
                        </div>
                        <div class="lb-port-cont">
                            <h1 class="lb-project"><a href="http://blog.vtnorton.com">Blog do Norton</a></h1>
                            <div class="lb-desc">
                                <p>Qual o diferencial deste blog? Qual o segredo? A verdade. A mais pura verdade. Vamos ser sinceros? O máximo possível. Textos da minha mente, na hora que eu penso escrevo. Vamos ter a verdade nua e crua. Um blog sobre meus modus-operantis e meu modus-pensiatis sobre a vida do cotidiano. Espero que gostem.</p>
                                <p><a class="exp-button" href="http://blog.vtnorton.com">Veja o Blog &#8594;</a></p>
                            </div>
                        </div>
                    </article>
                </div>

                <a href="#portfolio-8" class="lightbox projects" rel="section">
                    <div class="tile small live" data-stops="0,75%,100%" data-speed="1500" data-delay="1100" data-stack="true">
                        <div class="live-front blue">
                            <img class="live-img" src="images/tile.onenote.png" alt="Guia definitivo para o OneNote" />
                        </div>
                        <div class="live-back green">
                            <img class="live-img" src="images/tile.onenote.back.png" alt="Guia definitivo para o OneNote" />
                        </div>
                    </div>
                </a>
                <!-- Lightbox Article Preview -->
                <div class="tile-pre">
                    <article id="portfolio-8" class="lb-portfolio">
                        <div class="portfolio-img">
                            <img class="tile-pre-img" src="images/tile.onenote.png" alt="Guia definitivo para o OneNote" />
                        </div>
                        <div class="lb-port-cont">
                            <h1 class="lb-project"><a href="http://vtnorton.com/onenote/" target="_blank">Guia definitivo para o OneNote</a></h1>
                            <div class="lb-desc">
                                <p>OneNote é um caderno virtual de anotações que permite que os usuários criem anotações escritas ou desenhadas e compartilhar ela! E neste eBook GRATUITO você aprenderá a usuar os melhores recursos desta incrível ferramenta.</p>
                                <p><a class="exp-button" href="http://vtnorton.com/onenote/" target="_blank">Baixar o eBook &#8594;</a></p>
                            </div>
                        </div>
                    </article>
                </div>

                <!-- Tile 25: Snapchat -->
                <a href="#portfolio-25" class="lightbox projects" rel="section">
                    <div class="tile small">
                        <img class="live-img" src="images/tile.snapchat.png" alt="Snapchat: vtnorton" />
                    </div>
                </a>
                <!-- Lightbox Article Preview -->
                <div class="tile-pre">
                    <article id="portfolio-25" class="lb-portfolio">
                        <div class="portfolio-img">
                            <img class="tile-pre-img" src="images/tile.snapchat.back.png" alt="Snapchat: vtnorton" />
                        </div>
                        <div class="lb-port-cont">
                            <h1 class="lb-project"><a href="https://www.snapchat.com/add/vtnorton">Snapchat: vtnorton</a></h1>
                            <div class="lb-desc">
                                <p>Tudo bem que ainda não temos snapchat no Windows Phone, mas isso não significa que eu não estaja por aqui! Da uma conferida nos meus últimos snaps, acabo revelando as novidades primeiro lá!</p>
                                <p><a class="exp-button" href="https://www.snapchat.com/add/vtnorton">Siga-me &#8594;</a></p>
                            </div>
                        </div>
                    </article>
                </div>

                <!-- Tile 26: Facebook -->
                <a href="#portfolio-26" class="lightbox projects" rel="section">
                    <div class="tile small">
                        <img class="live-img" src="images/tile.facebook.png" alt="Facebook: vitor.norton" />
                    </div>
                </a>
                <!-- Lightbox Article Preview -->
                <div class="tile-pre">
                    <article id="portfolio-26" class="lb-portfolio">
                        <div class="portfolio-img">
                            <img class="tile-pre-img" src="images/tile.facebook.png" alt="Facebook: vitor.norton" />
                        </div>
                        <div class="lb-port-cont">
                            <h1 class="lb-project"><a href="http://facebook.com/vitor.norton">Facebook: vitor.norton</a></h1>
                            <div class="lb-desc">
                                <p>Como não poderia estar no Facebook? Sério, como? Ainda não curtiu minha página do Facebook, então curte lá! Vai lá! Tô esperando... Ok, já curtiu né? Vamos! Aee, agora sim! Valeu!</p>
                                <p><a class="exp-button" href="http://facebook.com/vitor.norton">Curte lá &#8594;</a></p>
                            </div>
                        </div>
                    </article>
                </div>

                <!-- Tile 27: Twitter -->
                <a href="#portfolio-27" class="lightbox projects" rel="section">
                    <div class="tile small">
                        <img class="live-img" src="images/tile.twitter.png" alt="@vt_norton" />
                    </div>
                </a>
                <!-- Lightbox Article Preview -->
                <div class="tile-pre">
                    <article id="portfolio-27" class="lb-portfolio">
                        <div class="portfolio-img">
                            <img class="tile-pre-img" src="images/tile.twitter.png" alt="@vt_norton" />
                        </div>
                        <div class="lb-port-cont">
                            <h1 class="lb-project"><a href="https://www.twitter.com/vt_norton">@vt_norton</a></h1>
                            <div class="lb-desc">
                                <p>Quer saber das novidades antes de todo mundo? Siga no Snap! Quer ficar por dentro dos cursos, vídeos e ebooks, curte a página... O Twitter? Bem, o Twitter... É onde eu falo besteira. Siga-me lá. Veja as baboseiras que eu penso.</p>
                                <p><a class="exp-button" href="https://www.twitter.com/vt_norton">Segue lá! &#8594;</a></p>
                            </div>
                        </div>
                    </article>
                </div>
            </section>
        </section>
    </div>

    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.1/jquery.min.js" type="text/javascript"></script>
    <script src="/js/jquery.youtubebackground.js" type="text/javascript"></script>
    <script src="/js/jquery.masonry.min.js" type="text/javascript"></script>
    <script src="/js/jquery.easing.1.3.js" type="text/javascript"></script>
    <script src="/js/MetroJs.lt.js" type="text/javascript"></script>
    <script src="/js/jquery.flexslider-min.js" type="text/javascript" charset="utf-8"></script>
    <script src="/js/hoverintent.js" type="text/javascript" charset="utf-8"></script>
    <script src="/js/javascript.js" type="text/javascript"></script>
    <script>
        (function (i, s, o, g, r, a, m) {
            i['GoogleAnalyticsObject'] = r; i[r] = i[r] || function () {
                (i[r].q = i[r].q || []).push(arguments)
            }, i[r].l = 1 * new Date(); a = s.createElement(o),
            m = s.getElementsByTagName(o)[0]; a.async = 1; a.src = g; m.parentNode.insertBefore(a, m)
        })(window, document, 'script', 'https://www.google-analytics.com/analytics.js', 'ga');

        ga('create', 'UA-50145252-1', 'auto');
        ga('send', 'pageview');

    </script>
    <script async src="//pagead2.googlesyndication.com/pagead/js/adsbygoogle.js"></script>
    <script>
        (adsbygoogle = window.adsbygoogle || []).push({
            google_ad_client: "ca-pub-5584056449430370",
            enable_page_level_ads: true
        });
    </script>
    <script>
        jQuery(function ($) {
            $('#video').YTPlayer({
                fitToBackground: true,
                videoId: 'LSmgKRx5pBo'
            });
        });
    </script>
</body>
</html>

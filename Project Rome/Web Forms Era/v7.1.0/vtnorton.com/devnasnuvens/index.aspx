<%@ Page Language="C#" AutoEventWireup="false" CodeBehind="index.aspx.cs" Inherits="VTNORTON.devnasnuvens.index" %>

<!DOCTYPE html>
<!--[if lt IE 7]>      <html class="no-js lt-ie9 lt-ie8 lt-ie7"> <![endif]-->
<!--[if IE 7]>         <html class="no-js lt-ie9 lt-ie8"> <![endif]-->
<!--[if IE 8]>         <html class="no-js lt-ie9"> <![endif]-->
<!--[if gt IE 8]><!-->
<html xmlns="http://www.w3.org/1999/xhtml"
xmlns:fb="http://ogp.me/ns/fb#">
<!--<![endif]-->
<head>

    <title>#DevNasNuvens - 20/08 em Vitória - ES</title>

    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
    <%-- NÃO APAGAR, EVENTOS FUTUROS, REFERENCIA (NOME DO TEMPLATE) <meta name="description" content="Evential - One Page Event HTML Template">--%>
    <meta name="description" content="O evento gratuito #DevNasNuvens ocorrerá das 13 horas até as 18 horas, no dia 20 de agosto em Vitória – ES." />
    <meta name="author" content="Vítor Norton" />

    <!-- viewport settings -->
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no" />
    <meta property="og:image" content="http://vtnorton.com/devnasnuvens/img/LinkImage.jpg" />


    <!-- CSS -->
    <link rel="stylesheet" href="/devnasnuvens/css/bootstrap.css" />
    <link rel="stylesheet" href="/devnasnuvens/css/font-awesome.min.css" />
    <link rel="stylesheet" href="/devnasnuvens/css/jquery.countdown.css" />
    <link rel="stylesheet" href="/devnasnuvens/css/magnific-popup.css" />
    <link rel="stylesheet" href="/devnasnuvens/css/flipCard.css" />
    <link rel="stylesheet" href="/devnasnuvens/css/owl.carousel.css" />
    <link rel="stylesheet" href="/devnasnuvens/css/owl.theme.css" />
    <link rel="stylesheet" href="/devnasnuvens/css/main.css" />
    <link id="main-style" rel="stylesheet" href="/devnasnuvens/css/color/green.css" />


    <!-- Font -->
    <link href='http://fonts.googleapis.com/css?family=Economica:400,700' rel='stylesheet' type='text/css' />

    <!-- Favicon -->
    <link rel="apple-touch-icon" sizes="180x180" href="apple-touch-icon.png?v=9CbybKbHGb" />
    <link rel="icon" type="image/png" href="favicon-32x32.png?v=9CbybKbHGb" sizes="32x32" />
    <link rel="icon" type="image/png" href="favicon-16x16.png?v=9CbybKbHGb" sizes="16x16" />
    <link rel="manifest" href="manifest.json?v=9CbybKbHGb" />
    <link rel="mask-icon" href="safari-pinned-tab.svg?v=9CbybKbHGb" color="#5bbad5" />
    <link rel="shortcut icon" href="favicon.ico?v=9CbybKbHGb" />
    <meta name="theme-color" content="#ffffff" />
</head>
<body>
    <!-- NAVIGATION -->
    <nav class="navbar navbar-fixed-top navbar-custom" role="navigation">
        <!-- We use the fluid option here to avoid overriding the fixed width of a normal container within the narrow content columns. -->
        <div class="container">
            <div data-scroll-header class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#nav"><span class="sr-only">Toggle navigation</span> <span class="icon-bar"></span><span class="icon-bar"></span><span class="icon-bar"></span></button>
                <a class="navbar-brand" href="#">
                    <img src="/devnasnuvens/img/logo.png" style="max-height: 20px; margin-top: 12px" alt="logo" />
                </a>
            </div>
            <div class="collapse navbar-collapse" id="nav">
                <ul class="nav navbar-nav navbar-right uppercase">
                    <li><a data-scroll href="#overview">Visão geral</a></li>
                    <li><a data-scroll href="#speakers">Palestrantes</a></li>
                    <li><a data-scroll href="#register">Registrar</a></li>
                    <li><a data-scroll href="#schedule">Inscrição</a></li>
                    <li><a data-scroll href="#venue">Local</a></li>
                    <li><a data-scroll href="#sponsors">Patrocinadores</a></li>
                    <li><a data-scroll href="#contact">Contato</a></li>
                </ul>
            </div>
            <!-- /.navbar-collapse -->
        </div>
    </nav>
    <!-- TOP -->
    <section id="top" data-stellar-background-ratio="0.5">
        <div class="countdown">
            <div class="container">
                <div class="row">
                    <div class="col-lg-8 col-lg-offset-2 text-center">
                        <%--<img src="/devnasnuvens/img/logo.png">--%>
                    </div>
                    <div class="col-md-4 col-lg-4 col-md-offset-4 text-center" style="text-shadow: 0 0 8px #000">
                        <%--<div id="countdown"></div>--%>
                        <%--<h3>27 de Agosto de 2016 em Vitória - ES</h3>--%>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- OVERVIEW -->
    <section id="overview">
        <div class="container">
            <div class="row">
                <div class="col-lg-10 col-lg-offset-1 text-center">
                    <i class="fa fa-4x fa-globe"></i>
                    <h2 class="uppercase">sobre o evento</h2>
                    <p class="lead">
                        O evento gratuito #DevNasNuvens vem apresentar as melhores práticas, produtos e serviços para interessados em tecnologias como desenvolvedores de software, profissionais de infraestruturas, gestores e tomadores de decisão, e demais interessados. 
                    </p>
                    <p class="lead">
                        O evento será realizado no dia 20 de agosto, em Vitória - ES, nas dependências do Centro Universitário Católico de Vitória (Salesiana). Serão oferecidas aos participantes 14 palestras, totalizando mais de 12 horas de conteúdo e informação sobre desenvolvimento de soluções em CloudFirst. Os palestrantes convidados são profissionais da área, tanto do mundo open-source como do mundo Microsoft!
                    </p>
                </div>
                <div class="col-lg-8 col-lg-offset-2 text-center">
                    <a class="button button-big button-dark" data-scroll href="#register">Faça sua inscrição</a>
                </div>
            </div>
        </div>
    </section>
    <!-- SPEAKERS -->
    <section id="speakers">
        <div class="container">
            <div class="row">
                <div class="col-lg-10 col-lg-offset-1">
                    <h2 class="uppercase text-center">palestrantes</h2>
                    <div class="row">
                        <!-- speaker 1 -->
                        <div class="speaker col-xs-12 col-sm-4 col-md-4 col-lg-4">
                            <figure>
                                <img class="img-responsive" src="/devnasnuvens/img/norton.jpg" alt="" />
                                <figcaption>
                                    <p>Microsoft MVP (2015) e Windows Insider MVP, desenvolvedor de aplicativos para Windows como o Formula Universal Code Editor e Random 42 e web design, basicamente, um garoto de programa.</p>
                                </figcaption>
                            </figure>
                            <h4>Vítor Norton</h4>
                            <span class="title">Desenvolvedor Mobile - Windows Insider MVP</span>
                        </div>
                        <div class="speaker col-xs-12 col-sm-4 col-md-3 col-lg-4">
                            <figure>
                                <img class="img-responsive" src="/devnasnuvens/img/yanaga.jpg" alt="" />
                                <figcaption>
                                    <p>Edson Yanaga, Diretor de Experiência do Desenvolvedor da Red Hat, é Java Champion e Microsoft MVP. Também é um autor reconhecido internacionalmente e palestrante frequente em eventos internacionais, discutindo Java, Cloud Computing, DevOps, Microservices e Software Craftsmanship.</p>
                                </figcaption>
                            </figure>
                            <h4>Edson Yanaga</h4>
                            <span class="title">Diretor de Experiência do Desenvolvedor da Red Hat</span>
                        </div>
                        <div class="speaker col-xs-12 col-sm-4 col-md-3 col-lg-4">
                            <figure>
                                <img class="img-responsive" src="/devnasnuvens/img/giggio.jpg" alt="" />
                                <figcaption>
                                    <p>Arquiteto e desenvolvedor, agilista, pai, filho, marido, escalador, ciclista. Foi reconhecido como Microsoft MVP, participa do .Net Architects, grava o podcast Tecnoretórica, escreve posts no blog e fala o que bem entende no twitter @giovannibassi. Giovanni é agilista e trouxe os programas de certificação e treinamento da Scrum.org pro Brasil. Junto com alguns amigos criou a Lambda3, que insiste em fazer projetos e consultoria direito. </p>
                                </figcaption>
                            </figure>
                            <h4>Giovanni Bassi</h4>
                            <span class="title">CRO na Lambda3</span>
                        </div>
                    </div>
                    <div class="row">
                        <div class="speaker col-xs-12 col-sm-4 col-md-3 col-lg-4">
                            <figure>
                                <img class="img-responsive" src="/devnasnuvens/img/victor2.jpg" alt="" />
                                <figcaption>
                                    <p>Desenvolvedor, Harcore Gamer aficionado, escalador e mais recentemente: empreendedor. Trabalhando com métodos ágeis desde 2004, já viu várias empresas falirem. Depois de inúmeras tentativas "in company" de mudança cultural, cansou de trabalhar para os outros e decidiu o óbvio: fazer a própria empresa dar certo. Assim nasceu a Lambda3, empresa multidisciplinar que atualmente possui projetos Ágeis de diversos tamanhos entregando valor de negócio com inovação e muito bom humor. Victor também é maluco o bastante para acreditar que é possível um mundo sem gerentes. Neste momento, Victor é um dos diretores do Board da Agile Alliance Global, e conselheiro da Agile Alliance Brazil.</p>
                                </figcaption>
                            </figure>
                            <h4>Victor Hugo Germano</h4>
                            <span class="title">Desenvolvedor - Lambda 3</span>
                        </div>
                        <div class="speaker col-xs-12 col-sm-4 col-md-3 col-lg-4">
                            <figure>
                                <img class="img-responsive" src="/devnasnuvens/img/thommy.jpg" alt="" />
                                <figcaption>
                                    <p>Sócio-diretor da Ease Media – Assessoria e Marketing Digital, atua com mídias digitais há 11 anos tendo trabalhado em diversas agências do ES e de Curitiba e em IES como UFES, UFPR e UFMS. Atualmente focado em consultoria de empresas e no terceiro setor.</p>
                                </figcaption>
                            </figure>
                            <h4>Thommy Lacerda Sossai</h4>
                            <span class="title">Diretor - EASE MEDIA Assessoria e marketing social</span>
                        </div>
                        <div class="speaker col-xs-12 col-sm-4 col-md-3 col-lg-4">
                            <figure>
                                <img class="img-responsive" src="/devnasnuvens/img/jonathan.jpg" alt="" />
                                <figcaption>
                                    <p>Programador, escritor e palestrante. Autor do livro CodeIgniter - Produtividade na criação de aplicações web em PHP e do ebook PHP 7 - Mudanças e Novidades. Criador do portal Universidade CodeIgniter e colunista do iMasters e Oficina da Net.</p>
                                </figcaption>
                            </figure>
                            <h4>Jonathan Lamim Antunes</h4>
                            <span class="title">CEO - JLamim</span>
                        </div>
                    </div>
                    <div class="row">
                        <div class="speaker col-xs-12 col-sm-4 col-md-3 col-lg-4">
                            <figure>
                                <img class="img-responsive" src="/devnasnuvens/img/renan.jpg" alt="" />
                                <figcaption>
                                    <p>Graduando em Sistemas de Informação, Professor de Informática e Jogos Digitais, trabalho com um projeto da FAPES sobre desenvolvimento de jogos com alunos do Ensino Médio de escola pública. Para mim o desenvolvimento de jogos não é apenas um trabalho, mas como uma forma de diversão já que desde pequeno eu jogava todos os jogos possíveis. Hoje como desenvolvedor posso criar o que sempre me fez feliz Jogos.</p>
                                </figcaption>
                            </figure>
                            <h4>Renan Duarte</h4>
                            <span class="title">Instrutor - Softmark</span>
                        </div>
                        <div class="speaker col-xs-12 col-sm-4 col-md-3 col-lg-4">
                            <figure>
                                <img class="img-responsive" src="/devnasnuvens/img/tiago.jpg" alt="" />
                                <figcaption>
                                    <p>Tiago Ribeiro Santos é programador e desenvolvedor de soluções com Arduino, hobbysta apaixonado em eletrônica nas horas vagas. Já ministrou aulas e palestras de Robótica com hardware livre em eventos como: LatinoWare (Conferência Latino Americana de Software Livre), Revista Espírito Livre, Arduino Day, UFPE e no IFES. Amante da linguagem Python, é fundador do grupo de usuários de Arduino no Espírito Santo.</p>
                                </figcaption>
                            </figure>
                            <h4>Tiago Ribeiro Santos</h4>
                            <span class="title">Sócio-Programador - BeeSet Soluções Tecnológicas</span>
                        </div>
                        <div class="speaker col-xs-12 col-sm-4 col-md-3 col-lg-4">
                            <figure>
                                <img class="img-responsive" src="/devnasnuvens/img/guilherme.jpg" alt="" />
                                <figcaption>
                                    <p>Universitário, Pythonista, Arduineiro e amante de tecnologia. Gosto de conhecer novas pessoas e conversar bastante!</p>
                                </figcaption>
                            </figure>
                            <h4>Guilherme Mauro</h4>
                            <span class="title">Estudante - Ufes</span>
                        </div>
                    </div>
                    <div class="row">
                        <div class="speaker col-xs-12 col-sm-4 col-md-3 col-lg-4">
                            <figure>
                                <img class="img-responsive" src="/devnasnuvens/img/mikael.jpg" alt="" />
                                <figcaption>
                                    <p>Mikael Hadler, possui formação técnica como Técnico em informática e Técnico em redes de computadores, aluno de Análise e Desenvolvimento de Sistemas na  FAESA. Tem experiência com desenvolvimento web com foco em soluções livres, atua no cenário local fomentando o uso de tecnologias livres e a dois anos colaborador da Revista Espirito Livre</p>
                                </figcaption>
                            </figure>
                            <h4>Mikael Hadler</h4>
                            <span class="title">Desenvolvedor Web</span>
                        </div>
                        <div class="speaker col-xs-12 col-sm-4 col-md-3 col-lg-4">
                            <figure>
                                <img class="img-responsive" src="/devnasnuvens/img/leonardo.JPG" alt="" />
                                <figcaption>
                                    <p>Cofundador da WINGS Holding, e Clay - Consultoria em Marketing e Comunicação. Está empreendendo também o Horizon, iniciativa que tem o objetivo de desenvolver ensino de ciência e tecnologia no país.</p>
                                </figcaption>
                            </figure>
                            <h4>Leonardo Hora</h4>
                            <span class="title">Empreendedor no Horizon, e Clay</span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <div id="register">
        <div class="container">
            <div class="row">
                <div class="col-lg-8 col-lg-offset-2" style="text-shadow: 0 0 8px #000">
                    <h3 class="text-center">Faça sua inscrição GRATUITAMENTE!</h3>
                    <div class="col-lg-8 col-lg-offset-2 text-center">
                        <a class="button button-big button-light" data-scroll href="https://onedrive.live.com/redir?page=survey&resid=EF627BED23A6EF8C!590398&authkey=!ABnx_ttKvdLgnRM&ithint=file%2cxlsx">Faça sua inscrição</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- SCHEDULE -->
    <section id="schedule">
        <div class="container">
            <div class="row">
                <div class="col-lg-10 col-lg-offset-1">
                    <h2 class="uppercase text-center">Agenda</h2>
                    <div id="timetable2" class="owl-carousel owl-theme">
                        <!-- DAY 1 -->
                        <div class="item">
                            <div class="event">
                                <div class="event-inner">
                                    <div class="icon"><i class="fa fa-2x fa-clock-o"></i><span class="time">13:00</span> </div>
                                    <div class="description">
                                        <h3>Introdução</h3>
                                        <p>Na abertura do evento vai ser falado sobre a cultura "DOER" e sobre como isso afeta o trabalho e pode vir a deixar o profissional nas nuvens. Também será discutido a aproximação da Microsoft com o mundo open-source.</p>
                                        <span class="name">Vítor Norton, Edson Yanaga, Jonathan Lamim</span>
                                    </div>
                                </div>
                            </div>
                            <div class="event">
                                <div class="event-inner">
                                    <div class="icon"><i class="fa fa-2x fa-clock-o"></i><span class="time">14:00</span> </div>
                                    <div class="description">
                                        <h3>DevOps e Containers: como o Open Source está mudando a entrega de software</h3>
                                        <p>Nesse novo mundo com novos modelos econômicos surgindo nós temos que entregar software em produção cada vez melhor, mais rápido e de modo mais seguro. DevOps é o movimento atual para conseguirmos alcançar esse objetivo, e Containers é uma das tecnologias que fazem parte de toda essa inovação. Venha aprender como Containers e diversas ferramentas Open Source estão habilitando o movimento de DevOps para entregar software mais rápido em produção.</p>
                                        <span class="name">Edson Yanaga</span>
                                    </div>
                                </div>
                            </div>
                        </div>

                    </div>
                    <div id="days" class="owl-carousel">
                        <div class="item uppercase">
                            <h4 class="uppercase hidden-xs">SALA 1</h4>
                        </div>
                        <div class="item uppercase">
                            <h4 class="uppercase hidden-xs">SALA 2</h4>
                        </div>
                        <div class="item uppercase">
                            <h4 class="uppercase hidden-xs">LAB 1</h4>
                        </div>
                        <div class="item uppercase">
                            <h4 class="uppercase hidden-xs">LAB 2</h4>
                        </div>

                    </div>
                    <div id="timetable" class="owl-carousel owl-theme">
                        <!-- DAY 1 -->
                        <div id="day1" class="item">
                            <div class="event">
                                <div class="event-inner">
                                    <div class="icon"><i class="fa fa-2x fa-clock-o"></i><span class="time">15:00</span> </div>
                                    <div class="description">
                                        <h3>Windows Insider e a importância do feedback para os devs</h3>
                                        <p>A pouco tempo, a Microsoft mudou toda a sua cultura de desenvolvimento adicionando o principal programa de Feedbacks: O Windows Insider. Veja o que mudou desde então e descubra como os usuários moldaram o Windows 10 e seus aplicativos.</p>
                                        <span class="name">Vítor Norton</span>
                                    </div>
                                </div>
                            </div>
                            <div class="event">
                                <div class="event-inner">
                                    <div class="icon"><i class="fa fa-2x fa-clock-o"></i><span class="time">16:00</span> </div>
                                    <div class="description">
                                        <h3>Empreendedorismo e Marketing Digital</h3>
                                        <p>Trataremos do Marketing Digital aplicado ao empreendedor apresentando seus conceitos e soluções clássicas e inovadoras dos problemas comumente encontrados como a identificação e construção do público-alvo, criação de personas, quanto investir, em quais redes atuar, e muitas outras.</p>
                                        <span class="name">Thommy Lacerda Sossai</span>
                                    </div>
                                </div>
                            </div>
                            <div class="event">
                                <div class="event-inner">
                                    <div class="icon"><i class="fa fa-2x fa-clock-o"></i><span class="time">17:00</span> </div>
                                    <div class="description">
                                        <h3>Métricas que importam</h3>
                                        <p>Quem nunca ouviu um gerente de sistemas dizendo que quer "medir a produtividade" do time? Geralmente isso começa pela medição de linhas de código por dia ou por bugs encontrados - que, francamente, não dizem absolutamente nada sobre seu time! Quer conhecer uma alternativa? Então venha ver com as Métricas Lean, aplicadas a seus times de desenvolvimento, podem ajuda-lo a coletar informações que realmente tem sentido e que podemos ajudar na melhoria do seu time e de seu processo de desenvolvimento.</p>
                                        <span class="name">Victor Hugo Germano</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!-- DAY 2 -->
                        <div id="day2" class="item">
                            <div class="event">
                                <div class="event-inner">
                                    <div class="icon"><i class="fa fa-2x fa-clock-o"></i><span class="time">15:00</span> </div>
                                    <div class="description">
                                        <h3>Release contínuo de um microsserviço com Docker, ASP.NET Core e Azure Container Services</h3>
                                        <p>Com o ASP.NET agora rodando no Linux, com o ASP.NET Core, podemos também publicar aplicações em contêineres Docker. Nessa palestra vamos ver como funciona um processo de release contínuo de um microsserviço utilizando Docker em uma app ASP.NET Core</p>
                                        <span class="name">Giovanni Bassi</span>
                                    </div>
                                </div>
                            </div>
                             <div class="event">
                                <div class="event-inner">
                                    <div class="icon"><i class="fa fa-2x fa-clock-o"></i><span class="time">16:00</span> </div>
                                    <div class="description">
                                        <h3>Desenvolvimento de jogos utilizando Unity</h3>
                                        <p>Nessa palestra será falado sobre o mercado de jogos; como é o desenvolvimento no Brasil e a utilização da ferramenta Unity, que é a mais usada pelos desenvolvedores indie.</p>
                                        <span class="name">Renan Duarte</span>
                                    </div>
                                </div>
                            </div>
                            <div class="event">
                                <div class="event-inner">
                                    <div class="icon"><i class="fa fa-2x fa-clock-o"></i><span class="time">17:00</span> </div>
                                    <div class="description">
                                        <h3>Rasberry Pi como servidor de baixo custo para aplicações web</h3>
                                        <p>Nesta abordagem, iremos aprender como utilizar uma plataforma cloud para controlar dispositivos embarcados, para esta abordagem iremos criar um servidor de teste para aplicações web utilizando o Raspberry Pi.</p>
                                        <span class="name">Mikael Hadler</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!-- DAY 3 -->
                        <div id="day3" class="item">
                            <div class="event">
                                <div class="event-inner">
                                    <div class="icon"><i class="fa fa-2x fa-clock-o"></i><span class="time">15:00</span> </div>
                                    <div class="description">
                                        <h3>Arduino e Cultura Maker: Seja um inventor!	</h3>
                                        <p>A palestra aborda conceitos da apresentação do movimento maker no Brasil e no mundo. E como qualquer pessoa pode criar suas próprias invenções através de plataformas livres e de hardware aberto como o Arduino. Será abordado conceitos básicos de introdução ao hardware e apresentação de alguns projetos open source com Arduino. Seja mais um criador e invente!</p>
                                        <span class="name">Tiago Ribeiro Santos + Leonardo Hora</span>
                                    </div>
                                </div>
                            </div>
                            <div class="event">
                                <div class="event-inner">
                                    <div class="icon"><i class="fa fa-2x fa-clock-o"></i><span class="time">16:00 - 18:00</span> </div>
                                    <div class="description">
                                        <h3>Mini-curso: Programe robôs para a batalha com a ferramenta Robocode!</h3>
                                        <p>O minicurso consiste em apresentação da plataforma de programação de robôs para combate em ambiente virtual, para a introdução de conceitos do ensino de programação e lógica para iniciantes na linguagem JAVA. Também é visto uma apresentação do que é inteligência artificial com a utilização do Robocode.	</p>
                                        <span class="name">Tiago Ribeiro Santos</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!-- DAY 4 -->
                        <div id="day4" class="item">
                            <div class="event">
                                <div class="event-inner">
                                    <div class="icon"><i class="fa fa-2x fa-clock-o"></i><span class="time">15:00 - 18:00</span> </div>
                                    <div class="description">
                                        <h3>Minicurso: Introdução ao OpenCV e Python: Mensurando dimensões com visão computacional</h3>
                                        <p>O participante irá conhecer a principal ferramenta open source para visão computacional. Serão apresentandos exemplos de aplicações e desenvolveremos um algoritmo para mensurar dimensões de objetos utilizando este recurso juntamente com o Python.</p>
                                        <span class="name">Guilherme Mauro</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- VENUE -->
    <section id="venue">
        <div class="venue">
            <div class="container">
                <div class="row">
                    <div class="venue-address">
                        <h2 class="uppercase">local</h2>
                        <p>
                            O evento será realizado no Centro Universitário Católico de Vitória (Salesiana)
                        </p>
                        <p class="address">
                            <i class="fa fa-2x fa-map-marker fa-inverse"></i>Av Vitória, 950, Forte São João<br>
                            Vitória-ES
                        </p>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- SPONSORS -->
    <section id="sponsors">
        <div class="container">
            <div class="row">
                <div class="col-lg-12 text-center">
                    <h2 class="uppercase">Patrocinadores</h2>
                    <div class="sponsor-slider">
                        <a href="http://www.catolicasuperior.com.br/">
                            <img class="img-responsive" src="/devnasnuvens/img/salesiana.png" alt="logo" /></a>
                        <a href="http://www.lambda3.com.br/">
                            <img class="img-responsive" style="max-width:140px" src="/devnasnuvens/img/lambda3.png" alt="logo" /></a>
                        <a href="http://www.beeset.com.br/">
                            <img class="img-responsive" src="/devnasnuvens/img/beeset.jpg" alt="logo" /></a>
                        <a href="http://www.mindworks.com.br/">
                            <img class="img-responsive" src="/devnasnuvens/img/mindworks.png" alt="logo" /></a>
                        <a href="https://www.redhat.com/">
                            <img class="img-responsive" src="/devnasnuvens/img/redhat.png" alt="logo" /></a>
                        <a href="http://www.learning365.com.br/">
                            <img class="img-responsive" src="/devnasnuvens/img/elaearning.png" alt="logo" />
                        </a>
                    </div>
                    <hr />
                    <p class="lead uppercase">Seja um patrocinador</p>
                    <a class="button button-dark" href="mailto:contato@vtnorton.com?Subject=Quero%20ser%20um%20patrocinador%20no%20seu%20evento">Peça informações</a>
                </div>
            </div>
        </div>
    </section>
    <!-- SUBSCRIBE -->

    <!-- CONTACT -->
    <section id="contact">
        <!-- map -->
        <div id="gmap_canvas"></div>
        <div class="container">
            <div class="row">
                <div class="col-md-4 col-lg-4">
                    <div class="contact">
                        <h2 class="uppercase">contato</h2>
                        <p>Fique a vontade para entrar em contato por qualquer motivo, seja dúvida em relação ao evento, seja sobre a inscrição ou sobre caranvanas para o evento.</p>
                        <p class="address">
                            Av Vitória, 950, Forte São João, Vitória-ES<br />
                            <br />
                            contato@vtnorton.com
                            <br />
                            (28) 98114-1657
                        </p>
                        <div class="social">
                            <a href="#"><span class="fa-stack fa-lg"><i class="fa fa-circle fa-stack-2x"></i><i class="fa fa-twitter fa-stack-1x fa-inverse"></i></span></a>
                            <a href="http://twitter.com/vt_norton"><span class="fa-stack fa-lg"><i class="fa fa-circle fa-stack-2x"></i><i class="fa fa-facebook fa-stack-1x fa-inverse"></i></span></a>
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- modernizr -->
    <script src="/devnasnuvens/js/modernizr.custom.00695.js"></script>
    <script src="/devnasnuvens/js/jquery-1.11.0.min.js"></script>
    <script type="text/javascript" src="http://maps.google.com/maps/api/js?sensor=false"></script>
    <script src="/devnasnuvens/js/bootstrap.min.js"></script>
    <script src="/devnasnuvens/js/jquery.countdown.js"></script>
    <script src="/devnasnuvens/js/owl.carousel.min.js"></script>
    <script src="/devnasnuvens/js/jquery.magnific-popup.min.js"></script>
    <script src="/devnasnuvens/js/jquery.countTo.js"></script>
    <script src="/devnasnuvens/js/flipCard.js"></script>
    <script src="/devnasnuvens/js/jquery.stellar.min.js"></script>
    <script src="/devnasnuvens/js/smooth-scroll.js"></script>
    <script src="/devnasnuvens/js/retina-1.1.0.min.js"></script>
    <script src="/devnasnuvens/js/main.js"></script>
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
</body>
</html>

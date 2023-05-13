<%@ Page Title="FAQ - Perguntas e respostas frequentes | Vítor Norton" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="faq.aspx.cs" Inherits="VTNORTON.FAQ" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/css/faq-css.css" rel="stylesheet" />
    <style>
        img {
            max-height: 200px;
        }
    </style>
    <meta name="description" content="Para cada pergunta existe uma resposta, veja as respostas para as perguntas não tão frequentes assim!" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="cd-faq">
        <ul class="cd-faq-categories">
            <li><a class="selected" href="#dev"><%=VTNORTON.Resources.faq.Dev %></a></li>
            <li><a href="#about"><%=VTNORTON.Resources.faq.About %></a></li>
            <li><a href="#apps"><%=VTNORTON.Resources.faq.Apps %></a></li>
            <li><a href="#sites"><%=VTNORTON.Resources.faq.Sites %></a></li>
            <li><a href="#others"><%=VTNORTON.Resources.faq.Others %></a></li>
        </ul>
        <div class="cd-faq-items">
            <ul id="dev" class="cd-faq-group">
                <li class="cd-faq-title">
                    <h2><%=VTNORTON.Resources.faq.Dev %></h2>
                </li>
                <li>
                    <a class="cd-faq-trigger" href="#0"><%=VTNORTON.Resources.faq.Q01Dev %></a>
                    <div class="cd-faq-content">
                        <p><%=VTNORTON.Resources.faq.R01 %></p>
                    </div>
                </li>
                <li>
                    <a class="cd-faq-trigger" href="#0"><%=VTNORTON.Resources.faq.Q02Dev %></a>
                    <div class="cd-faq-content">
                        <p><%=VTNORTON.Resources.faq.R02 %></p>
                    </div>
                </li>
                <li>
                    <a class="cd-faq-trigger" href="#0"><%=VTNORTON.Resources.faq.Q03Dev %></a>
                    <div class="cd-faq-content">
                        <p><%=VTNORTON.Resources.faq.R03 %></p>
                    </div>
                </li>
            </ul>
            <ul id="apps" class="cd-faq-group">
                <li class="cd-faq-title">
                    <h2><%=VTNORTON.Resources.faq.Apps %></h2>
                </li>
            
                <li>
                    <a class="cd-faq-trigger" href="#0"><%=VTNORTON.Resources.faq.Q04App %></a>
                    <div class="cd-faq-content">
                        <p><%=VTNORTON.Resources.faq.R04 %></p>
                    </div>
                </li>

            </ul>
            <ul id="about" class="cd-faq-group">
                <li class="cd-faq-title">
                    <h2><%=VTNORTON.Resources.faq.About %></h2>
                </li>
                <li>
                    <a class="cd-faq-trigger" href="#0"><%=VTNORTON.Resources.faq.Q05About %></a>
                    <div class="cd-faq-content">
                        <p><%=VTNORTON.Resources.faq.R05 %></p>
                    </div>
                </li>
                <li>
                    <a class="cd-faq-trigger" href="#0"><%=VTNORTON.Resources.faq.Q06About %></a>
                    <div class="cd-faq-content">
                        <p><%=VTNORTON.Resources.faq.R06 %></p>
                    </div>
                </li>
                <li>
                    <a class="cd-faq-trigger" href="#0"><%=VTNORTON.Resources.faq.Q07About %></a>
                    <div class="cd-faq-content">
                        <p><%=VTNORTON.Resources.faq.R07 %></p>
                    </div>
                </li>
                <li>
                    <a class="cd-faq-trigger" href="#0"><%=VTNORTON.Resources.faq.Q08About %></a>
                    <div class="cd-faq-content">
                        <p><%=VTNORTON.Resources.faq.R08 %></p>
                    </div>
                </li>
                <li>
                    <a class="cd-faq-trigger" href="#0"><%=VTNORTON.Resources.faq.Q09About %></a>
                    <div class="cd-faq-content">
                        <p><%=VTNORTON.Resources.faq.R09 %></p>
                    </div>
                </li>
                <li>
                    <a class="cd-faq-trigger" href="#0"><%=VTNORTON.Resources.faq.Q10About %></a>
                    <div class="cd-faq-content">
                        <p><%=VTNORTON.Resources.faq.R10 %></p>
                    </div>
                </li>
            </ul>

            <ul id="sites" class="cd-faq-group">
                <li class="cd-faq-title">
                    <h2><%=VTNORTON.Resources.faq.Sites %></h2>
                </li>
                <li>
                    <a class="cd-faq-trigger" href="#0"><%=VTNORTON.Resources.faq.Q11Site %></a>
                    <div class="cd-faq-content">
                        <p><%=VTNORTON.Resources.faq.R11 %></p>
                    </div>
                </li>
                <li>
                    <a class="cd-faq-trigger" href="#0"><%=VTNORTON.Resources.faq.Q12Site %></a>
                    <div class="cd-faq-content">
                        <p><%=VTNORTON.Resources.faq.R12 %></p>
                    </div>
                </li>
            </ul>

            <ul id="others" class="cd-faq-group">
                <li class="cd-faq-title">
                    <h2><%=VTNORTON.Resources.faq.Others %></h2>
                </li>
                <li>
                    <a class="cd-faq-trigger" href="#0"><%=VTNORTON.Resources.faq.Q13Others %></a>
                    <div class="cd-faq-content">
                        <p><%=VTNORTON.Resources.faq.R13 %></p>
                    </div>
                </li>
                <li>
                    <a class="cd-faq-trigger" href="#0"><%=VTNORTON.Resources.faq.Q14Others %></a>
                    <div class="cd-faq-content">
                        <p>
                            <%=VTNORTON.Resources.faq.R14 %>
                            <br />
                            <img alt="Gatos casando" src="/img/others/cat_1.jpg" />
                            <img alt="Gato com cabeça torta" src="/img/others/cat_5.jpg" />
                            <img alt="Gato piscando" src="/img/others/cat_2.jpg" />
                            <img alt="Gato tentando afogar o outro gato no pote de ração... coitado, mal sabe ele que o zinca estava morrendo de fome." src="/img/others/cat_3.jpg" />
                            <img alt="Self felina" src="/img/others/cat_4.jpg" />
                        </p>
                    </div>
                </li>
            </ul>

        </div>
        <a href="#0" class="cd-close-panel">Close</a>
    </section>
    <script> //update these values if you change these breakpoints in the style.css file (or _layout.scss if you use SASS)
        var MqM = 768,
            MqL = 1024;

        var faqsSections = $('.cd-faq-group'),
            faqTrigger = $('.cd-faq-trigger'),
            faqsContainer = $('.cd-faq-items'),
            faqsCategoriesContainer = $('.cd-faq-categories'),
            faqsCategories = faqsCategoriesContainer.find('a'),
            closeFaqsContainer = $('.cd-close-panel');

        //select a faq section 
        faqsCategories.on('click', function (event) {
            event.preventDefault();
            var selectedHref = $(this).attr('href'),
                target = $(selectedHref);
            if ($(window).width() < MqM) {
                faqsContainer.scrollTop(0).addClass('slide-in').children('ul').removeClass('selected').end().children(selectedHref).addClass('selected');
                closeFaqsContainer.addClass('move-left');
                $('body').addClass('cd-overlay');
            } else {
                $('body,html').animate({ 'scrollTop': target.offset().top - 19 }, 200);
            }
        });

        //close faq lateral panel - mobile only
        $('body').bind('click touchstart', function (event) {
            if ($(event.target).is('body.cd-overlay') || $(event.target).is('.cd-close-panel')) {
                closePanel(event);
            }
        });
        faqsContainer.on('swiperight', function (event) {
            closePanel(event);
        });

        //show faq content clicking on faqTrigger
        faqTrigger.on('click', function (event) {
            event.preventDefault();
            $(this).next('.cd-faq-content').slideToggle(200).end().parent('li').toggleClass('content-visible');
        });

        //update category sidebar while scrolling
        $(window).on('scroll', function () {
            if ($(window).width() > MqL) {
                (!window.requestAnimationFrame) ? updateCategory() : window.requestAnimationFrame(updateCategory);
            }
        });

        $(window).on('resize', function () {
            if ($(window).width() <= MqL) {
                faqsCategoriesContainer.removeClass('is-fixed').css({
                    '-moz-transform': 'translateY(0)',
                    '-webkit-transform': 'translateY(0)',
                    '-ms-transform': 'translateY(0)',
                    '-o-transform': 'translateY(0)',
                    'transform': 'translateY(0)',
                });
            }
            if (faqsCategoriesContainer.hasClass('is-fixed')) {
                faqsCategoriesContainer.css({
                    'left': faqsContainer.offset().left,
                });
            }
        });

        function closePanel(e) {
            e.preventDefault();
            faqsContainer.removeClass('slide-in').find('li').show();
            closeFaqsContainer.removeClass('move-left');
            $('body').removeClass('cd-overlay');
        }

        function updateCategory() {
            updateCategoryPosition();
            updateSelectedCategory();
        }

        function updateCategoryPosition() {
            var top = $('.cd-faq').offset().top,
                height = jQuery('.cd-faq').height() - jQuery('.cd-faq-categories').height(),
                margin = 20;
            if (top - margin <= $(window).scrollTop() && top - margin + height > $(window).scrollTop()) {
                var leftValue = faqsCategoriesContainer.offset().left,
                    widthValue = faqsCategoriesContainer.width();
                faqsCategoriesContainer.addClass('is-fixed').css({
                    'left': leftValue,
                    'top': margin,
                    '-moz-transform': 'translateZ(0)',
                    '-webkit-transform': 'translateZ(0)',
                    '-ms-transform': 'translateZ(0)',
                    '-o-transform': 'translateZ(0)',
                    'transform': 'translateZ(0)',
                });
            } else if (top - margin + height <= $(window).scrollTop()) {
                var delta = top - margin + height - $(window).scrollTop();
                faqsCategoriesContainer.css({
                    '-moz-transform': 'translateZ(0) translateY(' + delta + 'px)',
                    '-webkit-transform': 'translateZ(0) translateY(' + delta + 'px)',
                    '-ms-transform': 'translateZ(0) translateY(' + delta + 'px)',
                    '-o-transform': 'translateZ(0) translateY(' + delta + 'px)',
                    'transform': 'translateZ(0) translateY(' + delta + 'px)',
                });
            } else {
                faqsCategoriesContainer.removeClass('is-fixed').css({
                    'left': 0,
                    'top': 0,
                });
            }
        }

        function updateSelectedCategory() {
            faqsSections.each(function () {
                var actual = $(this),
                    margin = parseInt($('.cd-faq-title').eq(1).css('marginTop').replace('px', '')),
                    activeCategory = $('.cd-faq-categories a[href="#' + actual.attr('id') + '"]'),
                    topSection = (activeCategory.parent('li').is(':first-child')) ? 0 : Math.round(actual.offset().top);

                if ((topSection - 20 <= $(window).scrollTop()) && (Math.round(actual.offset().top) + actual.height() + margin - 20 > $(window).scrollTop())) {
                    activeCategory.addClass('selected');
                } else {
                    activeCategory.removeClass('selected');
                }
            });
        }</script>
    <%--<script src="/js/faq.js"></script>--%>
</asp:Content>

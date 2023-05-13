<%@ Page Title="YOLO | Vtnorton" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="VTNORTON.yolo.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul style="margin-left: 0;">
        <li><a class="ativo" href="index.aspx">Principal</a></li>
        <li><a href="copa2014.aspx">Copa 2014</a></li>
        <!-- <li><a href="#">Avatares</a></li> -->
        <!-- <li><a href="#">Papeis de parede</a></li> -->
        <!-- <li><a href="#">Camisas</a></li> -->
        <!-- <li><a href="#">Canecas</a></li> -->
        <!-- <li><a href="#">Outros</a></li> -->
    </ul>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="content" class="layout-sidebar-right group">
        <div id="primary" class="group">

            <div class="hentry hentry-post group blog-big">
                <div class="thumbnail">
                    <img src="images/yolo-640-295-brasil-copa.jpg" class="aligncenter wp-post-image" alt="Yolo na Copa do Brasil" title="Yolo na Copa do Brasil" />
                    <h2><a href="copa2014.aspx">Vamos torcer juntos com o Brasil!</a></h2>
                    <p class="date">
                        <span class="month">Jun</span>
                        <span class="day">08</span>
                    </p>
                </div>
                <div class="meta group">
                    <p><span><a class="ativo" href="copa2014.aspx">Ver todos os avarares</a></span></p>
                    <%--<p><span><a href='http://www.vtnorton.com/yolo/index.aspx' onclick='&quot;window.open(this.href, \&quot;_blank\&quot;, \&quot;height=430,width=640\&quot;); return false;&quot;' title='Yolo | Vtnorton' target='_blank'>Compartilhe com os amigos</a></span></p>--%>
                    <p><span><a class="comments" href="download/avatares-copa-do-mundo-2014-pack-vtnorton.com.rar">Fazer download (.rar)</a></span></p>
                </div>
                <div class="the-content">
                    <p>
                        Apresentamos o nosso projeto YOLO, uma forma de nos conectar a você cada vez mais, e para começar com o pé direito, estamos com uma coleção de avatares para a Copa do Mundo deste ano, faça o uso avontade em suas redes socias! Ajude a divulgar o projeto, fale com os seus amigos onde você achou esses lindos avatares. Escolha um e use. 
                    </p>
                </div>
            </div>
        </div>
        <div id="sidebar" class="group">
            <div class="widget-first widget recent-posts">
                <h3>Outros projetos</h3>

                <div class="last-news group">

                    <div class="box-post group thumbnail">
                        <%--<div class="box-post-thumb sphere">
                            <img src="/images/various/glasses-86x86.jpg" alt="Search" title="Search" />
                        </div>--%>
                        <div class="box-post-body group">
                            <div class="news_title"><a href="/Search/Index.aspx?=yolotitle" title="Search: ache o que procura em poucos cliques" class="title">Search: ache o que procura em poucos cliques</a></div>
                            <p class="meta">Entre agora e conheça o Search! <a href="/search/index.aspx?=yolo">vtnorton.com/Search</a></p>
                        </div>
                    </div>

                    <div class="box-post group thumbnail">
                        <%--<div class="box-post-thumb sphere">
                            <img src="/images/various/sushi1-86x86.jpg" alt="Connect" title="Connect" />
                        </div>--%>
                        <div class="box-post-body group">
                            <div class="news_title"><a href="/connect/index.aspx?=yolotitle" title="Connect: sites profissionais com descontos surpreendentes" class="title">Connect: sua empresa merece um site</a></div>
                            <p class="meta">Veja os diversos motivos para ter um site <a href="/connect/motivos.aspx?=yolo">aqui</a>.</p>
                        </div>
                    </div>

                    <div class="box-post group thumbnail">
                        <%--<div class="box-post-thumb sphere">
                            <img src="/images/no_image_recentposts.jpg" alt="Yolo" title="Yolo" />
                        </div>--%>
                        <div class="box-post-body group">
                            <div class="news_title"><a href="copa2014.aspx" title="Yolo: uma maneira de nos conectar a você!" class="title">Yolo: uma maneira de nos conectar a você!</a></div>
                            <p class="meta">Conheça a coleção de avatares para a <a href="copa2014.aspx">Copa do Mundo</a>!</p>
                        </div>
                    </div>

                </div>

            </div>
        </div>
    </div>
</asp:Content>

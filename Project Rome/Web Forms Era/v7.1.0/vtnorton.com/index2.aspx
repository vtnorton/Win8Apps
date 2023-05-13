<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="VTNORTON.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        function Refresh(id) {
            document.getElementById('iFrame').src = '/projeto?Id=' + id;
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="content-mos" class="centered clearfix">
        <!-- Tile 1: Yapp -->
        <a onclick="Refresh(1)" class="all tile-click empresas">
            <div class="tile large live" data-stops="0,20%,80%,100%" data-speed="2000" data-delay="1500" data-direction="horizontal" data-stack="true">
                <div class="live-front">
                    <img class="live-img" src="images/tile.yapp.jpg" alt="Yapp, desenvolvendo aplicativos para você" />
                </div>
                <div class="live-back">
                    <img class="live-img" src="images/tile.yapp.back.jpg" alt="Yapp, desenvolvendo aplicativos para você" />
                </div>
                <span class="tile-cat blue">YAPP</span>
            </div>
        </a>

        <!-- Tile 3: NextCast -->
        <a href="#Id?9" class="all tile-click outros blog">
            <div class="tile small live" data-stops="0,30%,75%,75%" data-speed="750" data-delay="2000" data-stack="true">
                <div class="live-front blue">
                    <img class="live-img" src="images/tile.nextcast.jpg" alt="Nextcast" />
                </div>
                <div class="live-back green">
                    <img class="live-img" src="images/tile.nextcast.back.jpg" alt="Nextcast" />
                </div>
                <span class="tile-cat purple">Nextcast</span>
            </div>
        </a>

        <!-- Tile 4: Livecoding.tv -->
        <a href="#Id?9" class="all tile-click outros contact">
            <div class="tile small live" data-stops="0,33%,50%" data-speed="1750" data-delay="1000" data-direction="horizontal">
                <div class="live-front blue">
                    <img class="live-img" src="images/tile.livecoding.tv.jpg" alt="Livecoding.tv" />
                </div>
                <div class="live-back green">
                    <img class="live-img" src="images/tile.livecoding.tv.back.jpg" alt="Livecoding.tv" />
                </div>
                <span class="tile-cat black">livecoding.tv</span>
            </div>
        </a>

        <!-- Tile 5: MVP -->
        <a href="#Id?9" class="all tile-click all outros contact">
            <div class="tile small">
                <img class="live-img" src="images/tile.winmvp.jpg" alt="Windows Insider MVP" />
            </div>
        </a>

        <!-- Tile 6: Evento DevNasNuvens -->
        <a href="#Id?9" class="all tile-click blog">
            <div class="tile large">
                <img class="live-img" src="images/tile.dev.back.jpg" alt="Evento #DevNasNuvens" />
            </div>
        </a>

        <!-- Tile 7: Blog do Norton -->
        <a href="#Id?9" class="all tile-click blog">
            <div class="tile medium">
                <img class="live-img" src="images/tile.blog.jpg" alt="Blog do Norton" />
            </div>
        </a>

        <!-- Tile 8: OneNote -->
        <a href="#Id?9" class="all tile-click ebook">
            <div class="tile small live" data-stops="0,75%,100%" data-speed="1500" data-delay="1100" data-stack="true">
                <div class="live-front blue">
                    <img class="live-img" src="images/tile.onenote.jpg" alt="Guia definitivo para o OneNote" />
                </div>
                <div class="live-back green">
                    <img class="live-img" src="images/tile.onenote.back.jpg" alt="Guia definitivo para o OneNote" />
                </div>
            </div>
        </a>

        <!-- Tile 9: Garoto de Programa -->
        <a href="#Id?4" class="all tile-click blog empresas">
            <div class="tile small">
                <img class="live-img" src="images/tile.garotodeprograma.jpg" alt="Garoto de programa" />
            </div>
        </a>

        <div id="tile-panel" class="tile-pre" style="display: none; width: 100% !important">
            <div class="navigation">
                <div class="right">
                    <a href="http://youtube.com/vtnortondev" title="Youtube"><i class="fa fa-youtube-play"></i></a>
                    <a href="http://facebook.com/yappproducer" title="Facebook"><i class="fa fa-facebook-f"></i></a>
                    <a href="http://twitter.com/vt_norton" title="Twitter"><i class="fa fa-twitter"></i></a>
                    <a class="close" href="#" title="Fechar"><i class="fa fa-close fa-2x"></i></a>
                </div>
                <div class="clean"></div>
            </div>
            <iframe src="#" id="iFrame" style="border: none; width: 100%; height: 100%; overflow: hidden"></iframe>
        </div>
    </section>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/healtthrob.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="VTNORTON.index1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderSubMenu" runat="server">
    <ul>
        <li><a href="/eventos">Veja os próximos eventos</a></li>
        <li><a href="#">A versão 2.0 do Formula - Universal Code Editor foi lançada</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="loader"></div>
    <section class="info">
        <p>Se inscreva na minha lista de e-mails para saber de todas as novidade, é bem simples e sem spam! <a href="#email">Clique aqui!</a></p>
    </section>
    <section>
        <div class="section-image-left">
            <div class="mainpage-mos">
                <div class="centered clearfix content-mos">
                    <!-- Tile 1: Yapp -->
                    <a href="http://yapp.vtnorton.com" target="_blank" class="all tile-click empresas">
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


                    <!-- Tile 7: Blog do Norton -->
                    <a href="http://blog.vtnorton.com/" target="_blank" class="all tile-click blog">
                        <div class="tile medium">
                            <img class="live-img" src="images/tile.blog.jpg" alt="Blog do Norton" />
                        </div>
                    </a>
                    <!-- Tile 6: Evento DevNasNuvens -->
                    <a href="http://vtnorton.com/devnasnuvens" target="_blank" class="all tile-click blog">
                        <div class="tile small">
                            <img class="live-img" src="images/tile.dev.back.jpg" alt="Evento #DevNasNuvens" />
                        </div>
                    </a>
                    <!-- Tile 8: OneNote -->
                    <a href="http://vtnorton.com/onenote/" target="_blank" class="all tile-click ebook">
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
                    <a href="http://garotodeprograma.vtnorton.com/" target="_blank" class="all tile-click blog empresas">
                        <div class="tile small">
                            <img class="live-img" src="images/tile.garotodeprograma.jpg" alt="Garoto de programa" />
                        </div>
                    </a>
                    <!-- Tile 3: NextCast -->
                    <a href="https://www.mixcloud.com/vNextbr/" target="_blank" class="all tile-click outros blog">
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
                    <a href="https://www.livecoding.tv/vtnorton/" target="_blank" class="all tile-click outros contact">
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
                </div>
            </div>
        </div>
        <div class="section-wrapper">
            <div class="section-content-right">
                <h2>Projetos</h2>
                <p>Durante o tempo eu venho acumulando alguns projetos, dentre eles alguns blogs, ebooks, sites, eventos e cursos. Veja um pouco mais do meu trabalho.</p>
                <p>Estes são alguns dos meus projetos, caso queira conhecer mais sobre eles, clique em um dos ícones apresentados ao lado.</p>
            </div>
        </div>
        <div class="clean"></div>
    </section>
    <section class="bg-light">
        <div class="section-image-right">
            <div class="mainpage-mos">
                <div class="centered clearfix content-mos">
                    <!-- Tile 10: Formula -->
                    <a href="http://yapp.vtnorton.com/formula-universal-code-editor/" target="_blank" class="all tile-click blog empresas">
                        <div class="tile small">
                            <img class="live-img" src="images/Quebec.png" alt="Garoto de programa" />
                        </div>
                    </a>
                    <!-- Tile 11: Random 42 -->
                    <a href="http://yapp.vtnorton.com/random-42/" target="_blank" class="all tile-click blog empresas">
                        <div class="tile small">
                            <img class="live-img" src="images/Nice.png" alt="Garoto de programa" />
                        </div>
                    </a>
                    <!-- Tile 12: Conjugar -->
                    <a href="http://yapp.vtnorton.com/conjugar/" target="_blank" class="all tile-click blog empresas">
                        <div class="tile small">
                            <img class="live-img" src="images/Douai.png" alt="Garoto de programa" />
                        </div>
                    </a>
                    <!-- Tile 13: Time Calculator -->
                    <a href="http://yapp.vtnorton.com/time-calculator/" target="_blank" class="all tile-click blog empresas">
                        <div class="tile small">
                            <img class="live-img" src="images/Lyon.png" alt="Garoto de programa" />
                        </div>
                    </a>
                    <!-- Tile 14: TrueOrDare -->
                    <a href="http://yapp.vtnorton.com/trueordare/" target="_blank" class="all tile-click blog empresas">
                        <div class="tile small">
                            <img class="live-img" src="images/LasVegas.png" alt="Garoto de programa" />
                        </div>
                    </a>
                    <!-- Tile 15: Tocha -->
                    <a href="http://yapp.vtnorton.com/tocha-olimpica/" target="_blank" class="all tile-click blog empresas">
                        <div class="tile small">
                            <img class="live-img" src="images/Rio.png" alt="Garoto de programa" />
                        </div>
                    </a>
                </div>
            </div>
        </div>
        <div class="section-wrapper">
            <div class="section-content-left">
                <h2>Aplicativos</h2>
                <p>Para mim, desenvolver é o que me faz girar. Eu desenvolvo para Windows 10 pois sou apaixonado por essa plataforma.</p>
                <p>Conheça as ferramentas que podem facilitar - e muito - a sua vida. Disponíveis tanto para PC quando para Mobile em diversas regiões.</p>
            </div>
        </div>
        <div class="clean"></div>
    </section>
    <section id="email">
        <div class="section-image-left">
                <img style="max-height: 330px; padding: 40px; margin-top: 10px; margin-left: 120px" src="images/home/Email-Marketing3.png" />
            </div>
        <div class="section-wrapper">
            <div class="section-content-right">
                <h2>Newsletter</h2>
                <p>Se inscreva na minha newsletter e saiba tudo o que está acontecendo em primeira mão!</p>
                <p>Eu odeio spam na minha caixa de e-mail, tanto quanto você. Pode assinar sem medo!</p>
                <br />
                <form runat="server">
                    <asp:TextBox Height="28" ID="txtEmail" MaxLength="120" placeholer="Email" runat="server" TextMode="Email"></asp:TextBox>
                    <asp:Button ID="btnBaixar" OnClick="btnBaixar_Click" runat="server" Text="Cadastrar" /><br />
                </form>
                <p>
                    <asp:Label ID="lblEmailerro" runat="server" Text=""></asp:Label>
                </p>
            </div>
            <div class="clean"></div>
        </div>
    </section>
    <script src="/js/jquery.masonry.min.js" type="text/javascript"></script>
    <script src="/js/jquery.easing.1.3.js" type="text/javascript"></script>
    <script src="/js/MetroJs.lt.js" type="text/javascript"></script>
    <script src="/js/hoverintent.js" type="text/javascript" charset="utf-8"></script>
    <script src="/js/javascript.js" type="text/javascript"></script>
</asp:Content>

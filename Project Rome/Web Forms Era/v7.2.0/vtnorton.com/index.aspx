<%@ Page Title="" Language="C#" MasterPageFile="~/healtthrob.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="VTNORTON.index1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderSubMenu" runat="server">
    <ul>
        <li><a href="http://windowsinsiderbrasil.com.br"><%=VTNORTON.Resources.index.SlackGroup %></a></li>
        <li><a href="http://dev.vtnorton.com/released-formula-v2-0-see-whats-new/"><%=VTNORTON.Resources.index.Formula2pointo %></a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="loader"></div>
    <section class="info">
        <p><%=VTNORTON.Resources.index.Subscrive %></p>
    </section>
    <section>
        <div class="section-image-left">
            <div class="mainpage-mos">
                <div class="centered clearfix content-mos">
                    <!-- Tile 1: Yapp -->
                    <%--<a href="http://yapp.vtnorton.com" target="_blank" class="all tile-click empresas">
                        <div class="tile large live" data-stops="0,20%,80%,100%" data-speed="2000" data-delay="1500" data-direction="horizontal" data-stack="true">
                            <div class="live-front">
                                <img class="live-img" src="images/tile.yapp.jpg" alt="Yapp, desenvolvendo aplicativos para você" />
                            </div>
                            <div class="live-back">
                                <img class="live-img" src="images/tile.yapp.back.jpg" alt="Yapp, desenvolvendo aplicativos para você" />
                            </div>
                            <span class="tile-cat blue">YAPP</span>
                        </div>
                    </a>--%>

                    <!-- Tile 9: Garoto de Programa -->
                    <%--<a href="http://blog.vtnorton.com/" target="_blank" class="all tile-click blog empresas">
                        <div class="tile large">
                            <img class="live-img" src="images/tile.garotodeprograma.jpg" alt="Garoto de programa" />
                        </div>
                    </a>--%>
                    <a href="http://blog.vtnorton.com/">
                        <div class="tile medium">
                            <img class="live-img" src="images/tile/tile.blog.jpg" alt="Blog do Norton" />
                        </div>
                    </a>
                    <a href="http://vtnorton.com/devnasnuvens">
                        <div class="tile small">
                            <img class="live-img" src="images/tile/tile.dev.back.jpg" alt="Evento #DevNasNuvens" />
                        </div>
                    </a>
                    <a href="http://vtnorton.com/onenote/">
                        <div class="tile small live" data-stops="0,75%,100%" data-speed="1500" data-delay="1100" data-stack="true">
                            <div class="live-front blue">
                                <img class="live-img" src="images/tile/tile.onenote.jpg" alt="Guia definitivo para o OneNote" />
                            </div>
                            <div class="live-back green">
                                <img class="live-img" src="images/tile/tile.onenote.back.jpg" alt="Guia definitivo para o OneNote" />
                            </div>
                        </div>
                    </a>
                    <a href="https://www.mixcloud.com/vNextbr/" target="_blank">
                        <div class="tile small live" data-stops="0,30%,75%,75%" data-speed="750" data-delay="2000" data-stack="true">
                            <div class="live-front blue">
                                <img class="live-img" src="images/tile/tile.nextcast.jpg" alt="Nextcast" />
                            </div>
                            <div class="live-back green">
                                <img class="live-img" src="images/tile/tile.nextcast.back.jpg" alt="Nextcast" />
                            </div>
                            <span class="tile-cat purple">Nextcast</span>
                        </div>
                    </a>
                    <a href="https://www.livecoding.tv/vtnorton/" target="_blank">
                        <div class="tile small live" data-stops="0,33%,50%" data-speed="1750" data-delay="1000" data-direction="horizontal">
                            <div class="live-front blue">
                                <img class="live-img" src="images/tile/tile.livecoding.tv.jpg" alt="Livecoding.tv" />
                            </div>
                            <div class="live-back green">
                                <img class="live-img" src="images/tile/tile.livecoding.tv.back.jpg" alt="Livecoding.tv" />
                            </div>
                            <span class="tile-cat black">livecoding.tv</span>
                        </div>
                    </a>
                </div>
            </div>
        </div>
        <div class="section-wrapper">
            <div class="section-content-right">
                <h2><%=VTNORTON.Resources.index.Projects %></h2>
                <p><%=VTNORTON.Resources.index.ProjectsDetails %></p>
            </div>
        </div>
        <div class="clean"></div>
    </section>
    <section class="bg-light">
        <div class="section-image-right">
            <div class="mainpage-mos">
                <div class="centered clearfix content-mos">
                    <a href="/formula" class="tile-click">
                        <div class="tile large">
                            <img class="live-img" src="images/Quebec.png" alt="Formula - Universal Code Editor" />
                        </div>
                    </a>
                    <a href="/random42">
                        <div class="tile small">
                            <img class="live-img" src="images/Nice.png" alt="Random 42" />
                        </div>
                    </a>
                    <a href="/conjugar">
                        <div class="tile small">
                            <img class="live-img" src="images/Douai.png" alt="Conjugar" />
                        </div>
                    </a>
                    <a href="/timecalculator">
                        <div class="tile small">
                            <img class="live-img" src="images/Lyon.png" alt="Time Calculator" />
                        </div>
                    </a>
                    <a href="/verdadeouconsequencia">
                        <div class="tile small">
                            <img class="live-img" src="images/LasVegas.png" alt="Verdade ou Consequencia" />
                        </div>
                    </a>
                    <a href="/tochaolimpica">
                        <div class="tile small">
                            <img class="live-img" src="images/Rio.png" alt="Tocha Olímpica" />
                        </div>
                    </a>
                    <a href="/truedarkmode">
                        <div class="tile small">
                            <img class="live-img" src="/images/extention/bellevue.jpg" alt="True Dark Mode" />
                        </div>
                    </a>
                </div>
            </div>
        </div>
        <div class="section-wrapper">
            <div class="section-content-left">
                <h2><%=VTNORTON.Resources.index.Apps %></h2>
                <p><%=VTNORTON.Resources.index.AppsDetails %></p>
            </div>
        </div>
        <div class="clean"></div>
    </section>
    <section id="email" class="section-bg">
        <div class="wrapper">
            <div class="section-content-right">
                <h2 class="white notranslate">Newsletter</h2>
                <p class="white"><%=VTNORTON.Resources.index.Newsletter %></p>
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
    <section>
        <div class="wrapper" style="padding: 30px 0">
            <h2 class="blue"><%=VTNORTON.Resources.index.BlogdoNorton %></h2>
            <hr />
            <br />
            <asp:Repeater ID="rssRepeater" runat="server">
                <ItemTemplate>
                    <div class="article-blog">
                        <h4><a href="<%#Eval("Link")%>"><%#Eval("Title")%></a></h4>
                        <img src="<%#Eval("Image") %>" />
                        <p><%#Eval("Description")%></p>
                        <p><strong><a href="<%#Eval("Link")%>"><%=VTNORTON.Resources.index.ReadMore %></a></strong></p>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
            <div class="clean"></div>
        </div>
    </section>
    <section class="bg-light">
        <div class="wrapper" style="padding: 30px 0">
            <h2 class="blue"><%=VTNORTON.Resources.index.Dev %></h2>
            <hr />
            <br />
            <asp:Repeater ID="rptDev" runat="server">
                <ItemTemplate>
                    <div class="article-blog">
                        <h4><a href="<%#Eval("Link")%>"><%#Eval("Title")%></a></h4>
                        <img src="<%#Eval("Image") %>" />
                        <p><%#Eval("Description")%></p>
                        <p><strong><a href="<%#Eval("Link")%>"><%=VTNORTON.Resources.index.ReadMore %></a></strong></p>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
            <div class="clean"></div>
        </div>
    </section>
    <script src="/js/jquery.masonry.min.js" type="text/javascript"></script>
    <script src="/js/jquery.easing.1.3.js" type="text/javascript"></script>
    <script src="/js/MetroJs.lt.js" type="text/javascript"></script>
    <script src="/js/hoverintent.js" type="text/javascript" charset="utf-8"></script>
    <script src="/js/javascript.js" type="text/javascript"></script>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="primeiroturno.aspx.cs" Inherits="Eleicao.primeiroturno" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Resultados do primeiro turno | VTNorton</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul style="margin-left: 0;">
        <%--<li><a href="/emtemporeal.aspx">Em tempo real</a></li>--%>
        <%--<li><a href="pesquisa.aspx">Pesquisas</a></li>--%>
        <li><a class="ativo" href="/primeiroturno.aspx">Primeiro Turno</a></li>
        <li><a href="/projetos.aspx">Sobre este projeto</a></li>
        <li><a href="/winph.aspx">Acompanhe no seu celular</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="margin">
        <h1 style="margin-top: 30px;">Todos os candidatos</h1>
        <div style="width: 728px; margin: 0 auto; padding-top: 10px; padding-bottom: 10px;">
            <script type="text/javascript">
                google_ad_client = "ca-pub-5584056449430380";
                google_ad_slot = "3030208448";
                google_ad_width = 728;
                google_ad_height = 90;
            </script>
            <!-- eleicao.vtnorton.com -->
            <script type="text/javascript"
                src="//pagead2.googlesyndication.com/pagead/show_ads.js">
            </script>
        </div>


        <div class="card aecio left">
            <div style="float: left; width: 70px !important;">
                <img class="card-img" src="/img/candidatos/aecio-neves_s.jpg" />
            </div>
            <div style="float: right; width: 380px !important">
                <div class="card-info" style="float: left">
                    <h2>Aécio Neves</h2>
                    <h4>45 - PSDB</h4>
                    <h2>34.897.211 votos</h2>
                </div>
                <div class="card-porcentagem" style="float: right">
                    <h1>33,55%</h1>
                </div>
                <div style="clear: both"></div>
            </div>
            <div style="clear: both"></div>
        </div>
        <div class="card dilma right">
            <div style="float: left;">
                <img class="card-img" src="/img/candidatos/dilma_s.jpg" />
            </div>
            <div style="float: right; width: 380px !important">
                <div class="card-info" style="float: left">
                    <h2>Dilma Rousseff</h2>
                    <h4>13 - PT</h4>
                    <h2>43.267.668 votos</h2>
                </div>
                <div class="card-porcentagem" style="float: right">
                    <h1>41,59%</h1>
                </div>
                <div style="clear: both"></div>
            </div>
            <div style="clear: both"></div>
        </div>
        <div style="clear: both"></div>

        <div class="card eduardo left">
            <div style="float: left;">
                <img class="card-img" src="/img/candidatos/eduardo-jorge_s.jpg" />
            </div>
            <div style="float: right; width: 380px !important">
                <div class="card-info" style="float: left">
                    <h2>Eduardo Jorge</h2>
                    <h4>43 - PV</h4>
                    <h2>630.099 votos</h2>
                </div>
                <div class="card-porcentagem" style="float: right">
                    <h1>0,61%</h1>
                </div>
                <div style="clear: both"></div>
            </div>
            <div style="clear: both"></div>
        </div>
        <div class="card eymael right">
            <div style="float: left;">
                <img class="card-img" src="/img/candidatos/eymael_s.jpg" />
            </div>
            <div style="float: right; width: 380px !important">
                <div class="card-info" style="float: left">
                    <h2>Eymael</h2>
                    <h4>27 - PSDC</h4>
                    <h2>61.250 votos</h2>
                </div>
                <div class="card-porcentagem" style="float: right">
                    <h1>0,05%</h1>
                </div>
                <div style="clear: both"></div>
            </div>
            <div style="clear: both"></div>
        </div>
        <div style="clear: both"></div>

        <div class="card levy left">
            <div style="float: left;">
                <img class="card-img" src="/img/candidatos/levy-fidelix_s.jpg" />
            </div>
            <div style="float: right; width: 380px !important">
                <div class="card-info" style="float: left">
                    <h2>Levy Fidelix</h2>
                    <h4>28 - PRTB</h4>
                    <h2>446.878 votos</h2>
                </div>
                <div class="card-porcentagem" style="float: right">
                    <h1>0,43%</h1>
                </div>
                <div style="clear: both"></div>
            </div>
            <div style="clear: both"></div>
        </div>
        <div class="card luciana right">
            <div style="float: left;">
                <img class="card-img" src="/img/candidatos/luciana-genro_s.jpg" />
            </div>
            <div style="float: right; width: 380px !important">
                <div class="card-info" style="float: left">
                    <h2>Luciana Genro</h2>
                    <h4>50 - PSOL</h4>
                    <h2>1.612.186 votos</h2>
                </div>
                <div class="card-porcentagem" style="float: right">
                    <h1>1,55%</h1>
                </div>
                <div style="clear: both"></div>
            </div>
            <div style="clear: both"></div>
        </div>
        <div style="clear: both"></div>
        <div style="width: 728px; margin: 0 auto; padding-top: 10px; padding-bottom: 10px;">
            <script type="text/javascript">
                google_ad_client = "ca-pub-5584056449430380";
                google_ad_slot = "3030208448";
                google_ad_width = 728;
                google_ad_height = 90;
            </script>
            <!-- eleicao.vtnorton.com -->
            <script type="text/javascript"
                src="//pagead2.googlesyndication.com/pagead/show_ads.js">
            </script>
        </div>
        <div class="card marina left">
            <div style="float: left;">
                <img class="card-img" src="img/candidatos/marina-silva-40-2_s.jpg" />
            </div>
            <div style="float: right; width: 380px !important">
                <div class="card-info" style="float: left">
                    <h2>Marina Silva</h2>
                    <h4>40 - PSB</h4>
                    <h2>22.176.619 votos</h2>
                </div>
                <div class="card-porcentagem" style="float: right">
                    <h1>21,32%</h1>
                </div>
                <div style="clear: both"></div>
            </div>
            <div style="clear: both"></div>
        </div>
        <div class="card mauro right">
            <div style="float: left;">
                <img class="card-img" src="/img/candidatos/mauro-iasi_s.jpg" />
            </div>
            <div style="float: right; width: 380px !important">
                <div class="card-info" style="float: left">
                    <h2>Mauro Iasi</h2>
                    <h4>21 - PCB</h4>
                    <h2>61.250 votos</h2>
                </div>
                <div class="card-porcentagem" style="float: right">
                    <h1>0,06%</h1>
                </div>
                <div style="clear: both"></div>
            </div>
            <div style="clear: both"></div>
        </div>
        <div style="clear: both"></div>

        <div class="card everaldo left">
            <div style="float: left;">
                <img class="card-img" src="/img/candidatos/pastor-everaldo_s.jpg" />
            </div>
            <div style="float: right; width: 380px !important">
                <div class="card-info" style="float: left">
                    <h2>Pastor Everaldo</h2>
                    <h4>20 - PSC</h4>
                    <h2>780.513 votos</h2>
                </div>
                <div class="card-porcentagem" style="float: right">
                    <h1>0,75%</h1>
                </div>
                <div style="clear: both"></div>
            </div>
            <div style="clear: both"></div>
        </div>
        <div class="card rui right">
            <div style="float: left;">
                <img class="card-img" src="/img/candidatos/rui-costa-pimenta_s.jpg" />
            </div>
            <div style="float: right; width: 377px !important">
                <div class="card-info" style="float: left">
                    <h2>Rui Costa Pimenta</h2>
                    <h4>29 - PCO</h4>
                    <h2>12.324 votos</h2>
                </div>
                <div class="card-porcentagem" style="float: right">
                    <h1>0,01%</h1>
                </div>
                <div style="clear: both"></div>
            </div>
            <div style="clear: both"></div>
        </div>
        <div style="clear: both"></div>

        <div class="card ze left">
            <div style="float: left;">
                <img class="card-img" src="/img/candidatos/ze-maria_s.jpg" />
            </div>
            <div style="float: right; width: 380px !important">
                <div class="card-info" style="float: left">
                    <h2>Zé Maria</h2>
                    <h4>16 - PSTU</h4>
                    <h2>91.209 votos</h2>
                </div>
                <div class="card-porcentagem" style="float: right">
                    <h1>0,09%</h1>
                </div>
                <div style="clear: both"></div>
            </div>
            <div style="clear: both"></div>
        </div>
        <div style="clear: both"></div>

        <div style="width: 728px; margin: 0 auto; padding-top: 10px; padding-bottom: 10px;">
            <script type="text/javascript">
                google_ad_client = "ca-pub-5584056449430380";
                google_ad_slot = "3030208448";
                google_ad_width = 728;
                google_ad_height = 90;
            </script>
            <!-- eleicao.vtnorton.com -->
            <script type="text/javascript"
                src="//pagead2.googlesyndication.com/pagead/show_ads.js">
            </script>
        </div>
    </div>
    <div class="faixadecor" style="background: #e8e8e8; padding: 20px 0">
        <div class="margin">
            <h2>Informações gerais</h2>
            <div style="float: left" class="info">
                Seções totalizadas: 428.894 (100,00%)
                <br />
                Seções não totalizadas: 0 (0,00%)<br />
                Eleitorado não apurado: 688 (0,01%)<br />
                Eleitorado apurado: 142.821.358 (99,99%)
            </div>
            <div style="float: right; text-align: right" class="info">
                Votos em branco: 4.420.489 (3,84%)<br />
                Votos nulos: 6.678.592 (5,80%)<br />
                Votos válidos: 104.023.802 (90,36%)<br />
            </div>
            <div style="clear: both"></div>
        </div>
    </div>
</asp:Content>
<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Eleicao.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Acompanhe o resultado das eleições 2014 | VTNorton</title>
    <meta http-equiv="refresh" content="300;url=/index.aspx"/> 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul style="margin-left: 0;">
        <li><a class="ativo" href="/index.aspx">Início</a></li>
        <li><a href="/projetos.aspx">Sobre este projeto</a></li>
        <li><a href="/winph.aspx">Acompanhe no celular</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="faixadecor" style="background: #fafafa">
        <div class="margin">
            <div style="height: 80px;"></div>
            <div style="width: 728px; margin: 0 auto; padding-top: 5px;">
                <script type="text/javascript">
                    google_ad_client = "ca-pub-5584056449430370";
                    google_ad_slot = "3030208448";
                    google_ad_width = 728;
                    google_ad_height = 90;
                </script>
                <!-- eleicao.vtnorton.com -->
                <script type="text/javascript"
                    src="//pagead2.googlesyndication.com/pagead/show_ads.js">
                </script>
            </div>
            <h1>O Segundo Turno</h1>
        </div>
        
        <div class="faixadecor" style="background: #e8e8e8; margin-top: 30px; margin-bottom: 30px; padding-top: 30px; padding-bottom: 30px;">
            <div class="margin">
                <div class="card aecio left">
            <div style="float: left; width: 70px !important;">
                <img class="card-img" src="/img/candidatos/aecio-neves_s.jpg" />
            </div>
            <div style="float: right; width: 380px !important">
                <div class="card-info" style="float: left">
                    <h2>Aécio Neves</h2>
                    <h4>45 - PSDB</h4>
                    <h2>
                    <asp:Label ID="lblVotosAecio" runat="server" Text=""></asp:Label></h2>
                </div>
                <div class="card-porcentagem" style="float: right">
                    <h1><asp:Label ID="lblVotosPCAecio" runat="server" Text=""></asp:Label></h1>
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
                    <h2><asp:Label ID="lblVotosDilma" runat="server" Text=""></asp:Label></h2>
                </div>
                <div class="card-porcentagem" style="float: right">
                    <h1><asp:Label ID="lblVotosPCDilma" runat="server" Text=""></asp:Label></h1>
                </div>
                <div style="clear: both"></div>
            </div>
            <div style="clear: both"></div>
        </div>
        <div style="clear: both"></div>
            </div>
        </div>
        <div class="margin">
            <div style="height: 30px;"></div>
            <div style="width: 728px; margin: 0 auto; padding-top: 5px;">
                <script type="text/javascript">
                    google_ad_client = "ca-pub-5584056449430370";
                    google_ad_slot = "3030208448";
                    google_ad_width = 728;
                    google_ad_height = 90;
                </script>
                <!-- eleicao.vtnorton.com -->
                <script type="text/javascript"
                    src="//pagead2.googlesyndication.com/pagead/show_ads.js">
                </script>
                <div style="height: 50px;"></div>
            </div>
        </div>
    </div>    
</asp:Content>

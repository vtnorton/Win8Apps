<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="VTNORTON.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
        setInterval(function () {
            var hoje = new Date();
            var futuro = new Date('2015', '09', '02', '20', '30', '00');
            var ss = parseInt((futuro - hoje) / 1000);
            var mm = parseInt(ss / 60);
            var hh = parseInt(mm / 60);
            var dd = parseInt(hh / 24);
            ss = ss - (mm * 60);
            mm = mm - (hh * 60);
            hh = hh - (dd * 24);
            var faltam = '';
            faltam += (dd && dd > 1) ? dd + ' dias, ' : (dd == 1 ? '1 dia, ' : '');
            if (hh < 10)
                hh = "0" + hh;
            faltam += (toString(hh).length ? hh + ':' : '');
            if (mm < 10)
                mm = "0" + mm;
            faltam += (toString(mm).length ? mm + ':' : '');
            if (ss < 10)
                ss = "0" + ss;
            faltam += ss;
            document.getElementById("clock").innerHTML = faltam;
            document.getElementById("clock-time").innerHTML = faltam;
        }, 1000)
    </script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul>
        <li><a href="/" class="on">Principal</a></li>
        <li><a href="http://www.instagram.com/vt_norton">Siga-me no Instagram (@vt_norton)</a></li>
        <li><a href="http://www.twitter.com/vt_norton">Siga-me no Twitter (@vt_norton)</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="clock parallax">
        <h2 style="margin-bottom: 20px">você não aguarda por esperar</h2>
        <div onload="setInterval" id="clock"></div>
        <h3 style="margin-top: 20px;">SF = ((1 >= a2xp) + S01EXX + things) x B#;</h3>

    </div>
    <div class="home">
        <div class="home-1">
            <img src="images/others/clock.jpg" style="width: 100%" alt="02 de Outubro, você não aguarda por esperar" title="02 de Outubro, você não aguarda por esperar" />
            <article>
                <h3>Contagem regressiva</h3>
                <hr />
                <p>
                    Não conseguiu deduzir o que será feito quando o cronometro chegar a zero? Está curioso? Bem vindo ao meu mundo! O único jeito de saber o que significa, o que será, é estar inteiramente por dentro do assunto e esperar <span id="clock-time"></span> horas. <%--Ok, você ganhou a minha curiosidade, o que eu preciso fazer para saber mais? Simples, <a href="clock.aspx">veja tudo sobre o contador</a> que foi publicado até agora--%>
                </p>
            </article>
        </div>
        <div class="home-2">
            <asp:Label ID="lblImagePost1" runat="server" Text=""></asp:Label>
            <article>
                <h3>
                    <asp:Label ID="lblTitlePost1" runat="server" Text=""></asp:Label></h3>
                <hr />
                <p>
                    <asp:Label ID="lblFirstParagraphPost1" runat="server" Text=""></asp:Label>
                    <br />
                    <asp:Label ID="lblReadMorePost1" runat="server" Text=""></asp:Label>
                </p>
            </article>
        </div>
        <div class="home-3">
            <asp:Label ID="lblImagePost2" runat="server" Text=""></asp:Label>
            <article>
                <h3>
                    <asp:Label ID="lblTitlePost2" runat="server" Text=""></asp:Label></h3>
                <hr />
                <p>
                    <asp:Label ID="lblFirstParagraphPost2" runat="server" Text=""></asp:Label>
                    <br />
                    <asp:Label ID="lblReadMorePost2" runat="server" Text=""></asp:Label>
                </p>
            </article>

        </div>
        <div class="clean"></div>
    </div>
</asp:Content>

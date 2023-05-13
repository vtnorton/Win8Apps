<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="VTNORTON.search.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/css/hidra.css" rel="stylesheet" />

    <title>Hidra (Antes conhecido como Search) | VTNORTON</title>
    <meta name="description" content="Pesquise por vídeos e músicas com o Search. Sem pop-ups, botões de Downloads, anúncios e Captchas. O Search tira tudo isso e facilita o seu download." />
    <meta name="author" content="Vítor Norton" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul style="margin-left: 0;">
        <li><a class="ativo" href="/hidra/Index.aspx">Pesquisar</a></li>
        <li><a href="sobre.aspx">Sobre</a></li>
        <li><a href="opiniao.aspx">Mande a sua sugestão</a></li>
        <li><a href="adicionarnavegador.aspx">Adicione a Hidra em seu navegador</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="/js/blur.min.js"></script>
    <script>
        $(document).ready(function () {
            $('.tile').blurjs({
                source: '.img',
                overlay: 'rgba(0,0,0,0.612)',
                radius: 12
            });
        });
    </script>
    <div class="img">
        <%--<div style="min-height: 2700px"></div>--%>
        <div class="resultado">
            <div class="resultado-margin">
                <div class="tile left small">
                </div>
                <div class="tile right wide">
                </div>
                <div class="clear"></div>
                <br />

                <div class="tile left wide">
                </div>
                <div class="tile right small">
                </div>
                <div class="clear"></div>
                <br />

                <div class="full tile">
                    <asp:Label ID="lblResutadoHidra" runat="server" Text="Buscando..."></asp:Label>
                </div>
                <br />

                <div class="tile left square">
                </div>

                <div class="tile right square">
                </div>
                <div class="clear"></div>
                <br />

                <div class="full-without-size tile end">
                      <a href="#">Pesquisar no Google</a>
                    <hr />
                        <a href="#"> Pesquisar no Bing</a>
                    <hr />
                       <a href="#">  Pesquisar no Google Imagens</a>
                    <hr />
                       <a href="#">  Sugestão de resultado</a>
                </div>
                <div style="height: 130px;"></div>
            </div>
        </div>
    </div>

</asp:Content>

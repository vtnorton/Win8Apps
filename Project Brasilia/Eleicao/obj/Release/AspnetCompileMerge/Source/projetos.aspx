<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="projetos.aspx.cs" Inherits="Eleicao.projetos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Sobre este projeto</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul style="margin-left: 0;">
        <%--<li><a href="/index.aspx">Início</a></li>--%>
        <li><a href="/primeiroturno.aspx">Primeiro Turno</a></li>
        <li><a class="ativo" href="/projetos.aspx">Sobre este projeto</a></li>

        <%--<li><a href="/win.aspx">Baixar no Windows</a></li>--%>
        <li><a href="/winph.aspx">Acompanhe no seu celular</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="faixadecor" style="background: #fafafa">
        <div class="margin">
            <div style="height: 80px;"></div>
            <h1>Sobre o projeto</h1>
            <h2>Este é o resultado de três dias do meu trabalho</h2>
        </div>
        <div class="faixadecor" style="background: #e8e8e8; margin-top: 30px; margin-bottom: 30px;">
            <div class="margin">
                <div style="float: left; width: 650px">
                    <div style="margin: 30px 0">
                        <p>
                            Queria ter usado o próprio sistema do TSE, porém como a ideia veio de última hora, não foi possível usar o sistema deles. Isso implicou em ter de inserir manualmente o número dos votos no sistema. Então, senhoras e senhores, o sucesso deste projeto vai depender de n fatores, pois nada pode garantir que o meu provedor de internet (não citarei nomes aqui) vai estar funcionando. Mas farei o possível. Do momento em que o resultado é lançado no programa oficial, teremos um pequeno delay para ser atualizado aqui.
                        </p>
                        <p>
                            Este foi um projeto de última hora, então me perdoe por possíveis erros, ou por instabilidade. Foi feito em apenas 3 dias, e abrange também os usuários do Windows Phone e do Windows 8. Também não foi possível implementar o resultado para governadores e deputados. Estaremos aqui para o segundo turno, caso aconteça.
                        </p>

                    </div>
                </div>
                <div style="float: right; margin-top: 15px; margin-bottom: 10px; width: 336px">
                    <script type="text/javascript">
                        google_ad_client = "ca-pub-5584056449430370";
                        google_ad_slot = "5748172443";
                        google_ad_width = 336;
                        google_ad_height = 280;
                    </script>
                    <!-- square.eleicao.vtnorton.com -->
                    <script type="text/javascript"
                        src="//pagead2.googlesyndication.com/pagead/show_ads.js">
                    </script>
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

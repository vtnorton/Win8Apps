<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="adicionarnavegador.aspx.cs" Inherits="VTNORTON.search.adicionarnavegador" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/Search.css" rel="stylesheet" />
    <link href="Search.css" rel="stylesheet" />
    <title>Facilite as coisas, adicione o Search no seu navegador | VTNORTON</title>
    <meta name="description" content="Pesquise por vídeos e músicas com o Search. Sem pop-ups, botões de Downloads, anúncios e Captchas. O Search tira tudo isso e facilita o seu download." />
    <meta name="author" content="Vítor Norton" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul style="margin-left: 0;">
        <li><a href="/hidra/Index.aspx">Pesquisar</a></li>
        <li><a href="sobre.aspx">Sobre</a></li>
        <li><a href="opiniao.aspx">Mande a sua sugestão</a></li>
        <li><a class="ativo" href="adicionarnavegador.aspx">Adicione o Search em seu navegador</a></li>
        <%--<li><a href="/mixer/Index.aspx">M!xer</a></li>--%>
        <%--<li><a href="#">Novidades</a></li>--%>
        <%--<li><a href="#">Diferencial</a></li>--%>
        <%--<li><a href="#">Pirataria</a></li>--%>
        <%--<li><a href="#">Ajuda</a></li>--%>
    </ul>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="content" class="layout-sidebar-right group">
        <div id="slogan" class="inner">
            <h1>Facilitamos as coisas</h1>
            <h3>use o Search no seu navegador, de forma <span>fácil</span> e <span>rápida</span>!</h3>
        </div>
        <p>Integre o Search com o seu navegador favorito e facilite as suas buscas! Pesquise sem nem entrar no nosso site, de forma fácil, descomplicada e não precisa de complementos ou downloads!</p>
    </div>
    <div id="sobre" style="margin-top: -0px;" class="home-sections">
        <div id="servicos-2" class="section gradient group">
            <div class="tabs-container" style="margin-left: -20px;">
                <ul class="tabs">
                    <li>
                        <h4><a href="#chrome" title="Adicionar o Search no Chrome">Chrome</a></h4>
                    </li>
                    <li>
                        <h4><a href="#firefox" title="Adicionar o Search no Firefox">Firefox</a></h4>
                    </li>
                    <li>
                        <h4><a href="#explorer" title="Adicionar o Search no Internet Explorer">Explorer</a></h4>
                    </li>
                    <li>
                        <h4><a href="#opera" title="Adicionar o Search no Opera">Opera</a></h4>
                    </li>
                    <li>
                        <h4><a href="#safari" title="Adicionar o Search no Safari">Safari</a></h4>
                    </li>
                    <li>
                        <h4><a href="#outros" title="Adicionar o Search em outros navegadores">Outros</a></h4>
                    </li>
                </ul>
                <div class="border-box group">
                    <div id="chrome" class="panel group" style="padding-right: 10px; padding-left: 10px !important;">
                        <img src="/images/opensearch.png" alt="" class="alignleft" />
                        <h4>Adicione o Search no Chorme!</h4>
                        <p>
                            Uma das primeiras características do Chrome que o usuário novo costuma perceber é a ausência de uma barra de buscas, como a que existe no Mozilla Firefox ou Internet Explorer. Por meio dessa barra, o usuário pode pesquisar palavras-chaves em sites como o Google, Bing ou Ask.com e até mesmo no Search.

Com uma interface gráfica mais “limpa”, o usuário do Chrome usa a própria barra de endereços para realizar pesquisas, digitando nela palavras-chave ao invés de URLs. Mas como adicionar o Search no Chrome? 

Depois de ter visitado qualquer site do grupo <a href="http://www.vtnorton.com/?=engajamento">VTNORTON</a> (incluindo os sites no projeto <a href="/connect/Index.aspx">Connect</a>), você já está com o Search conectado ao seu  navegador. Para isso, basta começar a digitar o endereço do site (<a href="http://www.vtnorton.com/?=engajamento">vtnorton.com</a>) e pressionar a tecla Tab quando o Chrome identificar o endereço no histórico do navegador. Ao fazer isso, a barra ganha uma nova aparência, indicando que a palavra-chave digitada será usada para uma busca no Search, bastando então pressionar Enter.
                        </p>
                    </div>
                    <div id="firefox" class="panel group" style="padding-right: 10px; padding-left: 10px !important;">
                        <img src="/images/opensearch.png" alt="" class="alignleft" />
                        <h4>Adicione o Search no Firefox!</h4>
                        <p>
                            A Barra de Pesquisa está localizada no canto superior direito da janela do Firefox.
Para adicionar o Search, abra a lista de mecanismos de pesquisa, enquanto estiver navegando pelo site <a href="http://www.vtnorton.com/?=engajamento">vtnorton.com</a>, sites parceiros e sites no projeto <a href="/connect/Index.aspx">Connect</a>, e selecione Adicionar "Search". Então ele será adicionado à lista e se tornará o mecanismo de pesquisa ativo.
Para pesquisar, basta digitar um termo na barra de pesquisa e pressionar Enter e o Firefox irá levá-lo para a página com os resultados da pesquisa no Search.

                        </p>
                    </div>
                    <div id="explorer" class="panel group" style="padding-right: 10px; padding-left: 10px !important;">
                        <img src="/images/opensearch.png" alt="" class="alignleft" />
                        <h4>Adicione o Search ao Internet Explorer</h4>
                        <p>
                            Estamos trabalhando para adicionar o Internet Explorer, até mesmo nas versões mobiles, a nossa lista de navegadores conectados ao Search. Aguarde.
                        </p>
                    </div>
                    <div id="opera" class="panel group" style="padding-right: 10px; padding-left: 10px !important;">
                        <img src="/images/opensearch.png" alt="" class="alignleft" />
                        <h4>Adicione o Search ao Opera</h4>
                        <p>
                            Para adicionar o nosso motor de busca da forma mais conveniente proceda da seguinte forma: clique com o botão direito no campo de pesquisa e selecione “Criar pesquisa” no menu de contexto. Então basta dar um nome (Sugerimos “Search”) e adicionar uma palavra-chave. Clique em Ok e o nosso motor de busca estará pronto para eu possa ser utilizado onde quer que você esteja dentro do Opera. Caso tenha alguma dúvida consulte no suporte do Opera <a href="http://help.opera.com/Windows/9.23/pt/search.html">aqui</a>.
                        </p>
                    </div>
                    <div id="safari" class="panel group" style="padding-right: 10px; padding-left: 10px !important;">
                        <img src="/images/opensearch.png" alt="" class="alignleft" />
                        <h4>Adicione o Search ao Safari</h4>
                        <p>
                            Estamos trabalhando para adicionar o Safari a nossa lista de navegadores conectados ao Search, tanto para desktops quanto para dispositivos iOS. Aguarde. 
                        </p>
                    </div>
                    <div id="outros" class="panel group" style="padding-right: 10px; padding-left: 10px !important;">
                        <img src="/images/opensearch.png" alt="" class="alignleft" />
                        <h4>Adicionar o Search em outros navegadores</h4>
                        <p>
                            A maioria dos navegadores listados aqui, especialmente o Chrome e o Mozilla Firefox serviram de base para outros navegadores. Para conseguir adicionar o Search no seu navegador basta saber em que navegador ele foi baseado e seguir os passos descritos para ele.
                        </p>
                        <p>
                            Caso precise de ajuda para descobrir em qual navegador o seu foi baseado, ou caso queira entender melhor essa questão, entre em contato conosco por está <a href="/FormularioDeContato.aspx?=eng-adicionarnavegador">página</a>, ficaremos felizes em te ajudar.
                        </p>
                    </div>
                </div>
            </div>
            <div class="shadow"></div>
        </div>
    </div>
</asp:Content>

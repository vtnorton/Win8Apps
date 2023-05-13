<%@ Page Title="Sobre o Search | VTNORTON" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="sobre.aspx.cs" Inherits="VTNORTON.search.sobre" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta name="description" content="Pesquise por vídeos e músicas com o Search. Sem pop-ups, botões de Downloads, anúncios e Captchas. O Search tira tudo isso e facilita o seu download." />
    <meta name="author" content="Vítor Norton" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul style="margin-left: 0;">
        <li><a href="/hidra/Index.aspx">Pesquisar</a></li>
        <li><a class="ativo" href="sobre.aspx">Sobre</a></li>
        <li><a href="opiniao.aspx">Mande a sua sugestão</a></li>
        <li><a href="adicionarnavegador.aspx">Adicione o Search em seu navegador</a></li>
        <%--<li><a href="/mixer/Index.aspx">M!xer</a></li>--%>
        <%--<li><a href="#">Novidades</a></li>--%>
        <%--<li><a href="#">Diferencial</a></li>--%>
        <%--<li><a href="#">Pirataria</a></li>--%>
        <%--<li><a href="#">Ajuda</a></li>--%>
    </ul>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="content">
        <div id="slogan" style="height: 44px;" class="inner">
            <h1>Faça sua pesquisa aqui</h1>
            <h3>vídeos, músicas <span>de qualquer formato</span> na sua mão.</h3>
        </div>
        <div id="primary-total" class="hentry group wrapper-content" style="text-align: justify" role="main">
            Apresentação do Search como um mecanismo de pesquisa para facilitar downloads.<br />
            <p>
                Pesquise, através do poderoso Google, por vídeos e áudios, de uma forma prática e inovadora. Sabe aqueles pop-ups chatos, muitos botões escritos "Downloads", os anúncios demasiados que não permitem que você veja o conteúdo da página e os chatos Captchas. Pois é, com o Search nós tiramos tudo isso e facilitamos a sua pesquisa como nunca antes. Tão simples como o próprio Google, basta selecionar o tipo de arquivo que você está procurando, seja Músicas ou Vídeos. Faça download de seus arquivos favoritos de uma forma simples.
            </p>
            <br />
            <p>
                Em breve teremos mais novidades, mais suporte de arquivos.
            </p>
            <p>
                Versão atual: 1.0.2;<br />
                Data da última atualização: 15 de maio de 2014;<br />
                Data prevista da próxima versão: 03 de junho de 2014;<br />
            </p>
            <p>
                Histórico de versões:<br />
                1.0.0 - Pesquise, através do poderoso Google, por vídeos e áudios, de uma forma prática e inovadora. Sabe aqueles pop-ups chatos, muitos botões escritos "Downloads", os anúncios demasiados que não permitem que você veja o conteúdo da página e os chatos Captchas. Pois é, com o Search nós tiramos tudo isso e facilitamos a sua pesquisa como nunca antes. Tão simples como o próprio Google, basta selecionar o tipo de arquivo que você está procurando, seja Músicas ou Vídeos. Faça download de seus arquivos favoritos de uma forma simples.
                <br />
                <br />
                1.0.1 - Fizemos a correção em algumas palavras que não apareciam corretamente por causa do acento gráfico, adicionamos uma página sobre o Search e removemos links para o M!xer
 <br />
                <br />
                1.0.2 - Facilitamos a pesquisa, agora você pode entrar no Search direto pelo link http://search.vtnorton.com ou pelo link http://pesquisa.vtnorton.com, além disso adicionamos um campo onde você pode opinar sobre o Search, apreciaríamos muito a sua opinião. Adicionamos anúncios não invasivos no Search, além de ter feito correções e atualizado a página de sobre. Adicionamos o OpenSearch para poder integrar o Search com o seu navegador e criamos tutoriais para ajudar você. Refizemos a barra de busca, agora está mais limpa, simples e rápida. Melhoramos o código corrigindo erros e deixando a navegação extremamente mais rápida.
            </p>
            <br />
            <p>Em breve teremos mais novidades, mais suporte de arquivos.</p>


        </div>
    </div>
</asp:Content>

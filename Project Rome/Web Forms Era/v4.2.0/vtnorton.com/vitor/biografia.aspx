<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="biografia.aspx.cs" Inherits="VTNORTON.biografia" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>ul li p:first-letter{padding-left:0} ul li p{margin: 4px}</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul>
        <li><a href="/sobre">Sobre</a></li>
        <li><a class="on" href="/vitor/">Biografia</a></li>
        <li><a href="/linha-do-tempo.aspx">Linha do tempo</a></li>
        <li><a href="/redes-sociais">Redes Sociais</a></li>
        <li><a href="/faq">FAQ</a></li>
        <li><a href="/contato">Contato</a></li>
        <li><a href="/status.aspx">Status</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="box-content">
        <article>
            <h1>A história que ninguém quer ler</h1>
            <img src="profile-photo.png" alt="Vítor Norton" class="left" />
            <p>
                Como todo adolescente quis ir a festas e beber todas, infringir todas as regras da sociedade e quebrar os desafios impostos por meus amigos e por ele mesmo. Esse, definitivamente não sou eu. Definitivamente não sou de festas, e não bebo. Claro que em alguns momentos as regras impostas são feitas para serem quebradas e costumo quebrar os desafios impostos por mim e por quem sabe me desafiar. Aqui vai uma breve história: Nasci, no dia 30 de março - O ano fica oculto por motivos óbvios -, e morei no interior de Minas Gerais.
            </p>
            <p>
                Trabalhei durante anos (aproximadamente dois anos), em voluntariado, para o ministério infantil em uma igreja batista. Grande lição aprendida: não recuse ajudar, e também não recuse ajuda. Faz toda a diferença. Durante este tempo, antes de completar a minha maior idade, estudei italiano (por 2 anos) e fiquei fluente em Inglês, e tenho facilidade com o Espanhol e Francês. Tentei falar japonês, mas entendi algo: a vida é curta demais para aprender a falar japonês. Ainda antes dos 18 anos, fiz cursos de “Montagem e manutenção de computadores” e de “auxiliar de administração”.
            </p>
            <p>
                Trabalho com desenvolvimento web, de forma profissional, desde 2013. Já conhecia e comecei a estudar para tal em 2009, 4 anos antes de começar a faculdade. Com o tempo a experiência e principalmente os erros, me fizeram aprender mais e mais. Em relação a web, trabalho com CSS3, HTML5 e JavaScript como front-end, e back-end trabalho com Asp/.Net e C#. 
            </p>
            <p>
                O desenvolvimento web, para mim, é extremamente ligado ao design, a beleza de como os usuarios interagem com o site e a forma mais simples para tal. Tenho me especializado principalmente em design responsivo. Com o tempo aprendi a trabalhar, de forma profissional, com design para web, design para mídias sociais e confecção de cartões e convites. Trabalho com CorelDraw, em quase toda a suíte Adobe (sim, toda! Tendo destaque o Premiere, Photoshop, Illustrator e Flash Pro).
            </p>
            <img src="profile-photo-2.jpg" class="right" alt="Vítor Norton" />
            <p>
                O desenvolvimento para dispositivos moveis, e agora com o Windows 10, computadores, na plataforma da Microsoft, começou em 2014 com o aplicativo “Resultado das eleições 2014”, curiosamente é o segundo publicado, que teve, em 2 semanas, 8 mil downloads. Mas minha história com essa plataforma começou bem antes, já estudando e entendendo o funcionamento em 2010, logo no lançamento do Windows 8. O primeiro aplicativo “Calculadora de tempo” foi publicado alguns meses antes do segundo. Mas não consigo considerar como o primeiro pois não houve o uso de grandes tecnologias nele, nem muita popularidade. Para este tipo de desenvolvimento tenho uso avançado no Visual Studio, e trabalho com: XAML e C#/.Net. Também trabalho com o Microsoft Azure, SQL Server, Azure SQL Server, Azure Mobile Service e afins. Com o tempo aprendi mais linguagens, só por diversão, como Java, Visual Basic, F#, C e C++ por exemplo.
            </p>
            <p>
                Tenho experiências básicas com criação de jogos utilizando o Unity 3D junto ao Visual Studio para Windows Mobile e Xbox.
            </p>
            <p>
                Estou me formando em Sistemas de Informação onde adquiro experiência com desenvolvimento em Java e MySQL, além de C, e até mesmo redes, que não é meu ponto forte, a cada dia. 
            </p>
            <p>
                Desde de o ano de 2014 venho me apaixonando cada vez pela cultura Microsoft, no qual coleciono 50 certificados do MVA (Microsoft Virtual Academy) e pretendo futuramente, ter certificados de especialização na Microsoft e quem sabe não recebo um MVP (Most Value Person). Hoje sou usuário avançado na plataforma Windows, especialmente os mais atuais 8 e 10, além de experiências e cursos com o Windows Server 2012 R2, sou um Insider.
            </p>
            <p>
                O programa de feedback da Microsoft, Windows Insiders, reúne mais de 5 milhões de pessoas ao redor do mundo para ajudar a criar um sistema operacional melhor junto a equipe de desenvolvimento do Windows. Tive a honra de ser um, de 10, Insiders que foram chamados para visitar o Campus da Microsoft em Redmond, Wa, e conhecer as pessoas maravilhosas, incluindo o Joe Belfiore e o Gabriel Aul, que estão por tras desse universo. Você pode ver um pouco mais dessa história em um post no <a href="http://blogs.windows.com/bloggingwindows/2015/06/08/ten-windows-insiders-get-a-close-up-look-at-how-were-building-windows/">blog da Microsoft</a> (em inglês).
            </p>
            <p>
                Ainda há muito o que escrever nessa história, e continuarei a escrever sempre que um novo capítulo surgir... fique atento nessa página!
            </p><br />

            <hr /><br />
            <h1>Curiosidades sobre mim, mas é claro, ninguém está interessado.</h1>
            <br />
            <ul style="list-style:outside; margin-left:20px;">
                <li><p>Existem só duas regras para serem meus amigos: 1 – Ser uma pessoa de personalidade descente. 2 – Me pagar um pedaço de pizza.</p></li>
                <li><p>Sou a segunda pior pessoa para se ter como inimigo.</p></li>
                <li><p>Morar em duas cidades me fez entender que existe apenas algumas coisas essenciais para mim, isso me faz cada vez menos me apegar aos bens matérias. </p></li>
                <li><p>Tenho uma excelente memória para datas.</p></li>
                <li><p>Sou pontual, quando o transito da cidade coopera!</p></li>
                <li><p>Sou patologicamente tímido nas primeiras vezes que encontro uma pessoa, mas depois que pego intimidade, é difícil me fazer calar a boca.</p></li>
                <li><p>Tenho milhares de milhares de ideias todos os dias. Nem um por cento é aproveitada. Por falta de recursos, inspiração ou por preguiça mesmo.</p></li>
                <li><p>Amo fazer listas.</p></li>
                <li><p>Sei tocar piano e um pouco de flauta (falta prática).</p></li>
                <li><p>Trabalhar com prazos apertados me faz ser mais produtivo.</p></li>
                <li><p>Diferente de todos os outros desenvolvedores, odeio café. Fique a vontade para me julgar. </p></li>
                <li><p>Diferente do que muitos pensam não gosto de jogos, e não passo o dia em conversa fiada. </p></li>
                <li><p>Sou muito bom na cozinha.</p></li>
            </ul>
        </article>
    </div>
</asp:Content>

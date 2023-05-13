<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="faq.aspx.cs" Inherits="VTNORTON.FAQ" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/faq-css.css" rel="stylesheet" />
    <script src="/js/modernizr.js"></script>
    <style>
        img {
            max-height: 200px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul>
        <li><a href="/sobre">Sobre</a></li>
        <li><a href="/vitor/">Biografia</a></li>
        <li><a class="on" href="/faq">FAQ</a></li>
        <li><a href="/contato">Contato</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="cd-faq">
        <ul class="cd-faq-categories">
            <li><a class="selected" href="#dev">Desenvolvimento</a></li>
            <li><a href="#about">Sobre mim</a></li>
            <li><a href="#sites">Sites</a></li>
            <li><a href="#others">Outras</a></li>
        </ul>

        <div class="cd-faq-items">
            <ul id="dev" class="cd-faq-group">
                <li class="cd-faq-title">
                    <h2>Desenvolvimento</h2>
                </li>
                <li>
                    <a class="cd-faq-trigger" href="#0">Tenho perguntas relacionadas a criação de sites, estou no lugar certo?</a>
                    <div class="cd-faq-content">
                        <p>Por favor entre em contato via e-mail para mais informações e para solicitar um orçamento.</p>
                    </div>
                </li>
                <li>
                    <a class="cd-faq-trigger" href="#0">Tenho uma ideia de aplicativo ou game ou site, você poderia fazer?</a>
                    <div class="cd-faq-content">
                        <p>Ideias são sempre bem vindas e nenhuma é descartada. Envie-me a sua ideia, e quem sabe ela não será feita. Se você deseja um aplicativo somente seu, entre em contato para orçamento. </p>
                    </div>
                </li>
                <li>
                    <a class="cd-faq-trigger" href="#0">Por que não desenvolver para Android e iOS ou outras plataformas?</a>
                    <div class="cd-faq-content">
                        <p>Sou apenas um. Para criar aplicativos para iOS é preciso saber programar Swift e de um Mac, algo que eu não tenho (aceito doações). Para o Android é preciso saber Java, porém não tenho interesse em desenvolver para uma plataforma que eu não acredito ser ideal. Mas quem sabe, num futuro proxímo, eu mude de ideia... nunca descarto as possíbilidades.</p>
                    </div>
                </li>
            </ul>

            <ul id="about" class="cd-faq-group">
                <li class="cd-faq-title">
                    <h2>Sobre mim</h2>
                </li>
                <li>
                    <a class="cd-faq-trigger" href="#0">Você gosta de Lol ou Wow ou Minecraft ou algum outro game?</a>
                    <div class="cd-faq-content">
                        <p>Não sou adepto a jogos, claro que existem os casuais. Jogava Minecraft para construir algumas coisas, fora isso não sei nada mais.</p>
                    </div>
                </li>
                <li>
                    <a class="cd-faq-trigger" href="#0">Você vive falando da Microsoft, ela te paga alguma coisa?</a>
                    <div class="cd-faq-content">
                        <p>Falo e falo bem mesmo. Milhares de pessoas falam e falam de seus times e artistas e ninguém discute isso. A Microsoft não me paga nada para isso, mas seria bom. Hoje o site e alguns serviços essenciais para o funcionamento de outros sites e aplicativos meus estão hospedados no Azure, que está sendo pago pelo plano BizSpark da Microsoft. Pensando bem, ela me paga sim. E também, pagou uma viagem para conhece-los em Redmond, WA em Abril de 2015.</p>
                    </div>
                </li>
                <li>
                    <a class="cd-faq-trigger" href="#0">Não entendo nada que você publica ou escreve, você é normal?</a>
                    <div class="cd-faq-content">
                        <p>Não, eu não sou normal. A maioria das coisas que escrevo é sobre alguns mundos, como tecnologia, séries de tv e afins, e somente quem está por dentro desses mundos consegue entender. Sinto muito.</p>
                    </div>
                </li>
                <li>
                    <a class="cd-faq-trigger" href="#0">Além de computadores e séries de TV, você entende alguma outra coisa?</a>
                    <div class="cd-faq-content">
                        <p>Sou apaixonado por história, especialmente a história da arte, dos Estados Unidos e a do Egito. Também sou apaixonado por música, teatro e dança. Também adoro teorias da conspiração.</p>
                    </div>
                </li>
                <li>
                    <a class="cd-faq-trigger" href="#0">Não gosto de você.</a>
                    <div class="cd-faq-content">
                        <p>Isso não foi uma pergunta.</p>
                    </div>
                </li>
                <li>
                    <a class="cd-faq-trigger" href="#0">Você é um garoto de programa né?</a>
                    <div class="cd-faq-content">
                        <p>Isso depende.</p>
                    </div>
                </li>
            </ul>

            <ul id="sites" class="cd-faq-group">
                <li class="cd-faq-title">
                    <h2>Sites</h2>
                </li>
                <li>
                    <a class="cd-faq-trigger" href="#0">Não estou conseguindo acessar alguns sites que deveriam estar em seu nome.</a>
                    <div class="cd-faq-content">
                        <p>Devido a mudanças internas retirei da web diversos sites com o nome vtnorton. Caso você esteja tentando acessar ao site icesperafeliz.vtnorton.com, entre atravéz do endereço <a href="http://icesperafeliz.blogspot.com"  title="Entrar em icesperafeliz.blogspot.com" target="_blank">icesperafeliz.blogspot.com</a>. Os sites beta.vtnorton.com, vitor.vtnorton.com, hidra.vtnorton.com, www2.vtnorton.com e hot.vtnorton.com não estão disponíveis mais, assim como projetos como a Jade.</p>
                    </div>
                </li>
                <li>
                    <a class="cd-faq-trigger" href="#0">Não estou conseguindo acessar o meu e-mail @vtnorton.com</a>
                    <div class="cd-faq-content">
                        <p>Muitos e-mails foram desativados, com o conhecimento do dono do endereço. Foram feito backups dos dados e você têm 90 dias para poder pedir o acesso a tais dados, por favor entre em <a href="/contato" title="Entrar em contato" target="_blank">contato</a> comigo.</p>
                    </div>
                </li>
            </ul>

            <ul id="others" class="cd-faq-group">
                <li class="cd-faq-title">
                    <h2>Outras</h2>
                </li>
                <li>
                    <a class="cd-faq-trigger" href="#0">Pode arrumar a minha impressora?</a>
                    <div class="cd-faq-content">
                        <p>Não.</p>
                    </div>
                </li>
                <li>
                    <a class="cd-faq-trigger" href="#0">Por que não tem fotos de gatos por aqui?</a>
                    <div class="cd-faq-content">
                        <p>
                            Temos sim, olha...
                            <br />
                            <img alt="Gatos casando" src="images/others/cat_1.jpg" />
                            <img alt="Gato com cabeça torta" src="images/others/cat_5.jpg" />
                            <img alt="Gato piscando" src="images/others/cat_2.jpg" />
                            <img alt="Gato tentando afogar o outro gato no pote de ração... coitado, mal sabe ele que o zinca estava morrendo de fome." src="images/others/cat_3.jpg" />
                            <img alt="Self felina" src="images/others/cat_4.jpg" />
                        </p>
                    </div>
                </li>
            </ul>

        </div>
        <a href="#0" class="cd-close-panel">Close</a>
    </section>
    <script src="/js/jquery.mobile.custom.min.js"></script>
    <script src="/js/main.js"></script>
</asp:Content>

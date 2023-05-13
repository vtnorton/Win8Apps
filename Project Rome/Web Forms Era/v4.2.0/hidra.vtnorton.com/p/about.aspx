<%@ Page Title="Sobre + Ajuda" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="about.aspx.cs" Inherits="HidraOnline.p.about" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul>
        <li><a class="on" href="/p/about.aspx">Sobre a Hidra OS</a></li>
        <li><a href="/p/ajuda.aspx">Ajuda e suporte</a></li>
        <li><a href="/p/contato.aspx">Contato com o desenvolvedor</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="seventyfivepercent left">
        <div class="toggle-options-head">Sobre + história</div>
        <hr />
        <article>
            <p>
                O projeto Hidra OS começou em 2013 atravéz da necessidade de criar um sistema único para gerenciamento de algumas funções comuns, como blog, podcasts, slide, histórias e de fácil integração com projetos feitos em .Net, onde o desenvolvedor tem total liberdade de trabalhar como quiser, na ferramente que quiser e na linguagem que quiser trabalhar o website. Isso claro facilitando a vida dos 
                administradores. Porém só em 2015 esteve funcional e saiu dos papeis. Sua fase alpha começou oficialmente em julho de 2015, e a fase beta veio em março de 2016. Ainda não se sabe quando será feita a versão oficial, mas em breve, meus caros.
            </p>
            <p>
                A Hidra OS usa alguns frameworks para poder funcionar, entenda aqui quais são e o que eles fazem exatamente:
                
            </p>
            <ul>
                <li><strong>Black! Framework (B#!): </strong>Todo sistema precisa ter uma base, e o da Hidra OS é o Black! Framework, comulmente chamado de B#!. Esse projeto criado em C# abriga os tipos de dados, e metódos comuns utliziados em quase todos os softwares criados por Vítor Norton.</li>
                <li><strong>Ladon: </strong>O framework Ladon é o responsável por fazer a comunicação da Hidra OS com o B#! e com o banco de dados, através do <strong>Fluent NHibernate</strong> e SQL nativo.</li>
                <li><strong>Hidra Framework: </strong>Semelhante ao Ladon, é responsavel por fazer a comunicação da Hidra OS com o banco de dados, porém atravez do Azure Mobile Service, sendo assim este é utilizado somente para os aplicativos mobile da Hidra OS.</li>
                <li><strong>All Vtnorton: </strong>Este por sua vez carrega uma série de informações comuns, como template de emails, versões e descrições de sistemas entre outros, dos softwares produzidos por Vítor Norton.</li>
            </ul>
            <p>
                O sistema está em constante evolução e cada vez mais integrará com sistemas prontos, como Facebook, Google e até mesmo com sistemas nativos produzidos por Vítor Norton, como aplicativos de podcast e até mesmo o M!xer. O sistema tende a se tornar o único sistema que uma empresa precisará para gerenciar tudo, tendo uma caixa de e-mail propria e gerencimaento de clientes, loja e documentos. Mas isso, só futuramente. Antes, preciso de sua ajuda para manter o sistema fluido e maduro,
                para me ajudar envie <a href="/p/sugestion.aspx" title="Enviar sugestão" class="green">uma sugestão</a> ou <a class="green" href="/p/Bug.aspx" title="Reportar o surgimento de um problema">reporte um problema</a>.
            </p>
        </article>
    </div>
    <div class="twentyfivepercent right">
        <div class="toggle-options-head">Verções + informações</div>
        <hr />
        <p>
            Constantemente estou atualizando o sistema trazendo novas funcionalidades, correções de erros e melhorias de desempenho. Sempre que possível lanço um changelog com as alterações realizada, que pode ser acessado em meu <a target="_blank" title="Acessar o meu blog" href="http://www.vtnorton.com/blog" class="green">blog</a>. 
        </p>
        <p>
            Hidra OS:
            <asp:Label ID="lblHiraOnline" runat="server" Text=""></asp:Label><br />
            Heartthrob:
            <asp:Label ID="lblHeartthrob" runat="server" Text=""></asp:Label><br />
            Hidra framework:
            <asp:Label ID="lblHidra" runat="server" Text=""></asp:Label><br />
            Ladon framework:
            <asp:Label ID="lblLadon" runat="server" Text=""></asp:Label><br />
            Black! framework:
            <asp:Label ID="lblBuildFramework" runat="server" Text=""></asp:Label><br />
            OpenSearch:
            <asp:Label ID="lblOpenSearch" runat="server" Text=""></asp:Label><br />
            <br />
            <strong>Build atual:
                <asp:Label ID="lblBuild" runat="server" Text=""></asp:Label><br />
            </strong>
        </p>
        <h5>Agradescimentos</h5>
        <hr />
        <p>
            Plugins de terceiros que fazem a sua expêriencia com a Hidra OS serem melhores e que faz tudo funcionar.<br />
            <ul class="list">
                <li><a class="green" href="http://ricostacruz.com/nprogress/">NProgress</a></li>
                <li><a class="green" href="http://cksource.com/ckeditor">CKEditor</a></li>
                <li><a class="green" href="http://www.cssscript.com/responsive-step-progress-indicator-with-pure-css/">CSSsScript</a></li>
            </ul>
        </p>
    </div>
    <div class="clean"></div>
</asp:Content>

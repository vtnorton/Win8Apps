<%@ Page Title="Entrar em contato" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="contato.aspx.cs" Inherits="HidraOnline.p.contato" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul>
        <li><a href="/p/about.aspx">Sobre</a></li>
        <li><a href="/p/ajuda.aspx">Ajuda+Suporte</a></li>
        <li><a class="on" href="/p/contato.aspx">Contato</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <h1>Entrar em contato</h1>
    <span>Entre em contato caso precise de ajuda, ou deseja enviar algum feedback (sugestões ou críticas)</span>
    <div class="left half">
        <h2>Formas de contato</h2>
        <br />
        <p>
            vitor@vtnorton.com<br />
            contato@vtnorton.com<br />
            Cachoeiro de Itapemirim - Espírito Santo, Brazil<br />
        </p>

        <br />
        <p>
            Lista de formas de contato em ordem preferencial.
        Não deixe de entrar em contato comigo caso tenha alguma dúvida ou deseja fazer um orçamento para um site pessoal, empresarial, hotsite ou sites diversos.
        </p>
        <h4>Observações</h4>
        <p>
            Caso deseje enviar alguma informação referente ao uso abusivo ou inapropriado de texto, imagens, ou outros ou reportar erros (bugs) encontrados no site ou em nossos aplicativos por favor, clique no ícone de informação do lado direito do menu, ao lado dos ícones de pesquisa e acessibilidade. Usando esse metódo as informações que irei receber serão mais consisas e me ajudará a te ajudar.<br />
            Nenhuma informação além das informadas (Nome, E-mail e Mensagem) serão enviadas para mim. Absolutamente nenhuma informação será compartilhada sem o prévio consenso do autor.
        </p>

    </div>
    <div class="right half">
        <h2>Use este formulario de contato</h2>
        <h4>Ideias, sugestões, criticas, ou simplesmente bate-papo</h4>
        <asp:TextBox ID="txtInvalidSpam" runat="server" CssClass="displaynone" placeholder="Não preencha esse campo"></asp:TextBox><br />
        <asp:TextBox ID="txtNome" runat="server" placeholder="Digite seu nome"></asp:TextBox><br />
        <br />
        <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" placeholder="Digite seu e-mail"></asp:TextBox><br />
        <br />
        <asp:TextBox ID="txtMensagem" runat="server" placeholder="Digite sua mensagem" TextMode="MultiLine" Wrap="False"></asp:TextBox><br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Enviar" />
        <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
    </div>
    <div class="clean"></div>
</asp:Content>

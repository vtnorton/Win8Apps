<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="formulariodecontato.aspx.cs" Inherits="VTNORTON.FormularioDeContato" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul>
        <li><a href="/sobre">Sobre</a></li>
        <li><a href="/vitor/">Biografia</a></li>
        <li><a href="/linha-do-tempo.aspx">Linha do tempo</a></li>
        <li><a href="/redes-sociais">Redes Sociais</a></li>
        <li><a href="/faq">FAQ</a></li>
        <li><a class="on" href="/contato">Contato</a></li>
        <li><a href="/suporte/status.aspx">Status do serviço</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="box-content">
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
        </div>
        <div class="right half">
            <h2>Use este formulario de contato</h2>
            <h5 style="margin: 5px 0">Ideias, sugestões, criticas, ou simplesmente bate-papo</h5>
            <asp:TextBox ID="txtInvalidSpam" runat="server" CssClass="displaynone" placeholder="Não preencha esse campo"></asp:TextBox>
            <asp:TextBox ID="txtNome" runat="server" placeholder="Digite seu nome"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" placeholder="Digite seu e-mail"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtMensagem" runat="server" placeholder="Digite sua mensagem" TextMode="MultiLine" CssClass="full"  Wrap="False"></asp:TextBox>
            <br /><asp:Label ID="Label4" runat="server" Text=""></asp:Label>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Enviar" />
        </div>
        <div class="clean"></div>
    </div>
    <div class="box-content">
        <h2>Observações</h2><br />
        <p>Caso deseje enviar alguma informação referente ao uso abusivo ou inapropriado de texto, imagens, ou outros ou reportar erros (bugs) encontrados no site ou em nossos aplicativos por favor, clique no ícone de informação do lado direito do menu, ao lado dos ícones de pesquisa e acessibilidade. Usando esse metódo as informações que irei receber serão mais consisas e me ajudará a te ajudar.</p>
        <p>Nenhuma informação além das informadas (Nome, E-mail e Mensagem) serão enviadas para mim. Absolutamente nenhuma informação será compartilhada sem o prévio consenso do autor.</p>
    </div>
</asp:Content>

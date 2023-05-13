<%@ Page Title="Entrar em contato" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="contato.aspx.cs" Inherits="HidraOnline.p.contato" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul>
        <li><a href="/p/about.aspx">Sobre a Hidra OS</a></li>
        <li><a href="/p/ajuda.aspx">Ajuda e suporte</a></li>
        <li><a class="on" href="/p/contato.aspx">Contato com o desenvolvedor</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="seventyfivepercent left">
        <div class="toggle-options-head">Formulário de contato</div>
        <hr />
        <p>
            Por favor, entre em contato caso precise de ajuda ou por qualquer que seja o motivo (Ideias, sugestões, critícas ou simplesmente bate-papo). Vale lembrar que existe páginas especiais para enviar <a href="/p/sugestion.aspx" title="Enviar sugestão" class="green">uma sugestão</a> ou <a class="green" href="/p/Bug.aspx" title="Reportar o surgimento de um problema">reporte um problema</a>.
        </p>
        <asp:TextBox ID="txtInvalidSpam" runat="server" CssClass="displaynone" placeholder="Não preencha esse campo"></asp:TextBox><br />
        <asp:TextBox ID="txtNome" runat="server" placeholder="Digite seu nome"></asp:TextBox><br />
        <br />
        <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" placeholder="Digite seu e-mail"></asp:TextBox><br />
        <br />
        <asp:TextBox ID="txtMensagem" runat="server" placeholder="Digite sua mensagem" TextMode="MultiLine" Wrap="False"></asp:TextBox><br />
        <br />
        <asp:Button ID="Button1" runat="server" Height="50" CssClass="btn-green" Width="250" OnClick="Button1_Click" Text="Enviar" />
        <asp:Label ID="Label4" runat="server" Text=""></asp:Label>

    </div>
    <div class="twentyfivepercent right">
        <div class="toggle-options-head">Outras formas de contato</div>
        <hr />
        <p>
            Por favor, sinta-se livre para entrar em contato através dos sequintes endereços de e-mail. A lista está em ordem de contato preferencial.
            <br />
            Por favor não deixe de entrar em contato comigo caso tenha alguma dúvida ou deseja fazer um orçamento para um site pessoal, empresarial, hotsite ou sites diversos.
        </p>
        <p>
            vitor@vtnorton.com<br />
            contato@vtnorton.com<br />
            Cachoeiro de Itapemirim - Espírito Santo, Brazil<br />
        </p>
        <h5>Observações</h5>
        <hr />
        <p>
            Nenhuma informação além das informadas (nome, e-mail e mensagem) serão enviadas para mim. Absolutamente nenhuma informação será compartilhada sem o prévio consenso do autor.
        </p>
    </div>
    <div class="clean"></div>
</asp:Content>

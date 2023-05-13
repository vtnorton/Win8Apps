<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="atualizacao.aspx.cs" Inherits="VTNORTON.pages.atualizacao" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul style="margin-left: 0;">
        <li><a href="/status.aspx">Histórico de versões</a></li>
        <li><a href="/suporte.aspx">Suporte</a></li>
        <!-- Fazer link para o suporte especifico deste produto -->
        <li><a href="/relatar-bug.aspx">Relatar bug</a></li>
        <li><a href="/formulariodecontato.aspx">Entrar em contato</a></li>
        <li><a href="/faq.aspx">FAQ</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="faixadecor" style="background: #5f37be; padding: 30px 0 20px 0;">
        <div class="margin">
            <h1 class="att-title">
                <asp:Label ID="lblNomeVersao" runat="server" Text="Nova atualização"></asp:Label></h1>
            <h3 class="att-info">
                <asp:Label ID="lblSolucao" runat="server" Text="x"></asp:Label>
                - Data da atualização:
            <asp:Label ID="lblData" runat="server" Text="00/00/00"></asp:Label>
                - Versão atual:
            <asp:Label ID="lblVersao" runat="server" Text="0.0.0"></asp:Label></h3>
        </div>
    </div>

    <div class="wrapper-margin">
        <div class="att-descricao">
            <asp:Label ID="lblDescricao" runat="server" Text="Essa atualização trás correções e melhorias"></asp:Label>
        </div><hr />
        <div class="att-changelog">
            <h2>Changelog</h2>
            <asp:Label ID="lblChangelog" runat="server" Text="Correções de bugs"></asp:Label>
        </div><hr />
        <form style="padding-top: 15px; padding-bottom: 40px;" runat="server">
            <asp:Label ID="lblTituloComentarioAtualizacao" runat="server" Text="<h2>Enviar comentários</h2> Sua opinião é importante para nós."></asp:Label><br />
            <asp:TextBox ID="txtNome" Width="450" runat="server" placeholder="Digite seu nome" Wrap="False" EnableTheming="True"></asp:TextBox><br />
            <asp:TextBox ID="txtEmail" Width="450" runat="server" placeholder="Digite seu e-mail, não divulgaremos. (Opcional)" Wrap="False" EnableTheming="True"></asp:TextBox><br />
            <h3>Este artigo foi útil?</h3>
            <asp:RadioButtonList ID="rdlComentarioUtil" runat="server">
                <asp:ListItem Text="Sim" Value="Sim"></asp:ListItem>
                <asp:ListItem Text="Não" Value="Nao"></asp:ListItem>
                <asp:ListItem Text="Um pouco" Value="Pouco"></asp:ListItem>
            </asp:RadioButtonList><br />
            <h3>O que você achou desta atualização?</h3>
            <asp:RadioButtonList ID="rdlComentarioPro" runat="server">
                <asp:ListItem Text="Péssima" Value="Pessima"></asp:ListItem>
                <asp:ListItem Text="Ruim" Value="Ruim"></asp:ListItem>
                <asp:ListItem Text="Moderada" Value="Moderada"></asp:ListItem>
                <asp:ListItem Text="Boa" Value="Boa"></asp:ListItem>
                <asp:ListItem Text="Excelente" Value="Excelente"></asp:ListItem>
            </asp:RadioButtonList>
            <asp:TextBox ID="txtComentarioAtt" TextMode="MultiLine" Height="120" Width="450" runat="server" placeholder="Digite um comentário" Wrap="False" EnableTheming="True"></asp:TextBox><br />
            <asp:Label ID="lblComentario" runat="server" Text=""></asp:Label><br />
            <asp:Button ID="btnComentarioAtt" runat="server" OnClick="btnComentarioAttOC" Text="Enviar" />
        </form>
    </div>
</asp:Content>

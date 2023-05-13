<%@ Page Title="Reportar bug" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Bug.aspx.cs" Inherits="HidraOnline.p.Bug" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul>
        <li><a class="on" href="/p/Bug.aspx">Relatar problema</a></li>
        <li><a href="/p/novo/sugestion.aspx">Nova sugestão</a></li>
        <li><a href="/p/manage/bugs.aspx">Gerenciar feedback</a></li>
        <li><a href="/p/manage/advanced-bugs.aspx">Gerenciamento avançado de feedback</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">

    <div class="left seventyfivepercent">
        <asp:TextBox ID="txtEmail" placeholder="E-mail" TextMode="Email" CssClass="full" runat="server"></asp:TextBox>

        <asp:TextBox ID="txtDescricao" onKeyUp="CountChar('Content_txtDescricao', 2000, 'Count_txtDescricao')" placeholder="Descrição do bug" CssClass="full" TextMode="MultiLine" Height="100" runat="server"></asp:TextBox>
        <div class="lblCountCharFull">
            <span id="Count_txtDescricao">Nenhum caractere inserido até o momento.</span>
        </div>
            <asp:Label ID="lblInfo" runat="server" Text=""></asp:Label>
    </div>
    <div class="right twentyfivepercent">
        <div class="toggle-options-head">Reportar Bug</div>
        <hr />
        <p>
            Por favor, me informe o erro que você encontrou. Vale de tudo, erros de português, algumas coisa que não deveria estar onde está. O que está faltando? Quanto mais feedback melhor o sistema vai ficar.
        <br />
            Por favor, me informe seu e-mail para que eu possa te responder o mais rapído possível quando o bug for concertado!
        </p>
        <h5>Opções</h5>
        <hr />
        <p>
            <asp:CheckBox ID="ckbNaoEmail" Text="Não me enviar por e-mail" runat="server" />
        </p>
        <br />

        <h5>Ao reportar bug</h5>
        <hr />
        <article>
            <p>Você receberá por e-mail as mesmas informações compartilhadas comigo. Caso não queria receber com e-mail, maque a opção "Não me enviar por e-mail". Quando o problema for solucionado você receberá um e-mail informando e agradecendo pela sugestão.</p>
        </article>
        <br />
        <br />
        <asp:Button ID="btnEnivar" CssClass="full100 btn-green" Height="50" OnClick="btnEnivar_Click" runat="server" Text="Enviar" /><br />
    </div>
    <div class="clean"></div>
</asp:Content>

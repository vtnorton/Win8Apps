<%@ Page Title="Nova sugestão" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="sugestion.aspx.cs" Inherits="HidraOnline.p.novo.sugestion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul>
        <li><a href="/p/Bug.aspx">Relatar problema</a></li>
        <li><a class="on" href="/p/novo/sugestion.aspx">Nova sugestão</a></li>
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
        <div class="toggle-options-head">Nova sugestão</div>
        <hr />
        <p>Sugira alguma alteração no sistema e em breve ela séra incluida, caso seja válidada.</p>

        <h5>Opções</h5>
        <hr />
        <p>
            <asp:CheckBox ID="ckbNaoEmail" Text="Não me enviar por e-mail" runat="server" /></p>
        <br />

        <h5>Ao enviar uma sugestão</h5>
        <hr />
        <article>
            <p>Você receberá por e-mail as mesmas informações compartilhadas comigo. Caso não queria receber com e-mail, maque a opção "Não me enviar por e-mail". Quando a sugestão for acatada você receberá um e-mail informando e agradecendo pela sugestão.</p>
        </article>
        <br />
        <br />
        <asp:Button ID="btnEnivar" OnClick="btnEnivar_Click" CssClass="full100 btn-green" Height="50" runat="server" Text="Enviar" /><br />
    </div>
    <div class="clean"></div>
</asp:Content>

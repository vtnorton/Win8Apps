<%@ Page Title="Enviar sugestão | Vítor Norton" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="sugestion.aspx.cs" Inherits="VTNORTON.sugestion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul>
        <li><a href="/">Pagina Inicial</a></li>
        <li><a onclick="parent.history.back()" href="#">Voltar para a pagina anterior</a></li>
        <li><a href="/suporte/status.aspx">Status do serviço</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="box-content">
        <div class="seventyfivepercent left">
            <h1>Enviar sugestão</h1>
            <hr />
            <p>Por favor, descreva o máximo possível que talvez implementarei no sistema.</p>
            <asp:TextBox ID="txtInvalidSpam" runat="server" CssClass="displaynone" placeholder="Não preencha esse campo"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" placeholder="Digite seu e-mail"></asp:TextBox><br />
            <br />
            <asp:TextBox ID="txtMensagem" onKeyUp="CountChar('ContentPlaceHolder1_txtMensagem', 2000, 'Count_txtMensagem')"  runat="server" CssClass="full" placeholder="Digite sua mensagem" TextMode="MultiLine" Wrap="False"></asp:TextBox><br />
            <div class="lblCountCharFull">
                <span id="Count_txtMensagem">Nenhum caractere inserido até o momento.</span>
            </div>
            <br />
            <asp:CheckBox ID="ckbNotSendEmail" Text="Não me enviar por e-mail" runat="server" /><br />
            <asp:Label ID="lblTexto" runat="server" Text=""></asp:Label><br />
        </div>
        <div class="twentyfivepercent right">
            <h1>Observações</h1>
            <hr />
            <article>
                <p>
                    Quando atualizar o meu site com a sua sugestão, informarei via e-mail para você.
                </p>
                <p>#observação | Levo denuncias e avisos de bug muito a sério. Por favor, descreva o seu problema em detalhes.</p>
                <p>
                    #privacidade | Você receberá uma cópia de e-mail com todos os dados compartilhados comigo (caso não queria receber tal e-mail, marque a opção "Não me enviar por e-mail".
                </p>
            </article>
            <asp:Button ID="btnEnviar" runat="server" CssClass="full" Height="50" OnClick="btnEnviar_Click" Text="Enviar" />
        </div>
        <div class="clean"></div>
    </div>
</asp:Content>

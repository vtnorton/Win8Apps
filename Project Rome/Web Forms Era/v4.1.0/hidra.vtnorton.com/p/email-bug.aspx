<%@ Page Title="Enviar e-mail" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="email-bug.aspx.cs" Inherits="HidraOnline.p.email_bug" %>

<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .cbx {
            position: relative;
            top: -10px;
            margin-left: -4px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SUBMENU" runat="server">
     <ul>
        <li><a href="/p/Bug.aspx">Novo bug</a></li>
        <li><a href="/p/novo/sugestion.aspx">Nova sugestão</a></li>
        <li><a href="/p/manage/bugs.aspx">Gerenciar feedback</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
      <div class="left seventyfivepercent">

        <asp:TextBox ID="txtInvalidSpam" runat="server" CssClass="displaynone" placeholder="Não preencha esse campo"></asp:TextBox>
        <asp:TextBox ID="txtSubject" runat="server" placeholder="Assunto"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" placeholder="Destinatário"></asp:TextBox>
        <br />
        <CKEditor:CKEditorControl ID="CKEditor1" BasePath="/plugins/ckeditor/" Height="400px" runat="server"></CKEditor:CKEditorControl><br />
    </div>
    <div class="right twentyfivepercent">
        <div class="toggle-options-head">Configurações de e-mail</div>
        <div class="toggle-options-main">
            <p>Insira aqui algumas breves configurações, como idioma do e-mail (aplicavel para o rodapé e a assinatura do e-mail) e a conta de e-mail com o qual gostaria de ser o remetente. Vale lembrar que a conta jade@vtnorton.com não é monitorada, então não espere uma resposta através desta conta de e-mail.</p>

            <h5>Opções:</h5>
            <hr />
            <div class="left half">
                Idioma do e-mail:
                <br />
                <br />
                Remetente do e-mail:<br />
                <br />
                Incluir cabeçalho:
                <br />
            </div>
            <div class="right half">
                <asp:DropDownList ID="ddlLanguageEmail" CssClass="full" runat="server">
                    <asp:ListItem Text="Português (Brasil)" Enabled="true" Selected="True" Value="pt-br"></asp:ListItem>
                    <asp:ListItem Text="English (United States)" Enabled="true" Selected="False" Value="en-us"></asp:ListItem>
                </asp:DropDownList><br />
                <br />
                <asp:DropDownList ID="ddlFrom" CssClass="full" runat="server">
                    <asp:ListItem Text="vitor@vtnorton.com" Enabled="true" Selected="True" Value="ddlVitorAccount"></asp:ListItem>
                    <asp:ListItem Text="contato@vtnorton.com" Enabled="true" Selected="False" Value="ddlContactAccount"></asp:ListItem>
                    <asp:ListItem Text="jade@vtnorton.com" Enabled="true" Selected="False" Value="ddlJadeAccount"></asp:ListItem>
                </asp:DropDownList><br />
                <br /><br />
                <asp:CheckBox ID="cbxHeader" CssClass="cbx" runat="server" />
                <br />
            </div><br />
            <div class="clean"></div>
            <h5>Suporte</h5>
            <hr />
            <p>
                Caso esteja com problemas por favor, não exite em contactar o administrador do sistema pelo e-mail vitor@vtnorton.com, ou pelo telefone +55 (28) 9 9972-2490.
            </p>
        </div>
        <asp:Label ID="Label4" runat="server" Text=""></asp:Label><br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Enviar" />
    </div>
    <div class="clean"></div>
</asp:Content>

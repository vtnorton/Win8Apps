<%@ Page Title="Enviar e-mail" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="email.aspx.cs" Inherits="HidraOnline.p.email" %>

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
        <li><a href="/p/slides.aspx">Editar slides do site</a></li>
        <li><a href="/p/avaliacoes.aspx">Avaliações de usuários</a></li>
        <li><a href="/p/information.aspx">Informações gerais</a></li>
        <li><a href="/p/bugs.aspx">elatórios de bug</a></li>
        <li><a class="on" href="/p/email.aspx">Enviar e-mail</a></li>
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
        <hr />

        <p>Insira aqui algumas breves configurações, como idioma do e-mail (aplicavel para o rodapé e a assinatura do e-mail) e a conta de e-mail com o qual gostaria de ser o remetente. Vale lembrar que a conta jade@vtnorton.com não é monitorada, então não espere uma resposta através desta conta de e-mail.</p>

        <h5>Opções:</h5>
        <hr />

        <div class="left">
            <p>Idioma do e-mail:</p>
        </div>
        <div class="right">
            <asp:DropDownList ID="ddlLanguageEmail" CssClass="full" runat="server">
                <asp:ListItem Text="Português (Brasil)" Enabled="true" Selected="True" Value="pt-br"></asp:ListItem>
                <asp:ListItem Text="English (United States)" Enabled="true" Selected="False" Value="en-us"></asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="clean"></div>
        <div class="left">
            <p>Remetente do e-mail:</p>
        </div>
        <div class="right">
            <asp:DropDownList ID="ddlFrom" CssClass="full" runat="server">
                <asp:ListItem Text="vitor@vtnorton.com" Enabled="true" Selected="True" Value="ddlVitorAccount"></asp:ListItem>
                <asp:ListItem Text="contato@vtnorton.com" Enabled="true" Selected="False" Value="ddlContactAccount"></asp:ListItem>
                <asp:ListItem Text="jade@vtnorton.com" Enabled="true" Selected="False" Value="ddlJadeAccount"></asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="clean"></div>
        <p>
            <asp:CheckBox ID="cbxHeader" Text="Incluir cabeçalho" CssClass="cbx" runat="server" />
        </p>
        <br />
        <h5>Suporte</h5>
        <hr />
        <p>
            Caso esteja com problemas por favor, não exite em contactar o administrador do sistema pelo e-mail vitor@vtnorton.com, ou pelo telefone +55 (28) 9 9972-2490.
        </p>

        <asp:Label ID="Label4" runat="server" Text=""></asp:Label><br />
        <asp:Button ID="Button1" CssClass="full100 btn-green" Height="50" runat="server" OnClick="Button1_Click" Text="Enviar" />

    </div>
    <div class="clean"></div>
</asp:Content>

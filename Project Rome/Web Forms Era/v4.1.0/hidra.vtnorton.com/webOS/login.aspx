<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="HidraOnline.webOS.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="/webOS/css/style.css" rel="stylesheet" />
    <link href="/css/heartthrob.css" rel="stylesheet" />
    <title>Login | Hidra OS</title>
    <%-- Coisas para fazer nesta pagina
        1 - Criptografar o acesso (senha)
        2 - Cor do fundo trocar automaticamente (slide)
        3 - Verificação de duas etapas (celular)
        4 - Lembrar e-mail (semelhante ao gmail.com)
        5 - Entrar em modo básico
    --%>
    <style>label{position:relative; top:6px}</style>
</head>
<body>
    <div class="login-box">
        <div class="login-box-header">
            <img class="img" src="/webOS/img/hidralogo.png" />
        </div>
        <div class="login-box-content">
            <span>Por favor, entre na sua conta da Hidra</span><br />
            <br />
            <form id="frmLogin" runat="server">
                <asp:TextBox ID="txbLogin" CssClass="full" runat="server"></asp:TextBox>
                <asp:TextBox ID="txbPassword" CssClass="full" TextMode="Password" runat="server"></asp:TextBox><br />
                <asp:CheckBox ID="cbxConnected" Text="Manter-me conectado" runat="server" /><br />
                <asp:Button ID="btnLogin" runat="server" CssClass="btn" Width="220" OnClick="btnLogin_Click" Text="Login" />
            </form>
            <span><a href="#">Esqueceu sua senha?</a></span><br />
            <span>
                <asp:Label ID="lblVersion" runat="server" Text="Label"></asp:Label></span>
            <%--<span><a href="#">Entrar em modo básico</a></span>--%>
        </div>
    </div>
</body>
</html>

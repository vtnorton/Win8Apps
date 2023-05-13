<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="HidraOnline.webOS.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="/webOS/css/style.css" rel="stylesheet" />
    <link href="/css/heartthrob.css" rel="stylesheet" />
    <title>Login | Hidra OS</title>
    <style>label { position: relative;top: 6px}</style>
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
                <asp:TextBox ID="txbLogin" CssClass="full" placeholder="E-mail" runat="server"></asp:TextBox>
                <asp:TextBox ID="txbPassword" CssClass="full" TextMode="Password" placeholder="Senha" runat="server"></asp:TextBox><br />
                <asp:CheckBox ID="cbxConnected" Text="Manter-me conectado" runat="server" /><br />
                <p>
                    <asp:Button ID="btnLogin" runat="server" CssClass="btn-green" Height="50" Width="220" OnClick="btnLogin_Click" Text="Login" />
                </p>
            </form>
            <div class="login-box-content-options">
                <p>
                    <a class="green" href="#">Esqueceu sua senha?</a><br />
                    <asp:Label ID="lblVersion" runat="server" Text=""></asp:Label>
                </p>
            </div>
        </div>
    </div>
</body>
</html>

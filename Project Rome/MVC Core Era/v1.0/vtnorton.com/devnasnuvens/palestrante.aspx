<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="palestrante.aspx.cs" Inherits="VTNORTON.devnasnuvens.palestrante" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>#DevNasNuvens - Bem vindo ao evento!</title>
</head>
<body style="font-family:'Segoe UI', Tahoma, Geneva, Verdana, sans-serif">
    <header>
        <h1 style="font-weight:300"><asp:Label runat="server" ID="txtH1"></asp:Label></h1>
    </header>
    <article>
        <asp:Label runat="server" ID="Mensagem"></asp:Label>
    </article>
    <footer>
        <img src="/devnasnuvens/img/doc.png" style="min-width:100%; max-width: 100%; position:absolute; bottom:0" />
    </footer>
</body>
</html>

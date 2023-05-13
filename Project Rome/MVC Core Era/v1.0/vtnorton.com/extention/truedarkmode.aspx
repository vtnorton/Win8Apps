<%@ Page Title="True Dark Mode | Vítor Norton" Language="C#" MasterPageFile="~/healtthrob.Master" AutoEventWireup="true" CodeBehind="truedarkmode.aspx.cs" Inherits="VTNORTON.extention.truedarkmode" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta name="description" content="It really doesn't matter of you Windows is on dark mode or on the light mode. The websites you visit isn't. This Microsoft Edge extension is about to change it. When enabled, this extension will put your favorite web site on the dark mode! So don't forget to put Windows and Edge on Dark Mode" />
    <meta name="keywords" content="formula universal code editor, dark mode, microsoft edge, windows insider, insider, internet explorer, edge extension, extension, edge plugin, true dark mode, windows 10" />
    <script>
        var $window = $(window);
        $window.scroll(function () {
            if ($(window).width() >= 895) {
                if ($window.scrollTop() >= 330) {
                    $('.app').addClass('fixed-header');
                }
                else {
                    $('.app').removeClass('fixed-header');
                }
            }
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderSubMenu" runat="server">
    <ul>
        <li><a class="on notranslate" href="#">True Dark Mode!</a></li>
        <li><a href="/extention/tdm/darkmode_1.0.0.zip"><%=VTNORTON.Resources.darkmode.Link1 %></a></li>
        <li><a href="https://github.com/vtnorton/TrueDarkMode"><%=VTNORTON.Resources.darkmode.Link2 %></a></li>
        <li><a href="https://github.com/vtnorton/TrueDarkMode/issues/new"><%=VTNORTON.Resources.darkmode.Link3 %></a></li>
        <li><a href="https://github.com/vtnorton/TrueDarkMode/issues/new"><%=VTNORTON.Resources.darkmode.Link4 %></a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="bg-dark app">
        <div class="app-section">
            <div class="app-image">
                <img style="padding: 0px; width: 200px" src="/images/extention/bellevue.jpg" />
            </div>
            <div class="app-definition">
                <h2 class="white notranslate">True Dark Mode</h2>
                <p class="white"><%=VTNORTON.Resources.darkmode.ThisAppDescription %></p>
                <a href="/extention/tdm/darkmode_1.0.0.zip" class="btn white notranslate">Download</a> <a href="http://dev.vtnorton.com/true-dark-mode-changelog/" class="btn white notranslate">Changelog</a>
            </div>
            <div class="clean"></div>
        </div>
    </section>
    <section>
        <div class="section-image-left">
            <img class="section-image-left-img" style="padding: 20px; margin-left: 10px; padding-bottom: 40px" src="/images/apps/formula.png" />
        </div>
        <div class="section-wrapper">
            <div class="section-content-right">
                <h1><%=VTNORTON.Resources.darkmode.Extension %></h1>
                <p><%=VTNORTON.Resources.darkmode.ExtensionDetail %></p>
            </div>
            <div class="clean"></div>
        </div>
    </section>
    <section class="bg-light">
        <div class="section-image-right">
            <img class="section-image-right-img formula-mobile-view" style="padding: 20px" src="/images/apps/formula-mobile.png" />
        </div>
        <div class="section-wrapper">
            <div class="section-content-left">
                <h1><%=VTNORTON.Resources.darkmode.Install %></h1>
                <p><%=VTNORTON.Resources.darkmode.InstallDetail %></p>
                <br />
                <form runat="server">
                    <asp:TextBox Height="28" ID="txtEmail" MaxLength="120" placeholer="Email" runat="server" TextMode="Email"></asp:TextBox>
                    <asp:Button ID="btnBaixar" OnClick="btnBaixar_Click" runat="server" Text="Cadastrar" /><br />
                </form>
                <p style="padding-bottom: 40px">
                    <asp:Label ID="lblEmailerro" runat="server" Text=""></asp:Label>
                </p>
            </div>
            <div class="clean"></div>
        </div>
    </section>
    <section>
        <div class="section-image-left">
            <img class="section-image-left-img" style="padding: 20px; margin-top: 78px; padding-bottom: 40px;" src="/images/apps/code.png" />
        </div>
        <div class="section-wrapper">
            <div class="section-content-right">
                <h1><%=VTNORTON.Resources.darkmode.Contribute %></h1>
                <p><%=VTNORTON.Resources.darkmode.ContributeDetail %></p>
                <ul>
                    <li><p><a href="https://github.com/vtnorton/TrueDarkMode"><%=VTNORTON.Resources.darkmode.GoTo %></a></p></li>
                    <li><p style="padding-bottom: 40px"><a href="http://vtnorton.com/formula" class="notranslate">Download Formula - Universal Code Editor</a></p></li>
                </ul>
            </div>
            <div class="clean"></div>
        </div>
    </section>
    <section class="section-bg" id="formula-section-bg">
        <div class="section-wrapper" style="padding-top: 40px; padding-bottom: 40px">
            <h1 class="white"><%=VTNORTON.Resources.darkmode.ToDarkMode %></h1>
            <p class="white"><%=VTNORTON.Resources.darkmode.ToDarkModeDetail %></p>
        </div>
    </section>
    <section class="bg-light">
        <div class="wrapper" style="padding: 30px 0">
            <asp:Repeater ID="rssRepeater" runat="server">
                <ItemTemplate>
                    <div class="article-blog">
                        <h4><a href="<%#Eval("Link")%>"><%#Eval("Title")%></a></h4>
                        <img src="<%#Eval("Image") %>" />
                        <p><%#Eval("Description")%></p>
                        <p><strong><a href="<%#Eval("Link")%>">Read more</a></strong></p>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
            <div class="clean"></div>
        </div>
    </section>
</asp:Content>

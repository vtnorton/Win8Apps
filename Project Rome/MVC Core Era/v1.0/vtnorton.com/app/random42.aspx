<%@ Page Title="Random 42 | Vítor Norton" Language="C#" MasterPageFile="~/healtthrob.Master" AutoEventWireup="true" CodeBehind="random42.aspx.cs" Inherits="VTNORTON.app.random42" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta name="description" content="" />
    <meta name="keywords" content="" />
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
    <script type="application/ld+json">
    {
      "@context": "http://schema.org",
      "@type": "SoftwareApplication",
      "name": "Random 42",
      "operatingSystem": "Windows 10",
      "applicationCategory": "http://schema.org/BusinessApplication",
      "offers": {
        "@type": "Offer",
        "price": "Free",
        "priceCurrency": "USD"
      }
    }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderSubMenu" runat="server">
    <ul>
        <li><a href="/"><%=VTNORTON.Resources.heartthrob.AllApps %></a></li>
        <li><a href="#" class="on notranslate">Random 42</a></li>
        <li><a href="http://dev.vtnorton.com/random-42-changelog/" class="notranslate">Changelog</a></li>
        <li><a href="#"><%=VTNORTON.Resources.heartthrob.SendFeedback %></a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="app bg-purple">
        <div class="app-section">
            <div class="app-image">
                <img style="padding: 0px; width: 200px" src="/images/Nice.png" />
            </div>
            <div class="app-definition">
                <h2 class="white notranslate">Random 42</h2>
                <p class="white"><%=VTNORTON.Resources.terre.NiceShortDescription %></p>
                <a href="https://www.microsoft.com/store/apps/9nblggh5x1t9" class="btn white notranslate">Download</a> <a href="http://dev.vtnorton.com/random-42-changelog/" class="btn white notranslate">Changelog</a>
            </div>
            <div class="clean"></div>
        </div>
    </section>
    <section>
        <div class="section-image-right">
            <img class="section-image-right-img" style="padding: 20px; margin-right: -20px; padding-bottom: 40px" src="/images/apps/random.png" />
        </div>
        <div class="section-wrapper">
            <div class="section-content-left">
                <h1><%=VTNORTON.Resources.terre.TerreDescription %></h1>
                <p><%=VTNORTON.Resources.terre.NiceDescription %></p>
            </div>
            <div class="clean"></div>
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

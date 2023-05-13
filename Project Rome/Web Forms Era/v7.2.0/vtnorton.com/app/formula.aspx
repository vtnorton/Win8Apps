<%@ Page Title="Formula - Universal Code Editor | Vítor Norton" Language="C#" MasterPageFile="~/healtthrob.Master" AutoEventWireup="true" CodeBehind="formula.aspx.cs" Inherits="VTNORTON.app.formula" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta name="description" content="How many times do you get out of your office and remember a line of code that can fix the biggest bug you have? Formula is here for you!" />
    <meta name="keywords" content="formula universal code editor, formula, code editor, universal windows app, uwp, windows 10, developer tools, top free app, top paid app, java, javascript" />
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
      "name": "Formula - Universal Code Editor",
      "operatingSystem": "Windows 10",
      "applicationCategory": "http://schema.org/BusinessApplication",
      "aggregateRating": {
        "@type": "AggregateRating",
        "ratingValue": "4.5",
        "ratingCount": "138"
      },
      "offers": {
        "@type": "Offer",
        "price": "1.99",
        "priceCurrency": "USD"
      }
    }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderSubMenu" runat="server">
    <ul>
        <li><a href="/"><%=VTNORTON.Resources.heartthrob.AllApps %></a></li>
        <li><a href="#" class="on notranslate">Formula - Universal Code Editor</a></li>
        <li><a href="http://dev.vtnorton.com/formula-changelog/" class="notranslate">Changelog</a></li>
        <li><a href="#"><%=VTNORTON.Resources.heartthrob.SendFeedback %></a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="bg-dark-blue app">
        <div class="app-section">
            <div class="app-image">
                <img style="padding: 0px; width: 200px" src="/images/Quebec.png" />
            </div>
            <div class="app-definition">
                <h2 class="white notranslate">Formula - Universal Code Editor</h2>
                <p class="white"><%=VTNORTON.Resources.formula.ThisAppDescription %></p>
                <a href="https://www.microsoft.com/store/apps/9nblggh4wb6b" class="btn white notranslate">Download</a> <a href="http://dev.vtnorton.com/formula-changelog/" class="btn white notranslate">Changelog</a>
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
                <h1><%=VTNORTON.Resources.formula.TheFormula %></h1>
                <p><%=VTNORTON.Resources.formula.TheFormulaContent %></p>
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
                <h1><%=VTNORTON.Resources.formula.Languages %></h1>
                <p><%=VTNORTON.Resources.formula.LanguagesContent %></p>
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
                <h1><%=VTNORTON.Resources.formula.Features %></h1>
                <p><%=VTNORTON.Resources.formula.FeaturesContent %></p>
            </div>
            <div class="clean"></div>
        </div>
    </section>
    <section class="section-bg" id="formula-section-bg">
        <div class="section-wrapper" style="padding-top: 40px; padding-bottom:40px">
            <h1 class="white"><%=VTNORTON.Resources.formula.Reviews %></h1>
            <p class="white"><%=VTNORTON.Resources.formula.Review1 %></p>
            <p class="white"><%=VTNORTON.Resources.formula.Review2 %></p>
            <p class="white"><%=VTNORTON.Resources.formula.Review3 %></p>
            <p class="white"><%=VTNORTON.Resources.formula.Review4 %></p>
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

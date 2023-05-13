<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="author.aspx.cs" Inherits="VTNORTON.blog.author" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul>
        <li><a href="/">Início</a></li>
        <li>></li>
        <li><a href="/blog/">Blog</a></li>
        <li>></li>
        <li><asp:Label ID="lblAuthorNameSubMenu" runat="server" Text=""></asp:Label></li>
    </ul>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="box-content">
        <asp:Label ID="lblAuthorCover" runat="server" Text=""></asp:Label>
            <div class="left profile-pic">
                <asp:Label ID="lblAuthorProfileImage" runat="server" Text=""></asp:Label>
            </div>
            <div class="right profile-info">
                <asp:Label ID="lblAuthorName" runat="server" Text=""></asp:Label><br />
                <asp:Label ID="lblAuthorDescription" runat="server" Text=""></asp:Label><br />
                <asp:Label ID="lblAuthorJob" runat="server" Text=""></asp:Label>
            </div>
            <div class="clean"></div>
        </div>
        <div class="left list-post seventyfivepercent">
            <h1>Posts deste autor</h1>
            <hr />
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <div class="lp-stand-alone">
                        <div class="left lpsa-image">
                            <%#Eval("URLImage") %>
                        </div>
                        <div class="right lpsa-post">
                            <h3><a href="/blog/post.aspx?id=<%#Eval("Id") %>"><%#Eval("Title") %></a></h3>
                            <h6>Data: <%#Eval("PostedDate") %> | Categoria: <a href="/blog/categoria.aspx?id=<%#Eval("IdCategory")%>"><%#Eval("CategoryName") %></a></h6>
                            <%#Eval("FirstParagraph").ToString() %>
                            <p class="read-more"><a href="/blog/post.aspx?id=<%#Eval("Id") %>">Leia mais</a></p>
                        </div>
                        <div class="clean"></div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
            <asp:Label ID="lblErro" runat="server" Text=""></asp:Label>
            <br />
            <div class="left half">
                <asp:Label ID="lblLessPost" runat="server" Text=""></asp:Label>
            </div>
            <div class="right half" style="text-align: right">
                <asp:Label ID="lblMorePost" runat="server" Text=""></asp:Label>
            </div>
        </div>
        <div class="right blog-widget twentyfivepercent">
            <div class="newer">
                <h1>Posts recentes</h1>
                <hr />
                <ul>
                    <asp:Repeater ID="Repeater2" runat="server">
                        <ItemTemplate>
                            <li>
                                <p><%#Eval("Title") %></p>
                                <a href="/blog/post.aspx?id=<%#Eval("Id") %>">Leia mais</a>
                            </li>
                        </ItemTemplate>
                    </asp:Repeater>
                </ul>
            </div>
            <br />
            <div style="width: 336px; margin: 0 auto">
                <script async src="//pagead2.googlesyndication.com/pagead/js/adsbygoogle.js"></script>
                <!-- Post -->
                <ins class="adsbygoogle"
                    style="display: inline-block; width: 336px; height: 280px"
                    data-ad-client="ca-pub-5584056449430370"
                    data-ad-slot="3557028846"></ins>
                <script>
                    (adsbygoogle = window.adsbygoogle || []).push({});
                </script>
            </div><br />
            <div class="instagram">
                <h1>@vt_norton</h1>
                <hr />
                <script src="//instansive.com/widget/js/instansive.js"></script>
                <iframe src="//instansive.com/widgets/3c8986526c667003f02f8e3eab51b31f12a0424e.html" id="instansive_3c8986526c" name="instansive_3c8986526c" scrolling="no" allowtransparency="true" class="instansive-widget" style="width: 100%; border: 0; overflow: hidden;"></iframe>
                <br />
                <a class="twitter-timeline" href="https://twitter.com/vt_norton" data-widget-id="335433741990240257">Tweets de @vt_norton</a>
                <script>!function (d, s, id) { var js, fjs = d.getElementsByTagName(s)[0], p = /^http:/.test(d.location) ? 'http' : 'https'; if (!d.getElementById(id)) { js = d.createElement(s); js.id = id; js.src = p + "://platform.twitter.com/widgets.js"; fjs.parentNode.insertBefore(js, fjs); } }(document, "script", "twitter-wjs");</script>
            </div>
        </div>
        <div class="clean"></div>
    </div>
</asp:Content>

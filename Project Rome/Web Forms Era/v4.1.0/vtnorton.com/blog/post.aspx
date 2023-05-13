<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="post.aspx.cs" Inherits="VTNORTON.blog.post" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul>
        <li><a href="/">Início</a></li>
        <li>></li>
        <li><a href="/blog/">Blog</a></li>
        <li>></li>
        <li><asp:Label ID="lblSubMenuCategory" runat="server" Text=""></asp:Label></li>
        <li>></li>
        <li><asp:Label ID="lblSubMenuTitle" runat="server" Text=""></asp:Label></li>
    </ul>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="box-content">
        <div class="left blog-post  seventyfivepercent"">
            <h1>
                <asp:Label ID="lblPostTitle" runat="server" Text="Carregando..."></asp:Label></h1>
            <hr />
            <article>
                <p>
                    <asp:Label ID="lblPostContent" runat="server" Text="Carregando..."></asp:Label>
                </p>
            </article>
        </div>
        <div class="right blog-widget twentyfivepercent">
            <div class="post-info">
                <h1>Informações do post</h1>
                <hr />
                <strong>Autor:</strong>
                <asp:Label ID="lblAuthorNamePost" runat="server" Text="Vítor Norton"></asp:Label>
                <br />
                <strong>Postado em:</strong>
                <asp:Label ID="lblPostDate" runat="server" Text="00/00/0000"></asp:Label>
                <br />
                <strong>Categoria:</strong>
                <asp:Label ID="lblCategory" runat="server" Text="Sem categoria"></asp:Label><br />
                <br />
                <div class="clean"></div>
            </div>
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
        <asp:Label ID="lblProfileBackground" runat="server" Text="<div>"></asp:Label>
        <div class="left profile-pic">
            <asp:Label ID="lblAuthorProfile" runat="server" Text="Carregando..."></asp:Label>
        </div>
        <div class="right profile-info">
            <h3>
                <asp:Label ID="lblAuthorName" runat="server" Text="Carregando..."></asp:Label></h3>
            <p>
                <asp:Label ID="lblAuthorDescricao" runat="server" Text="Carregando..."></asp:Label>
            </p>
            <p>
                <asp:Label ID="lblAuthorJob" runat="server" Text="Carregando..."></asp:Label>
            </p>
        </div>
        <div class="clean"></div>
    </div>
    </div>
</asp:Content>

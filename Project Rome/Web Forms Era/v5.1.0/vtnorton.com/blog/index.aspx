<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="VTNORTON.blog.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="post-item">


        <asp:Repeater ID="rptPosts" runat="server">
            <ItemTemplate>
                <article class="entry wow fadeInDown" data-wow-duration="1000ms" data-wow-delay="300ms">

                    <div class="post-thumb">
                        <a href="/blog/post.aspx?id=<%#Eval("Id") %>">
                            <%#Eval("URLImage") %>
                        </a>
                    </div>
                    <div class="post-excerpt">
                        <h3><a href="/blog/post.aspx?id=<%#Eval("Id") %>"><%#Eval("Title") %></a></h3>
                        <p><%#Eval("FirstParagraph") %></p>
                        <a class="btn btn-transparent" href="/blog/post.aspx?id=<%#Eval("Id") %>">Leia mais</a>
                    </div>
                    <div class="post-meta">
                        <span class="post-date">
                            <i class="fa fa-calendar"></i><%#Eval("PostedDate") %>
                        </span>
                        <span class="post-view">
                            <i class="fa fa-eye"></i><%#Eval("Visits") %> visualizações
                        </span>
                        <span class="author">
                            <i class="fa fa-user"></i><%#Eval("AuthorName") %>
                        </span>
                        <span class="post-tags">
                            <i class="fa fa-tags"></i><a href="/blog/categoria.aspx?id=<%#Eval("IdCategory") %>"><%#Eval("CategoryName") %></a>
                        </span>
                    </div>
                </article>
            </ItemTemplate>
        </asp:Repeater>
        <nav class="post-pagination wow fadeInDown" data-wow-duration="1000ms" data-wow-delay="300ms">
            <asp:Label ID="lblMorePosts" runat="server" Text=""></asp:Label>
        </nav>
    </div>

</asp:Content>

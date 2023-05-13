<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="post.aspx.cs" Inherits="VTNORTON.blog.post" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="post-item">

        <!-- Single Post -->
        <article class="entry wow fadeInDown" data-wow-duration="1000ms" data-wow-delay="300ms">
            <%--<div class="post-thumb">
                <asp:Label ID="lblPostHTML" runat="server" Text=""></asp:Label>
            </div>--%>
            <div class="post-excerpt">
                <h2>
                    <asp:Label ID="lblPostTitle" runat="server" Text=""></asp:Label></h2>
                <asp:Label ID="lblPost" runat="server" Text=""></asp:Label>
            </div>
            <div class="post-meta">
                <span class="post-date">
                    <i class="fa fa-calendar"></i>
                    <asp:Label ID="lblPostedDate" runat="server" Text=""></asp:Label>
                </span>
                <span class="post-view">
                    <i class="fa fa-eye"></i>
                    <asp:Label ID="lblVisualizacoes" runat="server" Text=""></asp:Label>
                    visualizações
                </span>
                <span class="post-tags">
                    <i class="fa fa-tags"></i>
                    <asp:Label ID="lblCategoria" runat="server" Text=""></asp:Label>
                </span>
            </div>
        </article>
        <!-- End Single Post -->

    </div>

    <%--<div class="next-prev clearfix">
        <asp:Label ID="lblPrevPost" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblNextPost" runat="server" Text=""></asp:Label>
    </div>--%>
    <div class="author-about clearfix">
        <h4>Sobre
                <asp:Label ID="lblAuthorName" runat="server" Text=""></asp:Label></h4>
        <div class="post-author pull-left">
            <asp:Label ID="lblAuthorImage" runat="server" Text=""></asp:Label>
        </div>
        <div class="author-bio">
            <p>
                <asp:Label ID="lblAuthorBio" runat="server" Text=""></asp:Label>
            </p>

        </div>

    </div>
</asp:Content>

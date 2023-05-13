<%@ Page Title="Blog" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="blog.aspx.cs" Inherits="HidraOnline.blog" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul>
        <li><a href="/p/novo/post.aspx">Novo post</a></li>
        <li><a href="/p/novo/category.aspx">Nova categoria</a></li>
        <li><a href="/p/manage/post.aspx">Gerenciar posts</a></li>
        <li><a href="/p/manage/category.aspx">Gerenciar categorias</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="seventyfivepercent left">
        <article>
            <div class="toggle-options-head">Últimos posts cadastrados</div>
            <hr />
            <asp:Repeater ID="rptLastPost" runat="server">
                <ItemTemplate>
                    <div class="post">
                        <div class="left posts-img" style="width: 200px">
                            <%#Eval("URLImage") %>
                        </div>
                        <div class="right" style="width: calc(100% - 220px); padding-top: 10px">
                            <h4 class="green"><%#Eval("Title") %></h4>
                            <hr />
                            <h6 class="posts">Data: <span class="green"><%#Eval("PostedDate") %></span> | Autor: <span class="green"><%#Eval("AuthorName") %></span> | Categoria: <a href="/p/manage/category.aspx?Id=<%#Eval("IdCategory") %>" title="Editar esta categoria" class="green"><%#Eval("CategoryName") %></a></h6>
                            <article>
                                <%#Eval("FirstParagraph") %>
                            </article>
                            <a style="font-weight:600; font-size:16px" title="Editar esta postagem" class="green" href="/p/manage/post.aspx?Id=<%#Eval("Id") %>">Editar postagem</a>
                        </div>
                    </div>
                    <div class="clean"></div>
                </ItemTemplate>
            </asp:Repeater>
        </article>
    </div>
    <div class="twentyfivepercent right sidebar">
        <div class="toggle-options-head">Links rápidos</div>
        <hr />
        <article>
            <p>Aqui está uma pequena coleção de links disponíveis para você começar o seu blog. Claro que a parte de blog é bem mais do que isso, mas você pode começar a criar novos posts, categorias e gerenciar eles atravéz deste links. Para outras ações, como controle de usuário, configurações do blog e você deve visualizar novas áreas do site. </p>
            <ul>
                <li><a class="green" href="/p/novo/post.aspx">Novo post</a></li>
                <li><a class="green" href="/p/novo/category.aspx">Nova categoria</a></li>
                <li><a class="green" href="/p/manage/post.aspx">Gerenciar posts</a></li>
                <li><a class="green" href="/p/manage/category.aspx">Gerenciar categorias</a></li>
            </ul>
            <p><strong>Escreva posts inspiradores!</strong></p>
            <img src="/images/eat.sleep.do.jpg" width="340" alt="Coma, Durma, Faça - Vítor Norton" />
        </article>
    </div>
    <div class="clean"></div>
</asp:Content>

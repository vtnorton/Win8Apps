<%@ Page Title="Detalhes do feedback" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="bug-detail.aspx.cs" Inherits="HidraOnline.p.manage.bug_detail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul>
        <li><a href="/p/Bug.aspx">Novo bug</a></li>
        <li><a href="/p/novo/sugestion.aspx">Nova sugestão</a></li>
        <li><a href="/p/manage/bugs.aspx">Gerenciar feedback</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <article>
        <p>
            <strong>Nome do feedback: </strong>
            <asp:Label ID="lblName" runat="server" Text=""></asp:Label><br />
            <strong>Data de envio: </strong>
            <asp:Label ID="lblDate" runat="server" Text=""></asp:Label><br />
            <strong>Tipo do feedback: </strong>
            <asp:Label ID="lblType" runat="server" Text=""></asp:Label><br />
            <strong>Projeto referente: </strong>
            <asp:Label ID="lblProject" runat="server" Text=""></asp:Label><br />
            <strong>E-mail do remetente: </strong>
            <asp:Label ID="lblEmail" runat="server" Text=""></asp:Label><br />
            <strong>Votos nesse feedback: </strong>
            <asp:Label ID="lblUpvotes" runat="server" Text=""></asp:Label><br />
        </p>
        <p>
            <strong>Menssagem: </strong>
            <asp:Label ID="lblMensage" runat="server" Text=""></asp:Label>
        </p>
        <p>
            <strong>Status do feedback: </strong>
            <asp:Label ID="lblStatus" runat="server" Text=""></asp:Label><br />
            <!-- Poder modificar (ddl) -->
        </p>
    </article>
</asp:Content>

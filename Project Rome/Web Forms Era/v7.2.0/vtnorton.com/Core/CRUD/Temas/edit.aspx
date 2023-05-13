<%@ Page Title="Editar tema" Language="C#" MasterPageFile="~/Core/Internal.Master" AutoEventWireup="true" CodeBehind="edit.aspx.cs" Inherits="VTNORTON.Core.CRUD.Temas.edit" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="header">
        <h2>Editar tema</h2>
        <p>Sinta-se a vontade para corrigir um problema no tema, ou modificar ele da forma como você preferir. </p>
        <p><a href="index.aspx">Ver todos</a> | <a href="create.aspx">Criar novo</a></p>
    </div>
    <h4>Nome</h4>
    <p>Dê um nome para o tema. Por conveniência, começe com [pt] para temas em Português e [en] para temas em Inglês.</p>
    <asp:TextBox ID="txtNome" placeholder="Nome do tema" runat="server"></asp:TextBox><br />
    <h4>Descrição do tema</h4>
    <p>Por favor, não use mais do que 140 caracteres para descrever o tema do e-mail.</p>
    <asp:TextBox ID="txtDescricao" placeholder="Descrição do tema (Max: 140)" MaxLength="140" runat="server"></asp:TextBox><br />
    <h4>Conteúdo do tema</h4>
    <p>O tema deve conter as palavras CONTENT e FOOTER para identificar aonde será o conteúdo e aonde será o rodapé, respectivamente.</p>
    <asp:TextBox ID="CKEditorControl1" TextMode="MultiLine" placeholder="Conteúdo do tema" runat="server"></asp:TextBox><br />
    <br />
    <br />
    <asp:Button ID="btnSubmit" OnClick="btnSubmit_Click" runat="server" Text="Enviar novos dados" />
    <asp:Label ID="lblInfo" runat="server"></asp:Label>
</asp:Content>

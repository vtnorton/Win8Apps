<%@ Page Title="Criar um novo tema" Language="C#" MasterPageFile="~/Core/Internal.Master" AutoEventWireup="true" CodeBehind="create.aspx.cs" Inherits="VTNORTON.Core.CRUD.Temas.create" %>

<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="header">
        <h2>Criar um novo tema</h2>
        <p>Adicione um tema personalizado para uso deles no e-mail marketing. Os temas devem ser em HTML puro. </p>
        <p><a href="index.aspx">Ver todos</a> | <a href="create.aspx">Criar novo</a></p>
    </div>
    <div class="row">
        <div class="col-md-12">
            <asp:TextBox ID="txtNome" placeholder="Nome do tema" runat="server"></asp:TextBox><br />
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <asp:TextBox ID="txtDescricao" placeholder="Descrição do tema (Max: 140)" MaxLength="140" runat="server"></asp:TextBox><br />
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <p>O tema deve conter as palavras CONTENT e FOOTER para identificar aonde será o conteúdo e aonde será o rodapé, respectivamente.</p><br />
            <CKEditor:CKEditorControl BasePath="/ckeditor/" ID="CKEditorControl1" runat="server"></CKEditor:CKEditorControl>
            <br />
            <br />
        </div>
    </div>
    <div class="row">
        <div class="col s12">
            <asp:Button ID="btnSubmit" OnClick="btnSubmit_Click" runat="server" Text="Enviar novos dados" />
            <asp:Label ID="lblInfo" runat="server"></asp:Label>
        </div>
    </div>
</asp:Content>

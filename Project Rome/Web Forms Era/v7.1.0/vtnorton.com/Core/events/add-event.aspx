<%@ Page Title="" Language="C#" MasterPageFile="~/Core/Internal.Master" AutoEventWireup="true" CodeBehind="add-event.aspx.cs" Inherits="VTNORTON.Core.events.add_event" %>

<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="//cdn.ckeditor.com/4.5.11/standard/ckeditor.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="header">
        <h2>Adicionar novo evento</h2>
        <p>Adicione informações para um novo evento.</p>
    </div>
    <div class="row">
        <div class="col-md-12">
            <asp:TextBox ID="txtNome" placeholder="Nome do evento" runat="server"></asp:TextBox><br />
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <asp:TextBox ID="txtEndereco" placeholder="Local do evento" runat="server"></asp:TextBox><br />
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <CKEditor:CKEditorControl BasePath="/ckeditor/" ID="txtDescricao" runat="server"></CKEditor:CKEditorControl>
            <br />
            <br />
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <asp:TextBox ID="txtURL" placeholder="Link para inscrição" runat="server"></asp:TextBox><br />
        </div>
    </div>
    <div class="row">
        <div class="col-md-1">
            <asp:TextBox ID="txtDia" placeholder="Dia" runat="server"></asp:TextBox>
        </div>
        <div class="col-md-1">
            <asp:TextBox ID="txtMes" placeholder="Mês" runat="server"></asp:TextBox>
        </div>
        <div class="col-md-1">
            <asp:TextBox ID="txtAno" placeholder="Ano" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-md-6">
            <h4>Já passou a data do evento?</h4>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" DataTextField="Já passou?">
                <asp:ListItem Text="Sim" Value="1"></asp:ListItem>
                <asp:ListItem Text="Não" Value="0"></asp:ListItem>
            </asp:RadioButtonList>
        </div>
        <div class="col-md-6">
            <h4>O evento é online?</h4>
            <asp:RadioButtonList ID="RadioButtonList2" runat="server" DataTextField="É online?">
                <asp:ListItem Text="Sim" Value="1"></asp:ListItem>
                <asp:ListItem Text="Não" Value="0"></asp:ListItem>
            </asp:RadioButtonList>
        </div>
    </div>
    <br />
    <div class="row">
        <div class="col s12">
            <asp:Button ID="btnSubmit" OnClick="btnSubmit_Click" runat="server" Text="Enviar novos dados" />
            <asp:Label ID="lblInfo" runat="server"></asp:Label>
        </div>
    </div>

</asp:Content>

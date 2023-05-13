<%@ Page Title="Novo usuário" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="new-user.aspx.cs" Inherits="HidraOnline.p.gdvw.new_user" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SUBMENU" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <h1>Novo usuário</h1>
    <span>Novo usuário a ser conectado com a Hidra OS (Hidra framework e B#! Framework)</span><br />


    <asp:TextBox ID="txtName" placeholder="Nome" runat="server"></asp:TextBox><br />
    <asp:TextBox ID="txtDescricao" placeholder="Descrição (Maxímo de 240 caracteres)" MaxLength="140" TextMode="MultiLine" Height="80" runat="server"></asp:TextBox><br />
    <asp:TextBox ID="txtJob" placeholder="Profissão" runat="server"></asp:TextBox><br />
    <asp:TextBox ID="txtURLProfile" placeholder="URL da imagem de perfil" runat="server"></asp:TextBox><br />
    <asp:TextBox ID="txtURLCover" placeholder="URL da imagem de capa" runat="server"></asp:TextBox><br />
    <asp:TextBox ID="txtBirthday" TextMode="Date" placeholder="Data de nascimento" runat="server"></asp:TextBox><br />
    <div class="left half">
        <hr />
        <br />
        <asp:TextBox ID="txtEmail" placeholder="E-mail" TextMode="Email" runat="server"></asp:TextBox><br />
        <asp:TextBox ID="txtSenha" placeholder="Senha" TextMode="Password" runat="server"></asp:TextBox><br />
        <asp:TextBox ID="txtVerificarSenha" placeholder="Verificar senha" TextMode="Password" runat="server"></asp:TextBox><br />
        <br />
        <hr />
        <br />
    </div>
    <div class="right half">
        <asp:Label ID="lblInfo" runat="server" Text=""></asp:Label>
    </div>
    <div class="clean"></div>
    <asp:Button ID="btnCreate" OnClick="btnCreate_Click" runat="server" Text="Criar autor" />
</asp:Content>

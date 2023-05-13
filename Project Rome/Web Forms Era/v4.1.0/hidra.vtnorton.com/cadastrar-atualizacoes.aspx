<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="cadastrar-atualizacoes.aspx.cs" Inherits="BuildOnline.cadastrar_atualizacoes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SUBMENU" runat="server">
     <ul style="margin-left: 0px;">
        <li><a class="ativo" href="cadastrar-atualisacoes.aspx">Cadastrar atualização</a></li>
        <li><a href="gerenciar-atualizacoes.aspx">Gerenciar atualizações</a></li>
        <li><a href="cadastrar-solucoes.aspx">Cadastrar soluções</a></li>
        <li><a href="gerenciar-solucoes.aspx">Gerenciar soluções</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <div class="row-fluid">
            <div class="build-titulo">
                <h3>Nova atualização</h3>
            </div>
            <form id="form2" runat="server">
                <asp:TextBox AutoCompleteType="None" ID="txtData" runat="server" CssClass="span3 build-correcao-margin-top-1px" placeholder="Data da atualização"></asp:TextBox>
                <asp:DropDownList OnLoad="drdSistema_Load" CssClass="span7" ID="drdSistema" runat="server">
                    <asp:ListItem  Enabled="true" Text="vtnorton.com" Value="00"></asp:ListItem>
                    <asp:ListItem Text="search.vtnorton.com" Value="01"></asp:ListItem>
                    <asp:ListItem Text="build.vtnorton.com/" Value="02"></asp:ListItem>
                </asp:DropDownList>
                <asp:TextBox AutoCompleteType="None" ID="txtPrimeiroNumero" runat="server" CssClass="span1" placeholder="1"></asp:TextBox>
                <asp:TextBox AutoCompleteType="None" ID="txtSegundoNumero" runat="server" CssClass="span1" placeholder="0"></asp:TextBox>
                <asp:TextBox AutoCompleteType="None" ID="txtTerceiroNumero" runat="server" CssClass="span1" placeholder="0"></asp:TextBox><br />
                <br />

                <asp:TextBox AutoCompleteType="None" ID="txtNome" runat="server" CssClass="span11" placeholder="Nome da atualização (Ex.: UPDATE #03)"></asp:TextBox><br />
                <br />
                <asp:TextBox AutoCompleteType="None" ID="txtDescricao" runat="server" CssClass="span11" placeholder="Descricao da atualização"></asp:TextBox><br />
                <br />
                <asp:TextBox AutoCompleteType="None" ID="txtChangelog" runat="server" CssClass="span11" placeholder="O que foi alterado nessa atualização" CausesValidation="False"></asp:TextBox><br />
                <br />
                <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label><br />
                <asp:Button ID="btnAtualizar" runat="server" CssClass="btn-success btn" OnClick="CommitCadastroAtualizacao" Text="Enviar" />
            </form>
        </div>
    </div>
</asp:Content>

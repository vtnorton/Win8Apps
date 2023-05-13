<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="add-user.aspx.cs" Inherits="SunWeb.humans.add_user" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="row">
            <div class="col s12">
                <div class="input-field s12">
                    <h5>Adicionar usuário</h5>
                </div>
                <hr />
                <p>Você está prestes a conceder acesso ao sistema a: <asp:Label ID="lblName" runat="server" Text=""></asp:Label></p>
                <p>O convite para acesso ao sistema será enviado por e-mail do funcionário cadastrado.</p>
                <asp:Button ID="btnAddUser" runat="server" OnClick="btnAddUser_Click" Text="Adicionar usuário" />
            </div>
        </div>
    <div class="row">
        <div class="col s12">
            <div class="input-field col s3">
                <asp:DropDownList ID="ddlAcessType" CssClass="browser-default" runat="server">
                    <asp:ListItem Enabled="true" Selected="True" Text="Escolha uma opção"></asp:ListItem>
                    <asp:ListItem Enabled="true" Selected="False" Text="Administrador" Value="1"></asp:ListItem>
                    <asp:ListItem Enabled="true" Selected="False" Text="Usuário comum" Value="2"></asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col s12">
            <div class="text-center">
                <p>Quero fazer uma página tipo <a href="https://www.onenote.com/">esta</a> ou <a href="http://demo.web3canvas.com/themeforest/flathost/onepage/index.html">esta</a> para dar uma noção ao administrador do sistema os seguintes pontos: </p>
                <ul> 

                    <li>Entenda as consequências de dar acesso ao usuário</li>
                    <li>Entenda a diferença entre usuário comum/administrador</li>
                    <li>Motivos para que transformasse um funcionário em usuário</li>
                    <li>Motivos para não transformar um funcionário em usuário (para não transformarem faxineiras, e outros)</li>
                </ul>                
                <p>Maicon, faça um desing, use as páginas acima como referencia, se possível um HTML desta página serial legal. A única coisa que vou precisar (em termo de programação) é o dropdown list (que pode ser trocado por dois botões, uma para add como admin e outra para add como usuário) e checkbox para selecionar as fazendas em que ele é usuário. Também vou precisar de um layout (e de novo, um HTML pronto seria bacana, para um e-mail no tipo do design que esta página vai ficar, com alguns textos onde vamos explicar o sistema, e as vantagens para ser usuário dele, e um botão para finalizar o cadastro)</p>
                <p>Stefany, no momento em que o Maicon fizer o design vou precisar dos textos para preencher a página. :-)</p>
            </div>
        </div>
    </div>
</asp:Content>

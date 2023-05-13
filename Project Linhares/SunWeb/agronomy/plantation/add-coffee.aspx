<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="add-coffee.aspx.cs" Inherits="SunWeb.agronomy.plantation.add_coffee" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="padding:20px">

    <p>Por favor, informe a data prevista para estes acontecimentos</p>
    <asp:TextBox ID="txtNome" placeholder="Nome da plantação" runat="server"></asp:TextBox><br />
    <br />
    <h3>Plantio</h3>
    <hr />
    Início:
    <asp:TextBox ID="txtDateOfPlantation" TextMode="Date" runat="server"></asp:TextBox>
    | Fim:
    <asp:TextBox ID="txtEndOfPlantation" TextMode="Date" runat="server"></asp:TextBox>
    | 
    <asp:CheckBox ID="ckbPlantio" Enabled="false" Text="Deixar o sistema calcular uma data. (Data prevista pelo sistema: 00/00/2000)" runat="server" />
    <h3>Florada</h3>
    <hr />
    Início:
    <asp:TextBox ID="txtBateOfFlowering" TextMode="Date" runat="server"></asp:TextBox>
    | Fim:
    <asp:TextBox ID="txtEndOfFlowering" TextMode="Date" runat="server"></asp:TextBox>
    | 
    <asp:CheckBox ID="ckbFlowering" Enabled="false" Text="Deixar o sistema calcular uma data. (Data prevista pelo sistema: 00/00/2000)" runat="server" />
    <h3>Colheita</h3>
    <hr />
    Início:
    <asp:TextBox ID="txtHarvest" TextMode="Date" runat="server"></asp:TextBox>
    | Fim:
    <asp:TextBox ID="txtEndOfHarvest" TextMode="Date" runat="server"></asp:TextBox>
    | 
    <asp:CheckBox ID="ckbHarvest" Enabled="false" Text="Deixar o sistema calcular uma data. (Data prevista pelo sistema: 00/00/2000)" runat="server" />
    <h3>Processamento</h3>
    <hr />
    Início:
    <asp:TextBox ID="txtProcessing" TextMode="Date" runat="server"></asp:TextBox>
    | Fim:
    <asp:TextBox ID="txtEndOfProcessing" TextMode="Date" runat="server"></asp:TextBox>
    | 
    <asp:CheckBox ID="ckbProcessing" Enabled="false" Text="Deixar o sistema calcular uma data. (Data prevista pelo sistema: 00/00/2000)" runat="server" />
    <h3>Secagem</h3>
    <hr />
    Início:
    <asp:TextBox ID="txtDrying" TextMode="Date" runat="server"></asp:TextBox>
    | Fim:
    <asp:TextBox ID="txtEndOfDrying" TextMode="Date" runat="server"></asp:TextBox>
    | 
    <asp:CheckBox ID="ckbDrying" Enabled="false" Text="Deixar o sistema calcular uma data. (Data prevista pelo sistema: 00/00/2000)" runat="server" />
    <h3>Torra</h3>
    <hr />
    Início:
    <asp:TextBox ID="txtRoasting" TextMode="Date" runat="server"></asp:TextBox>
    | Fim:
    <asp:TextBox ID="txtEndOfRoasting" TextMode="Date" runat="server"></asp:TextBox>
    | 
    <asp:CheckBox ID="ckbRoasting" Enabled="false" Text="Deixar o sistema calcular uma data. (Data prevista pelo sistema: 00/00/2000)" runat="server" />
    <h3>Moagem</h3>
    <hr />
    Início:
    <asp:TextBox ID="txtGrinding" TextMode="Date" runat="server"></asp:TextBox>
    | Fim:
    <asp:TextBox ID="txtEndOfFrinding" TextMode="Date" runat="server"></asp:TextBox>
    | 
    <asp:CheckBox ID="ckbGrinding" Enabled="false" Text="Deixar o sistema calcular uma data. (Data prevista pelo sistema: 00/00/2000)" runat="server" />
    <h3>Classificação</h3>
    <hr />
    Início:
    <asp:TextBox ID="txtClassification" TextMode="Date" runat="server"></asp:TextBox>
    | Fim:
    <asp:TextBox ID="txtendOfClassification" TextMode="Date" runat="server"></asp:TextBox>
    | 
    <asp:CheckBox ID="ckbClassification" Enabled="false" Text="Deixar o sistema calcular uma data. (Data prevista pelo sistema: 00/00/2000)" runat="server" />
    <h3>Embalagem</h3>
    <hr />
    Início:
    <asp:TextBox ID="txtPacking" TextMode="Date" runat="server"></asp:TextBox>
    | Fim:
    <asp:TextBox ID="txtEndOfPacking" TextMode="Date" runat="server"></asp:TextBox>
    | 
    <asp:CheckBox ID="ckbPacking" Enabled="false" Text="Deixar o sistema calcular uma data. (Data prevista pelo sistema: 00/00/2000)" runat="server" />
    <h3>Encaixotamento</h3>
    <hr />
    Início:
    <asp:TextBox ID="txtBoking" TextMode="Date" runat="server"></asp:TextBox>
    | Fim:
    <asp:TextBox ID="txtEndOfBoking" TextMode="Date" runat="server"></asp:TextBox>
    | 
    <asp:CheckBox ID="ckbBoxing" Enabled="false" Text="Deixar o sistema calcular uma data. (Data prevista pelo sistema: 00/00/2000)" runat="server" />

    <br /><br />
    <asp:Button ID="btnStart" OnClick="btnStart_Click" runat="server" Text="Iniciar plantação" />
        </div>
</asp:Content>

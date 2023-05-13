<%@ Page Title="Adicionar fazenda | AgroAssistant" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="add-farm.aspx.cs" Inherits="SunWeb.add_farm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="padding: 20px">
        <asp:TextBox ID="txtName" placeholder="Nome da fazenda" runat="server"></asp:TextBox><br />
        <br />
        <asp:TextBox ID="txtOwner" placeholder="Nome da proprietário da fazenda" runat="server"></asp:TextBox><br />
        <br />
        <asp:TextBox ID="txtAdress" placeholder="Endereço" TextMode="Phone" runat="server"></asp:TextBox><br />
        <br />
        <asp:TextBox ID="txtSize" placeholder="Tamanho" runat="server"></asp:TextBox><br />
        <hr />

        <asp:DropDownList ID="ddlCountry" OnSelectedIndexChanged="ddlRegion_SelectedIndexChanged" AutoPostBack="true" runat="server">
        </asp:DropDownList><br />
        <br />

        <asp:DropDownList ID="ddlRegion" AutoPostBack="true" runat="server">
        </asp:DropDownList><br />
        <br />
        <asp:RadioButtonList ID="rbtUnity" runat="server">
            <asp:ListItem Enabled="true" Selected="False" Text="Ambos"></asp:ListItem>
            <asp:ListItem Enabled="true" Selected="True" Text="Agricultura"></asp:ListItem>
            <asp:ListItem Enabled="true" Selected="False" Text="Pecuaria"></asp:ListItem>
        </asp:RadioButtonList><br />
        <br />
        <asp:Button ID="btnNewuser" OnClick="btnNewuser_Click" runat="server" Text="Adicionar fazenda" />
        <asp:Label ID="lblErro" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>

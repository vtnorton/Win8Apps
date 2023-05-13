<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="add-production-cost.aspx.cs" Inherits="SunWeb.financial.add_production_cost" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="padding: 20px">

        <div class="right">
            <h4>Compras</h4>
            <table>
                <tr>
                    <td>Descrição</td>
                    <td>Valor total</td>
                </tr>
                <tr>
                    <td>Adubo
                    </td>
                    <td>
                        <asp:TextBox TextMode="Number" ID="txtFertilizer" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Micro-nutrientes
                    </td>
                    <td>
                        <asp:TextBox TextMode="Number" ID="txtMicroNutrients" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Herbicida
                    </td>
                    <td>
                        <asp:TextBox TextMode="Number" ID="txtHerbicide" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Fungicida
                    </td>
                    <td>
                        <asp:TextBox TextMode="Number" ID="txtFungicide" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Inseticida
                    </td>
                    <td>
                        <asp:TextBox TextMode="Number" ID="txtInsecticide" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Esterco
                    </td>
                    <td>
                        <asp:TextBox TextMode="Number" ID="txtManure" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Combustivel
                    </td>
                    <td>
                        <asp:TextBox TextMode="Number" ID="txtFuel" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Lubrificante
                    </td>
                    <td>
                        <asp:TextBox TextMode="Number" ID="txtLubricant" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Equipamento de limpeza
                    </td>
                    <td>
                        <asp:TextBox TextMode="Number" ID="txtCleaningEquipament" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Ferramentas
                    </td>
                    <td>
                        <asp:TextBox TextMode="Number" ID="txtTools" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Peças e acessórios
                    </td>
                    <td>
                        <asp:TextBox TextMode="Number" ID="txtAcessoriess" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Outros
                    </td>
                    <td>
                        <asp:TextBox TextMode="Number" ID="txtOthers" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </div>
        <div class="left">
            <h4>Serviços</h4>
            <table>
                <tr>
                    <td>Descrição</td>
                    <td>Valor total</td>
                </tr>
                <tr>
                    <td>Pessoal contratado
                    </td>
                    <td>
                        <asp:TextBox TextMode="Number" ID="txtEmployee" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Pessoal próprio
                    </td>
                    <td>
                        <asp:TextBox TextMode="Number" ID="txtTempEmployee" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Horas extras
                    </td>
                    <td>
                        <asp:TextBox TextMode="Number" ID="txtOvertime" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Eletricidade
                    </td>
                    <td>
                        <asp:TextBox TextMode="Number" ID="txtEletricity" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Manutenção de máquina
                    </td>
                    <td>
                        <asp:TextBox TextMode="Number" ID="txtMachineMaintenance" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Transporte próprio
                    </td>
                    <td>
                        <asp:TextBox TextMode="Number" ID="txtPublicTransport" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Transporte de terceiros
                    </td>
                    <td>
                        <asp:TextBox TextMode="Number" ID="txtThirdpartyTransport" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Outros
                    </td>
                    <td>
                        <asp:TextBox TextMode="Number" ID="txtServicesOthers" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </div>
        <div class="clean"></div>
        <asp:Label ID="lblErro" runat="server" placeholder=""></asp:Label>
        <hr />
        <asp:Button ID="btnCadastrar" OnClick="btnCadastrar_Click" runat="server" Text="Cadastrar" />
    </div>
</asp:Content>

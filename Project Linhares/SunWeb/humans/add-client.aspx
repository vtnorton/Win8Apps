<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="add-client.aspx.cs" Inherits="SunWeb.humans.add_client" EnableEventValidation="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
        $(document).ready(function () {
            $('input#txtFirstName, input#txtLastName, input#txtNickName, input#txtMail, input#txtPhone, input#txtAddress, input#txtNeighborhood, input#txtObservation, input#txtBrazilCPF, input#txtBrazilRG, input#txtPassport').characterCounter();
            $('#ContentPlaceHolder1_txtBirtday').pickadate({
                selectMonths: true, // Creates a dropdown to control month
                selectYears: 100 // Creates a dropdown of 15 years to control year
            });
            $('#ContentPlaceHolder1_txtHiringDate').pickadate({
                selectMonths: true, // Creates a dropdown to control month
                selectYears: 100 // Creates a dropdown of 15 years to control year
            });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblRepeted" runat="server" Text=""></asp:Label>
    <div class="row">
        <div class="col s12">
            <div class="input-field s12">
                <h3>Adicionar novo cliente</h3>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col s12">
            <div class="input-field s12">
                <h5>Informações básicas</h5>
            </div>
            <hr />
        </div>
    </div>
    <div class="row" style="margin-top: -20px">
        <div class="col s12">
            <div class="input-field col s4">
                <asp:TextBox ID="txtFirstName" CssClass="validate" length="25" MaxLength="25" runat="server"></asp:TextBox>
                <label for="txtFirstName">Nome</label>
            </div>
            <div class="input-field col s4">
                <asp:TextBox ID="txtLastName" CssClass="validate" length="25" MaxLength="25" runat="server"></asp:TextBox>
                <label for="txtLastName">Sobrenome</label>
            </div>
            <div class="input-field col s4">
                <asp:TextBox ID="txtNickName" CssClass="validate" length="25" MaxLength="25" runat="server"></asp:TextBox>
                <label for="txtNickName">Apelido</label>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col s12">
            <div class="input-field col s5">
                <asp:TextBox ID="txtMail" TextMode="Email" AutoPostBack="true" OnTextChanged="txtMail_TextChanged" length="150" MaxLength="150" CssClass="validate" runat="server"></asp:TextBox>
                <label for="txtMail" data-error="Por favor, digite um valor válido de e-mail" data-success="Correto!">E-mail</label>
            </div>
            <div class="input-field col s4">
                <asp:TextBox ID="txtPhone" TextMode="Phone" length="15" MaxLength="15" CssClass="validate" runat="server"></asp:TextBox>
                <label for="txtPhone">Telefone</label>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col s12">
            <div class="input-field col s4">
                <asp:TextBox ID="txtAddress" MaxLength="200" length="200" CssClass="validate" runat="server"></asp:TextBox>
                <label for="txtAddress">Endereço</label>
            </div>
            <div class="input-field col s2">
                <asp:TextBox ID="txtNeighborhood" MaxLength="50" length="50" CssClass="validate" runat="server"></asp:TextBox>
                <label for="txtNeighborhood">Bairro</label>
            </div>
            <div class="input-field col s2">
                <asp:TextBox ID="txtCity" MaxLength="120" length="120" CssClass="validate" runat="server"></asp:TextBox>
                <label for="txtCity">Cidade</label>
            </div>
            <%--<div class="input-field col s2">
                <label style="margin-top: -23px;">Estado</label>
                <asp:DropDownList ID="ddlState" name="ContentPlaceHolder1_ddlState" CssClass="browser-default" runat="server">
                </asp:DropDownList>
            </div>--%>
            <%--<div class="input-field col s2">
                <label style="margin-top: -23px;">País</label>
                <asp:DropDownList ID="ddlCountry" name="ContentPlaceHolder1_ddlCountry" CssClass="browser-default" runat="server">
                </asp:DropDownList>
            </div>--%>
        </div>
    </div>
    <div class="row">
        <div class="col s12">
            <div class="input-field col s3">
                <asp:TextBox ID="txtBirtday" TextMode="Date" runat="server"></asp:TextBox>
                <label for="txtBirtday">Data de nascimento</label>
            </div>
            <%--<div class="input-field col s3">
                <label style="margin-top: -23px;">País de nacionalidade</label>
                <asp:DropDownList ID="dllNacionalityCoutry" name="ContentPlaceHolder1_dllNacionalityCoutry" CssClass="browser-default" runat="server">
                </asp:DropDownList>
            </div>--%>
            <div class="input-field col s3">
                <asp:DropDownList ID="ddlSex" CssClass="browser-default" runat="server">
                    <asp:ListItem Enabled="true" Selected="True" Text="Escolha uma opção"></asp:ListItem>
                    <asp:ListItem Enabled="true" Selected="False" Text="Masculino" Value="M"></asp:ListItem>
                    <asp:ListItem Enabled="true" Selected="False" Text="Feminino" Value="F"></asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col s12">
            <div class="input-field col s6">
                <asp:TextBox ID="txtObservation" TextMode="MultiLine" length="5000" CssClass="validate materialize-textarea" runat="server"></asp:TextBox>
                <label for="txtObservation">Observações</label>
            </div>
        </div>
        <div class="row">
            <div class="col s12">
                <div class="input-field s12">
                    <h5>Documentos</h5>
                </div>
                <hr />
            </div>
        </div>
        <div class="row">
            <div class="col s12">
                <div class="input-field col s4">
                    <asp:TextBox ID="txtBrazilCPF" OnTextChanged="txtBrazilCPF_TextChanged" AutoPostBack="true" length="14" MaxLength="14" CssClass="validate" runat="server"></asp:TextBox>
                    <label for="txtBrazilCPF">CPF</label>
                </div>
                <div class="input-field col s4">
                    <asp:TextBox ID="txtBrazilRG" OnTextChanged="txtBrazilCPF_TextChanged" AutoPostBack="true" length="12" MaxLength="12" CssClass="validate" runat="server"></asp:TextBox>
                    <label for="txtBrazilRG">RG</label>
                </div>
                <div class="input-field col s4">
                    <asp:TextBox ID="txtPassport" OnTextChanged="txtPassport_TextChanged" AutoPostBack="true" length="50" CssClass="validate" runat="server"></asp:TextBox>
                    <label for="txtPassport">Passaporte</label>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col s12">
                <div class="all-post text-center">
                    <asp:Label ID="lblErro" runat="server" Text=""></asp:Label>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col col-md-4">
                <div class="all-post text-center">
                    <a href="manage-employee.aspx" class="btn red-text btn-red"><i class="fa fa-undo"></i>Cancelar</a>
                </div>
            </div>
            <div class="col col-md-4">
                <div class="all-post text-center">
                    <asp:LinkButton CssClass="btn btn-transparent" ID="hplAdd" OnClick="hplAdd_Click" runat="server"><i class="fa fa-plus"></i>Adicionar cliente</asp:LinkButton>
                </div>
            </div>
        </div>
    </div>
    <script>
        var maskBehavior = function (val) {
            return val.replace(/\D/g, '').length === 11 ? '(00) 00000-0000' : '(00) 0000-00009';
        },
        options = {
            onKeyPress: function (val, e, field, options) {
                field.mask(maskBehavior.apply({}, arguments), options);
            }
        };
        //populateCountries("ContentPlaceHolder1_ddlCountry", "ContentPlaceHolder1_ddlState");
        //populateCountries("ContentPlaceHolder1_dllNacionalityCoutry");
        $("#ContentPlaceHolder1_txtBrazilCPF").mask("000.000.000-00");
        $('#ContentPlaceHolder1_txtBrazilRG').mask('99.999.999-9');
        $('#ContentPlaceHolder1_txtBrazilCDTPIS').mask('000.00000.00-0');
        $('#ContentPlaceHolder1_txtBrazilCDTEmitionDate').mask('00/00/0000');
        $('#ContentPlaceHolder1_txtPhone').mask(maskBehavior, options);
    </script>
</asp:Content>

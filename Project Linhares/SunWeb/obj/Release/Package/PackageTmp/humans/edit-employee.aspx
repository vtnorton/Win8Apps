<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="edit-employee.aspx.cs" Inherits="SunWeb.humans.edit_employee"  EnableEventValidation="false"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
        $(document).ready(function () {
            $('input#txtFirstName, input#txtLastName, input#txtNickName, input#txtMail, input#txtPhone, input#txtAddress, input#txtNeighborhood, input#txtObservation, input#txtBrazilCDTNumber, input#txtBrazilCDTEmitionDate, input#txtBrazilCDTSigla, input#txtBrazilCDTSerie, input#txtBrazilCDTPIS, input#txtBrazilCDTCadastro, input#txtBrazilCPF, input#txtBrazilRG, input#txtBrazilCNH, input#txtPassport, input#txtJob, input#txtSalaryObservation').characterCounter();
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
    <div class="row">
        <div class="col s12">
            <div class="input-field s12">
                <h3>Adicionar novo funcionário</h3>
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
                <asp:TextBox ID="txtMail" TextMode="Email" length="150" MaxLength="150" CssClass="validate" runat="server"></asp:TextBox>
                <label for="txtMail" data-error="Por favor, digite um valor válido de e-mail" data-success="Correto!">E-mail</label>
            </div>
            <div class="input-field col s4">
                <asp:TextBox ID="txtPhone" TextMode="Phone" length="50" CssClass="validate" runat="server"></asp:TextBox>
                <label for="txtPhone">Telefone</label>
            </div>
            <div class="input-field col s3">
                <label style="margin-top: -23px;">Tipo de funcionário</label>
                <asp:DropDownList ID="ddlTemp" CssClass="browser-default" runat="server">
                    <asp:ListItem Enabled="false" Selected="True" Text="Escolha uma opção"></asp:ListItem>
                    <asp:ListItem Enabled="true" Selected="False" Text="Fixo" Value="0"></asp:ListItem>
                    <asp:ListItem Enabled="true" Selected="False" Text="Temporário" Value="1"></asp:ListItem>
                </asp:DropDownList>
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
            <div class="input-field col s2">
                <label style="margin-top: -23px;">Estado</label>
                <asp:DropDownList ID="ddlState" name="ContentPlaceHolder1_ddlState" CssClass="browser-default" runat="server">
                </asp:DropDownList>
            </div>
            <div class="input-field col s2">
                <label style="margin-top: -23px;">País</label>
                <asp:DropDownList ID="ddlCountry" name="ContentPlaceHolder1_ddlCountry" CssClass="browser-default" runat="server">
                </asp:DropDownList>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col s12">
            <div class="input-field col s3">
                <asp:TextBox ID="txtBirtday" TextMode="Date" runat="server"></asp:TextBox>
                <label for="txtBirtday">Data de nascimento</label>
            </div>
            <div class="input-field col s3">
                <label style="margin-top: -23px;">País de nacionalidade</label>
                <asp:DropDownList ID="dllNacionalityCoutry" name="ContentPlaceHolder1_dllNacionalityCoutry" CssClass="browser-default" runat="server">
                </asp:DropDownList>
            </div>
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
        <div class="row" style="margin-top: -20px">
            <div class="col s12">
                <div class="input-field col s4">
                    <asp:TextBox ID="txtBrazilCDTNumber" length="50" CssClass="validate" runat="server"></asp:TextBox>
                    <label for="txtBrazilCDTNumber">Carteira de trabalho</label>
                </div>
                <div class="input-field col s3">
                    <asp:TextBox ID="txtBrazilCDTEmitionDate" length="50" CssClass="validate" runat="server"></asp:TextBox>
                    <label for="txtBrazilCDTEmitionDate">Data de emissão</label>
                </div>
                <div class="input-field col s1">
                    <asp:TextBox ID="txtBrazilCDTSigla" length="50" CssClass="validate" runat="server"></asp:TextBox>
                    <label for="txtBrazilCDTSigla">Sigla</label>
                </div>
                <div class="input-field col s1">
                    <asp:TextBox ID="txtBrazilCDTSerie" length="50" CssClass="validate" runat="server"></asp:TextBox>
                    <label for="txtBrazilCDTSerie">Série</label>
                </div>
                <div class="input-field col s2">
                    <asp:TextBox ID="txtBrazilCDTPIS" length="50" CssClass="validate" runat="server"></asp:TextBox>
                    <label for="txtBrazilCDTPIS">P.I.S.</label>
                </div>
                <div class="input-field col s1">
                    <asp:TextBox ID="txtBrazilCDTCadastro" length="50" CssClass="validate" runat="server"></asp:TextBox>
                    <label for="txtBrazilCDTCadastro">Cadastro</label>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col s12">
                <div class="input-field col s4">
                    <asp:TextBox ID="txtBrazilCPF" length="50" CssClass="validate" runat="server"></asp:TextBox>
                    <label for="txtBrazilCPF">CPF</label>
                </div>
                <div class="input-field col s4">
                    <asp:TextBox ID="txtBrazilRG" length="50" CssClass="validate" runat="server"></asp:TextBox>
                    <label for="txtBrazilRG">RG</label>
                </div>
                <div class="input-field col s4">
                    <asp:TextBox ID="txtBrazilCNH" length="50" CssClass="validate" runat="server"></asp:TextBox>
                    <label for="txtBrazilCNH">Carteira de motorista</label>
                </div>
                <div class="input-field col s4">
                    <asp:TextBox ID="txtPassport" length="50" CssClass="validate" runat="server"></asp:TextBox>
                    <label for="txtPassport">Passaporte</label>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col s12">
                <div class="input-field s12">
                    <h5>Informações do funcionário</h5>
                </div>
                <hr />
            </div>
        </div>
        <div class="row" style="margin-top: -20px">
            <div class="col s12">

                <div class="input-field col s4">
                    <asp:TextBox ID="txtJob" length="50" CssClass="validate" runat="server"></asp:TextBox>
                    <label for="txtJob">Ocupação</label>
                </div>
                <div class="input-field col s3">
                    <asp:TextBox ID="txtSalary" TextMode="Number" CssClass="validate" runat="server"></asp:TextBox>
                    <label for="txtSalary">Salário</label>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col s12">
                <div class="input-field col s3">
                    <asp:TextBox ID="txtDaysAtWork" CssClass="validate" runat="server"></asp:TextBox>
                    <label for="txtDaysAtWork">Dias de trabalho</label>
                </div>
                <div class="input-field col s3">
                    <asp:TextBox ID="txtHoursOfWork" CssClass="validate" runat="server"></asp:TextBox>
                    <label for="txtHoursOfWork">Horas de trabalho</label>
                </div>
                <div class="input-field col s3">
                    <asp:TextBox ID="txtVacation" CssClass="validate" runat="server"></asp:TextBox>
                    <label for="txtVacation">Férias</label>
                </div>
                <div class="input-field col s3">
                    <asp:TextBox ID="txtHiringDate" TextMode="Date" runat="server"></asp:TextBox>
                    <label for="txtHiringDate">Contratação</label>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col s12">
                <div class="input-field col s5">
                    <asp:TextBox ID="txtSalaryObservation" length="5000" TextMode="MultiLine" CssClass="validate materialize-textarea" runat="server"></asp:TextBox>
                    <label for="txtSalaryObservation">Observação do salário</label>
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
                    <asp:LinkButton CssClass="btn btn-transparent red-text btn-red" ID="hplDelete" OnClick="hplDelete_Click" runat="server"><i class="fa fa-trash-o"></i>Excluir</asp:LinkButton>
                </div>
            </div>
            <div class="col col-md-4">
                <div class="all-post text-center">
                    <asp:LinkButton CssClass="btn btn-transparent" ID="hplSave" OnClick="hplSave_Click" runat="server"><i class="fa fa-save"></i>Salvar</asp:LinkButton>
                </div>
            </div>
            <div class="col col-md-4">
                <div class="all-post text-center">
                    <asp:LinkButton CssClass="btn btn-transparent" ID="hplAddUser" OnClick="hplAddUser_Click" runat="server"><i class="fa fa-plus"></i>Salvar e criar usuário</asp:LinkButton>
                </div>
            </div>
        </div>
    </div>
    <script>
        populateCountries("ContentPlaceHolder1_ddlCountry", "ContentPlaceHolder1_ddlState");
        populateCountries("ContentPlaceHolder1_dllNacionalityCoutry");
    </script>
</asp:Content>

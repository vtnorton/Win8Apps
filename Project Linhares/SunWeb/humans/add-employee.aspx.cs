using SunCore;
using SunCore.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SunWeb.humans
{
    public partial class add_employee : System.Web.UI.Page
    {

        int xIdEmployee;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void hplAdd_Click(object sender, EventArgs e)
        {
            AddEmployee();
        }

        protected void hplAddUser_Click(object sender, EventArgs e)
        {
            AddEmployee();
            Response.Redirect("/humans/add-user.aspx?id=" + xIdEmployee);
        }
        private void AddEmployee()
        {
            Create newEmployee = new Create();
            try
            {
                xIdEmployee = newEmployee.NewEmployee(1, txtBrazilCPF.Text, txtBrazilRG.Text, txtPassport.Text, txtBrazilCDTNumber.Text, txtBrazilCDTEmitionDate.Text, txtBrazilCDTSigla.Text, txtBrazilCDTSerie.Text, txtBrazilCDTPIS.Text, txtBrazilCDTCadastro.Text, txtBrazilCNH.Text, "SEM CNPJ", txtFirstName.Text, txtLastName.Text, txtNickName.Text, txtMail.Text, txtPhone.Text, txtAddress.Text, txtBirtday.Text, txtObservation.Text, " ", txtNeighborhood.Text, txtCity.Text, " ", ddlSex.SelectedItem.Value, txtJob.Text, txtHiringDate.Text, txtSalaryObservation.Text, txtSalary.Text, txtVacation.Text, txtHoursOfWork.Text, txtDaysAtWork.Text, int.Parse(ddlTemp.SelectedItem.Value));
                lblErro.Text = "<p>Funcionário inserido com sucesso! </p>";
            }
            catch (Exception Ex)
            {
                lblErro.Text = "<p>Houve um erro ao inserir novo funcionário: " + Ex.Message + "</p>";
            }
        }
        private void AddButtonDisable()
        {
            hplAdd.Attributes.Add("style", "display:none");
            hplAddUser.Attributes.Add("style", "display:none");
        }
        private void AddButtonEnable()
        {
            lblRepeted.Text = "";
            hplAddUser.Attributes.Add("style", "display:block");
            hplAdd.Attributes.Add("style", "display:block");
        }
        protected void txtMail_TextChanged(object sender, EventArgs e)
        {
            Check checkEmail = new Check();
            if(checkEmail.IsEmailExist(TableNames.Employee, txtMail.Text) != 0)
            {
                lblRepeted.Text = "<div class='erro-mensage'><h3>Pessoa repetida</h3><p>Já existe uma pessoa no sistema cadastrada com esse e-mail (ou cliente ou funcionário).</p></div>";
                AddButtonDisable();
                txtPassport.Enabled = false;
                txtBrazilCNH.Enabled = false;
                txtBrazilCPF.Enabled = false;
                txtBrazilRG.Enabled = false;
                txtBrazilCDTNumber.Enabled = false;
            }
            else
            {
                AddButtonEnable();
                txtPassport.Enabled = true;
                txtBrazilCNH.Enabled = true;
                txtBrazilCPF.Enabled = true;
                txtBrazilRG.Enabled = true;
                txtBrazilCDTNumber.Enabled = true;
            }
        }

        protected void txtBrazilCDTNumber_TextChanged(object sender, EventArgs e)
        {
            Check checkCDTNumber = new Check();
            if (checkCDTNumber.IsBrazilCDTNumeroExist(txtBrazilCDTNumber.Text) != 0)
            {
                lblRepeted.Text = "<div class='erro-mensage'><h3>Pessoa repetida</h3><p>Já existe uma pessoa no sistema cadastrada com esse número da carteira de trabalho (ou cliente ou funcionário).</p></div>";
                AddButtonDisable();
                txtPassport.Enabled = false;
                txtBrazilCNH.Enabled = false;
                txtBrazilCPF.Enabled = false;
                txtBrazilRG.Enabled = false;
                txtMail.Enabled = false;
            }
            else
            {
                AddButtonEnable();
                txtPassport.Enabled = true;
                txtBrazilCNH.Enabled = true;
                txtBrazilCPF.Enabled = true;
                txtBrazilRG.Enabled = true;
                txtMail.Enabled = true;
            }
        }

        protected void txtBrazilCPF_TextChanged(object sender, EventArgs e)
        {
            Check checkBrazilCPF = new Check();
            if (checkBrazilCPF.IsBrazilCPFExist(txtBrazilCPF.Text) != 0)
            {
                lblRepeted.Text = "<div class='erro-mensage'><h3>Pessoa repetida</h3><p>Já existe uma pessoa no sistema cadastrada com esse CPF (ou cliente ou funcionário).</p></div>";
                AddButtonDisable();
                txtPassport.Enabled = false;
                txtBrazilCNH.Enabled = false;
                txtBrazilCDTNumber.Enabled = false;
                txtBrazilRG.Enabled = false;
                txtMail.Enabled = false;
            }
            else
            {
                AddButtonEnable();
                txtPassport.Enabled = true;
                txtBrazilCNH.Enabled = true;
                txtBrazilCDTNumber.Enabled = true;
                txtBrazilRG.Enabled = true;
                txtMail.Enabled = true;
            }
        }

        protected void txtBrazilCNH_TextChanged(object sender, EventArgs e)
        {
            Check checkBrazilCNH = new Check();
            if (checkBrazilCNH.IsBrazilCNHExist(txtBrazilCNH.Text) != 0)
            {
                lblRepeted.Text = "<div class='erro-mensage'><h3>Pessoa repetida</h3><p>Já existe uma pessoa no sistema cadastrada com esse documento (CNH) (ou cliente ou funcionário).</p></div>";
                AddButtonDisable();
                txtPassport.Enabled = false;
                txtBrazilCPF.Enabled = false;
                txtBrazilCDTNumber.Enabled = false;
                txtBrazilRG.Enabled = false;
                txtMail.Enabled = false;
            }
            else
            {
                AddButtonEnable();
                txtPassport.Enabled = true;
                txtBrazilCPF.Enabled = true;
                txtBrazilCDTNumber.Enabled = true;
                txtBrazilRG.Enabled = true;
                txtMail.Enabled = true;
            }
        }

        protected void txtPassport_TextChanged(object sender, EventArgs e)
        {
            Check checkPassport = new Check();
            if (checkPassport.IsPassportExist(txtPassport.Text) != 0)
            {
                lblRepeted.Text = "<div class='erro-mensage'><h3>Pessoa repetida</h3><p>Já existe uma pessoa no sistema cadastrada com passaporte (ou cliente ou funcionário).</p></div>";
                AddButtonDisable();
                txtBrazilCNH.Enabled = false;
                txtBrazilCPF.Enabled = false;
                txtBrazilCDTNumber.Enabled = false;
                txtBrazilRG.Enabled = false;
                txtMail.Enabled = false;
            }
            else
            {
                AddButtonEnable();
                txtBrazilCNH.Enabled = true;
                txtBrazilCPF.Enabled = true;
                txtBrazilCDTNumber.Enabled = true;
                txtBrazilRG.Enabled = true;
                txtMail.Enabled = true;
            }
        }
    }
}
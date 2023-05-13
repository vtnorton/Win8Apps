using SunCore;
using SunCore.Methods;
using System;

namespace SunWeb.humans
{
    public partial class add_client : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void hplAdd_Click(object sender, EventArgs e)
        {
            Create newCliente = new Create();
            try
            {
                newCliente.NewClient(1, txtBrazilCPF.Text, txtBrazilRG.Text, txtPassport.Text, "NN", "NN", "NN", "NN", "NN", "NN", "SEM CNH", "SEM CNPJ", txtFirstName.Text, txtLastName.Text, txtNickName.Text, txtMail.Text, txtPhone.Text, txtAddress.Text, txtBirtday.Text, txtObservation.Text, " ", txtNeighborhood.Text, txtCity.Text, " ", ddlSex.SelectedItem.Text);
                lblErro.Text = "<p>Cliente inserido com sucesso! </p>";
            }
            catch (Exception Ex)
            {
                lblErro.Text = "<p>Houve um erro ao inserir novo cliente: " + Ex.Message + "</p>";
            }
        }

        private void AddButtonDisable()
        {
            hplAdd.Attributes.Add("style", "display:none");
        }
        private void AddButtonEnable()
        {
            lblRepeted.Text = "";
            hplAdd.Attributes.Add("style", "display:block");
        }
        protected void txtMail_TextChanged(object sender, EventArgs e)
        {
            Check checkEmail = new Check();
            if (checkEmail.IsEmailExist(TableNames.Client, txtMail.Text) != 0)
            {
                lblRepeted.Text = "<div class='erro-mensage'><h3>Pessoa repetida</h3><p>Já existe uma pessoa no sistema cadastrada com esse e-mail (ou cliente ou funcionário).</p></div>";
                AddButtonDisable();
                txtPassport.Enabled = false;
                txtBrazilCPF.Enabled = false;
                txtBrazilRG.Enabled = false;
            }
            else
            {
                AddButtonEnable();
                txtPassport.Enabled = true;
                txtBrazilCPF.Enabled = true;
                txtBrazilRG.Enabled = true;
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
                txtBrazilRG.Enabled = false;
                txtMail.Enabled = false;
            }
            else
            {
                AddButtonEnable();
                txtPassport.Enabled = true;
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
                txtBrazilCPF.Enabled = false;
                txtBrazilRG.Enabled = false;
                txtMail.Enabled = false;
            }
            else
            {
                AddButtonEnable();
                txtBrazilCPF.Enabled = true;
                txtBrazilRG.Enabled = true;
                txtMail.Enabled = true;
            }
        }
    }
}
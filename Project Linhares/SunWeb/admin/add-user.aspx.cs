using SunCore.Methods;
using System;
using System.Web.UI.WebControls;

namespace SunWeb.admin
{
    public partial class add_user : System.Web.UI.Page
    {
        int IdUser;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlFarm.DataSource = new Read().Farm(IdUser);
                if (!IsPostBack)
                {
                    ddlFarm.DataTextField = "Name";
                    ddlFarm.DataValueField = "Id";
                }
                ddlFarm.DataBind();

                if (ddlFarm.Items.Count == 0)
                    ddlFarm.Items.Insert(0, new ListItem("Não há nenhuma fazenda cadastrada", "108", true));
                else
                    ddlFarm.Items.Insert(0, new ListItem("Selecione uma fazenda", "108", true));
            }
        }

        protected void btnNewuser_Click(object sender, EventArgs e)
        {
            Create newUser = new Create();
            try
            {
                newUser.NewUser(int.Parse(ddlFarm.SelectedValue), txtCPF.Text, txtRG.Text, txtPassport.Text, "0", "0",txtName.Text, txtLastName.Text,txtNickName.Text, txtEmail.Text, txtPhone.Text, txtAdress.Text, "0", 0, int.Parse(rbtUnity.SelectedValue), txtPassword.Text);
                lblErro.Text = "Cadastrado com sucesso";
            }
            catch (Exception ex)
            {
                lblErro.Text = "Erro: " + ex.Message;
            }
        }
    }
}
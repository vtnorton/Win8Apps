using SunCore.Methods;
using SunCore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SunWeb.admin
{
    public partial class edit_user : System.Web.UI.Page
    {
        public int IdFarm = 1;
        int Id, IdDocument;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            Id = int.Parse(Request.QueryString["Id"]);
            UserRepository repoUser = new UserRepository();

            txtAdress.Text = repoUser.RetornarID(Id).Address;
            txtBirthday.Text = repoUser.RetornarID(Id).Birthday.ToString();
            txtEmail.Text = repoUser.RetornarID(Id).Email;
            txtLastName.Text = repoUser.RetornarID(Id).LastName;
            txtName.Text = repoUser.RetornarID(Id).Name;
            txtNickName.Text = repoUser.RetornarID(Id).NickName;
            txtPassword.Text = repoUser.RetornarID(Id).Password;
            txtPhone.Text = repoUser.RetornarID(Id).Phone;
            IdDocument = repoUser.RetornarID(Id).IdDocument;
        }

        protected void btnNewuser_Click(object sender, EventArgs e)
        {
            Update updateUser = new Update();
            //newUser.UpdateDocument(txtCPF.Text, txtRG.Text, txtPassport.Text, "", "");
            //Metodo para retornar o id do documento criado cujo cpf, rg, passaport e outros sejam igual ao passado
            try
            {
                try
                {
                    updateUser.UpdateDocument(IdDocument,txtCPF.Text, txtRG.Text, txtPassport.Text, null, null);
                    lblErro.Text = "Atualizado com sucesso";
                }
                catch (Exception ex)
                {
                    lblErro.Text = "Erro ao inserir documento: " + ex.Message;
                }
                updateUser.UpdateUser(Id, IdFarm, txtName.Text, txtLastName.Text, txtNickName.Text, txtEmail.Text, txtPhone.Text, txtAdress.Text, "0", 0, 0, txtPassword.Text);
                lblErro.Text = "Atualizado com sucesso";
            }
            catch (Exception ex)
            {
                lblErro.Text = "Erro: " + ex.Message;
            }
        }
    }
}
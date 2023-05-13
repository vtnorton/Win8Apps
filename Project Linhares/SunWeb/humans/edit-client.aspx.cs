using SunCore.Methods;
using SunCore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SunWeb.humans
{
    public partial class edit_client : System.Web.UI.Page
    {
        public int IdUser = 1;
        int Id;
        protected void Page_Load(object sender, EventArgs e)
        {
            Id = int.Parse(Request.QueryString["Id"]);
            ClientRepository repoClient = new ClientRepository();
            DocumentRepository repoDocument = new DocumentRepository();
            int IdDocument = repoClient.RetornarID(Id).IdDocument;

            txtAddress.Text = repoClient.RetornarID(Id).Address;
            txtBirtday.Text = repoClient.RetornarID(Id).Birthday;
            txtBrazilCPF.Text = repoDocument.RetornarID(IdDocument).BrazilCPF;
            txtBrazilRG.Text = repoDocument.RetornarID(IdDocument).BrazilRG;
            txtCity.Text = repoClient.RetornarID(Id).City;
            txtLastName.Text = repoClient.RetornarID(Id).LastName;
            txtMail.Text = repoClient.RetornarID(Id).Email;
            txtNeighborhood.Text = repoClient.RetornarID(Id).Neighborhood;
            txtNickName.Text = repoClient.RetornarID(Id).NickName;
            txtObservation.Text = repoClient.RetornarID(Id).Observation;
            txtPassport.Text = repoDocument.RetornarID(IdDocument).Passport;
            txtPhone.Text = repoClient.RetornarID(Id).Phone;
            ddlSex.SelectedValue = repoClient.RetornarID(Id).Sex;
        }

        protected void hplDelete_Click(object sender, EventArgs e)
        {
            Delete deleteClient = new Delete();
            try
            {
                deleteClient.DeleteClient(Id);
                Response.Redirect("/humans/manage-client.aspx");
            }
            catch (Exception ex)
            {
                lblErro.Text = "Erro: " + ex.Message;
            }
        }

        protected void hplSave_Click(object sender, EventArgs e)
        {
            Update updateClient = new Update();
            try
            {
                updateClient.UpdateClient(Id, 1, txtBrazilCPF.Text, txtBrazilRG.Text, txtPassport.Text, "NN", "NN", "NN", "NN", "NN", "NN", "SEM CNH", "SEM CNPJ", txtFirstName.Text, txtLastName.Text, txtNickName.Text, txtMail.Text, txtPhone.Text, txtAddress.Text, txtBirtday.Text, txtObservation.Text, " ", txtNeighborhood.Text, txtCity.Text, " ", ddlSex.SelectedItem.Text);
                lblErro.Text = "Salvo com sucesso";
            }
            catch (Exception ex)
            {
                lblErro.Text = "Erro: " + ex.Message;
            }
        }
    }
}
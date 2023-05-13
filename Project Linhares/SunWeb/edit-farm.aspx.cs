using SunCore.Methods;
using SunCore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SunWeb
{
    public partial class edit_farm : System.Web.UI.Page
    {
        int Id;
        protected void Page_Load(object sender, EventArgs e)
        {
            Id = int.Parse(Request.QueryString["Id"]);
            FarmRepository repoUser = new FarmRepository();
            txtAdress.Text = repoUser.RetornarID(Id).Address;
            txtCoutry.Text = repoUser.RetornarID(Id).IdCountry.ToString();
            txtName.Text = repoUser.RetornarID(Id).Name;
            txtOwner.Text = repoUser.RetornarID(Id).Owner;
            txtRegion.Text = repoUser.RetornarID(Id).IdRegion.ToString();
            txtSize.Text = repoUser.RetornarID(Id).Size.ToString();
        }

        protected void btnNewuser_Click(object sender, EventArgs e)
        {
            Update updateFarm = new Update();
            try
            {
                updateFarm.UpdateFarm(Id,int.Parse(txtSize.Text), 1, 1, txtName.Text, txtOwner.Text, txtAdress.Text, 1, 1);
                lblErro.Text = "Atualizado com sucesso";
            }
            catch (Exception ex)
            {
                lblErro.Text = "Erro: " + ex.Message;
            }
        }
    }
}
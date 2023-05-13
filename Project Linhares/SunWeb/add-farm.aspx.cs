using SunCore.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SunWeb
{
    public partial class add_farm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlCountry.DataSource = new Read().Country();
                if (!IsPostBack)
                {
                    ddlCountry.DataTextField = "Name";
                    ddlCountry.DataValueField = "Id";
                }
                ddlCountry.DataBind();

                if (ddlCountry.Items.Count == 0)
                    ddlCountry.Items.Insert(0, new ListItem("Não há nenhuma país cadastrado", "108", true));
                else
                    ddlCountry.Items.Insert(0, new ListItem("Selecione um país", "108", true));

                ddlRegion.SelectedValue = "108";
                ddlRegion.Items.Insert(0, new ListItem("Selecione um país primeiro", "108", true));
            }
        }

        protected void btnNewuser_Click(object sender, EventArgs e)
        {
            Create newFarm = new Create();
            try
            {
                //newFarm.NewFarm(int.Parse(txtSize.Text), 1, 1, txtName.Text, txtOwner.Text, txtAdress.Text, int.Parse(ddlRegion.SelectedValue), int.Parse(ddlCountry.SelectedValue));
                newFarm.NewFarm(int.Parse(txtSize.Text), 1, 1, txtName.Text, txtOwner.Text, txtAdress.Text, 1, int.Parse(ddlCountry.SelectedValue));
                lblErro.Text = "Cadastrado com sucesso";
            }
            catch (Exception ex)
            {
                lblErro.Text = "Erro: " + ex.Message;
            }
        }

        protected void ddlRegion_SelectedIndexChanged(object sender, EventArgs e)
        {

            ddlRegion.DataSource = null;
            ddlRegion.DataBind();

            ddlRegion.Enabled = false;

            

            //if (!IsPostBack)
            //{
            //    ddlRegion.DataSource = new Read().Region(int.Parse(ddlCountry.SelectedValue));
            //    if (!IsPostBack)
            //    {
            //        ddlRegion.DataTextField = "Name";
            //        ddlRegion.DataValueField = "Id";
            //    }
            //    ddlCountry.DataBind();

            //    if (ddlRegion.Items.Count == 0)
            //        ddlRegion.Items.Insert(0, new ListItem("Não há nenhuma país cadastrado", "108", true));
            //    else
            //        ddlRegion.Items.Insert(0, new ListItem("Selecione um país", "108", true));
               
            //}
        }
    }
}
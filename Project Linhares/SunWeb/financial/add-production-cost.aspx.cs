using SunCore.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SunWeb.financial
{
    public partial class add_production_cost : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            Create newProductionCost = new Create();
            try
            {
                newProductionCost.NewProducitonCost(1, decimal.Parse(txtFertilizer.Text), decimal.Parse(txtMicroNutrients.Text), decimal.Parse(txtHerbicide.Text), decimal.Parse(txtFungicide.Text), decimal.Parse(txtInsecticide.Text), decimal.Parse(txtManure.Text), decimal.Parse(txtFuel.Text), decimal.Parse(txtLubricant.Text), decimal.Parse(txtCleaningEquipament.Text), decimal.Parse(txtTools.Text), decimal.Parse(txtAcessoriess.Text), decimal.Parse(txtOthers.Text), decimal.Parse(txtEmployee.Text), decimal.Parse(txtTempEmployee.Text), decimal.Parse(txtOvertime.Text), decimal.Parse(txtEletricity.Text), decimal.Parse(txtMachineMaintenance.Text), decimal.Parse(txtPublicTransport.Text), decimal.Parse(txtThirdpartyTransport.Text), "", decimal.Parse(txtServicesOthers.Text), "Usuário anonimo", DateTime.Now);
                lblErro.Text = "Cadastrado com sucesso";
            }
            catch (Exception ex)
            {
                lblErro.Text = "Erro: " + ex.Message;
            }
        }
    }
}
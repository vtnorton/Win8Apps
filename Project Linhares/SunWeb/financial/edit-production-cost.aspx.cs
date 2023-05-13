using SunCore.Methods;
using SunCore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SunWeb.financial
{
    public partial class edit_production_cost : System.Web.UI.Page
    {
        int Id;
        protected void Page_Load(object sender, EventArgs e)
        {
            Id = int.Parse(Request.QueryString["Id"]);
            ProductionCostRepository repoProductionCost = new ProductionCostRepository();

            txtAcessoriess.Text = repoProductionCost.RetornarID(Id).Accessories.ToString();
            txtCleaningEquipament.Text = repoProductionCost.RetornarID(Id).CleaningEquipament.ToString();
            txtEletricity.Text = repoProductionCost.RetornarID(Id).Eletricity.ToString();
            txtEmployee.Text = repoProductionCost.RetornarID(Id).Employee.ToString();
            txtFertilizer.Text = repoProductionCost.RetornarID(Id).Fertilizer.ToString();
            txtFuel.Text = repoProductionCost.RetornarID(Id).Fuel.ToString();
            txtFungicide.Text = repoProductionCost.RetornarID(Id).Fungicide.ToString();
            txtHerbicide.Text = repoProductionCost.RetornarID(Id).Herbicide.ToString();
            txtInsecticide.Text = repoProductionCost.RetornarID(Id).Insecticide.ToString();
            txtLubricant.Text = repoProductionCost.RetornarID(Id).Lubricant.ToString();
            txtMachineMaintenance.Text = repoProductionCost.RetornarID(Id).MachineMaintenance.ToString();
            txtManure.Text = repoProductionCost.RetornarID(Id).Manure.ToString();
            txtMicroNutrients.Text = repoProductionCost.RetornarID(Id).MicroNutrients.ToString();
            txtOthers.Text = repoProductionCost.RetornarID(Id).Others.ToString();
            txtOvertime.Text = repoProductionCost.RetornarID(Id).Overtime.ToString();
            txtPublicTransport.Text = repoProductionCost.RetornarID(Id).PublicTransport.ToString();
            txtServicesOthers.Text = repoProductionCost.RetornarID(Id).ServicesOthers.ToString();
            txtTempEmployee.Text = repoProductionCost.RetornarID(Id).TempEmployee.ToString();
            txtThirdpartyTransport.Text = repoProductionCost.RetornarID(Id).ThirdpartyTransport.ToString();
            txtTools.Text = repoProductionCost.RetornarID(Id).Tools.ToString();
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            Update updateProductionCost = new Update();
            try
            {
                updateProductionCost.UpdateProducitonCost(Id,1, decimal.Parse(txtFertilizer.Text), decimal.Parse(txtMicroNutrients.Text), decimal.Parse(txtHerbicide.Text), decimal.Parse(txtFungicide.Text), decimal.Parse(txtInsecticide.Text), decimal.Parse(txtManure.Text), decimal.Parse(txtFuel.Text), decimal.Parse(txtLubricant.Text), decimal.Parse(txtCleaningEquipament.Text), decimal.Parse(txtTools.Text), decimal.Parse(txtAcessoriess.Text), decimal.Parse(txtOthers.Text), decimal.Parse(txtEmployee.Text), decimal.Parse(txtTempEmployee.Text), decimal.Parse(txtOvertime.Text), decimal.Parse(txtEletricity.Text), decimal.Parse(txtMachineMaintenance.Text), decimal.Parse(txtPublicTransport.Text), decimal.Parse(txtThirdpartyTransport.Text), "", decimal.Parse(txtServicesOthers.Text), "Usuário anonimo", DateTime.Now);
                lblErro.Text = "Atualizado com sucesso";
            }
            catch (Exception ex)
            {
                lblErro.Text = "Erro: " + ex.Message;
            }
        }
    }
}
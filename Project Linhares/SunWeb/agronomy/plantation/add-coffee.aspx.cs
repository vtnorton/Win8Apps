using SunCore.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SunWeb.agronomy.plantation
{
    public partial class add_coffee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnStart_Click(object sender, EventArgs e)
        {
            Create newCoffee = new Create();
            newCoffee.NewUserCoffee(1, false, txtNome.Text, 1, 0, txtDateOfPlantation.Text, txtEndOfPlantation.Text, 0, txtBateOfFlowering.Text, txtEndOfFlowering.Text, 0, txtHarvest.Text, txtEndOfHarvest.Text, 0, txtProcessing.Text, txtEndOfProcessing.Text, 0, txtDrying.Text, txtEndOfDrying.Text, 0, txtRoasting.Text, txtEndOfRoasting.Text, 0, txtGrinding.Text, txtEndOfFrinding.Text, 0, txtClassification.Text, txtendOfClassification.Text, 0, txtPacking.Text, txtEndOfPacking.Text, 0, txtBoking.Text, txtEndOfBoking.Text);
        }
    }
}
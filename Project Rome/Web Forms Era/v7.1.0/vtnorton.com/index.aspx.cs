using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using vtnCore.Methods;

namespace VTNORTON
{
    public partial class index1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBaixar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
                lblEmailerro.Text = "Por favor, insira um e-mail";
            else
            {
                try
                {
                    new Create().NewEmail(txtEmail.Text);
                    txtEmail.Text = null;
                    lblEmailerro.Text = "Cadastrado com sucesso";
                }
                catch (Exception)
                {
                    lblEmailerro.Text = "Houve um erro ao cadastrar seu e-mail, desculpe. :(";
                }
                
            }
        }
    }
}
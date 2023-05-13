using System;
using System.Web.UI;
using vtnCore.Methods;
using vtnCore.Stuff;

namespace VTNORTON.extention
{
    public partial class truedarkmode : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                rssRepeater.DataSource = GetRSS.Get("http://dev.vtnorton.com/category/apps/true-dark-mode/feed", 3);
                rssRepeater.DataBind();
            }
            catch (Exception)
            {

            }
        }
        protected void btnBaixar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
                lblEmailerro.Text = "Por favor, insira um e-mail";
            else
            {
                try
                {
                    InsertEmail.Insert(txtEmail.Text, EmailLists.TrueDarkMode);
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
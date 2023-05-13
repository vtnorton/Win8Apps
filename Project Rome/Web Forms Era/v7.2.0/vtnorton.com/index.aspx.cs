using System;
using System.ComponentModel.DataAnnotations;
using System.Web.UI;
using vtnCore.Classes;
using vtnCore.Methods;
using vtnCore.Repository;
using vtnCore.Stuff;

namespace VTNORTON
{
    public partial class index1 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                rssRepeater.DataSource = GetRSS.Get("http://blog.vtnorton.com/feed", 3);
                rssRepeater.DataBind();
                rptDev.DataSource = GetRSS.Get("http://dev.vtnorton.com/feed", 3);
                rptDev.DataBind();
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
                    InsertEmail.Insert(txtEmail.Text, EmailLists.Main);

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
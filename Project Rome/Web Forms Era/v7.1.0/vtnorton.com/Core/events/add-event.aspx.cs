using System;
using System.Web.UI;
using vtnCore.Methods;

namespace VTNORTON.Core.events
{
    public partial class add_event : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAno.Text) || string.IsNullOrEmpty(txtDescricao.Text) || string.IsNullOrEmpty(txtDia.Text) ||
                string.IsNullOrEmpty(txtEndereco.Text) || string.IsNullOrEmpty(txtMes.Text) || string.IsNullOrEmpty(txtNome.Text) ||
                string.IsNullOrEmpty(txtURL.Text))
                lblInfo.Text = "Por favor, insira todas as informações pedidas";
            else
            {
                try
                {
                    int x = int.Parse(RadioButtonList1.SelectedValue);
                    int y = int.Parse(RadioButtonList2.SelectedValue);
                    new Create().NewEvento(int.Parse(txtDia.Text), x, y, int.Parse(txtAno.Text), txtEndereco.Text, txtNome.Text, txtMes.Text, txtDescricao.Text, txtURL.Text);
                    lblInfo.Text = "Evento inserido com sucesso";
                    txtURL.Text = null;
                    txtDescricao.Text = null;
                    txtNome.Text = null;
                    txtMes.Text = null;
                    txtEndereco.Text = null;
                    txtDia.Text = null;
                    txtAno.Text = null;
                }
                catch (Exception ex)
                {
                    lblInfo.Text = "Houve um erro ao adicionar o evento: " + ex.Message;
                }
            }
        }
    }
}
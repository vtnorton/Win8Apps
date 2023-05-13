using Hidra;
using Hidra.Resultados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VTNORTON.search
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String StringDigitada = "Teste";
            lblResutadoHidra.Text = Knowledge.Resultado(StringDigitada) + Bing.Resultado(StringDigitada) + Google.Resultado(StringDigitada) + Youtube.Resultado(StringDigitada) + Twitter.Resultado(StringDigitada) + Wikipedia.Resultado(StringDigitada);
        }
    }
}
using E2014Classes.Objetos;
using E2014Classes.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Eleicao
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Votacao objVotacao = new Votacao();
            VotacaoRepository daoVotacao = new VotacaoRepository();

            lblVotosAecio.Text = daoVotacao.RetornarPorID("1").VotosAecio + " votos";
            lblVotosDilma.Text = daoVotacao.RetornarPorID("1").VotosDilma + " votos";
            lblVotosPCAecio.Text = daoVotacao.RetornarPorID("1").PorcentagemVotosAecio +"%";
            lblVotosPCDilma.Text = daoVotacao.RetornarPorID("1").PorcentagemVotosDilma + "%";
        }
    }
}
using BuildClasses;
using BuildClasses.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VTNORTON.pages
{
    public partial class atualizacao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int LinkID = Convert.ToInt32(Request.QueryString["LinkID"]);

            Atualizacao objAtualizacao = new Atualizacao();
            AtualizacaoRepository daoAtualizacao = new AtualizacaoRepository();

            if (daoAtualizacao.RetornarPorID(LinkID) == null)
            {
                 Response.Redirect("/erro/404.aspx?LinkID=" + LinkID + "&atualizacao.aspx");
            }
            else
            {
                try
                {
                    Solucao objSolucao = new Solucao();
                    SolucaoRepository daoSolucaa = new SolucaoRepository();
                    lblNomeVersao.Text = daoAtualizacao.RetornarPorID(LinkID).NomeDaVersao;
                    lblVersao.Text = daoAtualizacao.RetornarPorID(LinkID).VersaoPrimeiroNumero.ToString() + "." + daoAtualizacao.RetornarPorID(LinkID).VersaoSegundoNumero.ToString() + "." + daoAtualizacao.RetornarPorID(LinkID).VersaoTerceiroNumero.ToString();
                    lblDescricao.Text = daoAtualizacao.RetornarPorID(LinkID).Descricao;
                    lblChangelog.Text = daoAtualizacao.RetornarPorID(LinkID).Changelog;
                    lblData.Text = daoAtualizacao.RetornarPorID(LinkID).DataDaAtualizacao;
                    int Solucao = daoAtualizacao.RetornarPorID(LinkID).IDSolucao;
                    lblSolucao.Text = daoSolucaa.RetornarPorID(Solucao).Nome;
                }
                catch(Exception ex)
                {
                   // ex.Message;
                   //Response.Redirect("/erro/000.aspx?LinkID=" + LinkID + "&atualizacao.aspx&Message=" + ex.Message);
                }
            }

        }

        protected void btnComentarioAttOC(object sender, EventArgs e)
        {

        }
    }
}
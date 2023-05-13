using BuildClasses;
using BuildClasses.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BuildOnline
{
    public partial class cadastrar_atualizacoes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void CommitCadastroAtualizacao(object sender, EventArgs e)
        {
            try
            {
                Atualizacao Att = new Atualizacao();
                AtualizacoesRepository dao = new AtualizacoesRepository();
            
                Att.NomeDaVersao = txtNome.Text;
                Att.Descricao = txtDescricao.Text;
                Att.Changelog = txtChangelog.Text;
                Att.VersaoPrimeiroNumero = Convert.ToInt32(txtPrimeiroNumero.Text); //Verificar se o int32 vai tranferir o numero puro
                Att.VersaoSegundoNumero = Convert.ToInt32(txtSegundoNumero.Text);
                Att.VersaoTerceiroNumero = Convert.ToInt32(txtTerceiroNumero.Text);

                Att.DataDaAtualizacao = txtData.Text; // Precisa mudar o DataDaAtualizacao de String para Date

                Att.IDSolucao = Convert.ToInt32(drdSistema.SelectedValue); // Com certeza vai precisar alterar aqui

                dao.Inserir(Att);
                lblMensagem.Text = "Atualização cadastrada com sucesso! :-)";
            }
            catch
            {
                lblMensagem.Text = "Houve um erro desconheicido ao cadastrar a atualização";
            }
        }
        protected void drdSistema_Load(object sender, EventArgs e)
        {
            Solucoes Soluc = new Solucoes();
            SolucoesRepository daosoluc = new SolucoesRepository();
        } 
    }
}
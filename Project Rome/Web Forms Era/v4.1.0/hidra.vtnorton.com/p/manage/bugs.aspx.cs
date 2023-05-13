using Ladon.Methods;
using System;

namespace HidraOnline.p.manage
{
    public partial class bugs : System.Web.UI.Page
    {
        int StartWith, Load;
        String Status, Type;
        Read readBug = new Read();

        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Request.QueryString["sw"] != null)
                StartWith = Convert.ToInt32(Request.QueryString["sw"]);
            else
                StartWith = 0;

            if (Request.QueryString["ddlStatus"] != null)
                Status = Request.QueryString["ddlStatus"];
            else
                Status = "All";

            if (Request.QueryString["ddlType"] != null)
                Type = Request.QueryString["ddlType"];
            else
                Type = "Both";

            if (Request.QueryString["Load"] != null)
                Load = Convert.ToInt32(Request.QueryString["Load"]);
            else
                Load = 25;

            if(Type == "Both")
            {
                switch (Status)
                {
                    case "GoingOn":
                        lblSelecionado.Text = "Mostando " + Convert.ToInt32(ddlCarregar.Text) + " itens dos tipos (sugestão e problemas) que estão em andamento.";
                        break;
                    case "Recived":
                        lblSelecionado.Text = "Mostando " + Convert.ToInt32(ddlCarregar.Text) + " itens dos tipos (sugestão e problemas) que foram recebidas.";
                        break;
                    case "Canceled":
                        lblSelecionado.Text = "Mostando " + Convert.ToInt32(ddlCarregar.Text) + " itens dos tipos (sugestão e problemas) que foram canceladas.";
                        break;
                    case "Done":
                        lblSelecionado.Text = "Mostando " + Convert.ToInt32(ddlCarregar.Text) + " itens dos tipos (sugestão e problemas) que foram concluidos.";
                        break;
                    case "NextUpdate":
                        lblSelecionado.Text = "Mostando " + Convert.ToInt32(ddlCarregar.Text) + " itens dos tipos (sugestão e problemas) que estarão na proxíma atualização.";
                        break;
                    case "NonRecived":
                        lblSelecionado.Text = "Mostando " + Convert.ToInt32(ddlCarregar.Text) + " itens dos tipos (sugestão e problemas) que não foram recebidos.";
                        break;
                    case "All":
                        lblSelecionado.Text = "Mostando " + Convert.ToInt32(ddlCarregar.Text) + " itens dos tipos (sugestão e problemas).";
                        break;
                }
            }else if(Type == "Bugs")
            {
                switch (Status)
                {
                    case "GoingOn":
                        lblSelecionado.Text = "Mostando " + Convert.ToInt32(ddlCarregar.Text) + " problemas que estão em andamento.";
                        break;
                    case "Recived":
                        lblSelecionado.Text = "Mostando " + Convert.ToInt32(ddlCarregar.Text) + " problemas que foram recebidas.";
                        break;
                    case "Canceled":
                        lblSelecionado.Text = "Mostando " + Convert.ToInt32(ddlCarregar.Text) + " problemas que foram canceladas.";
                        break;
                    case "Done":
                        lblSelecionado.Text = "Mostando " + Convert.ToInt32(ddlCarregar.Text) + " problemas que foram concluidos.";
                        break;
                    case "NextUpdate":
                        lblSelecionado.Text = "Mostando " + Convert.ToInt32(ddlCarregar.Text) + " problemas que estarão na proxíma atualização.";
                        break;
                    case "NonRecived":
                        lblSelecionado.Text = "Mostando " + Convert.ToInt32(ddlCarregar.Text) + " problemas que não foram recebidos.";
                        break;
                    case "All":
                        lblSelecionado.Text = "Mostando " + Convert.ToInt32(ddlCarregar.Text) + " problemas.";
                        break;
                }
            }else if(Type == "Sugestion")
            {
                switch (Status)
                {
                    case "GoingOn":
                        lblSelecionado.Text = "Mostando " + Convert.ToInt32(ddlCarregar.Text) + " sugestões que estão em andamento.";
                        break;
                    case "Recived":
                        lblSelecionado.Text = "Mostando " + Convert.ToInt32(ddlCarregar.Text) + " sugestões que foram recebidas.";
                        break;
                    case "Canceled":
                        lblSelecionado.Text = "Mostando " + Convert.ToInt32(ddlCarregar.Text) + " sugestões que foram canceladas.";
                        break;
                    case "Done":
                        lblSelecionado.Text = "Mostando " + Convert.ToInt32(ddlCarregar.Text) + " sugestões que foram concluidos.";
                        break;
                    case "NextUpdate":
                        lblSelecionado.Text = "Mostando " + Convert.ToInt32(ddlCarregar.Text) + " sugestões que estarão na proxíma atualização.";
                        break;
                    case "NonRecived":
                        lblSelecionado.Text = "Mostando " + Convert.ToInt32(ddlCarregar.Text) + " sugestões que não foram recebidos.";
                        break;
                    case "All":
                        lblSelecionado.Text = "Mostando " + Convert.ToInt32(ddlCarregar.Text) + " sugestões.";
                        break;
                }
            }
            

            Repeater1.DataSource = readBug.Bug(Load, StartWith);
            Repeater1.DataBind();

            lblErro.Text = "<p style='text-aling:center'>Não há itens na categoria selecionada</p>";

            if (StartWith != 0)
            {
                lblLessBugs.Text = "<a href='/p/manage/bugs.aspx?sw=" + (StartWith - Convert.ToInt32(ddlCarregar.Text)) + "&ddlStatus=" + ddlStatus.Text + "&ddlType=" + ddlType.Text + "'>Bugs mais recentes</a>";
            }
            if (Repeater1.Items.Count >= 10)
            {
                lblMoreBugs.Text = "<a href='/p/manage/bugs.aspx?sw=" + (StartWith + Convert.ToInt32(ddlCarregar.Text)) + "&ddlStatus="+ ddlStatus.Text+"&ddlType="+ddlType.Text+"'>Bugs mais antigos</a>";
            }
        }

        protected void ddlCarregar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("/p/manage/bugs.aspx?sw=" + StartWith + "&ddlStatus=" + ddlStatus.Text + "&ddlType=" + ddlType.Text + "&Load=" + Convert.ToInt32(ddlCarregar.Text));
        }

        protected void ddlStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("/p/manage/bugs.aspx?sw=" + StartWith + "&ddlStatus=" + ddlStatus.Text + "&ddlType=" + ddlType.Text + "&Load="+ Convert.ToInt32(ddlCarregar.Text));
        }

        protected void ddlType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("/p/manage/bugs.aspx?sw=" + StartWith + "&ddlStatus=" + ddlStatus.Text + "&ddlType=" + ddlType.Text + "&Load=" + Convert.ToInt32(ddlCarregar.Text));
        }
    }
}
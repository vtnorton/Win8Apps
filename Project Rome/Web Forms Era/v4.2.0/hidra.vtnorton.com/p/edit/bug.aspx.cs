using Ladon.Methods;
using Ladon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HidraOnline.p.edit
{
    public partial class bug : System.Web.UI.Page
    {
        int IdBug, Upvotes;
        String Email, Message, Date, Project, Status, Type;
        Update updateBug = new Update();
        Delete deleteBug = new Delete();
        BugRepository repoBug = new BugRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            IdBug = Convert.ToInt32(Request.QueryString["Id"]);
            Upvotes = repoBug.RetornarID(IdBug).Upvotes;
            Email = repoBug.RetornarID(IdBug).Email;
            Message = repoBug.RetornarID(IdBug).Menssage;
            Date = repoBug.RetornarID(IdBug).Date;
            Project = repoBug.RetornarID(IdBug).Project;
            Status = repoBug.RetornarID(IdBug).Status;
            Type = repoBug.RetornarID(IdBug).Type;

            if (!IsPostBack)
            {

                lblDate.Text = Date;
                lblMenssage.Text = Message;
                lblProject.Text = Project;
                lblStatus.Text = Status;
                lblType.Text = Type;
                lblUpvotes.Text = Upvotes + " votos";
                lblEmail.Text = "<a href='/p/email-bug.aspx?email=" + Email + "'>" + Email + "</a>";
                ddlStatus.SelectedValue = Status;
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("/p/manage/bugs.aspx");
        }

        protected void btnAtualizar_Click(object sender, EventArgs e)
        {
            int intType = 0;
            if (Type == "Sugestão")
                intType = 1;
            if (Type == "Problema")
                intType = 2;

            switch (Convert.ToInt32(ddlStatus.Text))
            {
                case 1:
                    Status = "Recebido";
                    break;
                case 2:
                    Status = "Em andamento";
                    break;
                case 3:
                    Status = "Disponivel na atualização";
                    break;
                case 4:
                    Status = "Cancelado";
                    break;
                case 5:
                    Status = "Concluído";
                    break;
            }

            updateBug.UpdateBug(IdBug, intType, Status, Email, Message, Project, Date);
            Response.Redirect("/p/manage/bugs.aspx");
        }

        protected void lbtExcluir_Click(object sender, EventArgs e)
        {
            deleteBug.DeleteBug(IdBug);
            Response.Redirect("/p/manage/bugs.aspx");
        }
    }
}
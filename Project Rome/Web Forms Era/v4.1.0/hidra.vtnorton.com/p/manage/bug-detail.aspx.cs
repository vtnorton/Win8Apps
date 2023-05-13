using Ladon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HidraOnline.p.manage
{
    public partial class bug_detail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BugRepository repoBug = new BugRepository();

            int Id = Convert.ToInt32(Request.QueryString["id"]);

            lblDate.Text = repoBug.RetornarID(Id).Date;
            lblEmail.Text = "<a href='/email-bug.aspx?email=" + repoBug.RetornarID(Id).Email + "'>" + repoBug.RetornarID(Id).Email + "</a>";
            lblMensage.Text = repoBug.RetornarID(Id).Menssage ;
            lblProject.Text = repoBug.RetornarID(Id).Project;
            lblType.Text = repoBug.RetornarID(Id).Type;
            lblUpvotes.Text = repoBug.RetornarID(Id).Upvotes.ToString();
            lblName.Text = "#" + Id;

            lblStatus.Text = repoBug.RetornarID(Id).Status; //Fazer usuario mudar
        }
    }
}
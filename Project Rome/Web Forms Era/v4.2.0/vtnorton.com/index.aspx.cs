using BSharp.Methods;
using Ladon.Methods;
using Ladon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VTNORTON
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PostRepository repoPost = new PostRepository();
            Read readPost = new Read();

            int[] Ids = readPost.PostLastAndPenultimateId();
            int IdLastPost = Ids[0];
            int IdPenultimatePost = Ids[1];


            lblFirstParagraphPost1.Text = repoPost.RetornarID(IdLastPost).FirstParagraph;
            lblFirstParagraphPost2.Text = repoPost.RetornarID(IdPenultimatePost).FirstParagraph;
            lblImagePost1.Text = repoPost.RetornarID(IdLastPost).URLImage;
            lblImagePost2.Text = repoPost.RetornarID(IdPenultimatePost).URLImage;
            lblReadMorePost1.Text = "<a href='/"+repoPost.RetornarID(IdLastPost).URL + "'>Leia mais</a>";
            lblReadMorePost2.Text = "<a href='/" + repoPost.RetornarID(IdPenultimatePost).URL + "'>Leia mais</a>";
            lblTitlePost1.Text = repoPost.RetornarID(IdLastPost).Title;
            lblTitlePost2.Text = repoPost.RetornarID(IdPenultimatePost).Title;

        }
    }
}
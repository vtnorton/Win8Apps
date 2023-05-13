using AllVtnorton.Email;
using AllVtnorton.Email.Portuguese;
using Ladon.Methods;
using Ladon.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HidraOnline.p.edit
{
    public partial class category : System.Web.UI.Page
    {
        int IdCategory;
        int IdAuthor = Setting.IdAuthor;
        String Descricao, Title, URLImage, URLCover, URL;
        AuthorRepository repoAuthor = new AuthorRepository();
        CategoryRepository repoCategory = new CategoryRepository();
        protected void txtUrlIcon_TextChanged(object sender, EventArgs e)
        {
            lblImage.Text = "<img style='min-width:170px; max-width:170px; min-height: 170px; max-height: 170px' src='http://" + URL + "/" + URLImage + "'/>";
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            IdCategory = Convert.ToInt32(Request.QueryString["Id"]);

            URL = repoAuthor.RetornarID(IdAuthor).URL;
            Descricao = repoCategory.RetornarID(IdCategory).Description;
            Title = repoCategory.RetornarID(IdCategory).Name;
            URLImage = repoCategory.RetornarID(IdCategory).URLIcon;
            URLCover = repoCategory.RetornarID(IdCategory).URLCover;

            txtDescription.Text = Descricao;
            txtTitle.Text = Title;
            txtUrlCover.Text = URLCover;
            txtUrlIcon.Text = URLImage;

            lblImage.Text = "<img style='min-width:170px; max-width:170px; min-height: 170px; max-height: 170px' src='http://" + URL +"/"+ URLImage + "'/>";

        }

        protected void btnAtualizar_Click(object sender, EventArgs e)
        {
            int i = 1;
            String URL = "/p/manage/postbycategory.aspx?Id=" + IdCategory;
            Update updateCategory = new Update();
            lblInfo.Text = "<strong>Log: </strong> <hr/>" +
                i + ". Iniciado a atualização da categoria. <br /> <br />";

            if(txtTitle.Text != Title)
            {
                if (ckbEnviarEmail.Checked)
                {

                    lblInfo.Text += i++ + ". Iniciando processo de criação de e-mail. <br/><br/>";
                    String ListaDePosts = "", Email = repoAuthor.RetornarID(IdAuthor).Email;
                    SmtpClient Cliente = new SmtpClient();
                    MailMessage Message = new MailMessage();
                    Read post = new Read();
                    NetworkCredential smtpCreds = new NetworkCredential(JadeAccount.Email, JadeAccount.Password);
                    DataTable postDataTable = new DataTable();
                    try
                    {
                        ListaDePosts = "<style>table{width:100%;margin-top:10px}table tr{border-bottom:1px solid #2572EB}table tr:first-of-type{background:#eee}table tr td{padding:8px 8px 15px;font-size:14px}table tr td:last-of-type{padding-right:0 !important}table tr:hover{background:#eee;-moz-transition:all 0.5s;-o-transition:all 0.5s;-webkit-transition:all 0.5s;transition:all 0.5s}table tr:first-of-type{border-top:none !important;font-weight:600}</style>";
                        ListaDePosts += "<table><tr><td>Título</td><td>Autor</td><td>Data de postagem</td><td>Visitas</td></tr>";

                        postDataTable = post.PostByCategoryForEmail(true, 1000, 0, IdCategory);
                        DataRow[] currentRows = postDataTable.Select();
                        //ListaDePosts += "<tr>";
                        //foreach (DataColumn column in postDataTable.Columns)
                        //{
                        //    ListaDePosts += "<td>" + column.ColumnName + "</td>";
                        //}
                        //ListaDePosts += "</tr>";
                        foreach (DataRow row in currentRows)
                        {
                            ListaDePosts += "<tr>";

                            foreach (DataColumn column in postDataTable.Columns)
                                ListaDePosts += "<td>" + row[column] + "</td>";

                            ListaDePosts += "</tr>";
                        }

                        ListaDePosts += "</table>";
                        try
                        {
                            Cliente.Host = JadeAccount.Host;
                            Cliente.Port = JadeAccount.Port;
                            Cliente.UseDefaultCredentials = JadeAccount.UseDefaultCredentials;
                            Cliente.Credentials = smtpCreds;
                            Cliente.EnableSsl = JadeAccount.EnableSsl;
                            Message.IsBodyHtml = JadeAccount.IsBodyHtml;
                            Message.Subject = "Lista de posts que precisa de atenção!";
                            Message.Body = string.Concat(BodyPt.StartForSenddingEmail, "<br />Uma categoria foi atualizada, e para tanto, os posts a seguir devem ser alterados de forma manual para uma nova categoria, ou serem deletados. <br /><br /> ", ListaDePosts, BodyPt.EndAutomatic);
                            Message.From = new MailAddress(Email);
                            Message.To.Add(new MailAddress(Email));
                            Cliente.Send(Message);
                            lblInfo.Text += i++ + ". E-mail enviado com sucesso para: " + Email + "<br/> <br/>";
                        }
                        catch
                        {
                            lblInfo.Text += i++ + ". Erro ao enviar e-mail, continuando processo. <br/><br/>";
                        }
                    }
                    catch
                    {
                        lblInfo.Text += i++ + "Erro ao criar lista de postagems.";
                    }

                }
                try
                {
                    Boolean Worked = updateCategory.UpdateCategory(IdCategory, Title, Descricao, URLImage, URLCover);
                    if (Worked)
                    {
                        lblInfo.Text += i++ + ". Categoria atualizada com sucesso. <br /> <br />";
                        lblInfo.Text += i++ + ". Redirecionando para postagens desta categoria em alguns segundos. Caso não redirecione automaticamente, clique <a href='" + URL + "'>aqui</a>. <br />";
                        if (ckbExiberPosts.Checked)
                        {
                            Response.AddHeader("REFRESH", "5;URL=" + URL);
                        }
                        else
                        {
                            Response.AddHeader("REFRESH", "5;URL=/p/manage/category.aspx");
                        }

                    }
                    else
                    {
                        lblInfo.Text = "<div class='info'><h1 class='red'>Erro!</h1><hr /><article><p>Houve um erro ao atualizar esta categoria. Erro no servidor, contate o administrador do sistema.</p></article></div>";
                    }
                }
                catch (Exception E)
                {

                }
            }
            else
            {
                Boolean Worked = updateCategory.UpdateCategory(IdCategory, Title, Descricao, URLImage, URLCover);
                if (Worked)
                {
                    lblInfo.Text += i++ + ". Categoria atualizada com sucesso. <br /> <br />";
                    lblInfo.Text += i++ + ". Redirecionando para postagens desta categoria em alguns segundos. Caso não redirecione automaticamente, clique <a href='" + URL + "'>aqui</a>. <br />";
                    if (ckbExiberPosts.Checked)
                    {
                        Response.AddHeader("REFRESH", "5;URL=" + URL);
                    }
                    else
                    {
                        Response.AddHeader("REFRESH", "5;URL=/p/manage/category.aspx");
                    }

                }
                else
                {
                    lblInfo.Text = "<div class='info'><h1 class='red'>Erro!</h1><hr /><article><p>Houve um erro ao atualizar esta categoria. Erro no servidor, contate o administrador do sistema.</p></article></div>";
                }
            }

           

        }
    }
}
using BSharp.Methods;
using BSharp.Classes;
using Ladon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using AllVtnorton;
using System.Data;

namespace Ladon.Methods
{
    public class Create
    {
        public Boolean NewApplication(String xVersion, String xName, String xDescription, String xURLIcon, String xURLCape, String xSize, String xIdAppCategory)
        {
            try
            {
                Application objApplication = new Application();
                ApplicationRepository repoApplication = new ApplicationRepository();

                objApplication.Description = Strings.JustFistUppercase(xDescription);
                objApplication.Version = xVersion;
                objApplication.Name = Strings.JustFistUppercase(xName);
                objApplication.URLCape = xURLCape;
                objApplication.URLIcon = xURLIcon;

                repoApplication.Create(objApplication);

                return true;
            }
            catch
            {
                return false;
            }
        }
        public Boolean NewAuthor(String xName, String xDescription, String xURLProfile, String xURLCover, String xBirthday, String xEmail, String xJob)
        {
            try
            {
                Author objAuthor = new Author();
                AuthorRepository repoAuthor = new AuthorRepository();

                objAuthor.Birthday = xBirthday.Trim();
                objAuthor.Description = Strings.JustFistUppercase(xDescription).Trim();
                objAuthor.Email = xEmail.Trim();
                objAuthor.Job = xJob.Trim();
                objAuthor.URL = "vtnorton.com";
                objAuthor.Name = Strings.FistUppercaseAllWords(xName);
                objAuthor.URLCover = xURLCover.Trim();
                objAuthor.URLProfile = xURLProfile.Trim();

                repoAuthor.Create(objAuthor);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Boolean NewCategory(String xName, String xDescription, String xURLIcon, String xURLCover)
        {
            try
            {
                Category objCategory = new Category();
                CategoryRepository repoCategory = new CategoryRepository();

                objCategory.Description = xDescription;
                objCategory.Name = xName;
                objCategory.URLCover = xURLCover.Trim();
                objCategory.URLIcon = xURLIcon.Trim();

                repoCategory.Create(objCategory);

                return true;
            }
            catch
            {
                return false;
            }
        }
        public Boolean NewPost(int xIdCategory, int xIdAuthor, String xTitle, String xContent, int xOnline)
        {
            try
            {
                Post objPost = new Post();
                PostRepository repoPost = new PostRepository();
                AuthorRepository repoAuthor = new AuthorRepository();
                CategoryRepository repoCategory = new CategoryRepository();

                objPost.IdAuthor = xIdAuthor;
                objPost.IdCategory = xIdCategory;
                objPost.AuthorName = repoAuthor.RetornarID(xIdAuthor).Name;
                objPost.CategoryName = repoCategory.RetornarID(xIdCategory).Name;
                objPost.Online = xOnline;
                objPost.Content = xContent.Trim();
                objPost.PostedDate = DateTime.Now.ToString();
                objPost.Title = xTitle;
                objPost.UpdatedDate = DateTime.Now.ToString();
                objPost.URL = Url.UrlGenerator(xTitle, true);
                objPost.Visits = 0;
                objPost.URLImage = "<img" + Strings.GetBetween(xContent, "<img", " />") + " />";
                objPost.FirstParagraph = "<p>" + Strings.GetBetween(Regex.Replace(xContent, @"(<img\/?[^>]+>)", @""), "<p>", "</p>") + "</p>";

                repoPost.Create(objPost);
                return true;
            }
            catch
            {
                return false;
            }

        }
        public Boolean NewBug(String xStatus, String xEmail, String xMenssage, String xProject)
        {
            try
            {
                Bug objBug = new Bug();
                BugRepository repoBug = new BugRepository();

                objBug.Date = DateTime.Now.ToString();
                objBug.Menssage = xMenssage;
                objBug.Project = xProject;
                objBug.Email = xEmail.Trim().ToLower();
                objBug.Status = xStatus.Trim();
                switch (xStatus)
                {
                    case "Não recebido":
                        objBug.StatusCSSClass = "nonrecived";
                        break;
                    case "Recebido":
                        objBug.StatusCSSClass = "recived";
                        break;
                    case "Em andamento":
                        objBug.StatusCSSClass = "goingon";
                        break;
                    case "Disponivel na atualização":
                        objBug.StatusCSSClass = "nextupdate";
                        break;
                    case "Cancelado":
                        objBug.StatusCSSClass = "canceled";
                        break;
                    case "Concluído":
                        objBug.StatusCSSClass = "done";
                        break;
                }
                objBug.Upvotes = 0;
                objBug.Type = "Problema";

                repoBug.Create(objBug);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Boolean NewSugestion(String xStatus, String xEmail, String xMenssage, String xProject)
        {
            try
            {
                Bug objBug = new Bug();
                BugRepository repoBug = new BugRepository();

                objBug.Date = DateTime.Now.ToString();
                objBug.Menssage = xMenssage;
                objBug.Project = xProject;
                objBug.Email = xEmail.Trim().ToLower();
                objBug.Status = xStatus.Trim();
                switch (xStatus)
                {
                    case "Não recebido":
                        objBug.StatusCSSClass = "nonrecived";
                        break;
                    case "Recebido":
                        objBug.StatusCSSClass = "recived";
                        break;
                    case "Em andamento":
                        objBug.StatusCSSClass = "goingon";
                        break;
                    case "Disponivel na atualização":
                        objBug.StatusCSSClass = "nextupdate";
                        break;
                    case "Cancelado":
                        objBug.StatusCSSClass = "canceled";
                        break;
                    case "Concluído":
                        objBug.StatusCSSClass = "done";
                        break;
                }
                objBug.Upvotes = 0;
                objBug.Type = "Sugestão";

                repoBug.Create(objBug);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

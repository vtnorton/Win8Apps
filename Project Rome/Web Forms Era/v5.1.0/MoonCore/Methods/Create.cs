using System;
using System.Text.RegularExpressions;
using Core.Methods;
using MoonCore.Repository;
using MoonCore.Classes;

namespace MoonCore.Methods
{
    public class Create
    {
        public Boolean NewAuthor(string xName, string xDescription, string xURLProfile, string xEmail)
        {
            try
            {
                Author objAuthor = new Author();
                AuthorRepository repoAuthor = new AuthorRepository();
                
                objAuthor.Bio = xDescription.Trim();
                objAuthor.Email = xEmail.Trim();
                objAuthor.Name = Strings.FistUppercaseAllWords(xName);
                objAuthor.URLProfile = xURLProfile.Trim();

                repoAuthor.Create(objAuthor);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Boolean NewCategory(string xName, string xDescription)
        {
            try
            {
                Category objCategory = new Category();
                CategoryRepository repoCategory = new CategoryRepository();

                objCategory.Description = xDescription;
                objCategory.Name = xName;

                repoCategory.Create(objCategory);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public Boolean NewPost(int xIdCategory, string xTitle, string xContent, string xPostHTML, int xOnline)
        {
            try
            {
                Post objPost = new Post();
                PostRepository repoPost = new PostRepository();
                AuthorRepository repoAuthor = new AuthorRepository();
                CategoryRepository repoCategory = new CategoryRepository();

                objPost.IdCategory = xIdCategory;
                objPost.CategoryName = repoCategory.RetornarID(xIdCategory).Name;
                objPost.Content = xContent.Trim();
                objPost.PostedDate = DateTime.Now.ToString();
                objPost.Title = xTitle;
                objPost.UpdatedDate = DateTime.Now.ToString();
                objPost.URL = Url.UrlGenerator(xTitle, true);
                objPost.Visits = 0;
                objPost.URLImage = "<img" + Strings.GetBetween(xContent, "<img", " />") + " />";
                if (xPostHTML != "image")
                    objPost.PostHTML = xPostHTML;
                else
                    objPost.PostHTML = objPost.URLImage;
                objPost.FirstParagraph = Strings.GetBetween(Regex.Replace(xContent, @"(<img\/?[^>]+>)", @""), "<p>", "</p>");

                repoPost.Create(objPost);
                return true;
            }
            catch
            {
                return false;
            }

        }
        public Boolean NewBug(string xStatus, string xEmail, string xMenssage, string xProject)
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
        public Boolean NewSugestion(string xStatus, string xEmail, string xMenssage, string xProject)
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

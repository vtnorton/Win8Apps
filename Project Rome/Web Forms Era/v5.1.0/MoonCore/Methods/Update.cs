using Core.Methods;
using MoonCore.Classes;
using MoonCore.Repository;
using System;
using System.Text.RegularExpressions;

namespace MoonCore.Methods
{
    public class Update
    {
        public Boolean UpdatePost(int xId, int xIdCategory, int xIdAuthor, string xTitle, string xContent, string xPostHTML, int xOnline)
        {
            try
            {
                Post objPost = new Post();
                PostRepository repoPost = new PostRepository();
                AuthorRepository repoAuthor = new AuthorRepository();
                CategoryRepository repoCategory = new CategoryRepository();

                objPost.Id = xId;
                objPost.IdCategory = xIdCategory;
                objPost.CategoryName = repoCategory.RetornarID(xIdCategory).Name;
                objPost.Content = xContent.Trim();
                objPost.Title = xTitle;
                objPost.PostedDate = repoPost.RetornarID(xId).PostedDate;
                objPost.UpdatedDate = DateTime.Now.ToString();
                objPost.URL = Url.UrlGenerator(xTitle, true);
                objPost.Visits = 0;
                objPost.URLImage = "<img" + Strings.GetBetween(xContent, "<img", " />") + " />";
                if (xPostHTML != "image")
                    objPost.PostHTML = xPostHTML;
                else
                    objPost.PostHTML = objPost.URLImage;
                objPost.FirstParagraph = "<p>" + Strings.GetBetween(Regex.Replace(xContent, @"(<img\/?[^>]+>)", @""), "<p>", "</p>") + "</p>";

                repoPost.Update(objPost);
                return true;
            }
            catch
            {
                return false;
            }

        }
        public Boolean UpdateCategory(int xId, String xName, String xDescription)
        {
            try
            {
                Category objCategory = new Category();
                CategoryRepository repoCategory = new CategoryRepository();

                objCategory.Id = xId;
                objCategory.Description = xDescription;
                objCategory.Name = xName;

                repoCategory.Update(objCategory);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public Boolean UpdateBug(int xId, int xType, String xStatus, String xEmail, String xMenssage, String xProject, String xDate)
        {
            try
            {
                Bug objBug = new Bug();
                BugRepository repoBug = new BugRepository();

                objBug.Id = xId;
                objBug.Menssage = xMenssage;
                objBug.Project = xProject;
                objBug.Date = xDate;
                objBug.Email = xEmail.ToLower();
                objBug.Status = xStatus;
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

                if(xType==1)
                    objBug.Type = "Sugestão";
                if (xType == 2)
                    objBug.Type = "Problema";

                repoBug.Update(objBug);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

using BSharp.Classes;
using BSharp.Methods;
using Ladon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ladon.Methods
{
    public class Update
    {
        public Boolean UpdatePost(int xId, int xIdCategory, int xIdAuthor, String xTitle, String xContent, int xOnline)
        {
            try
            {
                Post objPost = new Post();
                PostRepository repoPost = new PostRepository();
                AuthorRepository repoAuthor = new AuthorRepository();
                CategoryRepository repoCategory = new CategoryRepository();

                objPost.Id = xId;
                objPost.IdAuthor = xIdAuthor;
                objPost.IdCategory = xIdCategory;
                objPost.AuthorName = repoAuthor.RetornarID(xIdAuthor).Name;
                objPost.CategoryName = repoCategory.RetornarID(xIdCategory).Name;
                objPost.Online = xOnline;
                objPost.Content = xContent.Trim();
                objPost.Title = xTitle;
                objPost.PostedDate = repoPost.RetornarID(xId).PostedDate;
                objPost.UpdatedDate = DateTime.Now.ToString();
                objPost.URL = Url.UrlGenerator(xTitle, true);
                objPost.Visits = 0;
                objPost.URLImage = "<img" + Strings.GetBetween(xContent, "<img", " />") + " />";
                objPost.FirstParagraph = "<p>" + Strings.GetBetween(Regex.Replace(xContent, @"(<img\/?[^>]+>)", @""), "<p>", "</p>") + "</p>";

                repoPost.Update(objPost);
                return true;
            }
            catch
            {
                return false;
            }

        }
        public Boolean UpdateCategory(int xId, String xName, String xDescription, String xURLIcon, String xURLCover)
        {
            try
            {
                Category objCategory = new Category();
                CategoryRepository repoCategory = new CategoryRepository();

                objCategory.Id = xId;
                objCategory.Description = Strings.JustFistUppercase(xDescription);
                objCategory.Name = Strings.JustFistUppercase(xName);
                objCategory.URLCover = xURLCover;
                objCategory.URLIcon = xURLIcon;

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

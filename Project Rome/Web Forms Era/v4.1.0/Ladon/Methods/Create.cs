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

namespace Ladon.Methods
{
    public class Create
    {
        public Boolean NewAppCategory(String xName, String xDescription, String xURLIcon, String xURLCover)
        {
            try
            {
                AppCategory objAppCategory = new AppCategory();
                AppCategoryRepository repoAppCategory = new AppCategoryRepository();

                objAppCategory.Description = Strings.FistUppercase(xDescription);
                objAppCategory.Name = Strings.FistUppercase(xName);
                objAppCategory.URLCover = xURLCover;
                objAppCategory.URLIcon = xURLIcon;

                repoAppCategory.Create(objAppCategory);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Boolean NewApplication(String xVersion, String xName, String xDescription, String xURLIcon, String xURLCape, String xSize, String xIdAppCategory)
        {
            try
            {
                Application objApplication = new Application();
                ApplicationRepository repoApplication = new ApplicationRepository();

                objApplication.Description = Strings.FistUppercase(xDescription);
                objApplication.IdAppCategory = xIdAppCategory;
                objApplication.Version = xVersion;
                objApplication.Name = Strings.FistUppercase(xName);
                objApplication.Size = xSize;
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
        public Boolean NewAuthor(String xName, String xDescription, String xURLProfile, String xURLCover, String xBirthday, String xEmail, String xPassword, String xJob)
        {
            try
            {
                Author objAuthor = new Author();
                AuthorRepository repoAuthor = new AuthorRepository();
                objAuthor.Birthday = xBirthday.Trim();
                objAuthor.Description = Strings.FistUppercase(xDescription).Trim();
                objAuthor.Email = xEmail.Trim();
                objAuthor.Job = xJob.Trim();
                objAuthor.FirstLogin = "Sem dados";
                objAuthor.LastLogin = "Sem dados";
                objAuthor.URL = "vtnorton.com";
                objAuthor.Name = Strings.FistUppercaseAllWords(xName);
                objAuthor.Password = xPassword; //Criptografar com MD5 Hash
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

                objCategory.Description = Strings.FistUppercase(xDescription);
                objCategory.Name = Strings.FistUppercase(xName);
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
                objPost.Title = Strings.FistUppercase(xTitle);
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

        public Boolean NewSlide(String xURLImage, String xURLLink, String xTitle, String xDescription)
        {
            try
            {
                Slide objSlide = new Slide();
                SlideRepository repoSlide = new SlideRepository();

                objSlide.Description = Strings.FistUppercase(xDescription);
                objSlide.Title = Strings.FistUppercase(xTitle);
                objSlide.URLImage = xURLImage.Trim();
                objSlide.URLLink = xURLLink.Trim();

                repoSlide.Create(objSlide);
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
                objBug.Menssage = Strings.FistUppercase(xMenssage);
                objBug.Project = Strings.FistUppercase(xProject);
                objBug.Email = xEmail.Trim().ToLower();
                objBug.Status = xStatus.Trim();
                switch (xStatus)
                {
                    case "NonRecived":
                        objBug.StatusCSSClass = ".nonrecived";
                        break;
                    case "Recived":
                        objBug.StatusCSSClass = ".recived";
                        break;
                    case "GoingOn":
                        objBug.StatusCSSClass = ".goingon";
                        break;
                    case "NextUpdate":
                        objBug.StatusCSSClass = ".nextupdate";
                        break;
                    case "Canceled":
                        objBug.StatusCSSClass = ".canceled";
                        break;
                    case "Done":
                        objBug.StatusCSSClass = ".done";
                        break;
                }
                objBug.Upvotes = 0;
                objBug.Type = "Bugs";

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
                objBug.Menssage = Strings.FistUppercase(xMenssage);
                objBug.Project = xProject;
                objBug.Email = xEmail.Trim().ToLower();
                objBug.Status = xStatus.Trim();
                switch (xStatus)
                {
                    case "NonRecived":
                        objBug.StatusCSSClass = ".nonrecived";
                        break;
                    case "Recived":
                        objBug.StatusCSSClass = ".recived";
                        break;
                    case "GoingOn":
                        objBug.StatusCSSClass = ".goingon";
                        break;
                    case "NextUpdate":
                        objBug.StatusCSSClass = ".nextupdate";
                        break;
                    case "Canceled":
                        objBug.StatusCSSClass = ".canceled";
                        break;
                    case "Done":
                        objBug.StatusCSSClass = ".done";
                        break;
                }
                objBug.Upvotes = 0;
                objBug.Type = "Sugestion";

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

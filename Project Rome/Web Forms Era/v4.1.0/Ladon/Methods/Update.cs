using BSharp.Classes;
using BSharp.Methods;
using Ladon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladon.Methods
{
    public class Update
    {
        public Boolean UpdatePost(int xIdCategory, int xIdAuthor, String xTitle, String xContent, int xOnline)
        {
            try
            {
                Post objPost = new Post();
                PostRepository repoPost = new PostRepository();

                objPost.IdAuthor = xIdAuthor;
                objPost.IdCategory = xIdCategory;
                objPost.Online = xOnline;
                objPost.Content = xContent;
                objPost.UpdatedDate = DateTime.Now.ToString();
                objPost.Title = Strings.FistUppercase(xTitle);
                objPost.UpdatedDate = DateTime.Now.ToString();
                objPost.URL = Url.UrlGenerator(xTitle, true);
                objPost.Visits = 1;

                repoPost.Update(objPost);

                return true;
            }
            catch
            {
                return false;
            }
        }
        public Boolean UpdateCategory(String xName, String xDescription, String xURLIcon, String xURLCover)
        {
            try
            {
                Category objCategory = new Category();
                CategoryRepository repoCategory = new CategoryRepository();

                objCategory.Description = Strings.FistUppercase(xDescription);
                objCategory.Name = Strings.FistUppercase(xName);
                objCategory.URLCover = xURLCover;
                objCategory.URLIcon = xURLIcon;

                repoCategory.Create(objCategory);

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

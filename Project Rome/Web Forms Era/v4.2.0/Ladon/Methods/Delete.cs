using BSharp.Classes;
using Ladon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladon.Methods
{
    public class Delete
    {
        public Boolean DeletePost(int xId)
        {
            try
            {
                Post objPost = new Post();
                PostRepository repoPost = new PostRepository();
                objPost.Id = xId;
                repoPost.Delete(objPost);
                return true;
            }
            catch
            {
                return false;
            }
            
        }
        public Boolean DeleteCategory(int xId)
        {
            try
            {
                Category objCategoria = new Category();
                CategoryRepository repoCategory = new CategoryRepository();
                objCategoria.Id = xId;
                repoCategory.Delete(objCategoria);
                return true;
            }
            catch
            {
                return false;
            }

        }
        public Boolean DeleteBug(int xId)
        {
            try
            {
                Bug objBug = new Bug();
                BugRepository repoBug = new BugRepository();
                objBug.Id = xId;
                repoBug.Delete(objBug);
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}

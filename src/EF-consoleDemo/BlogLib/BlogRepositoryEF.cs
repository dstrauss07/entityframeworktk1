using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BlogLib
{
    public class BlogRepositoryEF : IBlogRepository
    {
        private readonly BloggingContext _dbContext;
        public BlogRepositoryEF(BloggingContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddBlog(Blog newBlog)
        {
            _dbContext.Add(newBlog);
            _dbContext.SaveChanges();
        }

        public void DeleteBlog(int id)
        {
            throw new NotImplementedException();
        }

        public Blog GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Blog> ListAll()
        {
            return _dbContext.Blogs.ToList();
        }

        public void UpdateBlog(Blog updatedBlog)
        {
            throw new NotImplementedException();
        }
    }
}

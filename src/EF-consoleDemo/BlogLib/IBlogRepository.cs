using System;
using System.Collections.Generic;
using System.Text;

namespace BlogLib
{
    public interface IBlogRepository
    {
        List<Blog> ListAll();
        Blog GetById(int id);
        void AddBlog(Blog newBlog);
        void UpdateBlog(Blog updatedBlog);
        void DeleteBlog(int id);

    }
}

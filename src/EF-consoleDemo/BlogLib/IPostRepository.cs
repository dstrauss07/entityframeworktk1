using System;
using System.Collections.Generic;
using System.Text;

namespace BlogLib
{
    public interface IPostRepository
    {
        List<Post> ListAll();
        Post GetById(int id);
        void AddPost(Post newPost);
        void UpdatedPost(Post editedPost);
        void DeletedPost(int id);
    }
}

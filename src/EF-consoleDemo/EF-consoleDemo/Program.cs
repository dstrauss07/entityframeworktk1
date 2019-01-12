using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using BlogLib;

namespace EF_consoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Blog myblog = new Blog
            //{
            //    Url = "CCAlearn.tech",
            //    Rating = 5
            //};

            using (var db = new BloggingContext())
            {
                //db.Blogs.Add(myblog);
                //db.SaveChanges();
                var myBlog = db.Blogs
                        .Include(b => b.Posts)
                        .FirstOrDefault(b => b.BlogId == 1);

                for (int i = 0; i < 500; i++)
                {
                    var myPost = new Post
                    {
                        Blog = myBlog,
                        BlogId = myBlog.BlogId,
                        Title = $"Post # {i}!",
                        Content = $"<h1>I Love Posting </h1><p>This is post number {i}"
                    };
                

                    db.Posts.Add(myPost);
                    db.SaveChanges();
                }

                Console.WriteLine("Hello World!");
            }
        }
    }
}

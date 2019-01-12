using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogLib
{
    public class BloggingContext: DbContext
    {
        public BloggingContext(DbContextOptions<BloggingContext> options) :base(options)
        {

        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFBlog1;Trusted_Connection=True;");
        //}

    }
}

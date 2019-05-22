using Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BlogContext : DbContext
    {
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Article> Articles { get; set; }
    }
}

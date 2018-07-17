using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityFirstCode.Models
{
    public class NorthWindContext: DbContext
    {
        public NorthWindContext() 
        :base("name=NorthwindConnection")
        {

        }
        public DbSet<Category> CategoriesTable { get; set; }
        public DbSet<Product> ProductsTable { get; set; }

    }
}
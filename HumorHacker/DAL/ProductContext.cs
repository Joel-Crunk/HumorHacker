using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HumorHacker.Models;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;

namespace HumorHacker.DAL
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        //public DbSet<*name of new table*> *name of new table* { get; set; }
    }
}

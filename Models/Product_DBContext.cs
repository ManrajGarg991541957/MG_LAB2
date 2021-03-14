using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MG_LAB2.Models
{
    public class Product_DBContext : DbContext
    {
        public Product_DBContext(DbContextOptions<Product_DBContext> options) : base(options)
        {

        }
        //entity
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}

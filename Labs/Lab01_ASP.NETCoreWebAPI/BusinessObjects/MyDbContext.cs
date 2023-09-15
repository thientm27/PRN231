using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class MyDbContext :DbContext
    {
        public MyDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
  
            optionsBuilder.UseSqlServer(GetConnectionString());
        }
        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            var strConn = config["ConnectionString"];
            return strConn;
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Products> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, CategoryName = "Beverages" },
                new Category { Id = 2, CategoryName = "Condiments" },
                new Category { Id = 3, CategoryName = "Confections" },
                new Category { Id = 4, CategoryName = "Dairy Products" },
                new Category { Id = 5, CategoryName = "Grains/Cereals" },
                new Category { Id = 6, CategoryName = "Meat/Poultry" },
                new Category { Id = 7, CategoryName = "Produce" },
                new Category { Id = 8, CategoryName = "Seafood" }
   
                );
        }

    }
}

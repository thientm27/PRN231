﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace IdetityAjax.BOs
{
    public class MyDbContext : DbContext
    {

        public MyDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            var buider = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = buider.Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("MyStoreDB"));

        }

        public virtual DbSet<Category> Categories { get; set; }

        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder optionsBuilder)
        {
            optionsBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Beverages" },
                new Category { CategoryId = 2, CategoryName = "Condiments" },
                new Category { CategoryId = 3, CategoryName = "Confections" },
                new Category { CategoryId = 4, CategoryName = "Dairy Products" },
                new Category { CategoryId = 5, CategoryName = "Grains/Crereals" },
                new Category { CategoryId = 6, CategoryName = "Meat/Poultry" },
                new Category { CategoryId = 7, CategoryName = "Produce" },
                new Category { CategoryId = 8, CategoryName = "Seafood" }
            );
        }
    }
}

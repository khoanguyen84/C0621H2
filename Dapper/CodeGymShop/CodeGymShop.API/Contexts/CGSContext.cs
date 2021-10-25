using CodeGymShop.API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeGymShop.API.Contexts
{
    public class CGSContext : DbContext
    {
        public CGSContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            SeedingProduct(modelBuilder);
        }

        private void SeedingProduct(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    ProductId = 1,
                    ProductName = "iPhone 12",
                    Price = 18000000,
                    Quantity = 12,
                    Photo = "~/images/iphone12.jpg",
                    Manufactory = "Viet Nam",
                    Status = true
                },
                new Product()
                {
                    ProductId = 2,
                    ProductName = "Asus",
                    Price = 12000000,
                    Quantity = 10,
                    Photo = "~/images/laptop.jpg",
                    Manufactory = "ThaiLand",
                    Status = true
                });
        }
    }
}

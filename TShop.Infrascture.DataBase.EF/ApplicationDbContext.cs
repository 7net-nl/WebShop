using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using TShop.Domain.Entities;
using TShop.Infrascture.DataBase.EF.Configuration;

namespace TShop.Infrascture.DataBase.EF
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new ProductColorConfig());
            modelBuilder.ApplyConfiguration(new ProductSizeConfig());
            modelBuilder.ApplyConfiguration(new ImageFileConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.Seed();

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ImageFile> Images { get; set; }
        public DbSet<ProductColor> Colors { get; set; }
        public DbSet<ProductSize> Sizes { get; set; }
    }
}

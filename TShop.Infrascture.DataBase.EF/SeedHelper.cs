using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TShop.Domain.Entities;

namespace TShop.Infrascture.DataBase.EF
{
    public static class SeedHelper
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new Category { ID =1 , Name ="Tshirt" , InsertDate = DateTime.Now.Date , UpdateDate = DateTime.Now.Date });
            modelBuilder.Entity<Category>().HasData(new Category { ID = 2, Name = "Shoes", InsertDate = DateTime.Now.Date, UpdateDate = DateTime.Now.Date });
            modelBuilder.Entity<Category>().HasData(new Category { ID = 3, Name = "Jeans", InsertDate = DateTime.Now.Date, UpdateDate = DateTime.Now.Date });
            modelBuilder.Entity<Category>().HasData(new Category { ID = 4, Name = "Dress", InsertDate = DateTime.Now.Date, UpdateDate = DateTime.Now.Date });

            //////////////////////////////////////////

            modelBuilder.Entity<Product>().HasData(new Product
            {
                 ID = 1 ,
                 Available = EnumAvailable.InStock,
                 Category_ID = 1 ,
                 InsertDate = DateTime.Now.Date,
                  LongDescription = $@"Sed ut eros felis. Vestibulum rutrum imperdiet nunc a interdum. In scelerisque libero ut elit porttitor commodo. Suspendisse laoreet magna nec urna fringilla viverra.100% Cotton",
                   NewPrice = 50 ,
                    OldPrice = 70 ,
                     Rank = 4 ,
                      ShortDescription = "Vestibulum rutrum imperdiet nunc a interdum",
                       Title = "Product Name",
                        UpdateDate = DateTime.Now

            });

            /////////////////////////////////////////////

            modelBuilder.Entity<ProductColor>().HasData(new ProductColor { ID = 1 , Product_ID = 1 , Name="Red" , InsertDate = DateTime.Now.Date , UpdateDate = DateTime.Now.Date });
            modelBuilder.Entity<ProductColor>().HasData(new ProductColor { ID = 2, Product_ID = 1, Name = "Blue", InsertDate = DateTime.Now.Date, UpdateDate = DateTime.Now.Date });
            modelBuilder.Entity<ProductColor>().HasData(new ProductColor { ID = 3, Product_ID = 1, Name = "Pink", InsertDate = DateTime.Now.Date, UpdateDate = DateTime.Now.Date });
            ////////////////////////////////////////////////
            modelBuilder.Entity<ProductSize>().HasData(new ProductSize { ID = 1, Product_ID = 1, Name = "S", InsertDate = DateTime.Now.Date, UpdateDate = DateTime.Now.Date });
            modelBuilder.Entity<ProductSize>().HasData(new ProductColor { ID = 2, Product_ID = 1, Name = "M", InsertDate = DateTime.Now.Date, UpdateDate = DateTime.Now.Date });
            modelBuilder.Entity<ProductSize>().HasData(new ProductColor { ID = 3, Product_ID = 1, Name = "L", InsertDate = DateTime.Now.Date, UpdateDate = DateTime.Now.Date });
            //////////////////////////////////////////////////
            modelBuilder.Entity<ImageFile>().HasData(new ImageFile { ID = 1, Product_ID = 1, FileName = "a3.jpg", InsertDate = DateTime.Now.Date, UpdateDate = DateTime.Now.Date });
            modelBuilder.Entity<ImageFile>().HasData(new ImageFile { ID = 2, Product_ID = 1, FileName = "1.jpg", InsertDate = DateTime.Now.Date, UpdateDate = DateTime.Now.Date });
            modelBuilder.Entity<ImageFile>().HasData(new ImageFile { ID = 3, Product_ID = 1, FileName = "2.jpg", InsertDate = DateTime.Now.Date, UpdateDate = DateTime.Now.Date });
            modelBuilder.Entity<ImageFile>().HasData(new ImageFile { ID = 4, Product_ID = 1, FileName = "3.jpg", InsertDate = DateTime.Now.Date, UpdateDate = DateTime.Now.Date });
        }
    }
}

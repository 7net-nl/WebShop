using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TShop.Domain.Entities;

namespace TShop.Domain.Contract.Interfaces
{
    public interface IDataSet
    {
        DbSet<Product> Products { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<ProductColor> ProductColors { get; set; }
        DbSet<ProductSize> ProductSizes { get; set; }
        DbSet<ImageFile> Images { get; set; }
    }
}

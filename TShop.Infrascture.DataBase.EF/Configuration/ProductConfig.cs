using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TShop.Domain.Entities;

namespace TShop.Infrascture.DataBase.EF.Configuration
{
    public class ProductConfig : BaseConfig<Product,long>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(c => c.Available).IsRequired();
            builder.Property(c => c.Category_ID).IsRequired();
            builder.Property(c => c.LongDescription).HasMaxLength(4000).IsRequired();
            builder.Property(c => c.NewPrice).IsRequired();
            builder.Property(c => c.OldPrice);
            builder.Property(c => c.Rank).IsRequired();
            builder.Property(c => c.ShortDescription).HasMaxLength(2000).IsRequired();
            builder.Property(c => c.Title).HasMaxLength(1000).IsRequired();

           builder.HasOne(c => c.Category).WithMany().HasForeignKey(c => c.Category_ID).HasPrincipalKey(c => c.ID).IsRequired();
            builder.HasMany(c => c.Colors).WithOne().HasForeignKey(c => c.Product_ID).HasPrincipalKey(c => c.ID).IsRequired();
            builder.HasMany(c => c.Images).WithOne().HasForeignKey(c => c.Product_ID).HasPrincipalKey(c => c.ID).IsRequired();
            builder.HasMany(c => c.Sizes).WithOne().HasForeignKey(c => c.Product_ID).HasPrincipalKey(c => c.ID).IsRequired();
            

            base.Configure(builder);
        }
    }
}

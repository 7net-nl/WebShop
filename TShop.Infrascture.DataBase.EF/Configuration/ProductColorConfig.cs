using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TShop.Domain.Entities;

namespace TShop.Infrascture.DataBase.EF.Configuration
{
    public class ProductColorConfig : BaseConfig<ProductColor,long>
    {
        public override void Configure(EntityTypeBuilder<ProductColor> builder)
        {
            builder.Property(c => c.Name).HasMaxLength(500).IsRequired();

            base.Configure(builder);
        }
    }
}

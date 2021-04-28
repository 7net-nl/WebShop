using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TShop.Domain.Entities;

namespace TShop.Infrascture.DataBase.EF.Configuration
{
    public class CategoryConfig : BaseConfig<Category,byte>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(c => c.Name).HasMaxLength(300).IsRequired();

            base.Configure(builder);
        }
    }
}

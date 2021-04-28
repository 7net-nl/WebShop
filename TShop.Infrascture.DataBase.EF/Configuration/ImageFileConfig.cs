using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TShop.Domain.Entities;

namespace TShop.Infrascture.DataBase.EF.Configuration
{
    public class ImageFileConfig : BaseConfig<ImageFile,long>
    {
        public override void Configure(EntityTypeBuilder<ImageFile> builder)
        {
            builder.Property(c => c.FileName).HasMaxLength(500).IsRequired();

            base.Configure(builder);
        }
    }
}

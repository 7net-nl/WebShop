using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TShop.Domain.Entities;

namespace TShop.Infrascture.DataBase.EF.Configuration
{
    public abstract class BaseConfig<TEntity,TPrimaryKey>: IEntityTypeConfiguration<TEntity>
        where TEntity : Entity<TPrimaryKey>
        where TPrimaryKey:struct
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasIndex(c => c.ID);
            builder.Property(c => c.ID).IsRequired();
            builder.Property(c => c.InsertDate).IsRequired();
            builder.Property(c => c.UpdateDate).IsRequired();

        }
    }
}

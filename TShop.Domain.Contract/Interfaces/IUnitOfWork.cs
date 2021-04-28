using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace TShop.Domain.Contract.Interfaces
{
    public interface IUnitOfWork
    {
        void Commit();

        DbSet<TEntity> Set<TEntity>() where TEntity : class;
    }
}

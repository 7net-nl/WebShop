using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TShop.Domain.Contract.Interfaces;

namespace TShop.Infrascture.DataBase.EF
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext dbContext;

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Commit()
        {
            dbContext.SaveChanges();
        }

        public DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return dbContext.Set<TEntity>();
        }
    }
}

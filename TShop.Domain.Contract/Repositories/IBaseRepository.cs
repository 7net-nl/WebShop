using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using TShop.Domain.Entities;

namespace TShop.Domain.Contract.Repositories
{
    public interface IBaseRepository
    {
        void Add<TEntity, TPrimaryKey>(TEntity entity) where TEntity : Entity<TPrimaryKey> where TPrimaryKey : struct;
        void Update<TEntity, TPrimaryKey>(TEntity entity) where TEntity : Entity<TPrimaryKey> where TPrimaryKey : struct;
        void Delete<TEntity, TPrimaryKey>(TPrimaryKey key) where TEntity : Entity<TPrimaryKey> where TPrimaryKey : struct;
        TEntity Find<TEntity, TPrimaryKey>(TPrimaryKey key) where TEntity : Entity<TPrimaryKey> where TPrimaryKey : struct;
        TEntity FindInclude<TEntity, TPrimaryKey>(TPrimaryKey key, List<Expression<Func<TEntity, object>>> Includes)
            where TEntity : Entity<TPrimaryKey>
            where TPrimaryKey : struct;
        List<TEntity> GetAll<TEntity, TPrimaryKey>() where TEntity : Entity<TPrimaryKey> where TPrimaryKey : struct;
        List<TEntity> GetAllInclude<TEntity, TPrimaryKey>(List<Expression<Func<TEntity, object>>> Includes)
            where TEntity : Entity<TPrimaryKey>
            where TPrimaryKey : struct;
    }
}

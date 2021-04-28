using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using TShop.Domain.Contract.Interfaces;
using TShop.Domain.Contract.Repositories;
using TShop.Domain.Entities;

namespace TShop.Infrascture.DataBase.EF.Repositories
{
    public class BaseRepository : IBaseRepository
    {
        private readonly IUnitOfWork unitOfWork;

        public BaseRepository(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public void Add<TEntity, TPrimaryKey>(TEntity entity)
            where TEntity : Entity<TPrimaryKey>
            where TPrimaryKey : struct
        {
            entity.InsertDate = DateTime.Now.Date;
            entity.UpdateDate = DateTime.Now.Date;
            unitOfWork.Set<TEntity>().Add(entity);
        }

        public void Update<TEntity, TPrimaryKey>(TEntity entity)
            where TEntity : Entity<TPrimaryKey>
            where TPrimaryKey : struct
        {
            entity.UpdateDate = DateTime.Now.Date;
            unitOfWork.Set<TEntity>().Update(entity);        }

        public void Delete<TEntity, TPrimaryKey>(TPrimaryKey key)
            where TEntity : Entity<TPrimaryKey>
            where TPrimaryKey : struct
        {
            var Entity = unitOfWork.Set<TEntity>().Find(key);
            unitOfWork.Set<TEntity>().Remove(Entity);

        }

        public TEntity Find<TEntity, TPrimaryKey>(TPrimaryKey key)
            where TEntity : Entity<TPrimaryKey>
            where TPrimaryKey : struct
        {
            return unitOfWork.Set<TEntity>().Find(key);
        }

        public TEntity FindInclude<TEntity, TPrimaryKey>(TPrimaryKey key,List<Expression<Func<TEntity, object>>> Includes)
            where TEntity : Entity<TPrimaryKey>
            where TPrimaryKey : struct
        {
            IQueryable<TEntity> Query = unitOfWork.Set<TEntity>().Where(c=>c.ID.Equals(key));
            foreach (var item in Includes)
            {
                Query = Query.Include(item);
            }
            return Query.LastOrDefault();
        }

        public List<TEntity> GetAll<TEntity, TPrimaryKey>()
            where TEntity : Entity<TPrimaryKey>
            where TPrimaryKey : struct
        {
            return unitOfWork.Set<TEntity>().ToList();
        }

        public List<TEntity> GetAllInclude<TEntity,TPrimaryKey>(List<Expression<Func<TEntity,object>>> Includes)
            where TEntity : Entity<TPrimaryKey>
            where TPrimaryKey:struct
        {
            IQueryable<TEntity> Query = unitOfWork.Set<TEntity>();
            foreach (var item in Includes)
            {
                Query = Query.Include(item);
            }
            return Query.ToList();
        }
    }
}

using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using TShop.Domain.Contract.Interfaces;
using TShop.Domain.Contract.Repositories;
using TShop.Domain.Entities;

namespace TShop.Service.Application
{
    public abstract class BaseService<TEntity,TEntityDto,TPrimaryKey> : IBaseService<TEntity,TEntityDto,TPrimaryKey>
        where TEntity:Entity<TPrimaryKey>
        where TEntityDto:IEntityDto<TPrimaryKey>
        where TPrimaryKey:struct
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IBaseRepository baseRepository;
        private readonly IMapper mapper;

        public BaseService(IUnitOfWork unitOfWork,IBaseRepository baseRepository,IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.baseRepository = baseRepository;
            this.mapper = mapper;
        }
        public void Save(TEntityDto entityDto)
        {
           if(entityDto.ID.Equals(0))
            {
                var Entity = DtoToEntity(entityDto);
                baseRepository.Add<TEntity,TPrimaryKey>(Entity);
                unitOfWork.Commit();
            }
           else if(!entityDto.ID.Equals(null))
            {
                var Entity = DtoToEntity(entityDto);
                baseRepository.Update<TEntity, TPrimaryKey>(Entity);
                unitOfWork.Commit();
            }

        }

        public void Delete(TPrimaryKey key)
        {
           if(!key.Equals(null))
            {
               baseRepository.Delete<TEntity, TPrimaryKey>(key);
                unitOfWork.Commit();
            }
        }

        public TEntityDto Find(TPrimaryKey key)
        {
            if(!key.Equals(null))
            {
               var Entity = baseRepository.Find<TEntity, TPrimaryKey>(key);
                return EntityToDto(Entity);
            }

           return default(TEntityDto);

        }

        public TEntityDto FindInclude(TPrimaryKey key)
        {
            if (!key.Equals(null))
            {
                var Entity = baseRepository.FindInclude<TEntity,TPrimaryKey>(key,AllInclude());
                return EntityToDto(Entity);
            }

            return default(TEntityDto);

        }

        public List<TEntityDto> GetAll()
        {
            var GetAll = baseRepository.GetAll<TEntity, TPrimaryKey>();
            return EntityToDto(GetAll);
        }

        public List<TEntityDto> GetAll(Paging paging)
        {
            var GetAll = Query(baseRepository.GetAll<TEntity, TPrimaryKey>(),paging).Skip((paging.SelectPage - 1) * paging.ShowPage).Take(paging.ShowPage).ToList();
            return EntityToDto(GetAll);

        }

        public List<TEntityDto> GetAllInclude()
        {
            var GetAll = baseRepository.GetAllInclude<TEntity,TPrimaryKey>(AllInclude());
            return EntityToDto(GetAll);

        }

        public List<TEntityDto> GetAllInclude(Paging paging)
        {
            var GetAll = Query(baseRepository.GetAllInclude<TEntity, TPrimaryKey>(AllInclude()),paging).Skip((paging.SelectPage -1)* paging.ShowPage).Take(paging.ShowPage).ToList();

            return EntityToDto(GetAll);

        }

        protected virtual List<Func<TEntity,bool>> Filter(Paging paging)
        {
           
            return new List<Func<TEntity, bool>>();
        }

        private IEnumerable<TEntity> Query(IEnumerable<TEntity> query,Paging paging)
        {
            foreach (var item in Filter(paging))
            {
                query = query.Where(item);
            }

            return query;
        }

        protected virtual List<Expression<Func<TEntity,object>>> AllInclude()
        {
            return new List<Expression<Func<TEntity, object>>>();
        }

        public Paging Pagination(Paging paging)
        {
           
            var count = Query(baseRepository.GetAllInclude<TEntity,TPrimaryKey>(AllInclude()),paging).Count();
            double TotalPage = count/(double)paging.ShowPage;
            paging.TotalPage = (short)Math.Ceiling(TotalPage);
           

            return paging;
        }

        protected TEntityDto EntityToDto(TEntity entity)
        {
            return mapper.Map<TEntity, TEntityDto>(entity);
        }

        protected TEntity DtoToEntity(TEntityDto entityDto)
        {
            return mapper.Map<TEntityDto, TEntity>(entityDto);
        }

        protected List<TEntityDto> EntityToDto(List<TEntity> entity)
        {
            return mapper.Map<List<TEntity>, List<TEntityDto>>(entity);
        }

        protected List<TEntity> DtoToEntity(List<TEntityDto> entityDto)
        {
            return mapper.Map<List<TEntityDto>, List<TEntity>>(entityDto);
        }
    }
}

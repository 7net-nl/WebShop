using System;
using System.Collections.Generic;
using TShop.Domain.Entities;

namespace TShop.Service.Application
{
    public interface IBaseService<TEntity,TEntityDto,TPrimaryKey>
        where TEntity : Entity<TPrimaryKey>
        where TEntityDto : IEntityDto<TPrimaryKey>
        where TPrimaryKey:struct
    {
        void Save(TEntityDto entityDto);
        void Delete(TPrimaryKey key);
        TEntityDto Find(TPrimaryKey key);
        TEntityDto FindInclude(TPrimaryKey key);
        Paging Pagination(Paging paging);
        List<TEntityDto> GetAll();
        List<TEntityDto> GetAll(Paging paging);
        List<TEntityDto> GetAllInclude();
        List<TEntityDto> GetAllInclude(Paging paging);
    }
}

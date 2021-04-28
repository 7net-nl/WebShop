using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using TShop.Domain.Contract.Interfaces;
using TShop.Domain.Contract.Repositories;
using TShop.Domain.Entities;

namespace TShop.Service.Application.Categorys
{
    public class CategoryService : BaseService<Category, CategoryDto, byte>, ICategoryService
    {
        public CategoryService(IUnitOfWork unitOfWork, IBaseRepository baseRepository, IMapper mapper) : base(unitOfWork, baseRepository, mapper)
        {
        }
    }
}

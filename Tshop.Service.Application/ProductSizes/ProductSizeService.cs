using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using TShop.Domain.Contract.Interfaces;
using TShop.Domain.Contract.Repositories;
using TShop.Domain.Entities;

namespace TShop.Service.Application.ProductSizes
{
    public class ProductSizeService : BaseService<ProductSize, ProductSizeDto, long>, IProductSizeService
    {
        public ProductSizeService(IUnitOfWork unitOfWork, IBaseRepository baseRepository, IMapper mapper) : base(unitOfWork, baseRepository, mapper)
        {
        }
    }
}

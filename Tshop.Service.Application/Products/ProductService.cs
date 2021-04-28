using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using AutoMapper;
using TShop.Domain.Contract.Interfaces;
using TShop.Domain.Contract.Repositories;
using TShop.Domain.Entities;

namespace TShop.Service.Application.Products
{
    public class ProductService : BaseService<Product, ProductDto, long>, IProductService
    {
        public ProductService(IUnitOfWork unitOfWork, IBaseRepository baseRepository, IMapper mapper) : base(unitOfWork, baseRepository, mapper)
        {
        }

        protected override List<Expression<Func<Product, object>>> AllInclude()
        {
            return new List<Expression<Func<Product, object>>> { c => c.Category, c => c.Colors, C => C.Images, c => c.Sizes };
        }

        protected override List<Func<Product, bool>> Filter(Paging paging)
        {
            return new List<Func<Product, bool>>
            {
                c=>string.IsNullOrEmpty(paging.Category) ? true :  c.Category.Name == paging.Category,
                c=>string.IsNullOrEmpty(paging.Color) ? true : c.Colors.Exists(d=>d.Name == paging.Color),
                c=>string.IsNullOrEmpty(paging.Brand) ? true :true,
                c=>paging.MinPrice == 0 & paging.MaxPrice == 0 ? true : c.NewPrice >= paging.MinPrice & c.NewPrice <= paging.MaxPrice

            };
        }
    }
}

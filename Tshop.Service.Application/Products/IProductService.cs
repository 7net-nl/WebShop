using System;
using System.Collections.Generic;
using System.Text;
using TShop.Domain.Entities;

namespace TShop.Service.Application.Products
{
    public interface IProductService : IBaseService<Product,ProductDto,long>
    {
    }
}

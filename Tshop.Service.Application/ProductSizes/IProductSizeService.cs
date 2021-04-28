using System;
using System.Collections.Generic;
using System.Text;
using TShop.Domain.Entities;

namespace TShop.Service.Application.ProductSizes
{
    public interface IProductSizeService : IBaseService<ProductSize,ProductSizeDto,long>
    {
    }
}

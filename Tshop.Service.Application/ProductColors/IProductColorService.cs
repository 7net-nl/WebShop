using System;
using System.Collections.Generic;
using System.Text;
using TShop.Domain.Entities;

namespace TShop.Service.Application.ProductColors
{
    public interface IProductColorService : IBaseService<ProductColor,ProductColorDto,long>
    {
    }
}

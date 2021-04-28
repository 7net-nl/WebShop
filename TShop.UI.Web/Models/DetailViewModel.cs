using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TShop.Service.Application.Products;

namespace TShop.UI.Web.Models
{
    public class DetailViewModel
    {
        public ProductDto Product { get; set; }
        public List<ProductDto> Products { get; set; }
    }
}

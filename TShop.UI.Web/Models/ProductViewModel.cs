using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TShop.Service.Application.Products;

namespace TShop.UI.Web.Models
{
    public class ProductViewModel
    {
        public List<ProductDto> Products { get; set; }
        public string Title { get; set; }
    }
}

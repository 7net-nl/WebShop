using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TShop.Service.Application;
using TShop.Service.Application.Products;

namespace TShop.UI.Web.Models
{
    public class StoreViewModel
    {
        public List<ProductDto> Products { get; set; }
        public Paging Paging { get; set; }
    }
}

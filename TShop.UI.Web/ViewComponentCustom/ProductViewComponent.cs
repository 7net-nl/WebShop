using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TShop.Service.Application.Products;
using TShop.UI.Web.Models;

namespace TShop.UI.Web.ViewComponentCustom
{
    [ViewComponent(Name ="Product")]
    public class ProductViewComponent : ViewComponent
    {
        private readonly IProductService productService;

        public ProductViewComponent(IProductService productService)
        {
            this.productService = productService;
        }
        public IViewComponentResult Invoke(string Title ="")
        {
            
            var model = new ProductViewModel
            {
                 
                 Products = productService.GetAllInclude().Take(4).ToList(),
                  Title = Title
            };
            
            return View(model);
        }
    }
}

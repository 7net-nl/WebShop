using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TShop.Service.Application;
using TShop.Service.Application.Products;
using TShop.UI.Web.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TShop.UI.Web.Controllers
{
    public class StoreController : Controller
    {
        private readonly IProductService productService;

        public StoreController(IProductService productService)
        {
            this.productService = productService;
        }
        public IActionResult Index(Paging paging)
        {
            var Pagination = productService.Pagination(paging);

                var model = new StoreViewModel
                {
                    Products = productService.GetAllInclude(Pagination),
                    Paging = Pagination
                };
            return View(model);
        }

        public IActionResult Detail(long Id=0)
        {
            var Product = productService.FindInclude(Id);
            var Products = productService.GetAllInclude().Take(12).ToList();
            var model = new DetailViewModel
            {
                 Product = Product,
                  Products = Products
            };

            return View(model);
        }

        public IActionResult QuickView(long Id=0)
        {
            var Product = productService.Find(Id);
            var model = new QuickDetailViewModel
            {
                Product = Product
            };

            return PartialView("QuickView",model);
        }

        [HttpPost]
        public IActionResult Search(string q = null)
        {

            return View();
        }
    }
}

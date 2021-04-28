using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TShop.Service.Application;
using TShop.Service.Application.Categorys;
using TShop.UI.Web.Models;

namespace TShop.UI.Web.ViewComponentCustom
{
    [ViewComponent(Name ="CategoryShop")]
    public class CategoryShopViewComponent : ViewComponent
    {
        private readonly ICategoryService categoryService;

        public CategoryShopViewComponent(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        public IViewComponentResult Invoke(Paging paging)
        {
            var model = new CategoryViewModel
            {
                 Categories = categoryService.GetAll(),
                  Paging = paging
            };

            return View(model);
        }
    }
}

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
    [ViewComponent(Name ="Category")]
    public class CategoryViewComponent : ViewComponent
    {
        private readonly ICategoryService categoryService;

        public CategoryViewComponent(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        public IViewComponentResult Invoke()
        {
            var model = new CategoryViewModel
            {
                 Categories = categoryService.GetAll()
            };
            return View(model);
        }
    }
}

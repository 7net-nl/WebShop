using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TShop.Service.Application;
using TShop.UI.Web.Models;

namespace TShop.UI.Web.ViewComponentCustom
{
    [ViewComponent(Name ="ColorShop")]
    public class ColorShopViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(Paging paging)
        {
            var model = new ColorShopViewModel
            {
                 Paging = paging
            };

            return View(model);
        }
    }
}

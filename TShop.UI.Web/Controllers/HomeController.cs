using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TShop.Service.Application.Categorys;
using TShop.Service.Application.Products;

namespace TShop.UI.Web.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
           
            return View();
        }


       
        [Route("404")]
        public IActionResult Erorr404()
        {
            return View();
        }
       

        public IActionResult ComingSoon()
        {
            return View();
        }

        [Authorize(Policy = "CheckCity")]
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}

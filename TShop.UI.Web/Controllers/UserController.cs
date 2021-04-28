using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TShop.UI.Web.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TShop.UI.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<Users> userManager;

        public UserController(UserManager<Users> userManager)
        {
            this.userManager = userManager;
        }
        
        public async Task<IActionResult> Index(string Email,string City)
        {
            var Users = await userManager.FindByEmailAsync(Email);
            var Claims = new Claim("City", City);
            await userManager.AddClaimAsync(Users, Claims);
            return RedirectToAction("Index", "Home");
        }
    }
}

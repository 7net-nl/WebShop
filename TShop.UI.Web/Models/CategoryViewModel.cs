using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TShop.Service.Application;
using TShop.Service.Application.Categorys;

namespace TShop.UI.Web.Models
{
    public class CategoryViewModel
    {
        public List<CategoryDto> Categories { get; set; }
        public Paging Paging { get; set; }
    }
}

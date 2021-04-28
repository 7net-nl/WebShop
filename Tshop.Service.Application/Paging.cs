using System;
using System.Collections.Generic;
using System.Text;

namespace TShop.Service.Application
{
    public class Paging
    {
        public string Category { get; set; }
        public short TotalPage { get; set; }
        public short SelectPage { get; set; }
        public short ShowPage { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public int MinPrice { get; set; }
        public int MaxPrice { get; set; }

        public Paging()
        {
            SelectPage = 1;
            ShowPage = 12;
        }
        
    }
}

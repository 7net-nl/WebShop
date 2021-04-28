using AutoMapper;
using AutoMapper.Configuration;
using System.Collections.Generic;
using System.Linq;
using TShop.Domain.Entities;

namespace TShop.Service.Application.Products
{
    /// <summary>
    /// <see cref="long"/>
    /// </summary>
    /// 

    public class ProductDto : IEntityDto<long>
    {
        public long ID { get; set; }
        public string Title { get; set; }
        public byte Category_ID { get; set; }
        public string Category { get; set; }
        public byte Rank { get; set; }
        public decimal OldPrice { get; set; }
        public decimal NewPrice { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public List<string> Colors { get; set; }
        public List<string> Sizes { get; set; }
        public string Available { get; set; }
        public List<string> Images { get; set; }


       
    }
}
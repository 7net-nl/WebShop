using System;
using System.Collections.Generic;
using System.Text;

namespace TShop.Domain.Entities
{
    /// <summary>
    /// <see cref="long"/>
    /// </summary>
    public class Product : Entity<long>
    {
        public string Title { get; set; }
        public byte Category_ID { get; set; }
        public Category Category { get; set; }
        public byte Rank { get; set; }
        public decimal OldPrice { get; set; }
        public decimal NewPrice { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public List<ProductColor> Colors { get; set; }
        public List<ProductSize> Sizes { get; set; }
        public EnumAvailable Available { get; set; }
        public List<ImageFile> Images { get; set; }



    }
}

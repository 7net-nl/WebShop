using System;
using System.Collections.Generic;
using System.Text;

namespace TShop.Domain.Entities
{
    /// <summary>
    /// <see cref="long"/>
    /// </summary>
    public class ProductSize : Entity<long>
    {
        public string Name { get; set; }
        public long Product_ID { get; set; }
    }
}

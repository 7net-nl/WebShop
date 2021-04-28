using System;
using System.Collections.Generic;
using System.Text;

namespace TShop.Domain.Entities
{
    /// <summary>
    /// <see cref="long"/>
    /// </summary>
    public class ImageFile : Entity<long>
    {
        public string FileName { get; set; }
        public long Product_ID { get; set; }
    }
}

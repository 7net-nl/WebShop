using System;
using System.Collections.Generic;
using System.Text;

namespace TShop.Domain.Entities
{
    /// <summary>
    /// <see cref="byte"/>
    /// </summary>
    public class Category : Entity<byte>
    {
        public string Name { get; set; }

    }
}

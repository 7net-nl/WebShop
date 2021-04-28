using System;
using System.Collections.Generic;
using System.Text;

namespace TShop.Service.Application
{
    public class EntityDto<TPrimaryKey> : IEntityDto<TPrimaryKey> where TPrimaryKey:struct
    {
        public TPrimaryKey ID { get; set; }
    }
}

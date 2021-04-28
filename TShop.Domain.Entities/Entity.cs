using System;

namespace TShop.Domain.Entities
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TPrimaryKey"></typeparam>
    public class Entity<TPrimaryKey> where TPrimaryKey:struct
    {
        public TPrimaryKey ID { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}

namespace TShop.Service.Application.ProductSizes
{
    /// <summary>
    /// <see cref="long"/>
    /// </summary>
    public class ProductSizeDto : EntityDto<long>
    {
        public string Name { get; set; }
        public long Product_ID { get; set; }
    }

}
namespace TShop.Service.Application.ProductColors
{
    /// <summary>
    /// <see cref="long"/>
    /// </summary>
    public class ProductColorDto : EntityDto<long>
    {
        public string Name { get; set; }
        public long Product_ID { get; set; }
    }
}
namespace TShop.Service.Application.ImageFiles
{
    /// <summary>
    /// <see cref="long"/>
    /// </summary>
    public class ImageFileDto : EntityDto<long>
    {
        public string FileName { get; set; }
        public long Product_ID { get; set; }
    }
}
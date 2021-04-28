namespace TShop.Service.Application
{
    public interface IEntityDto<TPrimaryKey> where TPrimaryKey : struct
    {
        TPrimaryKey ID { get; set; }
    }
}
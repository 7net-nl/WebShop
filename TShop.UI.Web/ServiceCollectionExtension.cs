using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TShop.Domain.Contract.Interfaces;
using TShop.Domain.Contract.Repositories;
using TShop.Infrascture.DataBase.EF;
using TShop.Infrascture.DataBase.EF.Repositories;
using TShop.Service.Application.Categorys;
using TShop.Service.Application.ImageFiles;
using TShop.Service.Application.ProductColors;
using TShop.Service.Application.Products;
using TShop.Service.Application.ProductSizes;

namespace TShop.UI.Web
{
    public static class ServiceCollectionExtension
    {
        public static void CustomService(this IServiceCollection services)
        {
            services.AddScoped<IBaseRepository, BaseRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IImageFileService, ImageFileService>();
            services.AddScoped<IProductSizeService, ProductSizeService>();
            services.AddScoped<IProductColorService, ProductcolorService>();
        }
    }
}

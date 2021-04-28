using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TShop.Domain.Entities;
using TShop.Service.Application.Products;

namespace TShop.Service.Application
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDto>().
            ForMember(dest => dest.Images, option => option.MapFrom(c => c.Images.Select(d => d.FileName))).
            ForMember(dest=>dest.Category,option=>option.MapFrom(c=>c.Category.Name)).
            ForMember(dest=>dest.Colors,opt=>opt.MapFrom(c=>c.Colors.Select(d=>d.Name))).
            ForMember(dst=>dst.Sizes,opt=>opt.MapFrom(c=>c.Sizes.Select(d=>d.Name)));
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using TShop.Domain.Contract.Interfaces;
using TShop.Domain.Contract.Repositories;
using TShop.Domain.Entities;

namespace TShop.Service.Application.ImageFiles
{
    public class ImageFileService : BaseService<ImageFile, ImageFileDto, long>, IImageFileService
    {
        public ImageFileService(IUnitOfWork unitOfWork, IBaseRepository baseRepository, IMapper mapper) : base(unitOfWork, baseRepository, mapper)
        {
        }
    }
}

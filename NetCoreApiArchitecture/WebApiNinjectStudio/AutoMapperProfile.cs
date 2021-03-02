using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using WebApiNinjectStudio.Domain.Entities;
using WebApiNinjectStudio.V1.Dtos;

namespace WebApiNinjectStudio
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //CreateMap<from, to>();

            #region Product Dto
            CreateMap<CreateProductDto, Product>();
            CreateMap<CreateProductImageDto, ProductImage>();            
            CreateMap<CreateProductTagDto, ProductTag>();

            CreateMap<UpdateProductDto, Product>();
            CreateMap<UpdateProductImageDto, ProductImage>();
            CreateMap<UpdateProductTagDto, ProductTag>();

            CreateMap<Product, ReturnProductDto>();
            CreateMap<ProductImage, ReturnProductImageDto>();
            CreateMap<ProductTag, ReturnProductTagDto>();
            #endregion
        }
    }
}

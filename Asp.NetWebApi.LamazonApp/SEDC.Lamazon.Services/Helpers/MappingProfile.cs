using AutoMapper;
using SEDC.Lamazon.Domain.DomainModels;
using SEDC.Lamazon.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.Lamazon.Services.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductVM>()
                .ForMember(des => des.OrderId, src => src.Ignore())
                .ForMember(des => des.Quantity, src => src.Ignore())
                .ReverseMap();

            CreateMap<Order, OrderVM>()
                .ForMember(dest => dest.Price, src => src.Ignore())
                .ForMember(dest => dest.ProductsVM, src => src.MapFrom(x => x.ProductOrders.Select(y => y.Product)))
                .ReverseMap()
                .ForMember(dest => dest.ProductOrders, src => src.Ignore())
                .ForMember(dest => dest.DateOfOrder, src => src.Ignore())
                .ForMember(dest => dest.User, src => src.Ignore());
        }
    }
}

using AutoMapper;
using E_Commerce.DTO.Product;
using E_commerce.Model;
using E_Commerce.DTO.Order;
using E_Commerce.DTO.OrderItem;
using E_Commerce.DTO.user;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using E_Commerce.DTO.Category;

namespace E_Commerce.Application.Mapper
{

    public class AutoMapperProfile : Profile
    {


        public AutoMapperProfile()
        {
            CreateMap<CreateProductDTO, Product>().ReverseMap();
            CreateMap<GetAllProductsDTO, Product>().ReverseMap();
            CreateMap<ProductDetailsDTO, Product>().ReverseMap();
            CreateMap<CategoryDTO, Categoryy>().ReverseMap();
            CreateMap<UserDTO, User>().ReverseMap();

            CreateMap<CreateOrderDetailDTO, OrderDetail>()
                      .ForMember(dest => dest.Quantity, opt => opt.MapFrom(src => src.Quantity ?? 0))
                      .ForMember(dest => dest.UnitPrice, opt => opt.MapFrom(src => src.UnitPrice ?? 0m))
                      .ReverseMap();

            CreateMap<GetAllOrderDetailDTO, OrderDetail>().ReverseMap();



            CreateMap<GetMasterOrderDTO, Order>()
                .ForMember(dest => dest.OrderID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.OrderStatus))
                .ReverseMap();


            CreateMap<CreateOrderMasterDTO, Order>()
            .ForMember(dest => dest.OrderDetails, opt => opt.MapFrom(src => src.OrderDetails))
            .ReverseMap();




        }

    }
}



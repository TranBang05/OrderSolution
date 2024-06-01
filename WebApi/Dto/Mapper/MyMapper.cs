using AutoMapper;
using WebApi.Dto.Response;
using WebApi.Models;

namespace WebApi.Dto.Mapper
{
    public class MyMapper:Profile
    {
        public MyMapper() 
        {
            CreateMap<Customer,CustomerResponse>();
            CreateMap<Employee,EmployeeResponse>();
            CreateMap<Product, ProductResponse>();
            CreateMap<OrderDetail, OrderDetailResponse>();

            CreateMap<Order, OrderResponse>()
                .ForMember(dest => dest.CustomerName, opt =>
                    opt.MapFrom(src => src.Customer!.CompanyName))
                .ForMember(dest => dest.EmployName, opt =>
                    opt.MapFrom(src => src.Employee!.FirstName))
                .ForMember(dest => dest.TotalAmount, opt => opt.MapFrom(src => src.OrderDetails.Sum(od => od.Quantity * od.UnitPrice * (decimal)(1 - od.Discount)))
                );
        }
    }
}

using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using WebApi.Dto.Response;
using WebApi.Models;

namespace WebApi.Service.Impl
{
    public class OrderService : IOrderService
    {
        private readonly prn221aContext _context;
        private readonly IMapper _mapper;

        public OrderService(prn221aContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public IQueryable<OrderResponse> GetOrders()
        {
            var orders = _context.Orders.AsQueryable();
            return _mapper.ProjectTo<OrderResponse>(orders);
        }
    }
}

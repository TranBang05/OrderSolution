using AutoMapper;
using System;
using WebApi.Dto.Response;
using WebApi.Models;

namespace WebApi.Service.Impl
{
    public class CustomerService : ICustomerService
    {
        private readonly prn221aContext _context;
        private readonly IMapper _mapper;

        public CustomerService(prn221aContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<CustomerResponse> listCustomer()
        {
            var customers = _context.Customers.ToList();
            var customerResponses = _mapper.Map<List<CustomerResponse>>(customers);
            return customerResponses;

        }
    }
}

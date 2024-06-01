using AutoMapper;
using WebApi.Dto.Response;
using WebApi.Models;

namespace WebApi.Service.Impl
{
    public class EmployeeService : IEmployeeService
    {
        private readonly prn221aContext _context;
        private readonly IMapper _mapper;

        public EmployeeService(prn221aContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<EmployeeResponse> listEmployees()
        {
            var employees = _context.Employees.ToList();
            var employeeResponses = _mapper.Map<List<EmployeeResponse>>(employees);
            return employeeResponses;
        }
    }
}

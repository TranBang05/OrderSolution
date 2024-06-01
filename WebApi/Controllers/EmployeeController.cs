using Microsoft.AspNetCore.Mvc;
using WebApi.Dto.Response;
using WebApi.Service;
using WebApi.Service.Impl;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public ActionResult<List<EmployeeResponse>> GetEmployee()
        {
            var employees = _employeeService.listEmployees();
            return Ok(employees);
        }
    }
}

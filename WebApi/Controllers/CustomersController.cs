using Microsoft.AspNetCore.Mvc;
using WebApi.Dto.Response;
using WebApi.Service;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : Controller
    {
        private readonly ICustomerService _customerService;
        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }


        [HttpGet]
        public ActionResult<List<CustomerResponse>> GetCustomers()
        {
            var customers = _customerService.listCustomer();
            return Ok(customers);
        }

    }
}

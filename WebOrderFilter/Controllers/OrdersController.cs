using Microsoft.AspNetCore.Mvc;
using WebOrderFilter.Models;

namespace WebOrderFilter.Controllers
{
    public class OrdersController : BaseController
    {
        private string rootApiUrl;
        private IConfiguration _configuration;

        public OrdersController(IConfiguration configuration)
        {
            _configuration = configuration;
            rootApiUrl = _configuration.GetSection("ApiUrls")["MyApi"];
        }
        public async Task<IActionResult> Index(string? customerName, string? employeeName, DateTime? startDate, DateTime? endDate, string sortOrder)
        {
            string orderResourcePath = rootApiUrl + "Order";
            string customerResourcePath = rootApiUrl + "Customers";
            string employeeResourcePath = rootApiUrl + "Employee";

            List<OrderResponse>? orders = await GetData<List<OrderResponse>?>(orderResourcePath);
            List<CustomerResponse>? customers = await GetData<List<CustomerResponse>?>(customerResourcePath);
            List<EmployeeResponse>? employees = await GetData<List<EmployeeResponse>?>(employeeResourcePath);

            if (orders == null)
            {
                return View(new List<OrderResponse>());
            }

            if (!string.IsNullOrEmpty(customerName))
            {
                orders = orders.Where(o => o.CustomerName != null && o.CustomerName.Contains(customerName)).ToList();
            }

           
            if (!string.IsNullOrEmpty(employeeName))
            {
                orders = orders.Where(o => o.EmployName != null && o.EmployName.Contains(employeeName)).ToList();
            }

       
            if (startDate.HasValue && endDate.HasValue)
            {
                orders = orders.Where(o => o.OrderDate >= startDate && o.OrderDate <= endDate).ToList();
            }

            if (!string.IsNullOrEmpty(sortOrder))
            {
                switch (sortOrder)
                {
                    case "asc":
                        orders = orders.OrderBy(o => o.OrderDate).ToList();
                        break;
                    case "desc":
                        orders = orders.OrderByDescending(o => o.OrderDate).ToList();
                        break;
                    default:
                        break;
                }
            }

            ViewBag.CustomerNames = customers?.Select(c => c.CompanyName).ToList();
            ViewBag.EmployeeNames = employees?.Select(e => e.FirstName).ToList();
            return View(orders);
        }





    }
}

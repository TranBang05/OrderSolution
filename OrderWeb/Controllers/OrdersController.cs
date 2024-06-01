using Microsoft.AspNetCore.Mvc;
using OrderWeb.Models;

namespace OrderWeb.Controllers
{
    public class OrdersController : BaseController
    {
        public async Task<IActionResult> Index(string customerName, string employeeName, DateTime? startDate, DateTime? endDate, string sortOrder)
        {
            var customers = await GetData<List<CustomerResponse>>("http://localhost:5088/api/Customers");
            var employees = await GetData<List<EmployeeResponse>>("http://localhost:5088/api/Employee");
            var orders = await GetData<List<OrderResponse>>("http://localhost:5088/api/Order");

            if (!string.IsNullOrEmpty(customerName))
            {
                orders = orders.Where(o => o.CustomerName.Contains(customerName)).ToList();
            }

            if (!string.IsNullOrEmpty(employeeName))
            {
                orders = orders.Where(o => o.EmployName.Contains(employeeName)).ToList();
            }

            if (startDate.HasValue)
            {
                orders = orders.Where(o => o.OrderDate >= startDate.Value).ToList();
            }

            if (endDate.HasValue)
            {
                orders = orders.Where(o => o.OrderDate <= endDate.Value).ToList();
            }

            switch (sortOrder)
            {
                case "date_asc":
                    orders = orders.OrderBy(o => o.OrderDate).ToList();
                    break;
                case "date_desc":
                    orders = orders.OrderByDescending(o => o.OrderDate).ToList();
                    break;
            }

            var viewModel = new OrderFilterViewModel
            {
                Customers = customers,
                Employees = employees,
                Orders = orders,
                SelectedCustomerName = customerName,
                SelectedEmployeeName = employeeName,
                StartDate = startDate,
                EndDate = endDate,
                SortOrder = sortOrder
            };

            return View(viewModel);
        }
    }
}

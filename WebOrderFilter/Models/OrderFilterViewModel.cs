namespace WebOrderFilter.Models
{
    public class OrderFilterViewModel
    {
        public List<CustomerResponse> Customers { get; set; }
        public List<EmployeeResponse> Employees { get; set; }
        public List<OrderResponse> Orders { get; set; }

        public string SelectedCustomerName { get; set; }
        public string SelectedEmployeeName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string SortOrder { get; set; }
    }
}

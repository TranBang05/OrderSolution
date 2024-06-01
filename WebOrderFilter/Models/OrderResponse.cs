namespace WebOrderFilter.Models
{
    public class OrderResponse
    {
       
        public int OrderId { get; set; }

        
        public string? CustomerId { get; set; }

       
        public int? EmployeeId { get; set; }

    
        public string? ShipCountry { get; set; }

        
        public DateTime? OrderDate { get; set; }

        public string? CustomerName { get; set; }

       
        public string? EmployName { get; set; }

       
        public decimal? TotalAmount { get; set; }

       
        public List<OrderDetailResponse> OrderDetails { get; set; }
    }
}

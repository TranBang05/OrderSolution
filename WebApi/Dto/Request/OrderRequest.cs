namespace WebApi.Dto.Request
{
    public class OrderRequest
    {
        public DateTime? OrderDate { get; set; }
        public int? ShipVia { get; set; }
        public decimal? Freight { get; set; }
        public string? ShipCountry { get; set; }

        public List<ProductRequest>? ListProducts { get; set; }
    }
}

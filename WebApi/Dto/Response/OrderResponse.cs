using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace WebApi.Dto.Response
{
    public class OrderResponse
    {
        [JsonProperty(Order = 1)]
        public int OrderId { get; set; }

        [JsonProperty(Order = 2)]
        public string? CustomerId { get; set; }

        [JsonProperty(Order = 3)]
        public int? EmployeeId { get; set; }

        [JsonProperty(Order = 4)]
        public string? ShipCountry { get; set; }

        [JsonProperty(Order = 5)]
        public DateTime? OrderDate { get; set; }

        [JsonProperty(Order = 6)]
        public string? CustomerName { get; set; }

        [JsonProperty(Order = 7)]
        public string? EmployName { get; set; }

        [JsonProperty(Order = 8)]
        public decimal? TotalAmount { get; set; }

        [JsonProperty(Order = 9)]
        public List<OrderDetailResponse> OrderDetails { get; set; }
    }
}
using WebApi.Dto.Response;
using WebApi.Models;

namespace WebApi.Service
{
    public interface IOrderService
    {
        IQueryable<OrderResponse> GetOrders();
    }
}

using WebApi.Models;

namespace WebApi.Dto.Response
{
    public class OrderDetailResponse
    {
       
        public virtual ProductResponse Product { get; set; } = null!;
    }
}

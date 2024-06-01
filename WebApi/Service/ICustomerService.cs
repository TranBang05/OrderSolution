using WebApi.Dto.Response;

namespace WebApi.Service
{
    public interface ICustomerService
    {
        public List<CustomerResponse> listCustomer();
    }
}

using WebApi.Dto.Response;

namespace WebApi.Service
{
    public interface IEmployeeService
    {
        public List<EmployeeResponse> listEmployees();
    }
}

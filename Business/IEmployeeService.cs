using EmpMgmtSys.Models.Employee;
using static EmpMgmtSys.Business.EmployeeService;

namespace EmpMgmtSys.Business
{
    public interface IEmployeeService
    {
        Task<String> CreateEmployeeAsync(EmployeeDTO model);
    }
}

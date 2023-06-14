using EmpMgmtSys.Business;
using Microsoft.AspNetCore.Mvc;
using static EmpMgmtSys.Business.EmployeeService;

namespace EmpMgmtSys.Controllers
{
    [Route("[controller]")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService
        }
        public IActionResult Create(EmployeeDTO model)
        {
            _employeeService.CreateEmployeeAsync(model);
            return View();
        }

    }
}

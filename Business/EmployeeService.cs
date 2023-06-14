using EmpMgmtSys.Data;
using System.ComponentModel.DataAnnotations;

namespace EmpMgmtSys.Business
{
    public class EmployeeService: IEmployeeService
    {
        private readonly IEmployeeService _employeeService;
        private readonly ApplicationDbContext _dbContext;
        public EmployeeService(IEmployeeService employeeService,
            ApplicationDbContext dbContext)
        {
            _employeeService = employeeService;
            _dbContext = dbContext;
        }
        public class EmployeeDTO
        {
            [Required]
            public string FullName { get; set; }
        }
        public class Employee
        {
            [Required]
            public string FullName { get; set; }
        }
        public Task<string> CreateEmployeeAsync(EmployeeDTO model)
        {
            var customer = new Employee()
            {
                FullName=model.FullName
            }
        }
    }
}

using EmpMgmtSys.Data;
using EmpMgmtSys.Data.Entities;
using EmpMgmtSys.Models.Employee;
using Mapster;

namespace EmpMgmtSys.Business
{
    public class EmployeeService : IEmployeeService
    {
        private readonly ApplicationDbContext _dbContext;
        public EmployeeService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<string> CreateEmployeeAsync(EmployeeDTO model)
        {
            try
            {
                var employee = model.Adapt<Employee>();
                await _dbContext.Employees.AddAsync(employee);
                await _dbContext.SaveChangesAsync();
                return ("Employee created Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong while creating Employee. Exception:{Exception}", ex);
                throw;
            }
        }
    }
}

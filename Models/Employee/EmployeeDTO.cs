using System.ComponentModel.DataAnnotations;

namespace EmpMgmtSys.Models.Employee
{
    public class EmployeeDTO
    {
        [Required]
        public string Name { get; set; }
        [Required]

        public string contact { get; set; }
        [Required]

        public string EmailAddress { get; set; }
        [Required]

        public DateTime JoiningDate { get; set; }
        [Required]

        public string DepartmentId { get; set; }
        [Required]

        public string DesignationId { get; set; }
    }
}

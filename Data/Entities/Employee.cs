namespace EmpMgmtSys.Data.Entities
{
    public class Employee : BaseEntity
    {
        public string Name { get; set; }
        public string contact { get; set; }
        public string EmailAddress { get; set; }
        public DateTime JoiningDate { get; set; }
        public string DepartmentId { get; set; }
        public ICollection<Department> Departments { get; set; }
        public string DesignationId { get; set; }
        public ICollection<Designation> Designations { get; set; }
        public ICollection<Leave> Leaves { get; set; }

    }
}

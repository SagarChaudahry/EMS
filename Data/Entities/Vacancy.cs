namespace EmpMgmtSys.Data.Entities
{
    public class Vacancy : BaseEntity
    {
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public int NumberOfVacancies { get; set; }
        public string DepartmentId { get; set; }
        public string DesignationId { get; set; }
        public Department Department { get; set; }
        public Designation Designation { get; set; }
    }
}

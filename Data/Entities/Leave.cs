namespace EmpMgmtSys.Data.Entities
{
    public class Leave :BaseEntity
    {
        public string LeaveType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string EmployeeId { get; set; }
        public Employee Employee { get; set; }

    }
}

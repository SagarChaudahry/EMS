﻿namespace EmpMgmtSys.Data.Entities
{
    public class Designation : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}

using Microsoft.AspNetCore.Identity;

namespace EmpMgmtSys.Data.Entities
{
    public class ApplicationRole:IdentityRole
    {
        public string Description { get; set; }
    }
}

namespace EmpMgmtSys.Data.Entities
{
    public class BaseEntity
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
        public string CreatedBy {get; set;}
        public bool IsDeleted {get; set;}
        public DateTimeOffset? ModifiedAt { get; set; }
    }
}

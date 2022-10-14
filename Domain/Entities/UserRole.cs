namespace Domain.Entities;

public class UserRole : BaseEntity
{
    public string UserId { get; set; }
    public User User { get; set; }

    public string RoleGroupId { get; set; }
    public RoleGroup RoleGroup { get; set; }

    public long Roles { get; set; }
}
namespace Domain.Entities;

public class UserRole : BaseEntity
{
    public int UserRoleId { get; set; }
    public int? UserId { get; set; }
    public int? RoleGroupId { get; set; }
    public long? Roles { get; set; }

    public virtual RoleGroup RoleGroup { get; set; }
    public virtual User User { get; set; }
}
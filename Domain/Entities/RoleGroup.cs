namespace Domain.Entities;

public class RoleGroup : BaseEntity
{
    public string RoleGroupName { get; set; }

    public ICollection<UserRole> UserRoles { get; set; }
    public ICollection<Role> Roles { get; set; }
}
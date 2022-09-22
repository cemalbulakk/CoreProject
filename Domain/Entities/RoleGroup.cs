using System.Data;

namespace Domain.Entities;

public class RoleGroup : BaseEntity
{
    public RoleGroup()
    {
        Roles = new HashSet<Role>();
        UserRoles = new HashSet<UserRole>();
    }

    public int RoleGroupId { get; set; }
    public string GroupName { get; set; }

    public virtual ICollection<Role> Roles { get; set; }
    public virtual ICollection<UserRole> UserRoles { get; set; }
}
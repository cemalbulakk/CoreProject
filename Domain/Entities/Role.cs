namespace Domain.Entities;

public class Role : BaseEntity
{
    public long BitwiseId { get; set; }
    public string RoleName { get; set; }
    public int RoleGroupId { get; set; }
    public RoleGroup RoleGroup { get; set; }
}
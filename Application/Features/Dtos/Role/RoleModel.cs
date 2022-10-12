namespace Application.Features.Dtos.Role;

public class RoleModel
{
    public int RoleId { get; set; }
    public string UserId { get; set; }
    public int RoleGroupId { get; set; }
    public long BitwiseId { get; set; }
    public string RoleGroupName { get; set; }
    public string RoleName { get; set; }
}
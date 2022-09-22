namespace Domain.Entities;

public class Role : BaseEntity
{
    public Int32 RoleID { get; set; }
    public long? BitwiseID { get; set; }
    public String RoleName { get; set; }
    public Int32? GroupID { get; set; }

    public virtual RoleGroup RoleGroup { get; set; }
}
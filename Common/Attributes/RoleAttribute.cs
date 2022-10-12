namespace Common.Attributes;

[AttributeUsage(AttributeTargets.All)]
public class RoleAttribute : Attribute
{
    public RoleAttribute(int roleGroupId, long bitwiseId)
    {
        RoleGroupId = roleGroupId;
        BitwiseId = bitwiseId;
    }

    public int RoleGroupId { get; }
    public long BitwiseId { get; }
}
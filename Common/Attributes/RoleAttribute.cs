namespace Common.Attributes;

[AttributeUsage(AttributeTargets.All)]
public class RoleAttribute : Attribute
{
    public RoleAttribute(string roleGroupId, long bitwiseId)
    {
        RoleGroupId = roleGroupId;
        BitwiseId = bitwiseId;
    }

    public string RoleGroupId { get; }
    public long BitwiseId { get; }
}
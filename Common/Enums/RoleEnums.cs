namespace Common.Enums;

public class RoleEnums
{
    public class RoleGroup
    {
        public const string User = "";
        public const string Product = "41074948-a395-4c16-93f4-a656d5088a09";
        public const string Category = "a1962816-1f34-4645-9ba7-3b6861f6502e";
    }

    public enum UserRoles
    {
        Admin = 1
    }

    public enum ProductRoles
    {
        GetProductList = 1,
        GetProduct = 2,
        CreateProduct = 4,
        UpdateProduct = 8,
        DeleteProduct = 16,
    }

    public enum CategoryRoles
    {
        GetCategoryList = 1,
        GetCategory = 2,
        CreateCategory = 4,
        UpdateCategory = 8,
        DeleteCategory = 16,
    }
}
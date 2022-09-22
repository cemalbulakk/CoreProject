namespace Domain.Entities;

public class BaseEntity
{
    public DateTime CreateDate { get; set; }
    public int CreateBy { get; set; }
    public DateTime? UpdateDate { get; set; }
    public int? UpdateBy { get; set; }
    public bool IsActive { get; set; } = true;
    public bool IsDelete { get; set; } = false;
}
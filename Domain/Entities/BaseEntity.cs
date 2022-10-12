namespace Domain.Entities;

public class BaseEntity
{
    public int Id { get; set; }
    public DateTime CreateDate { get; set; }
    public int CreateBy { get; set; }
    public DateTime? UpdateDate { get; set; }
    public int? UpdateBy { get; set; }
    public bool IsActive { get; set; }
    public Guid RowGuid { get; set; }
}
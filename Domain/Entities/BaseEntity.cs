namespace Domain.Entities;

public class BaseEntity
{
    public int Id { get; set; }
    public DateTime CreateDate { get; set; }
    public string CreateBy { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? UpdateBy { get; set; }
    public bool IsActive { get; set; }
    public Guid RowGuid { get; set; }
}
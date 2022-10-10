namespace Domain.Entities;

public class Town : BaseEntity
{
    public int TownId { get; set; }
    public string TownName { get; set; }
    public int DistrictId { get; set; }
    public District District { get; set; }
}
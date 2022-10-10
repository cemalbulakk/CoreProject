namespace Domain.Entities;

public class ActorType : BaseEntity
{
    public int ActorTypeId { get; set; }
    public string ActorTypeName { get; set; }

    public ICollection<Actor> Actors { get; set; }
}
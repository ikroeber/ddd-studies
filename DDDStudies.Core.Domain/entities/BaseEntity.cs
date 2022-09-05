namespace DDDStudies.Core.Domain
{
  public abstract class BaseEntity
  {
    public BaseEntity(UniqueId id) { Id = id; }

    public UniqueId Id { get; set; }
  }
}

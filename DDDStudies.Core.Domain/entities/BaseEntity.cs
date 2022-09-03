namespace DDDStudies.Core.Domain
{
  public abstract class BaseEntity
  {
    public UniqueId Id { get; set; }

    protected BaseEntity(UniqueId id) { Id = id; }
  }
}

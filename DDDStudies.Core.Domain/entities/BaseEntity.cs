using DDDStudies.Core.Domain.ValueObjects;

namespace DDDStudies.Core.Domain.Entities
{
  public abstract class BaseEntity
  {
    public BaseEntity(UniqueId id) { Id = id; }

    public UniqueId Id { get; set; }
  }
}

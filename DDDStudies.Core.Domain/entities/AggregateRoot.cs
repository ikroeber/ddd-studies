using System;
using System.Collections.Generic;

namespace DDDStudies.Core.Domain
{
  public class AggregateRoot : BaseEntity
  {
    private readonly List<IDomainEvent> _events = new();

    public AggregateRoot(UniqueId id) : base(id) { }

    public IEnumerable<IDomainEvent> GetEvents()
    {
      return _events;
    }

    protected void AddEvent(IDomainEvent @event)
    {
      _events.Add(@event);
    }
  }

}

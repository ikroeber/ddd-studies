using System;
using System.Collections.Generic;

namespace DDDStudies.Core.Domain.ValueObjects
{
  public class UniqueId : ValueObject
  {
    public UniqueId(Guid id)
    {
      Id = id;
    }

    public Guid Id { get; }

    protected override IEnumerable<object> GetEqualityComponents()
    {
      yield return Id;
    }
  }
}

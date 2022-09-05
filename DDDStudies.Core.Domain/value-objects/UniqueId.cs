using System;
using System.Collections.Generic;

namespace DDDStudies.Core.Domain
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

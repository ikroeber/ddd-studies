using System;

namespace DDDStudies.Core.Domain
{
  public class UniqueId : ValueObject<Guid>
  {
    public UniqueId(Guid value) : base(value) { }
  }
}

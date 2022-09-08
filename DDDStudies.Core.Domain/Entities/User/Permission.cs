using DDDStudies.Core.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDStudies.Core.Domain.Entities
{
  public class Permission : BaseEntity
  {
    public Permission(UniqueId id, Type entityType, Description description) : base(id)
    {
      EntityType = entityType;
      Description = description;
    }

    public Type EntityType { get; set; }
    public Description Description { get; set; }
  }
}

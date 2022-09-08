using DDDStudies.Core.Domain.ValueObjects;
using System;
using System.Collections.Generic;

namespace DDDStudies.Core.Domain.Entities;

public class User : AggregateRoot
{
  public User(UniqueId id, Name name, IEnumerable<Permission> permissions) : base(id)
  {
    Name = name;
    Permissions = permissions;
  }

  public Name Name { get; set; }
  public IEnumerable<Permission> Permissions { get; }

  public static User Create(Name name)
  {
    return new User(new UniqueId(Guid.NewGuid()), name, new List<Permission>());
  }
}

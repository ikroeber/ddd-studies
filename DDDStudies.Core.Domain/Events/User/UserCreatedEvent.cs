using DDDStudies.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDStudies.Core.Domain.Events
{
  public class UserCreatedEvent : IDomainEvent
  {
    public UserCreatedEvent(User user)
    {
      User = user;
    }

    public User User { get; }
  }
}

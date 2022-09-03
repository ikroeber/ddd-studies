using DDDStudies.Core.Domain;

namespace MyNamespace
{
  public class User : AggregateRoot
  {
    public Name Name { get; set; }

    public User(UniqueId id, Name name) : base(id)
    {
      Name = name;
    }
  }
}

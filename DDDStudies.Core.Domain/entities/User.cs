namespace DDDStudies.Core.Domain
{
  public class User : AggregateRoot
  {
    public User(UniqueId id, Name name) : base(id)
    {
      Name = name;
    }

    public Name Name { get; set; }
  }
}

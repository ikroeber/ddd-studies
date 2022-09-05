using System;
using System.Collections.Generic;

namespace DDDStudies.Core.Domain
{
  public class Name : ValueObject
  {
    public Name(string firstName, string lastName)
    {
      FirstName = firstName;
      LastName = lastName;
    }

    public string FirstName { get; }
    public string LastName { get; }

    public string GetFullName() => $"{FirstName} {LastName}";
    public override string ToString() => $"{GetFullName()}";
    protected override IEnumerable<object> GetEqualityComponents()
    {
      yield return FirstName;
      yield return LastName;
    }
  }
}

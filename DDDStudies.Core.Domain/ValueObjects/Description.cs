using DDDStudies.Core.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDStudies.Core.Domain.ValueObjects
{
  public class Description : ValueObject
  {
    private string _description;

    public Description(string description)
    {
      if (string.IsNullOrWhiteSpace(description))
        throw new DomainException("Description can't be empty!");
      _description = description;
    }

    public override string ToString()
    {
      return _description;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
      yield return _description;
    }
  }
}

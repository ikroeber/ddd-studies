using System;
using System.Collections.Generic;
using System.Linq;

namespace DDDStudies.Core.Domain
{
  public abstract class ValueObject
  {
    protected static bool EqualOperator(ValueObject left, ValueObject right)
    {
      return ReferenceEquals(left, right)
        || (left is not null && right is not null && left.Equals(right));
    }

    protected static bool NotEqualOperator(ValueObject left, ValueObject right)
    {
      return !EqualOperator(left, right);
    }

    protected abstract IEnumerable<object> GetEqualityComponents();

    public override bool Equals(object obj)
    {
      if (obj.GetType() != GetType())
      {
        return false;
      }

      ValueObject other = (ValueObject)obj;

      return GetEqualityComponents().SequenceEqual(other.GetEqualityComponents());
    }

    public override int GetHashCode()
    {
      return GetEqualityComponents()
          .Select(x => x != null ? x.GetHashCode() : 0)
          .Aggregate((x, y) => x ^ y);
    }

    public static bool operator ==(ValueObject obj1, ValueObject obj2)
    {
      return EqualOperator(obj1, obj2);
    }

    public static bool operator !=(ValueObject obj1, ValueObject obj2)
    {
      return NotEqualOperator(obj1, obj2);
    }
  }
}

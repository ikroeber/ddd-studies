using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace DDDStudies.Core.Domain
{
  public abstract class ValueObject<T>
  {
    public T Value { get; private set; }

    public ValueObject(T value)
    {
      Value = value;
    }

    protected bool ValueIsEqual(T value)
    {
      return Value.Equals(value);
    }

    private bool TypesAreEqual(object obj)
    {
      if (obj == null) { return false; }
      if (obj.GetType() != typeof(ValueObject<T>)) { return false; }

      var objValue = ((ValueObject<T>)obj).Value;

      if (Value == null || objValue == null) { return false; }

      var value1 = ((ValueObject<T>)obj1).Value;
      var value2 = ((ValueObject<T>)obj2).Value;

      if (value1.GetType() == value2.GetType()) { return false; }

      return ValuesAreEqual();
    }

    public override bool Equals(object obj)
    {
      return ValueObjectEquals(this, obj);
    }

    public override string ToString()
    {
      return Value.ToString();
    }

    public override int GetHashCode()
    {
      return Value.GetHashCode();
    }

    public static bool operator ==(ValueObject<T> obj1, ValueObject<T> obj2)
    {
      if (ReferenceEquals(obj1, obj2)) { return true; }
      if (obj1 == null) { return false; }

      return ValueObjectEquals(obj1, obj2);
    }

    public static bool operator !=(ValueObject<T> obj1, ValueObject<T> obj2)
    {
      return !ValueObjectEquals(obj1, obj2);
    }
  }
}

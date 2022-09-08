using DDDStudies.Core.Domain.Exceptions;
using DDDStudies.Core.Domain.ValueObjects;
using Xunit.Sdk;

namespace DDDStudies.Core.Domain.Tests;

public class NameTests
{
  [Theory]
  [InlineData(null, null)]
  [InlineData("", "")]
  [InlineData("FirstName", "")]
  [InlineData("", "LastName")]
  public static void ThrowsExceptionIfBothNamesAreNotFilled(string firstName, string lastName)
  {
    var exception = Record.Exception(() => new Name(firstName, lastName));
    Assert.IsType<DomainException>(exception);
    Assert.Equal("Both first and last names must be provided!", exception.Message);
  }

  [Fact]
  public static void DoesNotThrowExceptionIfBothNamesAreFilled()
  {
    var exception = Record.Exception(() => new Name("FirstName", "LastName"));
    Assert.IsNotType<DomainException>(exception);
  }

  [Fact]
  public static void FullNameIsFirstNameConcatenatedToTheLastName()
  {
    Name name = new("FirstName", "LastName");
    Assert.Equal("FirstName LastName", name.GetFullName());
  }
}

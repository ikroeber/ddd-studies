namespace DDDStudies.Core.Domain.Tests;

public class NameTests
{
  [Theory]
  [InlineData(null, null)]
  [InlineData("", "")]
  [InlineData("FirstName", "")]
  [InlineData("", "LastName")]
  public void ShouldHaveBothFirstAndLastNames(string firstName, string lastName)
  {
    Assert.Throws<DomainException>(() => new Name(firstName, lastName));
  }

  [Fact]
  public void FullNameShouldBeFirstNameConcatenatedToTheLastName()
  {
    Name name = new("FirstName", "LastName");
    Assert.Equal("FirstName LastName", name.GetFullName());
  }
}

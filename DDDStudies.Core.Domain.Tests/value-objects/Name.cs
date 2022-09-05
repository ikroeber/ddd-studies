namespace DDDStudies.Core.Domain.Tests;

public class NameTests
{
  public Name name1, name2, name3;

  public NameTests()
  {
    name1 = new Name("Igor", "Kroeber");
    name2 = new Name("Igor", "Kroeber");
    name3 = new Name("Aurora", "Lyra");
  }

  [Fact]
  public void EqualsShouldCompareBothFirstAndLastNames()
  {
    Assert.StrictEqual(name1, name2);
    Assert.NotStrictEqual(name1, name3);
  }

  [Fact]
  public void EqualityOperatorsShouldUseFirstAndLastNameValues()
  {
    Assert.True(name1 == name2);
    Assert.False(name1 != name2);
    Assert.True(name1 != name3);
    Assert.False(name1 == name3);
  }

  [Fact]
  public void NullComparisonShouldNotThrowException()
  {
    Assert.False(name1 == null);
    Assert.False(null == name1);
    Assert.True(name1 != null);
    Assert.True(null != name1);
  }
}

namespace DDDStudies.Core.Domain.Tests;

public class UniqueIdTests
{
  public UniqueId id1;
  public UniqueId id2;
  public UniqueId id3;

  public UniqueIdTests()
  {
    id1 = new UniqueId(Guid.NewGuid());
    id2 = new UniqueId(Guid.Parse(id1.Id.ToString()));
    id3 = new UniqueId(Guid.NewGuid());
  }

  [Fact]
  public void EqualsShouldUseGUIDValue()
  {
    Assert.StrictEqual(id1, id2);
    Assert.NotStrictEqual(id1, id3);
  }

  [Fact]
  public void EqualityOperatorsShouldUseGUIDValue()
  {
    Assert.True(id1 == id2);
    Assert.False(id1 != id2);
    Assert.True(id1 != id3);
    Assert.False(id1 == id3);
  }

  [Fact]
  public void NullComparisonShouldNotThrowException()
  {
    Assert.False(id1 == null);
    Assert.False(null == id1);
    Assert.True(id1 != null);
    Assert.True(null != id1);
  }
}

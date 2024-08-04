using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03142Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03142();
        sut.SatisfiesConditions([[1, 0, 2], [1, 0, 2]]).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S03142();
        sut.SatisfiesConditions([[1, 1, 1], [0, 0, 0]]).Should().BeFalse();
    }

    [Test]
    public void T3()
    {
        var sut = new S03142();
        sut.SatisfiesConditions([[1], [2], [3]]).Should().BeFalse();
    }
}

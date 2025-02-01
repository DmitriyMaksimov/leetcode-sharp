using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02709Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02709();
        Assert.That(sut.CanTraverseAllPairs([2, 3, 6]), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S02709();
        Assert.That(sut.CanTraverseAllPairs([3, 9, 5]), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S02709();
        Assert.That(sut.CanTraverseAllPairs([4, 3, 12, 8]), Is.True);
    }
}

using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02860Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02860();
        Assert.That(sut.CountWays([1, 1]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S02860();
        Assert.That(sut.CountWays([6, 0, 3, 3, 6, 7, 2, 7]), Is.EqualTo(3));
    }
}

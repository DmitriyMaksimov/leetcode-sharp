using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01509Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01509();
        Assert.That(sut.MinDifference([5, 3, 2, 4]), Is.EqualTo(0));
    }

    [Test]
    public void T2()
    {
        var sut = new S01509();
        Assert.That(sut.MinDifference([1, 5, 0, 10, 14]), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S01509();
        Assert.That(sut.MinDifference([3, 100, 20]), Is.EqualTo(0));
    }
}
using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02059Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02059();
        Assert.That(sut.MinimumOperations([2, 4, 12], 2, 12), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S02059();
        Assert.That(sut.MinimumOperations([3, 5, 7], 0, -4), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S02059();
        Assert.That(sut.MinimumOperations([2, 8, 16], 0, 1), Is.EqualTo(-1));
    }
}

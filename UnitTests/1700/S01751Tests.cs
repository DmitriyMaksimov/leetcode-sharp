using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01751Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01751();
        Assert.That(sut.MaxValue([[1, 2, 4], [3, 4, 3], [2, 3, 1]], 2), Is.EqualTo(7));
    }

    [Test]
    public void T2()
    {
        var sut = new S01751();
        Assert.That(sut.MaxValue([[1, 2, 4], [3, 4, 3], [2, 3, 10]], 2), Is.EqualTo(10));
    }

    [Test]
    public void T3()
    {
        var sut = new S01751();
        Assert.That(sut.MaxValue([[1, 1, 1], [2, 2, 2], [3, 3, 3], [4, 4, 4]], 3), Is.EqualTo(9));
    }
}
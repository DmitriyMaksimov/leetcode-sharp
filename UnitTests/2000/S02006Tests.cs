using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02006Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02006();
        Assert.That(sut.CountKDifference([1, 2, 2, 1], 1), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S02006();
        Assert.That(sut.CountKDifference([1, 3], 3), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S02006();
        Assert.That(sut.CountKDifference([3, 2, 1, 5, 4], 2), Is.EqualTo(3));
    }
}
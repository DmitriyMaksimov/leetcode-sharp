using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01508Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01508();
        Assert.That(sut.RangeSum([1, 2, 3, 4], 4, 1, 5), Is.EqualTo(13));
    }

    [Test]
    public void T2()
    {
        var sut = new S01508();
        Assert.That(sut.RangeSum([1, 2, 3, 4], 4, 3, 4), Is.EqualTo(6));
    }

    [Test]
    public void T3()
    {
        var sut = new S01508();
        Assert.That(sut.RangeSum([1, 2, 3, 4], 4, 1, 10), Is.EqualTo(50));
    }
}

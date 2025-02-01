using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02104Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02104();
        Assert.That(sut.SubArrayRanges([1, 2, 3]), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S02104();
        Assert.That(sut.SubArrayRanges([1, 3, 3]), Is.EqualTo(4));
    }

    [Test]
    public void T3()
    {
        var sut = new S02104();
        Assert.That(sut.SubArrayRanges([4, -2, -3, 4, 1]), Is.EqualTo(59));
    }
}

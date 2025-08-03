using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00908Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00908();
        Assert.That(sut.SmallestRangeI([1], 0), Is.EqualTo(0));
    }

    [Test]
    public void T2()
    {
        var sut = new S00908();
        Assert.That(sut.SmallestRangeI([0, 10], 2), Is.EqualTo(6));
    }

    [Test]
    public void T3()
    {
        var sut = new S00908();
        Assert.That(sut.SmallestRangeI([1, 3, 6], 3), Is.EqualTo(0));
    }
}
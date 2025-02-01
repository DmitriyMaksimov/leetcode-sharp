using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00440Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00440();
        Assert.That(sut.FindKthNumber(13, 2), Is.EqualTo(10));
    }

    [Test]
    public void T2()
    {
        var sut = new S00440();
        Assert.That(sut.FindKthNumber(1, 1), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S00440();
        Assert.That(sut.FindKthNumber(681692778, 351251360), Is.EqualTo(416126219));
    }

    [Test]
    public void T4()
    {
        var sut = new S00440();
        Assert.That(sut.FindKthNumber(304089173, 87099045), Is.EqualTo(178389137));
    }
}

using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00788Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00788();
        Assert.That(sut.RotatedDigits(10), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S00788();
        Assert.That(sut.RotatedDigits(1), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S00788();
        Assert.That(sut.RotatedDigits(2), Is.EqualTo(1));
    }
}

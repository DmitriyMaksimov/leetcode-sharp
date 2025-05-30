using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S00738))]
public class S00738Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00738();
        Assert.That(sut.MonotoneIncreasingDigits(10), Is.EqualTo(9));
    }

    [Test]
    public void T2()
    {
        var sut = new S00738();
        Assert.That(sut.MonotoneIncreasingDigits(1234), Is.EqualTo(1234));
    }

    [Test]
    public void T3()
    {
        var sut = new S00738();
        Assert.That(sut.MonotoneIncreasingDigits(332), Is.EqualTo(299));
    }
}

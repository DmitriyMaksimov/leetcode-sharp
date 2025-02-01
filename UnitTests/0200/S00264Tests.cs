using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00264Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00264();
        Assert.That(sut.NthUglyNumber(10), Is.EqualTo(12));
    }

    [Test]
    public void T2()
    {
        var sut = new S00264();
        Assert.That(sut.NthUglyNumber(1), Is.EqualTo(1));
    }
}
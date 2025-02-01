using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00069Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00069();
        Assert.That(sut.MySqrt(4), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S00069();
        Assert.That(sut.MySqrt(8), Is.EqualTo(2));
    }
}
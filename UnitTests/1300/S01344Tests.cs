using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01344Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01344();
        Assert.That(sut.AngleClock(12, 30), Is.EqualTo(165));
    }

    [Test]
    public void T2()
    {
        var sut = new S01344();
        Assert.That(sut.AngleClock(3, 30), Is.EqualTo(75));
    }

    [Test]
    public void T3()
    {
        var sut = new S01344();
        Assert.That(sut.AngleClock(3, 15), Is.EqualTo(7.5));
    }
}

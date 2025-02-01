using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01247Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01247();
        Assert.That(sut.MinimumSwap("xx", "yy"), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S01247();
        Assert.That(sut.MinimumSwap("xy", "yx"), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S01247();
        Assert.That(sut.MinimumSwap("xx", "xy"), Is.EqualTo(-1));
    }
}

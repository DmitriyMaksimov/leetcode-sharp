using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02483Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02483();
        Assert.That(sut.BestClosingTime("YYNY"), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S02483();
        Assert.That(sut.BestClosingTime("NNNNN"), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S02483();
        Assert.That(sut.BestClosingTime("YYYY"), Is.EqualTo(4));
    }
}
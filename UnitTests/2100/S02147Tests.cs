using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02147Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02147();
        Assert.That(sut.NumberOfWays("SSPPSPS"), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S02147();
        Assert.That(sut.NumberOfWays("PPSPSP"), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S02147();
        Assert.That(sut.NumberOfWays("S"), Is.EqualTo(0));
    }
}
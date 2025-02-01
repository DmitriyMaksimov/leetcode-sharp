using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01529Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01529();
        Assert.That(sut.MinFlips("10111"), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S01529();
        Assert.That(sut.MinFlips("101"), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S01529();
        Assert.That(sut.MinFlips("00000"), Is.EqualTo(0));
    }
}
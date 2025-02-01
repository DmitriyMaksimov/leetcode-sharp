using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01624Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01624();
        Assert.That(sut.MaxLengthBetweenEqualCharacters("aa"), Is.EqualTo(0));
    }

    [Test]
    public void T2()
    {
        var sut = new S01624();
        Assert.That(sut.MaxLengthBetweenEqualCharacters("abca"), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S01624();
        Assert.That(sut.MaxLengthBetweenEqualCharacters("cbzxy"), Is.EqualTo(-1));
    }
}
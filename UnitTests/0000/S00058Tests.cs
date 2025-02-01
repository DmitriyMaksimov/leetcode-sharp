using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00058Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00058();
        Assert.That(sut.LengthOfLastWord("Hello World"), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S00058();
        Assert.That(sut.LengthOfLastWord("   fly me   to   the moon  "), Is.EqualTo(4));
    }

    [Test]
    public void T3()
    {
        var sut = new S00058();
        Assert.That(sut.LengthOfLastWord("luffy is still joyboy"), Is.EqualTo(6));
    }

    [Test]
    public void T4()
    {
        var sut = new S00058();
        Assert.That(sut.LengthOfLastWord("test  "), Is.EqualTo(4));
    }
}
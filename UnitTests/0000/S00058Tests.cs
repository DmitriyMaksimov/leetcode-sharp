using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00058Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00058();
        sut.LengthOfLastWord("Hello World").Should().Be(5);
    }

    [Test]
    public void T2()
    {
        var sut = new S00058();
        sut.LengthOfLastWord("   fly me   to   the moon  ").Should().Be(4);
    }

    [Test]
    public void T3()
    {
        var sut = new S00058();
        sut.LengthOfLastWord("luffy is still joyboy").Should().Be(6);
    }

    [Test]
    public void T4()
    {
        var sut = new S00058();
        sut.LengthOfLastWord("test  ").Should().Be(4);
    }
}
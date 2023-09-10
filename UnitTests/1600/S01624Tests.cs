using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01624Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01624();
        sut.MaxLengthBetweenEqualCharacters("aa").Should().Be(0);
    }

    [Test]
    public void T2()
    {
        var sut = new S01624();
        sut.MaxLengthBetweenEqualCharacters("abca").Should().Be(2);
    }

    [Test]
    public void T3()
    {
        var sut = new S01624();
        sut.MaxLengthBetweenEqualCharacters("cbzxy").Should().Be(-1);
    }
}
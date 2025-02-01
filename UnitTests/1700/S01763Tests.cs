using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01763Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01763();
        Assert.That(sut.LongestNiceSubstring("YazaAay"), Is.EqualTo("aAa"));
    }

    [Test]
    public void T2()
    {
        var sut = new S01763();
        Assert.That(sut.LongestNiceSubstring("Bb"), Is.EqualTo("Bb"));
    }

    [Test]
    public void T3()
    {
        var sut = new S01763();
        Assert.That(sut.LongestNiceSubstring("c"), Is.EqualTo(""));
    }
}
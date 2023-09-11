using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01763Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01763();
        sut.LongestNiceSubstring("YazaAay").Should().Be("aAa");
    }

    [Test]
    public void T2()
    {
        var sut = new S01763();
        sut.LongestNiceSubstring("Bb").Should().Be("Bb");
    }

    [Test]
    public void T3()
    {
        var sut = new S01763();
        sut.LongestNiceSubstring("c").Should().Be("");
    }
}
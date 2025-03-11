using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01839Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01839();
        Assert.That(sut.LongestBeautifulSubstring("aeiaaioaaaaeiiiiouuuooaauuaeiu"), Is.EqualTo(13));
    }

    [Test]
    public void T2()
    {
        var sut = new S01839();
        Assert.That(sut.LongestBeautifulSubstring("aeeeiiiioooauuuaeiou"), Is.EqualTo(5));
    }

    [Test]
    public void T3()
    {
        var sut = new S01839();
        Assert.That(sut.LongestBeautifulSubstring("a"), Is.EqualTo(0));
    }
}

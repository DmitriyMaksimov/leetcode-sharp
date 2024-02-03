using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01910Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01910();
        sut.RemoveOccurrences("daabcbaabcbc", "abc").Should().Be("dab");
    }

    [Test]
    public void T2()
    {
        var sut = new S01910();
        sut.RemoveOccurrences("axxxxyyyyb", "xy").Should().Be("ab");
    }

    [Test]
    public void T3()
    {
        var sut = new S01910();
        sut.RemoveOccurrences("aabababa", "aba").Should().Be("ba");
    }
}
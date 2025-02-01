using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01910Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01910();
        Assert.That(sut.RemoveOccurrences("daabcbaabcbc", "abc"), Is.EqualTo("dab"));
    }

    [Test]
    public void T2()
    {
        var sut = new S01910();
        Assert.That(sut.RemoveOccurrences("axxxxyyyyb", "xy"), Is.EqualTo("ab"));
    }

    [Test]
    public void T3()
    {
        var sut = new S01910();
        Assert.That(sut.RemoveOccurrences("aabababa", "aba"), Is.EqualTo("ba"));
    }
}
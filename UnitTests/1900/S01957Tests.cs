using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01957Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01957();
        Assert.That(sut.MakeFancyString("leeetcode"), Is.EqualTo("leetcode"));
    }

    [Test]
    public void T2()
    {
        var sut = new S01957();
        Assert.That(sut.MakeFancyString("aaabaaaa"), Is.EqualTo("aabaa"));
    }

    [Test]
    public void T3()
    {
        var sut = new S01957();
        Assert.That(sut.MakeFancyString("aab"), Is.EqualTo("aab"));
    }
}
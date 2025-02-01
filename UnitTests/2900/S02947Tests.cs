using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02947Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02947();
        Assert.That(sut.BeautifulSubstrings("baeyh", 2), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S02947();
        Assert.That(sut.BeautifulSubstrings("abba", 1), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S02947();
        Assert.That(sut.BeautifulSubstrings("bcdf", 1), Is.EqualTo(0));
    }
}

using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02287Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02287();
        Assert.That(sut.RearrangeCharacters("ilovecodingonleetcode", "code"), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S02287();
        Assert.That(sut.RearrangeCharacters("abcba", "abc"), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S02287();
        Assert.That(sut.RearrangeCharacters("abbaccaddaeea", "aaaaa"), Is.EqualTo(1));
    }
}
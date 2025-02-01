using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03042Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03042();
        Assert.That(sut.CountPrefixSuffixPairs(["a", "aba", "ababa", "aa"]), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S03042();
        Assert.That(sut.CountPrefixSuffixPairs(["pa", "papa", "ma", "mama"]), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S03042();
        Assert.That(sut.CountPrefixSuffixPairs(["abab", "ab"]), Is.EqualTo(0));
    }
}
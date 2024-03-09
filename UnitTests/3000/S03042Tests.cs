using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03042Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03042();
        sut.CountPrefixSuffixPairs(["a", "aba", "ababa", "aa"]).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S03042();
        sut.CountPrefixSuffixPairs(["pa", "papa", "ma", "mama"]).Should().Be(2);
    }

    [Test]
    public void T3()
    {
        var sut = new S03042();
        sut.CountPrefixSuffixPairs(["abab", "ab"]).Should().Be(0);
    }
}
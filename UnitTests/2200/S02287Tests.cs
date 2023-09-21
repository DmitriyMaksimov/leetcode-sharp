using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02287Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02287();
        sut.RearrangeCharacters("ilovecodingonleetcode", "code").Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S02287();
        sut.RearrangeCharacters("abcba", "abc").Should().Be(1);
    }

    [Test]
    public void T3()
    {
        var sut = new S02287();
        sut.RearrangeCharacters("abbaccaddaeea", "aaaaa").Should().Be(1);
    }
}
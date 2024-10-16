using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02947Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02947();
        sut.BeautifulSubstrings("baeyh", 2).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S02947();
        sut.BeautifulSubstrings("abba", 1).Should().Be(3);
    }

    [Test]
    public void T3()
    {
        var sut = new S02947();
        sut.BeautifulSubstrings("bcdf", 1).Should().Be(0);
    }
}

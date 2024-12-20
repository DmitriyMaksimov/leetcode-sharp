using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02767Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02767();
        sut.MinimumBeautifulSubstrings("1011").Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S02767();
        sut.MinimumBeautifulSubstrings("111").Should().Be(3);
    }

    [Test]
    public void T3()
    {
        var sut = new S02767();
        sut.MinimumBeautifulSubstrings("0").Should().Be(-1);
    }
}

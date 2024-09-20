using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00214Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00214();
        sut.ShortestPalindrome("aacecaaa").Should().Be("aaacecaaa");
    }

    [Test]
    public void T2()
    {
        var sut = new S00214();
        sut.ShortestPalindrome("abcd").Should().Be("dcbabcd");
    }
}

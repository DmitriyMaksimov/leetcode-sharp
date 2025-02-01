using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00214Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00214();
        Assert.That(sut.ShortestPalindrome("aacecaaa"), Is.EqualTo("aaacecaaa"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00214();
        Assert.That(sut.ShortestPalindrome("abcd"), Is.EqualTo("dcbabcd"));
    }
}

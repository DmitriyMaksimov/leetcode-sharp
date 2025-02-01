using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00005Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00005();
        Assert.That(sut.LongestPalindrome("babad"), Is.EqualTo("bab"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00005();
        Assert.That(sut.LongestPalindrome("cbbd"), Is.EqualTo("bb"));
    }
}
using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00409Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00409();
        Assert.That(sut.LongestPalindrome("abccccdd"), Is.EqualTo(7));
    }

    [Test]
    public void T2()
    {
        var sut = new S00409();
        Assert.That(sut.LongestPalindrome("a"), Is.EqualTo(1));
    }
}
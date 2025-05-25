using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02131))]
public class S02131Test
{
    [Test]
    public void T1()
    {
        var sut = new S02131();
        Assert.That(sut.LongestPalindrome(["lc", "cl", "gg"]), Is.EqualTo(6));
    }

    [Test]
    public void T2()
    {
        var sut = new S02131();
        Assert.That(sut.LongestPalindrome(["ab", "ty", "yt", "lc", "cl", "ab"]), Is.EqualTo(8));
    }

    [Test]
    public void T3()
    {
        var sut = new S02131();
        Assert.That(sut.LongestPalindrome(["cc", "ll", "xx"]), Is.EqualTo(2));
    }
}

using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03518))]
public class S03518Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03518();
        Assert.That(sut.SmallestPalindrome("abba", 2), Is.EqualTo("baab"));
    }

    [Test]
    public void T2()
    {
        var sut = new S03518();
        Assert.That(sut.SmallestPalindrome("aa", 2), Is.EqualTo(""));
    }

    [Test]
    public void T3()
    {
        var sut = new S03518();
        Assert.That(sut.SmallestPalindrome("bacab", 1), Is.EqualTo("abcba"));
    }
}
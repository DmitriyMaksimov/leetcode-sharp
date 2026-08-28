using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03734))]
public class S03734Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03734();
        Assert.That(sut.LexPalindromicPermutation("baba", "abba"), Is.EqualTo("baab"));
    }

    [Test]
    public void T2()
    {
        var sut = new S03734();
        Assert.That(sut.LexPalindromicPermutation("baba", "bbaa"), Is.EqualTo(""));
    }

    [Test]
    public void T3()
    {
        var sut = new S03734();
        Assert.That(sut.LexPalindromicPermutation("abc", "abb"), Is.EqualTo(""));
    }
}
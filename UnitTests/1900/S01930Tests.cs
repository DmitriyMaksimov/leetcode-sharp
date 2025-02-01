using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01930Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01930();
        Assert.That(sut.CountPalindromicSubsequence("aabca"), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S01930();
        Assert.That(sut.CountPalindromicSubsequence("adc"), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S01930();
        Assert.That(sut.CountPalindromicSubsequence("bbcbaba"), Is.EqualTo(4));
    }
}
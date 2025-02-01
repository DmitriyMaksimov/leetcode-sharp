using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01143Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01143();

        Assert.That(sut.LongestCommonSubsequence("abcde", "ace"), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S01143();

        Assert.That(sut.LongestCommonSubsequence("abc", "abc"), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S01143();

        Assert.That(sut.LongestCommonSubsequence("abc", "def"), Is.EqualTo(0));
    }

    [Test]
    public void T4()
    {
        var sut = new S01143();

        Assert.That(sut.LongestCommonSubsequence("nematode knowledge", "empty bottle"), Is.EqualTo(7));
    }

    [Test]
    public void T5()
    {
        var sut = new S01143();

        Assert.That(sut.LongestCommonSubsequence("Let's try to use some longer strings to check performance", "Performance is a tricky one - it works well on small data sets, but could be painfully slow on large ones"), Is.EqualTo(31));
    }
}
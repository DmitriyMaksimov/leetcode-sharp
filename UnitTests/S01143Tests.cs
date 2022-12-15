using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01143Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01143();

        sut.LongestCommonSubsequence("abcde", "ace").Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S01143();

        sut.LongestCommonSubsequence("abc", "abc").Should().Be(3);
    }

    [Test]
    public void T3()
    {
        var sut = new S01143();

        sut.LongestCommonSubsequence("abc", "def").Should().Be(0);
    }

    [Test]
    public void T4()
    {
        var sut = new S01143();

        sut.LongestCommonSubsequence("nematode knowledge", "empty bottle").Should().Be(7);
    }

    [Test]
    public void T5()
    {
        var sut = new S01143();

        sut.LongestCommonSubsequence("Let's try to use some longer strings to check performance", "Performance is a tricky one - it works well on small data sets, but could be painfully slow on large ones").Should().Be(31);
    }
}
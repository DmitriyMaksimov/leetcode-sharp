using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01930Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01930();
        sut.CountPalindromicSubsequence("aabca").Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S01930();
        sut.CountPalindromicSubsequence("adc").Should().Be(0);
    }

    [Test]
    public void T3()
    {
        var sut = new S01930();
        sut.CountPalindromicSubsequence("bbcbaba").Should().Be(4);
    }
}
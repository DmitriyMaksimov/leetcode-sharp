using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00516Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00516();
        sut.LongestPalindromeSubseq("bbbab").Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S00516();
        sut.LongestPalindromeSubseq("cbbd").Should().Be(2);
    }
}
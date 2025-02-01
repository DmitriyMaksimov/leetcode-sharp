using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00516Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00516();
        Assert.That(sut.LongestPalindromeSubseq("bbbab"), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S00516();
        Assert.That(sut.LongestPalindromeSubseq("cbbd"), Is.EqualTo(2));
    }
}
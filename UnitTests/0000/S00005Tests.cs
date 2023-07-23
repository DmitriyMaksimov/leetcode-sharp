using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00005Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00005();
        sut.LongestPalindrome("babad").Should().Be("bab");
    }

    [Test]
    public void T2()
    {
        var sut = new S00005();
        sut.LongestPalindrome("cbbd").Should().Be("bb");
    }
}
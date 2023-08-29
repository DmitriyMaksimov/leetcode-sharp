using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00409Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00409();
        sut.LongestPalindrome("abccccdd").Should().Be(7);
    }

    [Test]
    public void T2()
    {
        var sut = new S00409();
        sut.LongestPalindrome("a").Should().Be(1);
    }
}
using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01328Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01328();
        sut.BreakPalindrome("abccba").Should().Be("aaccba");
    }

    [Test]
    public void T2()
    {
        var sut = new S01328();
        sut.BreakPalindrome("a").Should().Be("");
    }
}

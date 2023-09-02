using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00680Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00680();
        sut.ValidPalindrome("aba").Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S00680();
        sut.ValidPalindrome("abca").Should().BeTrue();
    }

    [Test]
    public void T3()
    {
        var sut = new S00680();
        sut.ValidPalindrome("abc").Should().BeFalse();
    }
}
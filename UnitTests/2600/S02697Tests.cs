using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02697Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02697();
        sut.MakeSmallestPalindrome("egcfe").Should().Be("efcfe");
    }
    
    [Test]
    public void T2()
    {
        var sut = new S02697();
        sut.MakeSmallestPalindrome("abcd").Should().Be("abba");
    }

    [Test]
    public void T3()
    {
        var sut = new S02697();
        sut.MakeSmallestPalindrome("seven").Should().Be("neven");
    }
}
using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02697Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02697();
        Assert.That(sut.MakeSmallestPalindrome("egcfe"), Is.EqualTo("efcfe"));
    }
    
    [Test]
    public void T2()
    {
        var sut = new S02697();
        Assert.That(sut.MakeSmallestPalindrome("abcd"), Is.EqualTo("abba"));
    }

    [Test]
    public void T3()
    {
        var sut = new S02697();
        Assert.That(sut.MakeSmallestPalindrome("seven"), Is.EqualTo("neven"));
    }
}
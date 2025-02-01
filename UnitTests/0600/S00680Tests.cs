using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00680Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00680();
        Assert.That(sut.ValidPalindrome("aba"), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S00680();
        Assert.That(sut.ValidPalindrome("abca"), Is.True);
    }

    [Test]
    public void T3()
    {
        var sut = new S00680();
        Assert.That(sut.ValidPalindrome("abc"), Is.False);
    }
}

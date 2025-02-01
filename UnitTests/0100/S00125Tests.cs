using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00125Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00125();
        Assert.That(sut.IsPalindrome("A man, a plan, a canal: Panama"), Is.True);
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00125();
        Assert.That(sut.IsPalindrome("race a car"), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S00125();
        Assert.That(sut.IsPalindrome(" "), Is.True);
    }

}

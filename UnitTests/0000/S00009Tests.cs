using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00009Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00009();
        Assert.That(sut.IsPalindrome(121), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S00009();
        Assert.That(sut.IsPalindrome(-121), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S00009();
        Assert.That(sut.IsPalindrome(10), Is.False);
    }
}

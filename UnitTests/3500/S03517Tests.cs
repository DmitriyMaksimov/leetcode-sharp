using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03517Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03517();
        Assert.That(sut.SmallestPalindrome("z"), Is.EqualTo("z"));
    }

    [Test]
    public void T2()
    {
        var sut = new S03517();
        Assert.That(sut.SmallestPalindrome("babab"), Is.EqualTo("abbba"));
    }

    [Test]
    public void T3()
    {
        var sut = new S03517();
        Assert.That(sut.SmallestPalindrome("daccad"), Is.EqualTo("acddca"));
    }
}

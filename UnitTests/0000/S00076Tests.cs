using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00076Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00076();
        Assert.That(sut.MinWindow("ADOBECODEBANC", "ABC"), Is.EqualTo("BANC"));
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00076();
        Assert.That(sut.MinWindow("a", "a"), Is.EqualTo("a"));
    }

    [Test]
    public void T3()
    {
        var sut = new S00076();
        Assert.That(sut.MinWindow("a", "aa"), Is.EqualTo(""));
    }

}
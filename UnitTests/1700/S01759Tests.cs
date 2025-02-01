using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01759Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01759();
        Assert.That(sut.CountHomogenous("abbcccaa"), Is.EqualTo(13));
    }

    [Test]
    public void T2()
    {
        var sut = new S01759();
        Assert.That(sut.CountHomogenous("xy"), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S01759();
        Assert.That(sut.CountHomogenous("zzzzz"), Is.EqualTo(15));
    }
}
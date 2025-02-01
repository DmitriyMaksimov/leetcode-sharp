using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01269Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01269();
        Assert.That(sut.NumWays(3, 2), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S01269();
        Assert.That(sut.NumWays(2, 4), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S01269();
        Assert.That(sut.NumWays(4, 2), Is.EqualTo(8));
    }
}
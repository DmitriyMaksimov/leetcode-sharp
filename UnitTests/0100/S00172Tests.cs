using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00172Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00172();
        Assert.That(sut.TrailingZeroes(3), Is.EqualTo(0));
    }

    [Test]
    public void T2()
    {
        var sut = new S00172();
        Assert.That(sut.TrailingZeroes(5), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S00172();
        Assert.That(sut.TrailingZeroes(0), Is.EqualTo(0));
    }
}
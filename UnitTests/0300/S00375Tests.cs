using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00375Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00375();
        Assert.That(sut.GetMoneyAmount(10), Is.EqualTo(16));
    }

    [Test]
    public void T2()
    {
        var sut = new S00375();
        Assert.That(sut.GetMoneyAmount(1), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S00375();
        Assert.That(sut.GetMoneyAmount(2), Is.EqualTo(1));
    }
}

using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00201Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00201();
        Assert.That(sut.RangeBitwiseAnd(5, 7), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S00201();
        Assert.That(sut.RangeBitwiseAnd(0, 0), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S00201();
        Assert.That(sut.RangeBitwiseAnd(1, 2147483647), Is.EqualTo(0));
    }
}
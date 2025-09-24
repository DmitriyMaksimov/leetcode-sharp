using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S00166))]
public class S00166Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00166();
        Assert.That(sut.FractionToDecimal(1, 2), Is.EqualTo("0.5"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00166();
        Assert.That(sut.FractionToDecimal(2, 1), Is.EqualTo("2"));
    }

    [Test]
    public void T3()
    {
        var sut = new S00166();
        Assert.That(sut.FractionToDecimal(4, 333), Is.EqualTo("0.(012)"));
    }
}
using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02806Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02806();
        Assert.That(sut.AccountBalanceAfterPurchase(9), Is.EqualTo(90));
    }

    [Test]
    public void T2()
    {
        var sut = new S02806();
        Assert.That(sut.AccountBalanceAfterPurchase(15), Is.EqualTo(80));
    }
}
using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02806Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02806();
        sut.AccountBalanceAfterPurchase(9).Should().Be(90);
    }

    [Test]
    public void T2()
    {
        var sut = new S02806();
        sut.AccountBalanceAfterPurchase(15).Should().Be(80);
    }
}
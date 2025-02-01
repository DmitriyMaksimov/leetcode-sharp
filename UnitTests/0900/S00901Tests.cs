using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00901Tests
{
    [Test]
    public void T1()
    {
        var stockSpanner = new S00901.StockSpanner();
        Assert.That(stockSpanner.Next(100), Is.EqualTo(1)); // return 1
        Assert.That(stockSpanner.Next(80), Is.EqualTo(1)); // return 1
        Assert.That(stockSpanner.Next(60), Is.EqualTo(1)); // return 1
        Assert.That(stockSpanner.Next(70), Is.EqualTo(2)); // return 2
        Assert.That(stockSpanner.Next(60), Is.EqualTo(1)); // return 1
        Assert.That(stockSpanner.Next(75), Is.EqualTo(4)); // return 4, because the last 4 prices (including today's price of 75)
                                              // were less than or equal to today's price.
        Assert.That(stockSpanner.Next(85), Is.EqualTo(6)); // return 6
    }
}
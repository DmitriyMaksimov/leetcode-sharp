using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00901Tests
{
    [Test]
    public void T1()
    {
        var stockSpanner = new S00901.StockSpanner();
        stockSpanner.Next(100).Should().Be(1); // return 1
        stockSpanner.Next(80).Should().Be(1); // return 1
        stockSpanner.Next(60).Should().Be(1); // return 1
        stockSpanner.Next(70).Should().Be(2); // return 2
        stockSpanner.Next(60).Should().Be(1); // return 1
        stockSpanner.Next(75).Should().Be(4); // return 4, because the last 4 prices (including today's price of 75)
                                              // were less than or equal to today's price.
        stockSpanner.Next(85).Should().Be(6); // return 6
    }
}
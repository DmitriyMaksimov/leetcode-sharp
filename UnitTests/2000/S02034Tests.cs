using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02034Tests
{
    [Test]
    public void T1()
    {
        var stockPrice = new S02034.StockPrice();
        stockPrice.Update(1, 10); // Timestamps are [1] with corresponding prices [10].
        stockPrice.Update(2, 5); // Timestamps are [1,2] with corresponding prices [10,5].
        Assert.That(stockPrice.Current(), Is.EqualTo(5)); // return 5, the latest timestamp is 2 with the price being 5.
        Assert.That(stockPrice.Maximum(), Is.EqualTo(10)); // return 10, the maximum price is 10 at timestamp 1.
        stockPrice.Update(1, 3); // The previous timestamp 1 had the wrong price, so it is updated to 3. Timestamps are [1,2] with corresponding prices [3,5].
        Assert.That(stockPrice.Maximum(), Is.EqualTo(5)); // return 5, the maximum price is 5 after the correction.
        stockPrice.Update(4, 2); // Timestamps are [1,2,4] with corresponding prices [3,5,2].
        Assert.That(stockPrice.Minimum(), Is.EqualTo(2)); // return 2, the minimum price is 2 at timestamp 4.
    }
}

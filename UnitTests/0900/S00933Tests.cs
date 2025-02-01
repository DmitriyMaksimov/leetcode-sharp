using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00933Tests
{
    [Test]
    public void T1()
    {
        var recentCounter = new S00933.RecentCounter();
        Assert.That(recentCounter.Ping(1), Is.EqualTo(1)); // requests = [1], range is [-2999,1], return 1
        Assert.That(recentCounter.Ping(100), Is.EqualTo(2)); // requests = [1, 100], range is [-2900,100], return 2
        Assert.That(recentCounter.Ping(3001), Is.EqualTo(3)); // requests = [1, 100, 3001], range is [1,3001], return 3
        Assert.That(recentCounter.Ping(3002), Is.EqualTo(3)); // requests = [1, 100, 3001, 3002], range is [2,3002], return 3
    }
}
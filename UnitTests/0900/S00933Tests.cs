using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00933Tests
{
    [Test]
    public void T1()
    {
        var recentCounter = new S00933.RecentCounter();
        recentCounter.Ping(1).Should().Be(1); // requests = [1], range is [-2999,1], return 1
        recentCounter.Ping(100).Should().Be(2); // requests = [1, 100], range is [-2900,100], return 2
        recentCounter.Ping(3001).Should().Be(3); // requests = [1, 100, 3001], range is [1,3001], return 3
        recentCounter.Ping(3002).Should().Be(3); // requests = [1, 100, 3001, 3002], range is [2,3002], return 3
    }
}
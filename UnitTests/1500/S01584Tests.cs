using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01584Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01584();
        sut.MinCostConnectPoints(new[] {new[] {0, 0}, new[] {2, 2}, new[] {3, 10}, new[] {5, 2}, new[] {7, 0}}).Should()
            .Be(20);
    }

    [Test]
    public void T2()
    {
        var sut = new S01584();
        sut.MinCostConnectPoints(new[] {new[] {3, 12}, new[] {-2, 5}, new[] {-4, 1}}).Should().Be(18);
    }
}
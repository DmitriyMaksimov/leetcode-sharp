using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01584Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01584();
        Assert.That(sut.MinCostConnectPoints([[0, 0], [2, 2], [3, 10], [5, 2], [7, 0]]), Is.EqualTo(20));
    }

    [Test]
    public void T2()
    {
        var sut = new S01584();
        Assert.That(sut.MinCostConnectPoints([[3, 12], [-2, 5], [-4, 1]]), Is.EqualTo(18));
    }
}
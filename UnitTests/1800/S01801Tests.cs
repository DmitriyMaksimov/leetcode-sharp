using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01801Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01801();
        sut.GetNumberOfBacklogOrders([[10, 5, 0], [15, 2, 1], [25, 1, 1], [30, 4, 0]]).Should().Be(6);
    }

    [Test]
    public void T2()
    {
        var sut = new S01801();
        sut.GetNumberOfBacklogOrders([[7, 1000000000, 1], [15, 3, 0], [5, 999999995, 0], [5, 1, 1]]).Should().Be(999999984);
    }
}

using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01184Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01184();
        sut.DistanceBetweenBusStops(new[] {1, 2, 3, 4}, 0, 1).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S01184();
        sut.DistanceBetweenBusStops(new[] {1, 2, 3, 4}, 0, 2).Should().Be(3);
    }

    [Test]
    public void T3()
    {
        var sut = new S01184();
        sut.DistanceBetweenBusStops(new[] {1, 2, 3, 4}, 0, 3).Should().Be(4);
    }
}
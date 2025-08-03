using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01184Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01184();
        Assert.That(sut.DistanceBetweenBusStops([1, 2, 3, 4], 0, 1), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S01184();
        Assert.That(sut.DistanceBetweenBusStops([1, 2, 3, 4], 0, 2), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S01184();
        Assert.That(sut.DistanceBetweenBusStops([1, 2, 3, 4], 0, 3), Is.EqualTo(4));
    }
}
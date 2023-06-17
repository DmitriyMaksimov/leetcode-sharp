using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02651Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02651();
        sut.FindDelayedArrivalTime(15, 5).Should().Be(20);
    }

    [Test]
    public void T2()
    {
        var sut = new S02651();
        sut.FindDelayedArrivalTime(13, 11).Should().Be(0);
    }
}
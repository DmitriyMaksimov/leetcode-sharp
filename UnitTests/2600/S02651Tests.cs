using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02651Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02651();
        Assert.That(sut.FindDelayedArrivalTime(15, 5), Is.EqualTo(20));
    }

    [Test]
    public void T2()
    {
        var sut = new S02651();
        Assert.That(sut.FindDelayedArrivalTime(13, 11), Is.EqualTo(0));
    }
}
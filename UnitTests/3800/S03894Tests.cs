using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03894))]
public class S03894Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03894();
        Assert.That(sut.TrafficSignal(60), Is.EqualTo("Red"));
    }

    [Test]
    public void T2()
    {
        var sut = new S03894();
        Assert.That(sut.TrafficSignal(5), Is.EqualTo("Invalid"));
    }

    [Test]
    public void T3()
    {
        var sut = new S03894();
        Assert.That(sut.TrafficSignal(0), Is.EqualTo("Green"));
    }
    [Test]
    public void T4()
    {
        var sut = new S03894();
        Assert.That(sut.TrafficSignal(30), Is.EqualTo("Orange"));
    }
}
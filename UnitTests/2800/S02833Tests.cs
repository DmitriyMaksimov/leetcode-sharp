using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02833Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02833();
        Assert.That(sut.FurthestDistanceFromOrigin("L_RL__R"), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S02833();
        Assert.That(sut.FurthestDistanceFromOrigin("_R__LL_"), Is.EqualTo(5));
    }

    [Test]
    public void T3()
    {
        var sut = new S02833();
        Assert.That(sut.FurthestDistanceFromOrigin("_______"), Is.EqualTo(7));
    }
}